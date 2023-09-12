using H1_Blackjack_opg.Model;
using H1_Blackjack_opg.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace H1_Blackjack_opg.Controller
{
    internal class Controller
    {
        public void PlayGame() 
        {
            Dealer dealer = new Dealer();
            Gui.DisplayWelcome();

            Table Cards;

            while (true)
            {
                Gui.DisplayNewRound();

                // Make and shuffle a deck of cards
                Cards.deck = dealer.MakeDeck();
                dealer.ShuffleDeck(Cards.deck);

                // Initialize hands for the player and dealer
                List<string> playerHand = new List<string>();
                List<string> dealerHand = new List<string>();

                // Deal the initial two cards to the player and dealer
                for (int i = 0; i < 2; i++)
                {
                    playerHand.Add(dealer.DealCard(Cards.deck));
                    dealerHand.Add(dealer.DealCard(Cards.deck));
                }

                // Display the initial hands
                Gui.DisplayPlayerHand(playerHand);
                Gui.DisplayDealerUpcard(dealerHand);

                // Player's turn
                playerPlaying(playerHand, dealer, Cards);


                // Dealer's turn
                DealerPlaying(playerHand, dealer, Cards, dealerHand);

                Gui.DisplayDealerUpcard(dealerHand);

                // Determine the winner
                int playerValue = GetHandValue(playerHand);
                int dealerValue = GetHandValue(dealerHand);

                if (playerValue > 21)
                {
                    Gui.DisplayDealerWinsAndbusted();
                }
                else if (dealerValue > 21 || playerValue > dealerValue)
                {
                    Gui.DisplayWin();
                }
                else if (dealerValue > playerValue)
                {
                    Gui.DisplayDealerWins();
                }
                else
                {
                    Gui.DisplayTie();
                }

                // Ask if the player wants to play another round
                Gui.DisplayWannaPlayAgain();
                string playAgain = Get.lowerInput();

                if (playAgain != "yes")
                {
                    Gui.DisplayThanks();
                    break;
                }
            }
        }

        private void playerPlaying(List<string> playerHand, Dealer dealer, Table Cards)
        {
            while (true)
            {
                Gui.DisplayHitOrStand();
                string choice = Get.lowerInput();

                if (choice == "hit")
                {
                    string newCard = dealer.DealCard(Cards.deck);
                    playerHand.Add(newCard);

                    Gui.DisplayPlayerHand(playerHand);

                    if (GetHandValue(playerHand) > 21)
                    {
                        Gui.DisplayDealerWinsAndbusted();
                        break;
                    }
                }
                else if (choice == "stand")
                {
                    break;
                }
                else
                {
                    Gui.DisplayInvalidChoice();
                }
            }
        }
        private void DealerPlaying(List<string> playerHand, Dealer dealer, Table Cards, List<string> dealerHand)
        {
            while (GetHandValue(dealerHand) < 17)
            {
                string newCard = dealer.DealCard(Cards.deck);
                dealerHand.Add(newCard);
            }
        }

        private int GetHandValue(List<string> hand)
        {
            int value = 0;
            int aceCount = 0;

            foreach (string card in hand)
            {
                string rank = card.Split(' ')[0];

                if (rank == "Ace")
                {
                    value += 11;
                    aceCount++;
                }
                else if (rank == "King" || rank == "Queen" || rank == "Jack")
                {
                    value += 10;
                }
                else
                {
                    value += int.Parse(rank);
                }
            }

            // Adjust for aces
            while (value > 21 && aceCount > 0)
            {
                value -= 10;
                aceCount--;
            }

            return value;
        }
    }
}
