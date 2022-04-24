using PokerHands.Interfaces;
using PokerHands.Models;
using System.Linq;

namespace PokerHands.Scores
{
	public class TwoPair : IScore
	{
		public Enums.Score GetScore()
		{
			return Enums.Score.TwoPair;
		}

		public bool CheckScore(Card[] cards)
		{
			return cards.GroupBy(card => card.Rank).Count(group => group.Count() >= 2) == 2;
		}
	}
}