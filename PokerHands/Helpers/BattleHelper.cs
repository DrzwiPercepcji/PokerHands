using PokerHands.Enums;
using PokerHands.Models;
using System.Linq;

namespace PokerHands.Helpers
{
	public static class BattleHelper
	{
		public static (Suit suit, Rank rank)? GetBestCard(Card[] cards, Suit suit)
		{
			if (cards == null || cards.Length == 0 || cards.All(card => card == null))
			{
				return null;
			}

			return (suit, cards.Where(card => card != null && card.Suit == suit).OrderByDescending(card => card.Rank).First().Rank);
		}
	}
}
