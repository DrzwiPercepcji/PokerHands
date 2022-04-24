using PokerHands.Models;
using System.Collections.Generic;

namespace PokerHands.Comparers
{
	public class RoyalFlush : Comparer<Card[]>
	{
		public override int Compare(Card[] x, Card[] y)
		{
			return 0;
		}
	}
}