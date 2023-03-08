using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    //Test class added to show all functionality of the program - Shuffling a pack, dealing one card, dealing multiple cards
    class Testing
    {
        static Pack pack = new Pack();
        //Method to test functionality of program - Shuffling, dealing
        public static void TestPacks()
        {
            ShuffleCards(1); //Calls the ShuffleCards method with the paramater of 1 - conducts a Fisher-Yates shuffle
            ShuffleCards(2); //2 = Riffle shuffle
            ShuffleCards(3); //3 = No shuffle
        }

        //Method to display both a single card and all cards in a pack
        private static void DisplayCards(Pack pack) //Takes a Pack as a paramater so the function has acces to the pack that needs to be dealt
        {
            Card playerCard = pack.dealCard();
            Console.WriteLine($"Single card:\nSuit: {playerCard.Suit} Value: {playerCard.Value}\n");
            List<Card> cards = pack.dealCard(52); //Deals the whole pack
            Console.WriteLine("All cards:");
            foreach (Card card in cards)
            {
                Console.WriteLine($"Suit: {card.Suit} Value: {card.Value}");
            }
            Console.WriteLine("---------------------------------------\n");
        }
        
        //Method to display what is happening to the user and then shuffle the cards
        private static void ShuffleCards(int shuffleType)
        {
            string shuffleName;
            //This if statement takes the shuffleType variable to determine the name of the shuffle so it can be printed to the user
            if (shuffleType == 1)
            {
                shuffleName = "Fisher-Yates Shuffle";
            }
            else if (shuffleType == 2)
            {
                shuffleName = "Riffle Shuffle";
            }
            else
            {
                shuffleName = "No Shuffle";
            }

            Console.WriteLine(shuffleName);
            Console.WriteLine("---------------------------------------\n");
            pack = new Pack(); //Creates a new, fresh pack so it won't be shuffled
            pack.shuffleCardPack(shuffleType); //Calls shuffleCardPack with whichever shuffeType was passed
            DisplayCards(pack);
        }
    }
}
