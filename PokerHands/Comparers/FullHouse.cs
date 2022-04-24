using PokerHands.Models;

namespace PokerHands.Comparers
{
	public class FullHouse : AbstractComparer
	{
		private const int GROUP_COUNT = 3;

		public override int Compare(Card[] x, Card[] y)
		{
			return BasicCompare(x, y, GROUP_COUNT);
		}
	}
}