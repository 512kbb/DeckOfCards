using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Player
    {
        public string Name;
        public List<Card> Hand = new List<Card>();

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>() { };
        }

        public Card TakeCard(Deck deck)
        {
            Card cardToTake = deck.Cards[deck.Cards.Count - 1];
            deck.Cards.Remove(cardToTake);
            Hand.Add(cardToTake);
            // cardToTake.PrintCard();
            return cardToTake;
        }

        public Card? DiscardCard(int index)
        {
            if(Hand.ElementAtOrDefault(index) != null) {
                Card cardToRemove = Hand[index];
                Hand.Remove(cardToRemove);
                return cardToRemove;
            }
            Console.WriteLine($"Card at index {index} does not exist");
            return null;
        }

        public void ShowHand()
        {
            foreach (Card card in Hand)
            {
                card.PrintCard();
            }
        }
    }
}