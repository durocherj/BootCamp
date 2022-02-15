using System;

namespace Exercise_24
{
    class Program
    {
        static void Main(string[] args)
        {
            var runAgain = true;
            while (runAgain)
            {
                Console.WriteLine("Please enter a very long string: ");
                string userInput = Console.ReadLine();

                while (userInput.Length <= 10)
                {
                    Console.WriteLine("Please enter a longer string. We need at least 10 characters.");
                    userInput = Console.ReadLine();
                }
                
                Console.WriteLine(userInput.Substring(userInput.Length - 10));
                
                Console.Write("Would you like to enter a new string? (Y/N) ");
                var repeatInput = Console.ReadLine().ToLower();

                if(repeatInput == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Goodbye!!!");
                    runAgain = false;
                }
            }
           

        }
    }
}
