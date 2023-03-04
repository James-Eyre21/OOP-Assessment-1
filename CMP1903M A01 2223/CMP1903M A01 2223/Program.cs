using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {

            Pack pack = new Pack();

            pack.shuffleCardPack(1);

            foreach (Card card in pack.cardPack)
            {
                Console.WriteLine($"{card.Suit} {card.Value}");
            }

            Console.ReadKey();
        }
    }
}
