using NUnit.Framework;
using PokerHands.Comparers;
using PokerHands.Enums;
using PokerHands.Models;
using System.Collections.Generic;

namespace PokerHands.Tests.Comparers
{
	public class StraightTest
	{
		private Comparer<Card[]> comparer;
		private Card[] cardsX;
		private Card[] cardsY;

		[SetUp]
		public void SetUp()
		{
			comparer = new Straight();
			cardsX = new Card[5];
			cardsX = new Card[5];
		}

		[Test]
		public void FirstIsSmallerTestPasses()
		{
			//Given
			cardsX = new Card[5] {
				new Card() { Suit = Suit.Clubs, Rank = Rank.Ace },
				new Card() { Suit = Suit.Clubs, Rank = Rank.Rank2 },
				new Card() { Suit = Suit.Diamonds, Rank = Rank.Rank4 },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Rank5 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank3 }
			};

			cardsY = new Card[5] {
				new Card() { Suit = Suit.Clubs, Rank = Rank.Rank10 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Queen },
				new Card() { Suit = Suit.Spades, Rank = Rank.Jack },
				new Card() { Suit = Suit.Diamonds, Rank = Rank.Ace },
				new Card() { Suit = Suit.Hearts, Rank = Rank.King }
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
				new Card() { Suit = Suit.Clubs, Rank = Rank.Rank9 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank10 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank8 },
				new Card() { Suit = Suit.Diamonds, Rank = Rank.Rank6 },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Rank7 }
			};

			cardsY = new Card[5] {
				new Card() { Suit = Suit.Clubs, Rank = Rank.Ace },
				new Card() { Suit = Suit.Clubs, Rank = Rank.Rank2 },
				new Card() { Suit = Suit.Diamonds, Rank = Rank.Rank4 },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Rank5 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank3 }
			};

			//When
			int result = comparer.Compare(cardsX, cardsY);

			//Then
			Assert.AreEqual(1, result);
		}

		[Test]
		public void EqualTestPasses()
		{
			//Given
			cardsX = new Card[5] {
				new Card() { Suit = Suit.Spades, Rank = Rank.Queen },
				new Card() { Suit = Suit.Clubs, Rank = Rank.Jack },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Rank10 },
				new Card() { Suit = Suit.Diamonds, Rank = Rank.Ace },
				new Card() { Suit = Suit.Spades, Rank = Rank.King }
			};

			cardsY = new Card[5] {
				new Card() { Suit = Suit.Clubs, Rank = Rank.Rank10 },
				new Card() { Suit = Suit.Diamonds, Rank = Rank.Queen },
				new Card() { Suit = Suit.Spades, Rank = Rank.Jack },
				new Card() { Suit = Suit.Clubs, Rank = Rank.Ace },
				new Card() { Suit = Suit.Hearts, Rank = Rank.King }
			};

			//When
			int result = comparer.Compare(cardsX, cardsY);

			//Then
			Assert.AreEqual(0, result);
		}
	}
}