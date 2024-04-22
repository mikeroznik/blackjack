// See https://aka.ms/new-console-template for more information
using blackjack;

Console.WriteLine("Hello, World!");

// create the deck

Deck newDeck = new();

newDeck.Shuffle();

Player player1 = new();

Dealer dealer = new();

PassOutCards();

string inputst;

do
{
	Console.WriteLine("Dealer hand showing: " + dealer.hand[0].face.ToString() + dealer.hand[0].suit.ToString());
	Console.WriteLine("Your hand: ");

	foreach (Card playerCard in player1.hand)
	{
		Console.WriteLine(playerCard.face.ToString() + " " + playerCard.suit.ToString());
	}

	Console.WriteLine("(H)it or (S)tay?");

	inputst = Console.ReadLine().ToUpper();

	if (inputst == "H")
	{
		player1.hand.Add(newDeck.wholeDeck[0]);
		newDeck.wholeDeck.RemoveAt(0);

		Console.WriteLine("Your hand: " + player1.Sum());

		if (player1.Sum() > 21)
		{
			Console.WriteLine("Bust");
			break;
		}
	}
	else
	{
		break;
	}		

} while (true);

if (player1.Sum() <= 21)
{
	do
	{
		Console.WriteLine("Dealer hand: ");

		foreach (Card dealerCard in dealer.hand)
		{
			Console.WriteLine(dealerCard.face.ToString() + " " + dealerCard.suit.ToString());
		}

		if (dealer.Sum() <= dealer.limit)
		{
			dealer.hand.Add(newDeck.wholeDeck[0]);
			newDeck.wholeDeck.RemoveAt(0);
		}

	} while (dealer.Sum() <= dealer.limit);
}

if (dealer.Sum() <= 21)
{
	Console.WriteLine("Dealer wins");
} else
{
	Console.WriteLine("Dealer busts");
}


void PassOutCards()
{
	for (int i = 0; i < 2; i++)
	{
		dealer.hand.Add(newDeck.wholeDeck[0]);
		newDeck.wholeDeck.RemoveAt(0);
	}

	for (int i = 0; i < 2; i++)
	{
		player1.hand.Add(newDeck.wholeDeck[0]);
		newDeck.wholeDeck.RemoveAt(0);
	}
}


// shuffle the deck
// create the dealer
// player(s)
// pass the cards (here)

// loop for turn, player first
// player decides hit/stay
// stay => loop for dealer

// check for winner