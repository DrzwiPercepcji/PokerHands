using PokerHands.Interfaces;
using PokerHands.Models;
using System.Linq;

namespace PokerHands.Scores
{
	public class Flush : IScore
	{
		public Enums.Score GetScore()
		{
			return Enums.Score.Flush;
		}

		public bool CheckScore(Card[] cards)
		{
			return cards.GroupBy(card => card.Suit).Count(group => group.Count() >= 5) == 1;
		}
	}
}