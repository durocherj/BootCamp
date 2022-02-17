// See https://aka.ms/new-console-template for more information


var repeatLoop = true;
int[] intArray = new int[5] { 16,32,64,128,256 };
var error = "I'm sorry, that's not a valid entry.";

Console.WriteLine($"The array is currently {String.Join(" ", intArray)}");
while (repeatLoop)
{
    
    Console.WriteLine("Enter command (half/double);");
    var hd = Console.ReadLine().ToLower();
    if (hd == "half")
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = intArray[i] / 2;            
        }
            
    else if (hd == "double")
        for (int i = 0;i < intArray.Length;i++)
        {
            intArray[i] = intArray[i] * 2;            
        }
            
    else
        Console.WriteLine(error);

    Console.WriteLine($"The array is now {String.Join(" ", intArray)}");
    Console.WriteLine("Would you like to continue? (y/n)");

    var goAgain = Console.ReadLine().ToLower();

    if (goAgain == "y")
        continue;
    else
        Console.WriteLine("Thank you, have a nice day!");
    repeatLoop = false;

}
