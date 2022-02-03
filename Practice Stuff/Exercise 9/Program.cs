using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var again = true;

            while (again == true)
            {
                Console.WriteLine("Please choose a language from the following: English, French, German, Spanish.");
                var input = Console.ReadLine();
                input = input.ToLower();

                switch (input)
                {
                case "english":
                    Console.WriteLine("Hello, World!");
                    break;

                case "french":
                    Console.WriteLine("Bonjour le monde!!!");
                    break;

                case "german":
                    Console.WriteLine("Hallo Welt!!!");
                    break;

                case "spanish":
                    Console.WriteLine("¡¡¡Hola Mundo!!!");
                    break;
                }

                Console.Write("Would you like to choose a new entry? (Y/N) ");
                var repeat = Console.ReadLine();
                repeat = repeat.ToLower();

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
