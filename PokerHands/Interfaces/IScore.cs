using PokerHands.Models;

namespace PokerHands.Interfaces
{
	public interface IScore
	{
		Enums.Score GetScore();

		bool CheckScore(Card[] cards);
	}
}
