using PokerHands.Interfaces;
using PokerHands.Models;
using System.Linq;

namespace PokerHands.Scores
{
	public class FullHouse : IScore
	{
		public Enums.Score GetScore()
		{
			return Enums.Score.FullHouse;
		}

		public bool CheckScore(Card[] cards)
		{
			return CheckOnePair(cards) && CheckThree(cards);
		}

		private bool CheckOnePair(Card[] cards)
		{
			return cards.GroupBy(card => card.Rank).Count(group => group.Count() == 2) == 1;
		}

		private bool CheckThree(Card[] cards)
		{
			return cards.GroupBy(card => card.Rank).Any(group => group.Count() == 3);
		}
	}
}