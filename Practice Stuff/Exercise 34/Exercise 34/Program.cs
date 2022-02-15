// See https://aka.ms/new-console-template for more information


var repeatLoop = true;
double[] doubleArray = new double[5] { 16,32,64,128,256 };
var error = "I'm sorry, that's not a valid entry.";
int indexNum;
while (repeatLoop)
{
    Console.WriteLine("Enter command (half/double);");
    string hd = Console.ReadLine().ToLower();
    if (hd == "half")
        foreach (double i in doubleArray)
            doubleArray[i] = doubleArray[i] / 2;
    else if (hd == "double ")
        foreach (double i in doubleArray)
            doubleArray[i] = doubleArray[i] * 2;
    else
        Console.WriteLine(error);

    Console.WriteLine("Would you like to continue? (y/n)");

    var goAgain = Console.ReadLine().ToLower();

    if (goAgain == "y")
        continue;
    else
        Console.WriteLine("Thank you, have a nice day!");
    repeatLoop = false;

}
