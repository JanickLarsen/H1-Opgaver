using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Blackjack_opg.Controller
{
    internal class Dealer
    {
        
        public List<string> MakeDeck()
        {
            List<string> deck = new List<string>();
            string[] types = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            foreach (string suit in types)
            {
                foreach (string rank in ranks)
                {
                    deck.Add(rank + " of " + suit);
                }
            }

            return deck;
        }
        public void ShuffleDeck(List<string> deck)
        {
            Random rand = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                string value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }

        public string DealCard(List<string> deck)
        {
            string card = deck[0];
            deck.RemoveAt(0);
            return card;
        }
    }
}
