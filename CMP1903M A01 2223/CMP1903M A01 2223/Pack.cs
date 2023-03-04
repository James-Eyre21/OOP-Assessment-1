using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public List<Card> cardPack = new List<Card>();
        public Pack()
        {
            //A nested for loop to add 13 cards for each suit to the pack

            for (int s = 1; s < 5; s++)
            {
                for (int v = 1; v < 14; v++)
                {
                    Card card = new Card(); //Creates a new Card object
                    card.Suit = s;
                    card.Value = v;
                    cardPack.Add(card);
                }
            }
        }

        public bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            
            //Fisher-Yates shuffle
            if (typeOfShuffle == 1)
            {
                Random r = new Random();
                for (int i = 0; i < cardPack.Count; i++)
                {
                    int rndNum = r.Next(0, cardPack.Count); //Creates a random number between 0 and the length of the pack
                    cardPack.Add(cardPack[rndNum]); //Adds the card to end of the list
                    cardPack.RemoveAt(rndNum); //Removes the card from its previous position
                }
                return true;
            }

            //Riffle Shuffle
            else if (typeOfShuffle == 2)
            {
                return true;
            }

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
