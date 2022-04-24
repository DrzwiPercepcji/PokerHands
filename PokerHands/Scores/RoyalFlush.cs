using PokerHands.Enums;
using PokerHands.Interfaces;
using PokerHands.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokerHands.Scores
{
	public class RoyalFlush : IScore
	{
		private readonly List<Suit> suits;
		private readonly Rank[] allowed;

		public RoyalFlush()
		{
			suits = new List<Suit>();
			allowed = new Rank[] { Rank.Rank10, Rank.Jack, Rank.Queen, Rank.King, Rank.Ace };
		}

		public Enums.Score GetScore()
		{
			return Enums.Score.RoyalFlush;
		}

		public bool CheckScore(Card[] cards)
		{
			foreach (Card card in cards)
			{
				if (!allowed.Contains(card.Rank))
				{
					return false;
				}
				suits.Add(card.Suit);
			}

			int uniqueSuits = (from x in suits select x).Distinct().Count();

			return uniqueSuits == 1;
		}
	}
}