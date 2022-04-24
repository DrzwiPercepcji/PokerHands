using PokerHands.Comparers;
using PokerHands.Enums;
using PokerHands.Models;
using System.Collections.Generic;

namespace PokerHands.Utils
{
	public static class ComparerFactory
	{
		public static Comparer<Card[]> Create(Score score)
		{
			Comparer<Card[]> newComparer = null;

			switch (score)
			{
				case Score.OnePair:
					newComparer = new OnePair();
					break;

				case Score.TwoPair:
					newComparer = new TwoPair();
					break;

				case Score.Trips:
					newComparer = new Trips();
					break;

				case Score.Straight:
					newComparer = new Straight();
					break;

				case Score.Flush:
					newComparer = new Flush();
					break;

				case Score.FullHouse:
					newComparer = new FullHouse();
					break;

				case Score.Quads:
					newComparer = new Quads();
					break;

				case Score.StraightFlush:
					newComparer = new StraightFlush();
					break;

				case Score.RoyalFlush:
					newComparer = new RoyalFlush();
					break;
			}

			return newComparer;
		}
	}
}
