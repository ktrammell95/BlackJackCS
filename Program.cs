using System;
using System.Collections.Generic;

namespace BlackJackCS
{
    class Card
    {
        public string Suit { get; set; }
        public string Value { get; set; }

        public int Points()
        {
            switch (Value)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                    return int.Parse(Value);
                case "Jack":
                case "Queen":
                case "King":
                    return 10;
                case "Ace":
                    return 11;
                default:
                    return 0;
            }
        }

    }

    class Hand
    {

    }
    class Dealer
    {
        public string Card { get; set; }

        // public void PrintCards()
        // {
        //     Console.WriteLine($"Dealer Card: {Card}");

        // }
    }
    class Player
    {
        public string Card { get; set; }

    }
    // public void PrintCards()
    // {
    //     Console.WriteLine($"Player Card: {Card}");

    // }

    // static string PromptForResponse(string prompt)
    // {
    //     Console.Write(prompt);
    //     var userInput = Console.ReadLine();
    //     return userInput;
    // }
    class Program
    {

        static void Main(string[] args)
        {
            // Create a List of cards
            var deck = new List<Card>();

            var cardSuits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };
            var cardValues = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (var suit in cardSuits)
            {
                foreach (var value in cardValues)
                {
                    var newCard = new Card();
                    newCard.Suit = suit;
                    newCard.Value = value;
                    // Console.WriteLine($"The {newCard.Value} of {newCard.Suit} is worth {newCard.Points()}");
                    deck.Add(newCard);
                }
            }

            // Shuffle Cards

            var numberOfCards = deck.Count;

            for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
            {
                var leftIndex = new Random().Next(0, rightIndex);
                var leftCard = deck[leftIndex];
                var rightCard = deck[rightIndex];
                deck[rightIndex] = leftCard;
                deck[leftIndex] = rightCard;
            }

            // Create list of Dealer cards 
            // - Pull 2 cards off top of deck (0,1) for Dealer. 
            // (Need to save but not show yet)

            // var DealerCardOne = new Dealer
            // {
            //     Card = cards[0],
            // };

            // var DealerCardTwo = new Dealer
            // {
            //     Card = cards[1],
            // };

            // - Create List Player cards - Pull 2 cards for the Player. (Print cards to screen)

            // var PlayerCardOne = new Player
            // {
            //     Card = cards[2],
            // };

            // var PlayerCardTwo = new Player
            // {
            //     Card = cards[3],
            // };

            // - Display Player Cards
            // var playerPoints = PlayerCardOne.Points() + PlayerCardTwo.Points();
            // PlayerCardOne.PrintCards();
            // PlayerCardTwo.PrintCards();
            // Console.WriteLine(playerPoints);



            // - If Player HITS:
            //   -- Loop to add to Player card List - Pull 1 card for Player
            // while (playerPoints < 21)
            // {
            //     var userInput = PromptForResponse("Would you like to HIT, or STAND? ");

            //     if (userInput == "HIT" || userInput == "Hit" || userInput == "hit")
            //     {

            //         var PlayerCardThree = new Player
            //         {
            //             Card = cards[4],
            //         };
            //         PlayerCardOne.PrintCards();
            //         PlayerCardTwo.PrintCards();
            //         PlayerCardThree.PrintCards();
            //         Console.WriteLine(PlayerCardOne.Points() + PlayerCardTwo.Points() + PlayerCardThree.Points());

            //     }
            //     else if (userInput == "STAND" || userInput == "Stand" || userInput == "stand")
            //     {
            //         Console.WriteLine($"User selected STAND");
            //     }
            //     else
            //     {
            //         Console.WriteLine($"Please make a valid selection");
            //     }
            // }

            // - Display Dealer Cards

            // DealerCardOne.PrintCards();
            // DealerCardTwo.PrintCards();

            // - Prompt - Give option for Player to HIT or STAND



            // - Check dealer cards total
            //   -- If <= 16, pull another card until >= 17
            //   -- If >= 17, no change
            //   -- If Dealer goes over 21, BUST

            //     var dealerpoints = DealerCardOne.Points() + DealerCardTwo.Points();

            //     if (dealerpoints <= 16)
            //     {
            //         Console.WriteLine(dealerpoints);
            //         Console.WriteLine($"Pick a card");
            //     }
            //     if (dealerpoints >= 17 && dealerpoints <= 21)
            //     {
            //         Console.WriteLine(dealerpoints);
            //         Console.Write($"Don't pick a card");
            //     }
            //     else if (dealerpoints >= 17 && dealerpoints < 21)
            //     {
            //         Console.WriteLine(dealerpoints);
            //         Console.Write($"Dealer is BUST!!");
            //     }

        }
    }

}
