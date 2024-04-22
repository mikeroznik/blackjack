using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
	public class Deck
	{
		public List<Card> wholeDeck = [];

		public Deck() {
			// create the deck

			wholeDeck.AddRange(CreateSet("spades"));
			wholeDeck.AddRange(CreateSet("hearts"));
			wholeDeck.AddRange(CreateSet("diamonds"));
			wholeDeck.AddRange(CreateSet("clubs"));
		}

		// shuffle all the whole deck
		public void Shuffle()
		{
			wholeDeck = [.. wholeDeck.OrderBy(x => Random.Shared.Next())];
		}

		public List<Card> CreateSet(string suit)
		{
			List<Card> tempSet = [];

			for (int i = 2; i <= 10; i++)
			{
				tempSet.Add(new Card(suit, i.ToString(), i));
			}

			tempSet.Add(new Card(suit, "king", 10));
			tempSet.Add(new Card(suit, "queen", 10));
			tempSet.Add(new Card(suit, "jack", 10));
			tempSet.Add(new Card(suit, "ace", 1));

			return tempSet;
		}
	}
}
