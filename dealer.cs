using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
	public class Dealer
	{
		// limit to stop hitting at
		public readonly int limit = 17;

		public int handValue;

		// shows only card 0 to start
		public List<Card> hand = new();

		public int Sum()
		{
			int sum = 0;

			foreach (Card card in hand)
			{
				sum += card.value;
			}

			return sum;
		}

		// get hand value
		/*		handValue()
				{ 
					foreach(card in hand)
					{
						handValue += card.value;
					}
				}

				//functionality to check hit/stay
				checkHandValue()
				{
					if handValue < 17
						hit;
				}*/
	}
}
