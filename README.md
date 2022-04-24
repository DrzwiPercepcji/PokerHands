# PokerHands

A simple library for poker hands recognition.

## Usage

```csharp
using PokerHands.Enums;
using PokerHands.Interfaces;
using PokerHands.Models;
using PokerHands.Scores;

namespace YourNamespace
{
	public class YourClass
	{
		public void YourMethod()
		{
            IScore score = new Flush();
			var cards = new Card[5] {
				new Card() { Suit = Suit.Hearts, Rank = Rank.Ace },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Rank10 },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Jack },
				new Card() { Suit = Suit.Clubs, Rank = Rank.King },
				new Card() { Suit = Suit.Hearts, Rank = Rank.Queen },
			};

			bool result = score.CheckScore(cards);
		}
	}
}
```
