// See https://aka.ms/new-console-template for more information



var repeatLoop = true;
int[] intArray = new int[5] { 2, 8, 0, 24, 51 };
var error = "I'm sorry, that's not a valid entry.";
int isItThere;
while (repeatLoop)
{
    Console.WriteLine("Please enter a value: ");
    var input = Console.ReadLine();
    bool inputValid = int.TryParse(input, out isItThere);

    if (inputValid)
    {
        if (intArray.Contains(isItThere))
            Console.WriteLine($"The value {isItThere} can be found at index {Array.IndexOf(intArray, isItThere)}");
        else
            Console.WriteLine("That value is not within the array.");
    }
    else
        Console.WriteLine(error);

    Console.WriteLine("Would you like to view another entry? (y/n)");

    var goAgain = Console.ReadLine().ToLower();

    if (goAgain == "y")
        continue;
    else
        Console.WriteLine("Thank you, have a nice day!");
    repeatLoop = false;

}
