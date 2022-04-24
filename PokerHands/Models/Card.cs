using PokerHands.Enums;

namespace PokerHands.Models
{
	public class Card
	{
		public int Id { get; set; }

		public Suit Suit { get; set; }

		public Rank Rank { get; set; }

		public bool Thrown { get; set; }
	}
}
