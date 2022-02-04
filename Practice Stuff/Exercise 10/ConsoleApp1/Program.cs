using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var again = true;

            while (again)
            {
                Console.Write("How tall are you (in inches)? ");
                var height = double.Parse(Console.ReadLine());

                if (height < 54)
                {
                    var diff = 54 - height;
                    Console.WriteLine("I'm sorry, you are " + diff + " inches too short. :(");
                }
                else
                {
                    Console.WriteLine("Yay, you can ride the raptor!!!! :D");
                }

                Console.Write("Would you like to go again? (y/n) ");
                var response = Console.ReadLine().ToLower();

                if (response == "y")
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
