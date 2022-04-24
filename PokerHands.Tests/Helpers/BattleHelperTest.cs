using NUnit.Framework;
using PokerHands.Enums;
using PokerHands.Helpers;
using PokerHands.Models;
using System;

namespace PokerHands.Tests.Helpers
{
	public class BattleHelperTest
	{
		private Card[] cards1;
		private Card[] cards2;

		[SetUp]
		public void SetUp()
		{
			cards1 = new Card[5] {
				new Card() { Suit = Suit.Clubs, Rank = Rank.Jack },
				new Card() { Suit = Suit.Clubs, Rank = Rank.Queen },
				new Card() { Suit = Suit.Diamonds, Rank = Rank.Rank7 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Ace },
				new Card() { Suit = Suit.Spades, Rank = Rank.Queen },
			};

			cards2 = new Card[5] {
				new Card() { Suit = Suit.Clubs, Rank = Rank.Jack },
				new Card() { Suit = Suit.Clubs, Rank = Rank.Rank2 },
				new Card() { Suit = Suit.Diamonds, Rank = Rank.Rank7 },
				new Card() { Suit = Suit.Spades, Rank = Rank.Ace },
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank3 },
			};
		}

		[Test]
		public void ShouldFindBestBattleCard()
		{
			var result1 = BattleHelper.GetBestCard(cards1, Suit.Clubs);
			var result2 = BattleHelper.GetBestCard(cards2, Suit.Spades);

			Assert.That(result1.Value.suit == Suit.Clubs && result1.Value.rank == Rank.Queen);
			Assert.That(result2.Value.suit == Suit.Spades && result2.Value.rank == Rank.Ace);
		}

		[Test]
		public void ShouldReturnNullWhenCardsAreEmptyOrNull()
		{
			var result1 = BattleHelper.GetBestCard(Array.Empty<Card>(), Suit.Clubs);
			var result2 = BattleHelper.GetBestCard(null, Suit.Spades);

			Assert.IsNull(result1);
			Assert.IsNull(result2);
		}

		[Test]
		public void ShouldHandleSomeEmptyCards()
		{
			Card[] empty1 = new Card[5] {
				new Card() { Suit = Suit.Clubs, Rank = Rank.Rank2 },
				null,
				new Card() { Suit = Suit.Clubs, Rank = Rank.Jack },
				null,
				new Card() { Suit = Suit.Spades, Rank = Rank.Rank3 },
			};

			Card[] empty2 = new Card[3] {
				null,
				null,
				null,
			};

			var result1 = BattleHelper.GetBestCard(empty1, Suit.Clubs);
			var result2 = BattleHelper.GetBestCard(empty2, Suit.Spades);

			Assert.That(result1.Value.suit == Suit.Clubs && result1.Value.rank == Rank.Jack);
			Assert.IsNull(result2);
		}
	}
}
