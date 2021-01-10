# BlackJackCS

# PEDA

## P - Describe the Problem

1.  Need a deck of 52 cards
2.  Need to Deal 2 cards to House that are not shown
3.  Need to Deal 2 cards to the player that are displayed
    -- Player should be able to say HIT (ask for another card)
    -- Need to be able to keep giving player cards until they say STOP
    -- Need to be able to know if Player is over 21 and then say BUST
4.  When player is done need to reveal dealer's cards
5.  Player should be able to HIT (ask for another card) or STAY (keep current cards)
6.  Dealer cards
    -- <= 16 must take a card
    -- >= 17 does not take another card
7.  Need to display winner - player or dealer is closer to 21 without going over
    -- Ties = dealer wins
8.  Option to play a new game
    -- 52 cards are shuffled again
    -- Empty hands for the dealer and player

Card Values:

- Number cards = number
- Aces = 1
- Jack, Queen, King = 10

Note: Cards do NOT need to be the same suit

## E - Give Examples

Example 1:

- Deal 2 cards to dealer (unknown)
- Deal 2 cards to player (Ace and 10) = 11
- Player chooses to HIT (3), Player hand = 14
- Player chooses to HIT (7), Player hand = 21
- Player chooses to STOP
- Show Dealer cards (7, 8) = 15
- Player STAYS
- Dealer must take another card (3) = 18
- Player WINS

Example 2:

- Deal 2 cards to dealer (unknown)
- Deal 2 cards to player (4 and 10) = 14
- Player chooses to HIT (5), Player hand = 19
- Player chooses to STOP
- Show Dealer cards (10, 10) = 20
- Player chooses to HIT (5), Player hand = 24
- Player BUSTS
- Dealer WINS

Example 3:

- Deal 2 cards to dealer (unknown)
- Deal 2 cards to player (4 and 10) = 14
- Player chooses to HIT (5), Player hand = 19
- Player chooses to STOP
- Show Dealer cards (10, 6) = 16
- Player chooses to STAY
- Dealer must take another card (4) = 21
- Dealer WINS

Example 4:

- Deal 2 cards to dealer (unknown)
- Deal 2 cards to player (3 and 4) = 7
- Player chooses to HIT (10), Player hand = 17
- Player chooses to STOP
- Show Dealer cards (1, 10) = 11
- Player chooses to HIT (8), Player hand = 19
- Player chooses to STAY
- Dealer must take another card (2) = 19
- Dealer and Player TIE

## D - Data Structure

- List: Deck of Cards (52)

- List: Player Dealt Cards (2)
- Update Player List if they take more cards

- List: Dealer Dealt Cards (2)
- Update Dealer List if they take more cards

- List: Game results (Winner, Tie, Bust)

## A - Algorithm

- Create a List of cards
- Shuffle Cards

- Create list of Dealer cards - Pull 2 cards off top of deck (0,1) for Dealer. (Need to save but not show yet)
- Create List Player cards - Pull 2 cards for the Player. (Print cards to screen)

- Prompt - Give option for Player to HIT or STAY
- Loop to add to Player card List - Pull 1 card for Player and add to LIST of cards until they say STAY or cards < 21
  -- If > 21, Player BUST

- Display Dealer Cards

- Prompt - Give option for Player to HIT or STAY

- If Player HITS:
  -- Loop to add to Player card List - Pull 1 card for Player

- Check dealer cards total
  -- If <= 16, pull another card until >= 17
  -- If >= 17, no change
  -- If Dealer goes over 21, BUST

- Compare Player cards to Dealer cards
  -- Highest # <= 21 wins
  -- If Player and Dealer == they TIE, Dealer WINS
