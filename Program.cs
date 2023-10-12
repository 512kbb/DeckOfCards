using System;

namespace DeckOfCards;
class Program
{
    static void Main(string[] args)
    {
        Deck deck1 = new Deck();
        Player player1 = new Player("512kb");
        // deck1.DisplayDeck();
        deck1.ShuffleCards();
        deck1.ShuffleCards();
        deck1.ShuffleCards();
        // Console.WriteLine("first display");
        // deck1.DisplayDeck();
        player1.TakeCard(deck1);
        player1.TakeCard(deck1);
        player1.TakeCard(deck1);
        Console.WriteLine("hand");
        player1.ShowHand();
        // deck1.DisplayDeck();
        deck1.AddDiscardCard(player1.DiscardCard(4));
        Console.WriteLine("hand after discard");

        player1.ShowHand();
        Console.WriteLine("discarded cards");
        
        deck1.DisplayDiscardedCards();





    }
}
