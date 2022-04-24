using PokerHands.Interfaces;
using PokerHands.Models;
using System.Linq;

namespace PokerHands.Scores
{
	public class StraightFlush : IScore
	{
		public Enums.Score GetScore()
		{
			return Enums.Score.StraightFlush;
		}

		public bool CheckScore(Card[] cards)
		{
			return CheckFlush(cards) && CheckStraight(cards);
		}

		public int GetPoints()
		{
			return 8;
		}

		private bool CheckFlush(Card[] cards)
		{
			return cards.GroupBy(card => card.Suit).Count(group => group.Count() >= 5) == 1;
		}

		private bool CheckStraight(Card[] cards)
		{
			return cards.GroupBy(card => card.Rank).Count() == cards.Count()
				&& cards.Max(card => (int)card.Rank) - cards.Min(card => (int)card.Rank) == 4;
		}
	}
}