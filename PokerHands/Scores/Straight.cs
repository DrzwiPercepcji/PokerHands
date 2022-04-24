using PokerHands.Interfaces;
using PokerHands.Models;
using System.Linq;

namespace PokerHands.Scores
{
	public class Straight : IScore
	{
		public Enums.Score GetScore()
		{
			return Enums.Score.Straight;
		}

		public bool CheckScore(Card[] cards)
		{
			return cards.GroupBy(card => card.Rank).Count() == cards.Count()
				&& cards.Max(card => (int)card.Rank) - cards.Min(card => (int)card.Rank) == 4;
		}
	}
}