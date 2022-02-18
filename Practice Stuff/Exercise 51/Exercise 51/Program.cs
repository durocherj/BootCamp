

bool repeat = true;
Console.WriteLine("Welcome to my English to Spansish Translator!");

Dictionary<string, string> words = new Dictionary<string, string>()
{
    {"hello", "hola" },
    {"food", "comida" },
    {"world", "mundo" },
    {"computer", "computadora" },
    {"exercise", "ejercicio" }
};

while (repeat)
{
    Console.WriteLine("Please enter the word you would like to translate:");
    var userInput = Console.ReadLine().ToLower();    

    if (words.ContainsKey(userInput))
    {
        Console.WriteLine($"{userInput} in Spanish is {words[userInput]}");
    }
    else
        Console.WriteLine("I'm sorry, I don't know that one.");

    Console.WriteLine("Would you like to try another word? (y/n)");
    var yn = Console.ReadLine().ToLower();

    if (yn == "n")
        repeat = false;
}