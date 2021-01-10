using System;
using System.Collections.Generic;

namespace BlackJackCS
{
    class Dealer
    {
        public string Card { get; set; }
        public int Points()
        {
            var cardValue = 0;
            switch (Card)
            {
                case "Ace of Clubs":
                case "Ace of Hearts":
                case "Ace of Spades":
                case "Ace of Diamonds":
                    cardValue = 1;
                    break;
                case "2 of Clubs":
                case "2 of Hearts":
                case "2 of Spades":
                case "2 of Diamonds":
                    cardValue = 2;
                    break;
                case "3 of Clubs":
                case "3 of Hearts":
                case "3 of Spades":
                case "3 of Diamonds":
                    cardValue = 3;
                    break;
                case "4 of Clubs":
                case "4 of Hearts":
                case "4 of Spades":
                case "4 of Diamonds":
                    cardValue = 4;
                    break;
                case "5 of Clubs":
                case "5 of Hearts":
                case "5 of Spades":
                case "5 of Diamonds":
                    cardValue = 5;
                    break;
                case "6 of Clubs":
                case "6 of Hearts":
                case "6 of Spades":
                case "6 of Diamonds":
                    cardValue = 6;
                    break;
                case "7 of Clubs":
                case "7 of Hearts":
                case "7 of Spades":
                case "7 of Diamonds":
                    cardValue = 7;
                    break;
                case "8 of Clubs":
                case "8 of Hearts":
                case "8 of Spades":
                case "8 of Diamonds":
                    cardValue = 8;
                    break;
                case "9 of Clubs":
                case "9 of Hearts":
                case "9 of Spades":
                case "9 of Diamonds":
                    cardValue = 9;
                    break;
                case "10 of Clubs":
                case "10 of Hearts":
                case "10 of Spades":
                case "10 of Diamonds":
                case "Jack of Clubs":
                case "Jack of Hearts":
                case "Jack of Spades":
                case "Jack of Diamonds":
                case "Queen of Clubs":
                case "Queen of Hearts":
                case "Queen of Spades":
                case "Queen of Diamonds":
                case "King of Clubs":
                case "King of Hearts":
                case "King of Spades":
                case "King of Diamonds":
                    cardValue = 10;
                    break;
                default:
                    cardValue = 0;
                    break;
            }

            return cardValue;
        }
        public void PrintCards()
        {
            Console.WriteLine($"Dealer Cards: {Card}");

        }
    }
    class Player
    {
        public string Card { get; set; }
        public int Points()
        {
            var cardValue = 0;
            switch (Card)
            {
                case "Ace of Clubs":
                case "Ace of Hearts":
                case "Ace of Spades":
                case "Ace of Diamonds":
                    cardValue = 1;
                    break;
                case "2 of Clubs":
                case "2 of Hearts":
                case "2 of Spades":
                case "2 of Diamonds":
                    cardValue = 2;
                    break;
                case "3 of Clubs":
                case "3 of Hearts":
                case "3 of Spades":
                case "3 of Diamonds":
                    cardValue = 3;
                    break;
                case "4 of Clubs":
                case "4 of Hearts":
                case "4 of Spades":
                case "4 of Diamonds":
                    cardValue = 4;
                    break;
                case "5 of Clubs":
                case "5 of Hearts":
                case "5 of Spades":
                case "5 of Diamonds":
                    cardValue = 5;
                    break;
                case "6 of Clubs":
                case "6 of Hearts":
                case "6 of Spades":
                case "6 of Diamonds":
                    cardValue = 6;
                    break;
                case "7 of Clubs":
                case "7 of Hearts":
                case "7 of Spades":
                case "7 of Diamonds":
                    cardValue = 7;
                    break;
                case "8 of Clubs":
                case "8 of Hearts":
                case "8 of Spades":
                case "8 of Diamonds":
                    cardValue = 8;
                    break;
                case "9 of Clubs":
                case "9 of Hearts":
                case "9 of Spades":
                case "9 of Diamonds":
                    cardValue = 9;
                    break;
                case "10 of Clubs":
                case "10 of Hearts":
                case "10 of Spades":
                case "10 of Diamonds":
                case "Jack of Clubs":
                case "Jack of Hearts":
                case "Jack of Spades":
                case "Jack of Diamonds":
                case "Queen of Clubs":
                case "Queen of Hearts":
                case "Queen of Spades":
                case "Queen of Diamonds":
                case "King of Clubs":
                case "King of Hearts":
                case "King of Spades":
                case "King of Diamonds":
                    cardValue = 10;
                    break;
                default:
                    cardValue = 0;
                    break;
            }

            return cardValue;
        }
        public void PrintCards()
        {
            Console.WriteLine($"Player Cards: {Card}");

        }
    }
    class Program
    {

        static string PromptForResponse(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }
        static void Main(string[] args)
        {
            // Create a List of cards

            var cardSuits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };
            var cardValues = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var cards = new List<string>();

            foreach (var suit in cardSuits)
            {
                foreach (var value in cardValues)
                {
                    var newString = $"{value} of {suit}";
                    cards.Add(newString);
                }
            }

            // Shuffle Cards

            var numberOfCards = cards.Count;

            for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
            {
                var leftIndex = new Random().Next(0, rightIndex);
                var leftCard = cards[leftIndex];
                var rightCard = cards[rightIndex];
                cards[rightIndex] = leftCard;
                cards[leftIndex] = rightCard;
            }

            // Create list of Dealer cards 
            // - Pull 2 cards off top of deck (0,1) for Dealer. 
            // (Need to save but not show yet)

            var DealerCardOne = new Dealer
            {
                Card = cards[0],
            };

            var DealerCardTwo = new Dealer
            {
                Card = cards[1],
            };

            // - Create List Player cards - Pull 2 cards for the Player. (Print cards to screen)

            var PlayerCardOne = new Player
            {
                Card = cards[2],
            };

            var PlayerCardTwo = new Player
            {
                Card = cards[3],
            };

            // - Display Player Cards

            PlayerCardOne.PrintCards();
            PlayerCardTwo.PrintCards();
            Console.WriteLine(PlayerCardOne.Points() + PlayerCardTwo.Points());



            // - If Player HITS:
            //   -- Loop to add to Player card List - Pull 1 card for Player

            var userInput = PromptForResponse("Would you like to HIT, or STAND? ");

            if (userInput == "HIT" || userInput == "Hit" || userInput == "hit")
            {
                var PlayerCardThree = new Player
                {
                    Card = cards[4],
                };
                PlayerCardOne.PrintCards();
                PlayerCardTwo.PrintCards();
                PlayerCardThree.PrintCards();
                Console.WriteLine(PlayerCardOne.Points() + PlayerCardTwo.Points() + PlayerCardThree.Points());

            }
            else if (userInput == "STAND" || userInput == "Stand" || userInput == "stand")
            {
                Console.WriteLine($"User selected STAND");
                // Console.WriteLine($"Dealer Cards: {dealerCards[0]} and {dealerCards[1]} ");
            }
            else
            {
                Console.WriteLine($"Please make a valid selection");
            }

            // - Display Dealer Cards

            DealerCardOne.PrintCards();
            DealerCardTwo.PrintCards();

            // - Prompt - Give option for Player to HIT or STAND



            // - Check dealer cards total
            //   -- If <= 16, pull another card until >= 17
            //   -- If >= 17, no change
            //   -- If Dealer goes over 21, BUST

            if (DealerCardOne.Points() + DealerCardTwo.Points() <= 16)
            {
                Console.WriteLine(DealerCardOne.Points() + DealerCardTwo.Points());
                Console.WriteLine($"Pick a card");
            }
            if (DealerCardOne.Points() + DealerCardTwo.Points() >= 17 && DealerCardOne.Points() + DealerCardTwo.Points() <= 21)
            {
                Console.WriteLine(DealerCardOne.Points() + DealerCardTwo.Points());
                Console.Write($"Don't pick a card");
            }
            else if (DealerCardOne.Points() + DealerCardTwo.Points() >= 17 && DealerCardOne.Points() + DealerCardTwo.Points() < 21)
            {
                Console.WriteLine(DealerCardOne.Points() + DealerCardTwo.Points());
                Console.Write($"Dealer is BUST!!");
            }
        }
    }

}
