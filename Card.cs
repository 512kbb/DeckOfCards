using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Card
    {
        public string? Name;
        public string? Suit;
        public int Value;

        public Card(string name, string suit, int value)
        {
            Name = name;
            Suit = suit;
            Value = value;
        }
        public void PrintCard()
        {
            Console.WriteLine($"{Name} OF {Suit} (value: {Value})");
        }
    }
}