using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public Pack()
        {
            //Initialise the card pack here
            List<Card> pack = new List<Card>();

            for (int s = 1; s < 5; s++)
            {
                for (int v = 1; v < 14; v++)
                {
                    Card card = new Card();
                    card.Suit = s;
                    card.Value = v;
                    pack.Add(card);
                }
            }
        }

        public bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            
            return false;

        }
        public static Card deal()
        {
            //Deals one card
            return null;

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            return null;
        }
    }
}
