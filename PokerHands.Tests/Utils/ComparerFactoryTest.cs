using NUnit.Framework;
using PokerHands.Comparers;
using PokerHands.Utils;

namespace PokerHands.Tests.Utils
{
	public class ComparerFactoryTest
	{
		[Test]
		public void ShouldReturnValidComparerByScore()
		{
			var result1 = ComparerFactory.Create(Enums.Score.OnePair);
			var result2 = ComparerFactory.Create(Enums.Score.StraightFlush);

			Assert.IsInstanceOf(typeof(OnePair), result1);
			Assert.IsInstanceOf(typeof(StraightFlush), result2);
		}
	}
}
