



using Exercise_43__Point_Class_;

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
    var point = new Point(actualX, actualY);

    Console.WriteLine($"You have created a point object ({point.X},{point.Y}). It has a distance of {point.Distance()}.");

    Console.WriteLine("Would you like to continue? (y/n)");
    var yn = Console.ReadLine().ToLower();
    if (yn == "n")
        break;
}


