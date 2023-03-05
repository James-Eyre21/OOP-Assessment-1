using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public static List<Card> pack = new List<Card>();
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
                    pack.Add(card);
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
                List<Card> shuffledPack = new List<Card>();
                for (int i = 0; i < 52; i++)
                {
                    int rndNum = r.Next(0, pack.Count); //Creates a random number between 0 and the length of the pack
                    shuffledPack.Add(pack[rndNum]); //Adds the card to a new list
                    pack.RemoveAt(rndNum); //Removes the card from its previous position
                }
                pack = shuffledPack; //Sets the value of 'pack' to be the same as the shuffled set of cards. So the shuffled pack cna be accessed elsewhere
                return true;
            }

            //Riffle Shuffle
            else if (typeOfShuffle == 2)
            {
                List<Card> half1 = new List<Card>(); //Creates a list that will store the first half of the pack
                List<Card> half2 = new List<Card>(); //Creates a list that will store the second half of the pack

                for (int i = 0; i < pack.Count / 2; i++) //Loops through the first half of the pack
                {
                    half1.Add(pack[i]);
                }

                for (int i = pack.Count / 2; i < pack.Count; i++) //Loops through the second half of the pack
                {
                    half2.Add(pack[i]);
                }

                pack.Clear(); //Clears the values from pack so they can be added back but in a shuffled order

                //This loop should emulate the riffling action, where the cards are split in two and a card from each side is placed on top of the other, one after another
                for (int i = 0; i < half1.Count; i++)
                {
                    pack.Add(half1[i]); //Adds a value from the first half
                    pack.Add(half2[i]); //Adds a value from the second half
                }

                return true;
            }

            //No shuffle
            else if (typeOfShuffle == 3)
            {
                return false;
            }

            else
            {
                return false;
            }

        }
        public static Card dealCard()
        {
            //Deals one card
            Card card = pack[0]; //Deals the top card of the pack - simulates how cards are dealt in real life

            return card;

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'

            List<Card> playerCards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                playerCards.Add(pack[i]);
            }

            return playerCards;
        }
    }
}
