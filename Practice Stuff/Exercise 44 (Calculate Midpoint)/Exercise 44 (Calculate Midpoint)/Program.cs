



using Exercise_44__Point_Class_;

var repeat = true;
var error = "I'm sorry, that's not a valid input";


while (repeat)
{
    Console.Write("Please enter the X coordinate: ");
    var inputX = Console.ReadLine();
    int actualX;
    var validX = int.TryParse(inputX, out actualX);
    if (!validX)
    {
        Console.WriteLine(error);
        continue;
    }

    Console.Write("Please enter the Y coordinate: ");
    var inputY = Console.ReadLine();
    int actualY;
    var validY = int.TryParse(inputY, out actualY);
    if (!validY)
    {
        Console.WriteLine(error);
        continue;
    }
    var point1 = new Point(actualX, actualY);

    Console.Write("Please enter the second X coordinate: ");
    var inputX2 = Console.ReadLine();
    int actualX2;
    var validX2 = int.TryParse(inputX, out actualX);
    if (!validX2)
    {
        Console.WriteLine(error);
        continue;
    }

    Console.Write("Please enter the second Y coordinate: ");
    var inputY2 = Console.ReadLine();
    int actualY2;
    var validY2 = int.TryParse(inputY, out actualY);
    if (!validY2)
    {
        Console.WriteLine(error);
        continue;
    }
    var point2 = new Point(actualX, actualY);






    Console.WriteLine("Would you like to continue? (y/n)");
    var yn = Console.ReadLine().ToLower();
    if (yn == "n")
        break;
}


