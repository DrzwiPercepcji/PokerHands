using NUnit.Framework;
using PokerHands.Enums;
using PokerHands.Interfaces;
using PokerHands.Models;
using PokerHands.Scores;

namespace PokerHands.Tests.Scores
{
	public class StraightFlushTest
	{
		private IScore score;
		private Card[] cards;

		[SetUp]
		public void SetUp()
		{
			score = new StraightFlush();
			cards = new Card[5];
		}

		[Test]
		public void CorrectCaseTestPasses()
		{
			//Given
			cards = new Card[5] {
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank7 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank10 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank9 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank8 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank6 },
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
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank7 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank10 },
				new Card() { Suit = Suit.Clubs, Rank = Rank.Rank9 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank8 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank6 }
			};

			//When
			bool result = score.CheckScore(cards);

			//Then
			Assert.AreEqual(false, result);
		}
	}
}