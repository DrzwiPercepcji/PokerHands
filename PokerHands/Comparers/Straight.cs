using PokerHands.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokerHands.Comparers
{
	public class Straight : AbstractDescendingComparer
	{
		public override int Compare(Card[] x, Card[] y)
		{
			List<Card> sortedX = x.OrderByDescending(card => card.Rank).ToList();
			List<Card> sortedY = y.OrderByDescending(card => card.Rank).ToList();

			if (sortedX[1].Rank == Enums.Rank.Rank5)
			{
				sortedX.RemoveAt(0);
				sortedX.Add(new Card() { Id = 0, Suit = Enums.Suit.Spades, Rank = Enums.Rank.Rank2 });
			}

			if (sortedY[1].Rank == Enums.Rank.Rank5)
			{
				sortedY.RemoveAt(0);
				sortedY.Add(new Card() { Id = 0, Suit = Enums.Suit.Spades, Rank = Enums.Rank.Rank2 });
			}

			return CompareRest(sortedX, sortedY);
		}
	}
}