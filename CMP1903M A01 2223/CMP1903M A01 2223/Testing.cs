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
            Testing rangeCheck = new Testing(); //Creates an object to access the 'RangeCheck' method
            Pack pack = new Pack();
            TestPacks(pack, rangeCheck.RangeCheck(3, 1, 3)); //Test for pack with no shuffle
            TestPacks(pack, rangeCheck.RangeCheck(2, 1, 3)); //Test for pack using Riffle shuffle
            TestPacks(pack, rangeCheck.RangeCheck(1, 1, 3)); //Test for pack using Fisher-yates shuffle
            
            Console.ReadKey();
        }

        //Method to test functionality of program - Shuffling, dealing
        public static void TestPacks(Pack pack, int shuffleType)
        {
            Testing rangeCheck = new Testing();

            pack.shuffleCardPack(shuffleType);

            Card playerCard = Pack.dealCard(); //This will return 1 single card
            Console.WriteLine($"Your card is: {playerCard.Suit} {playerCard.Value}"); //Prints out the suit then value of the returned card

            Console.WriteLine(); //Prints empty line to distinguish between the single dealt card and the list of cards

            Console.WriteLine("How many cards do you want to deal?");
            int numCards = rangeCheck.RangeCheck(Convert.ToInt32(Console.ReadLine()), 1, 52);

            List<Card> playerCards = Pack.dealCard(numCards); //This will return the given amount of cards and store it in a list
            //Loops through the list of cards
            foreach (Card card in playerCards)
            {
                Console.WriteLine($"Your card is: {card.Suit} {card.Value}"); //Prints out the suit then value of the current card in the list
            }
            Console.WriteLine("----------------"); //Prints a line to make it easier to see when one list of cards has finished printing
        }

        //Recursive function to conduct a range check on an input
        public int RangeCheck(int input, int min, int max)
        {
            if(input < min)
            {
                Console.WriteLine($"ERROR: Input too small. Must be between {min} and {max}"); //Gives the user useful feedback that will help them fix the error
                return RangeCheck(Convert.ToInt32(Console.ReadLine()), min, max); //Recurses until the user enters a valid input
            }

            else if (input > max)
            {
                Console.WriteLine($"ERROR: Input too large. Must be between {min} and {max}");
                return RangeCheck(Convert.ToInt32(Console.ReadLine()), min, max);
            }

            else
            {
                return input;
            }           
        }
        
    }
}
