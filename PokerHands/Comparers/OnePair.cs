using PokerHands.Models;

namespace PokerHands.Comparers
{
	public class OnePair : AbstractComparer
	{
		private const int GROUP_COUNT = 2;

		public override int Compare(Card[] x, Card[] y)
		{
			return BasicCompare(x, y, GROUP_COUNT);
		}
	}
}