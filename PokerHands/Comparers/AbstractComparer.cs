using PokerHands.Enums;
using PokerHands.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokerHands.Comparers
{
	public abstract class AbstractComparer : Comparer<Card[]>
	{
		protected int BasicCompare(Card[] x, Card[] y, int groupCount)
		{
			List<Card> pairX = x.AsEnumerable()
				.GroupBy(card => card.Rank)
				.Where(group => group.Count() == groupCount)
				.Select(group => group.ToList())
				.First();

			List<Card> pairY = y.AsEnumerable()
				.GroupBy(card => card.Rank)
				.Where(group => group.Count() == groupCount)
				.Select(group => group.ToList())
				.First();

			Rank rankX = pairX.First().Rank;
			Rank rankY = pairY.First().Rank;

			int result = CompareRanks(rankX, rankY);

			if (result != 0)
			{
				return result;
			}

			List<Card> restX = x.OrderByDescending(card => card.Rank).ToList();
			restX.RemoveAll(card => card.Rank == rankX);

			List<Card> restY = y.OrderByDescending(card => card.Rank).ToList();
			restY.RemoveAll(card => card.Rank == rankY);

			return CompareRest(restX, restY, groupCount);
		}

		protected int CompareRanks(Rank rankX, Rank rankY)
		{
			if (rankX > rankY)
			{
				return 1;
			}

			if (rankX < rankY)
			{
				return -1;
			}

			return 0;
		}

		protected int CompareRest(List<Card> restX, List<Card> restY, int groupCount = 0)
		{
			int result;
			Rank rankX;
			Rank rankY;

			int countDelta = 5 - groupCount;
			for (int i = 0; i < countDelta; i++)
			{
				rankX = restX[i].Rank;
				rankY = restY[i].Rank;

				result = CompareRanks(rankX, rankY);

				if (result != 0)
				{
					return result;
				}
			}

			return 0;
		}
	}
}