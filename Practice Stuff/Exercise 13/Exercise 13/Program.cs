using System;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var again = true;

            while (again)
            {
                Console.Write("Please enter an integer greater than 0: ");
                int input = int.Parse(Console.ReadLine());

                for (int i = input; i >= 0; i--)
                {
                    Console.Write(i + " ");
                }

                Console.Write("\nWould you like to go again? (y/n)");
                var repeat = Console.ReadLine().ToLower();

                if (repeat == "y")
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
