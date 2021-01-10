using System;
using System.Collections.Generic;

namespace BlackJackCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a List of cards

            var cardSuits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };
            var cardValues = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var cards = new List<string>();

            foreach (var suit in cardSuits)
            {
                foreach (var value in cardValues)
                {
                    var newString = $"{value} of {suit}";
                    Console.WriteLine($"{newString}");

                    cards.Add(newString);
                }
            }

            // - Shuffle Cards

            var numberOfCards = cards.Count;

            for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
            {
                var leftIndex = new Random().Next(0, rightIndex);
                var leftCard = cards[leftIndex];
                var rightCard = cards[rightIndex];
                cards[rightIndex] = leftCard;
                cards[leftIndex] = rightCard;
            }

            var cardDealtOne = cards[0];
            var cardDealtTwo = cards[1];
            Console.WriteLine($"Cards dealt: {cardDealtOne} and {cardDealtTwo}");
        }
    }
}
