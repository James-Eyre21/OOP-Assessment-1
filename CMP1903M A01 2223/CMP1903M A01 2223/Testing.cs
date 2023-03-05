using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();
            testPacks(pack, 3); //Test for pack with no shuffle
            testPacks(pack, 2); //test for pack using Riffle shuffle
            testPacks(pack, 1); //Test for pack using Fisher-yates shuffle
            

            Console.ReadKey();
        }

        //Method to test functionality of program - Shuffling, dealing
        public static void testPacks(Pack pack, int shuffleType)
        {
            pack.shuffleCardPack(shuffleType);

            Card playerCard = Pack.dealCard(); //This will return 1 single card
            Console.WriteLine($"Your card is: {playerCard.Suit} {playerCard.Value}"); //Prints out the suit then value of the returned card

            Console.WriteLine(); //Prints empty line to distinguish between the single dealt card and the list of cards

            List<Card> playerCards = Pack.dealCard(52); //This will return the given amount of cards and store it in a list
            //Loops through the list of cards
            foreach (Card card in playerCards)
            {
                Console.WriteLine($"Your card is: {card.Suit} {card.Value}"); //Prints out the suit then value of the current card in the list
            }
            Console.WriteLine("----------------"); //Prints a line to make it easier to see when one list of cards has finished printing
        }

        
    }
}
