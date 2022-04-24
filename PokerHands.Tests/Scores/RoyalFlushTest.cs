using NUnit.Framework;
using PokerHands.Enums;
using PokerHands.Interfaces;
using PokerHands.Models;
using PokerHands.Scores;

namespace PokerHands.Tests.Scores
{
	public class RoyalFlushTest
	{
		private IScore score;
		private Card[] cards;

		[SetUp]
		public void SetUp()
		{
			score = new RoyalFlush();
			cards = new Card[5];
		}

		[Test]
		public void CorrectCaseTestPasses()
		{
			//Given
			cards = new Card[5] {
				new Card() { Suit = Suit.Hearts, Rank = Rank.Ace },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Rank10 },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Jack },
				new Card() { Suit = Suit.Hearts, Rank = Rank.King },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Queen },
			};

			//When
			bool result = score.CheckScore(cards);

			//Then
			Assert.AreEqual(true, result);
		}

		[Test]
		public void IncorrectCaseTestFailures()
		{
			//Given
			cards = new Card[5] {
				new Card() { Suit = Suit.Hearts, Rank = Rank.Ace },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Rank10 },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Jack },
				new Card() { Suit = Suit.Clubs, Rank = Rank.King },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Queen },
			};

			//When
			bool result = score.CheckScore(cards);

			//Then
			Assert.AreEqual(false, result);
		}
	}
}