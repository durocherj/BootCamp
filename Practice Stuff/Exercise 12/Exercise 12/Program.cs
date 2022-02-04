using System;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var again = true;

            while (again)
            {
                for (int i = 9; i >= 0; i--)
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
