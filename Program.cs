using System;
using System.Collections.Generic;

namespace BlackJackCS
{
    class Hand
    {

        // Property that is a list of all the cards this hand is holding
        public List<Card> CardsInHand { get; set; } = new List<Card>();

        public void PlaceInHand(Card cardToPlaceInHand)
        {
            CardsInHand.Add(cardToPlaceInHand);
        }

        public int TotalValue()
        {
            // How do we get the total cards in the hand?
            // Start with grand total of 0
            // for each card in the hand do the following
            //    - Get the value of the current card
            //    - Add that value to the grand total
            //    - return the grand total

            var grandTotal = 0;

            foreach (var currentCardInHand in CardsInHand)
            {
                var currentCardValue = currentCardInHand.Points();

                grandTotal = grandTotal + currentCardValue;
            }
            return grandTotal;
        }
    }
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

            Console.WriteLine($"Ready to Play");

            // Create list of Dealer cards 
            // - Pull 2 cards off top of deck (0,1) for Dealer. 
            // (Need to save but not show yet)

            var dealerHand = new Hand();

            // Ask the deck for a card
            var firstDealerCard = deck[0];
            deck.Remove(firstDealerCard);
            // Place it in Dealer's Hand
            dealerHand.PlaceInHand(firstDealerCard);

            var secondDealerCard = deck[0];
            deck.Remove(secondDealerCard);
            // Place it in Dealer's Hand
            dealerHand.PlaceInHand(secondDealerCard);

            // - Create List Player cards - Pull 2 cards for the Player. (Print cards to screen)

            var playerHand = new Hand();

            // Ask the deck for a card
            var firstPlayerCard = deck[0];
            deck.Remove(firstPlayerCard);
            // Place it in Dealer's Hand
            playerHand.PlaceInHand(firstPlayerCard);

            var secondPlayerCard = deck[0];
            deck.Remove(secondPlayerCard);
            // Place it in Dealer's Hand
            playerHand.PlaceInHand(secondPlayerCard);

            //declare a variable early - have to specify
            string hitOrStand;

            do
            {
                // Show the cards in the Player's hand

                // Problem: Have a list of cards and want to print them all
                // Example: Card with Face = "Ace" Suit = "Clubs", Face = "Jack" Suit = "Diamonds"
                //          You have the Ace o Clubs
                //          You have the Jack of Diamonds
                // D: List, Card, strings of the Face and Suit
                // A: for each card in our list of cards,do the following step
                //    - print a string that looks like " You have <put the FACE here> of <put the SUIT here>

                foreach (var cardInPlayerHand in playerHand.CardsInHand)
                {
                    Console.WriteLine($"You have the {cardInPlayerHand.Value} of {cardInPlayerHand.Suit}");
                }

                // Get total value of cards in PlayerHand
                var thePlayerHandTotalValue = playerHand.TotalValue();

                Console.WriteLine($"You have the {thePlayerHandTotalValue} points");

                var thePlayerTotalValue = playerHand.TotalValue();
                Console.WriteLine($"Your hand is worth {thePlayerTotalValue}");

                // - If Player HITS:
                //   -- Loop to add to Player card List - Pull 1 card for Player
                Console.Write("Would you like to HIT, or STAND? ");
                hitOrStand = Console.ReadLine();

                if (hitOrStand == "HIT")
                {
                    var cardFromSelectingHitOption = deck[0];
                    deck.Remove(cardFromSelectingHitOption);

                    playerHand.PlaceInHand(cardFromSelectingHitOption);

                }

            } while (hitOrStand == "HIT" && playerHand.TotalValue() <= 21);

            if (playerHand.TotalValue() > 21)
            {
                foreach (var cardInPlayerhand in playerHand.CardsInHand)
                {
                    Console.WriteLine($"You have the {cardInPlayerhand.Value} of {cardInPlayerhand.Suit}");
                }
                Console.WriteLine($"Your hand is worth {playerHand.TotalValue()} points");

            }
            else
            {

                // - Check dealer cards total
                //   -- If < 17, pull another card until >= 17
                //   -- If >= 17, no change
                //   -- If Dealer goes over 21, BUST

                while (dealerHand.TotalValue() < 17)
                {
                    var cardDealtToDealer = deck[0];
                    deck.Remove(cardDealtToDealer);
                    dealerHand.PlaceInHand(cardDealtToDealer);
                }

                // - Display Dealer Cards

                Console.WriteLine();

                foreach (var cardInDealerhand in dealerHand.CardsInHand)
                {
                    Console.WriteLine($"You have the {cardInDealerhand.Value} of {cardInDealerhand.Suit}");
                }

                Console.WriteLine($"The dealer has {dealerHand.TotalValue()} points");
            }

            if (playerHand.TotalValue() > 21)
            {
                Console.WriteLine("DEALER WINS");
            }
            else if (dealerHand.TotalValue() > 21)
            {
                Console.WriteLine("PLAYER WINS");
            }
            else if (dealerHand.TotalValue() >= playerHand.TotalValue())
            {
                Console.WriteLine("DEALER WINS");
            }
            else
            {
                Console.WriteLine("PLAYER WINS");
            };


            // - Prompt - Give option for Player to HIT or STAND






        }
    }

}
