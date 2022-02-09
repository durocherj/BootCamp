using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var again = true;

            while(again)
            {
                Console.Write("Hello! Please enter an integer between 1 and 100: ");
                var input = int.Parse(Console.ReadLine());

                if (input % 2 != 0 && input < 60)
                    Console.WriteLine(input + " is odd and less than 60.");
                else if (input % 2 == 0 && input < 25)
                    Console.WriteLine(input + " is even and less than 25.");
                else if (input % 2 == 0 && input > 25 && input < 61)
                    Console.WriteLine(input + " is even and between 26 and 60 inclusive.");
                else if (input % 2 == 0 && input > 60)
                    Console.WriteLine(input + " is even and greater than 60.");
                else if (input % 2 != 0 && input > 60)
                    Console.WriteLine("I added this");
                    Console.WriteLine(input + " is odd and greater than 60.");
                



                Console.Write("Would you like to enter another number? (y/n) ");
                var repeat = Console.ReadLine().ToLower();

                if(repeat == "y")
                {
                    continue;
                }
                else
                {
                    again = false;
                }
               
               
            }
        }
    }
}
