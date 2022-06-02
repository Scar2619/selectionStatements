using System;

namespace selectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //if else statement

            Console.WriteLine("Input numbers 1-50 below to guess my favorite number.");
            var favNumber = int.Parse(Console.ReadLine());

            if (favNumber <= 6)
            {
                Console.WriteLine("Too low.");
            }
            else if (favNumber >= 8)
            {
                Console.WriteLine("Too high.");
            }
            else
            {
                Console.WriteLine("You nailed it!");
            }

        }
    }
}

