using NUnit.Framework;
using PokerHands.Comparers;
using PokerHands.Enums;
using PokerHands.Models;
using System.Collections.Generic;

namespace PokerHands.Tests.Comparers
{
	public class RoyalFlushTest
	{
		private Comparer<Card[]> comparer;
		private Card[] cardsX;
		private Card[] cardsY;

		[SetUp]
		public void SetUp()
		{
			comparer = new RoyalFlush();
			cardsX = new Card[5];
			cardsX = new Card[5];
		}

		[Test]
		public void EqualTestPasses()
		{
			//Given
			cardsX = new Card[5] {
				new Card() { Suit = Suit.Spades, Rank = Rank.Jack },
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank10 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Ace },
				new Card() { Suit = Suit.Spades, Rank = Rank.Queen },
				new Card() { Suit = Suit.Spades, Rank = Rank.King },
			};

			cardsY = new Card[5] {
				new Card() { Suit = Suit.Clubs, Rank = Rank.King },
				new Card() { Suit = Suit.Clubs, Rank = Rank.Ace },
				new Card() { Suit = Suit.Clubs, Rank = Rank.Jack },
				new Card() { Suit = Suit.Clubs, Rank = Rank.Rank10 },
				new Card() { Suit = Suit.Clubs, Rank = Rank.Queen },
			};

			//When
			int result = comparer.Compare(cardsX, cardsY);

			//Then
			Assert.AreEqual(0, result);
		}
	}
}