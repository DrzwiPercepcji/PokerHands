using PokerHands.Interfaces;
using PokerHands.Models;
using System.Linq;

namespace PokerHands.Scores
{
	public class OnePair : IScore
	{
		public Enums.Score GetScore()
		{
			return Enums.Score.OnePair;
		}

		public bool CheckScore(Card[] cards)
		{
			return cards.GroupBy(card => card.Rank).Count(group => group.Count() == 2) == 1;
		}
	}
}