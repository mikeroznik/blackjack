using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
	public class Card(string suit = "", string face = "", int value = 0)
	{
		public string suit = suit.Trim();
		public string face = face.Trim();
		public int value = value;
	}
}
