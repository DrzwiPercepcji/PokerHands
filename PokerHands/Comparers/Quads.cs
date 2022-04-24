using PokerHands.Models;

namespace PokerHands.Comparers
{
	public class Quads : AbstractComparer
	{
		private const int GROUP_COUNT = 4;

		public override int Compare(Card[] x, Card[] y)
		{
			return BasicCompare(x, y, GROUP_COUNT);
		}
	}
}