using System;


namespace Lab_3
{

    class Program
    {

        static void Main(string[] args)
        {
            var repeat = true;
            while (repeat)
            {
                Console.Write("Welcome to Dice Land!!! You may roll 2 dice. \nPlease choose how many sides the dice will have (Integers larger than 0 please): ");
                var input = Console.ReadLine();

                int sides;
                bool number = int.TryParse(input, out sides);

                if (number)
                {
                    Console.WriteLine($"You have chose to roll 2 dice with {sides} sides!");
                    if (sides == 6)
                    {
                        var output = Roller6();
                        Console.WriteLine(output);
                    }

                    else
                    {
                        var output = Roller(sides);
                        Console.WriteLine(output);
                    }

                }
                else
                    Console.WriteLine("I'm sorry, that isn't a valid entry.");

                Console.Write("Would you like to try again? (y/n) ");
                var again = Console.ReadLine().ToLower();

                if (again == "y")
                    continue;
                else
                    repeat = false;

            }

        }
       
        public static string Roller(int sides)
        {
            var rand = new Random();
            var res1 = rand.Next(1, sides + 1);
            var res2 = rand.Next(1, sides + 1);
            string output = $"{res1} and {res2} make {res1 + res2}.";
            return output;
        }
        public static string Roller6()
        {
            var rand = new Random();
            var res1 = rand.Next(1, 7);
            var res2 = rand.Next(1, 7);
            string output;

            if (res1 == 1 && res2 == 1)
                output = "Double 1s!!! That's Snake Eyes!!! Craps!!!";
            else if ((res1 == 1 && res2 == 2) || (res1 == 2 && res2 == 1))
                output = "A 1 and a 2, that's Ace Deuce!!! Craps!!!";
            else if (res1 == 6 && res2 == 6)
                output = "Double sixes!!! Box Cars!!! Craps!!!";
            else if (res1 + res2 == 7)
                output = $"{res1} and {res2}, 7 wins!!!!";
            else if (res1 + res2 == 11)
                output = $"{res1} and {res2}, 11 wins!!!!";
            else
                output = $"{res1} and {res2} make {res1 + res2}.";
            

            return output;
        }

    }
}
