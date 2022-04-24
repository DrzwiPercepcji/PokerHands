using PokerHands.Interfaces;
using PokerHands.Models;
using System.Linq;

namespace PokerHands.Scores
{
	public class Quads : IScore
	{
		public Enums.Score GetScore()
		{
			return Enums.Score.Quads;
		}

		public bool CheckScore(Card[] cards)
		{
			return cards.GroupBy(card => card.Rank).Any(group => group.Count() == 4);
		}
	}
}