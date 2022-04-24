using NUnit.Framework;
using PokerHands.Comparers;
using PokerHands.Enums;
using PokerHands.Models;
using System.Collections.Generic;

namespace PokerHands.Tests.Comparers
{
	public class FullHouseTest
	{
		private Comparer<Card[]> comparer;
		private Card[] cardsX;
		private Card[] cardsY;

		[SetUp]
		public void SetUp()
		{
			comparer = new FullHouse();
			cardsX = new Card[5];
			cardsX = new Card[5];
		}

		[Test]
		public void FirstIsSmallerTestPasses()
		{
			//Given
			cardsX = new Card[5] {
				new Card() { Suit = Suit.Clubs, Rank = Rank.Ace },
				new Card() { Suit = Suit.Clubs, Rank = Rank.Jack },
				new Card() { Suit = Suit.Diamonds, Rank = Rank.Jack },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Jack },
				new Card() { Suit = Suit.Spades, Rank = Rank.Ace },
			};

			cardsY = new Card[5] {
				new Card() { Suit = Suit.Clubs, Rank = Rank.Rank2 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Queen },
				new Card() { Suit = Suit.Clubs, Rank = Rank.Queen },
				new Card() { Suit = Suit.Diamonds, Rank = Rank.Rank2 },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Queen },
			};

			//When
			int result = comparer.Compare(cardsX, cardsY);

			//Then
			Assert.AreEqual(-1, result);
		}

		[Test]
		public void FirstIsLargerTestPasses()
		{
			//Given
			cardsX = new Card[5] {
				new Card() { Suit = Suit.Clubs, Rank = Rank.Rank10 },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Rank10 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Queen },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Queen },
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank10 },
			};

			cardsY = new Card[5] {
				new Card() { Suit = Suit.Clubs, Rank = Rank.Rank5 },
				new Card() { Suit = Suit.Spades, Rank = Rank.King },
				new Card() { Suit = Suit.Diamonds, Rank = Rank.King },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Rank5 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank5 },
			};

			//When
			int result = comparer.Compare(cardsX, cardsY);

			//Then
			Assert.AreEqual(1, result);
		}
	}
}