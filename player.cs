using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
	public class Player
	{
		public int handValue;
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
			foreach (card in hand)
			{
				handValue += card.value;
			}
		}*/
	}
}
