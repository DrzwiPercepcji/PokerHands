using PokerHands.Enums;
using PokerHands.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokerHands.Comparers
{
	public class TwoPair : AbstractComparer
	{
		public override int Compare(Card[] x, Card[] y)
		{
			List<Card> sortedX = x.OrderByDescending(card => card.Rank).ToList();
			List<Card> sortedY = y.OrderByDescending(card => card.Rank).ToList();

			Card restX = x.AsEnumerable()
				.GroupBy(card => card.Rank)
				.Where(group => group.Count() == 1)
				.Select(group => group.ToList())
				.First().First();

			Card restY = y.AsEnumerable()
				.GroupBy(card => card.Rank)
				.Where(group => group.Count() == 1)
				.Select(group => group.ToList())
				.First().First();

			sortedX.RemoveAll(card => card.Rank == restX.Rank);
			sortedX.Add(restX);

			sortedY.RemoveAll(card => card.Rank == restY.Rank);
			sortedY.Add(restY);

			int result;
			Rank rankX;
			Rank rankY;

			for (int i = 0; i < 5; i += 2)
			{
				rankX = sortedX[i].Rank;
				rankY = sortedY[i].Rank;

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