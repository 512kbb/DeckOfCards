using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> Cards = new List<Card>();
        public List<Card> DiscardedCards = new List<Card>();

        public Deck()
        {

            string[] suits = new string[4] { "SPADES", "CLUBS", "DIAMONDS", "HEARTS" };
            string[] names = new string[13] { "ACE", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "QUEEN", "KING" };
            // int cardCounter = 1;
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    Cards.Add(new Card(names[i], suits[j], i + 1));
                }

            }

        }

        public void ShuffleCards()
        {
            // fisher-yates shuffle algorithm: https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
            Random rand = new();
            List<Card> shuffledCards = new(Cards);
            int CardCount = shuffledCards.Count;

            while (CardCount > 1)
            {
                CardCount--;
                int randomNumber = rand.Next(CardCount + 1);
                Card card = shuffledCards[randomNumber];
                shuffledCards[randomNumber] = shuffledCards[CardCount];
                shuffledCards[CardCount] = card;
            }
            Cards = shuffledCards;
        }

        public void AddDiscardCard(Card card)
        {
            if (card != null)
            {
                DiscardedCards.Add(card);
            }
        }
        public void DisplayDeck()
        {
            foreach (Card card in Cards)
            {
                card.PrintCard();
            }
        }

        public void DisplayDiscardedCards()
        {
            foreach (Card card in DiscardedCards)
            {
                card.PrintCard();
            }
        }


    }
}