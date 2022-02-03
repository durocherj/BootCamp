using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            var userInput = Console.ReadLine();

            int guess = Convert.ToInt32(userInput);

            if (guess >= 10)
            {
                Console.WriteLine("Wow, that's a big one!!!");
            }
            else if (guess > 4 && guess < 10)
            {
                Console.WriteLine("That's not quite a smole, but not too big either.");
            }
            else
            {
                Console.WriteLine("That's a smol.");
            }
        }
    }
}
