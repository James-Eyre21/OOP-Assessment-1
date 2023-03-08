using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static Pack pack = new Pack();
        static void Main(string[] args)
        {
            while (MenuSystem()); //Repeats program until user chooses to exit
        }

        //Method to allow user to test specific functionality - Deal one card, deal multiple cards, shuffle pack, exit
        static bool MenuSystem() //Method not used elsewhere so it is encapsulated
        {
            Console.WriteLine("Welcome to the Card Dealer progam!" +
                "\n1. Deal one card" +
                "\n2. Deal multiple cards" +
                "\n3. Shuffle Pack" +
                "\n4. Run 'Testing'" +
                "\n5. Exit program");
            int userChoice = GetIntInput(1, 5); //Variable is private as it is not needed anywhere else

            switch (userChoice) //Switch case to run code based on what the user wishes to do
            {
                case 1:
                    Card playerCard = pack.dealCard(); //Creates a new card with the value returned from the dealCard function
                    Console.WriteLine($"\nSingle Card:\nSuit: {playerCard.Suit} Value: {playerCard.Value}"); //Displays the attributes of the dealt card
                    Console.WriteLine("---------------------------------------\n"); //Line for readability
                    break;

                case 2:
                    Console.WriteLine("How many cards do you want to be dealt?");
                    int numCards = GetIntInput(1, 52); //Stores the validated integer inputted by the user
                    List<Card> cards = pack.dealCard(numCards); //Creates a list of cards with the value returned by dealCard function
                    foreach (Card card in cards) //Loop to display attributes of each card in list
                    {
                        Console.WriteLine($"Suit: {card.Suit} Value: {card.Value}");                       
                    }
                    Console.WriteLine("---------------------------------------\n");
                    break;

                case 3:
                    Console.WriteLine($"Which type of shuffle?" +
                        $"\n1. Fisher-Yates Shuffle" +
                        $"\n2. Riffle Shuffle" +
                        $"\n3. No Shuffle");
                    int shuffleType = GetIntInput(1, 3);
                    pack.shuffleCardPack(shuffleType); //Shuffles pack based on which shuffle type the user chooses
                    Console.WriteLine("\nPack has been shuffled.\n");
                    break;
                case 4:
                    Testing.TestPacks(); //Calls the TestPacks method from Testing class
                    break;
                case 5:
                    return false; //Exits the program             
            }
            return true;
        }

        //Recursive function to conduct a range check on an input
        static int GetIntInput(int min, int max) //Method not used in other classes - encapsulated
        {
            int integerInput = 0; //Initialises an integer for validation
            bool isValid = false;

            while (!isValid)
            {
                string rawInput = Console.ReadLine();
                try
                {
                    integerInput = Convert.ToInt32(rawInput);
                    if (integerInput < min)
                    {
                        Console.WriteLine($"ERROR: Input too small. Must be between {min} and {max}"); //Gives the user useful feedback that will help them fix the error
                        return GetIntInput(min, max); //Recurses until the user enters a valid input
                    }

                    else if (integerInput > max)
                    {
                        Console.WriteLine($"ERROR: Input too large. Must be between {min} and {max}");
                        return GetIntInput(min, max);
                    }

                    else
                    {
                        isValid = true;
                    }
                }
                catch
                {
                    Console.WriteLine($"ERROR: Invalid input. Must be between {min} and {max}");
                }
            }
            return integerInput;
        }
    }
}
