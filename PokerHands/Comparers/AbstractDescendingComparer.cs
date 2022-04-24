using PokerHands.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokerHands.Comparers
{
	public abstract class AbstractDescendingComparer : AbstractComparer
	{
		public override int Compare(Card[] x, Card[] y)
		{
			List<Card> sortedX = x.OrderByDescending(card => card.Rank).ToList();
			List<Card> sortedY = y.OrderByDescending(card => card.Rank).ToList();

			return CompareRest(sortedX, sortedY);
		}
	}
}