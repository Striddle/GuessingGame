using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Think of a number between 1 and 100. I will try to guess it. AND I ALWAYS WIN!");
            Console.WriteLine("Enter either h, for higher, l for less, and e, for even.");
            Console.WriteLine("First Guess:50");

            string input = Console.ReadLine();

            

            if (input == "e")
            {
                Console.WriteLine("I WIIIIIIIIIN!");
            }

            if (input == "h")
            {
                Console.WriteLine("");
            }
        }
    }
}
