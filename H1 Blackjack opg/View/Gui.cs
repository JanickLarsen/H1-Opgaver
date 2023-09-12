using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Blackjack_opg.View
{
    internal class Gui
    {
        public static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Blackjack!");
        }

        public static void DisplayNewRound()
        {
            Console.WriteLine("\nStarting a new round...");
        }
        public static void DisplayPlayerHand(List<string> playerHand)
        {
            Console.WriteLine("\nYour hand: " + string.Join(", ", playerHand));
        }
        public static void DisplayDealerUpcard(List<string> dealerHand)
        {
            Console.WriteLine("Dealer's upcard: " + dealerHand[0]);
        }
        public static void DisplayHitOrStand()
        {
            Console.WriteLine("Do you want to 'hit' or 'stand'? ");
        }

        public static void DisplayNewCard(string newCard)
        {
            Console.WriteLine("You drew: " + newCard);
        }


        public static void DisplayDealerWinsAndbusted()
        {
            Console.WriteLine("Dealer wins! You busted.");
        }
        public static void DisplayDealerWins()
        {
            Console.WriteLine("Dealer wins!");
        }
        public static void DisplayWin()
        {
            Console.WriteLine("You win!");
        }

        public static void DisplayTie()
        {
            Console.WriteLine("It's a tie!");
        }

        public static void DisplayWannaPlayAgain() 
        {
            Console.Write("\nDo you want to play another round? (yes/no): ");
        }

        public static void DisplayThanks()
        {
            Console.WriteLine("Thanks for playing!");
        }


        public static void DisplayInvalidChoice()
        {
            Console.WriteLine("Invalid choice. Please enter 'hit' or 'stand'.");
        }
    }
}
