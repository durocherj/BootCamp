using System;

namespace Exercise_15
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

                for (int i = 1; i <= input; i++)
                {
                    var square = Math.Pow(i, 3);
                    Console.Write(square + " ");
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
