// See https://aka.ms/new-console-template for more information



var repeatLoop = true;
int[] intArray = new int[5] { 2, 8, 0, 24, 51 };
var error = "I'm sorry, that's not a valid entry.";
int indexValue;
Console.WriteLine(intArray.Max());
while (repeatLoop)
{
    Console.WriteLine("Please enter which indrex entry you would like to view: ");
    var input = Console.ReadLine();
    bool inputValid = int.TryParse(input, out indexValue);

    if (inputValid)
    {
        if (indexValue >= 0 && indexValue <= 4)
            Console.WriteLine($"The value at index {indexValue} is {intArray[indexValue]}");
        else
            Console.WriteLine(error);  
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
