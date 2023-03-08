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

        //Method to test functionality of program - Shuffling, dealing
        public static void TestPacks()
        {
            Console.WriteLine("Fisher-Yates shuffle:");
            Console.WriteLine("---------------------------------------\n");
            Pack pack = new Pack();
            pack.shuffleCardPack(1); //Calls shuffleCardPack with paramter 1, representing the Fisher-Yates shuffle
            DisplayCards(pack);

            Console.WriteLine("Riffle shuffle:");
            Console.WriteLine("---------------------------------------\n");
            pack = new Pack(); //Creates a new, fresh pack to show the shuffle from a default deck
            pack.shuffleCardPack(2); //Calls shuffleCardPack with paramter 2, representing the Riffle shuffle
            DisplayCards(pack);

            Console.WriteLine("No shuffle:");
            Console.WriteLine("---------------------------------------\n");
            pack = new Pack(); //Creates a new, fresh pack so it won't be shuffled
            pack.shuffleCardPack(3); //Calls shuffleCardPack with paramter 3, representing No shuffle
            DisplayCards(pack);
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
        
    }
}
