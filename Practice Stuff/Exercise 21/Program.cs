using System;

namespace Exercise_21
{
    class Program
    {
        static void Main(string[] args)
        {
            var newAgain = true;
            while (newAgain)
            {
                string outputString = "";
                var addWord = true;
                while (addWord)
                {
                    
                                        
                    Console.Write("Please enter any word: ");
                    string newWord = Console.ReadLine();
                    outputString += newWord + " n";

                    Console.Write("Would you like to add another word? (Y/N) ");
                    string newWordResponse = Console.ReadLine().ToLower();

                    if(newWordResponse == "y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(outputString);
                        addWord = false;
                    }
                    

                }
                Console.Write("Would you like to enter a new string? (Y/N)");
                var newStringResponse = Console.ReadLine().ToLower();

                if(newStringResponse == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Goodbye!!!");
                    newAgain = false;
                }
            }
        }
    }
}
