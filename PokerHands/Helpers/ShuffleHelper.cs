using System;
using System.Collections.Generic;

namespace PokerHands.Helpers
{
	public static class ShuffleHelper
	{
		public static void ComplexShuffle<T>(IList<T> list)
		{
			for (int i = 0; i < 3; i++)
			{
				SingleShuffle(list);
			}
		}

		public static void SingleShuffle<T>(IList<T> list)
		{
			Random random = new Random();

			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = random.Next(n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}
	}
}
