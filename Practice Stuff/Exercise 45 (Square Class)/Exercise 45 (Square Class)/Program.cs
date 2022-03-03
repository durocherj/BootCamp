using Exercise_45__Square_Class_;

bool repeat = true;
string error = "I'm sorry, that is not a valid option.";

while (repeat)
{
    Console.Write("Please enter a length for the sides of our square: ");
    int validSideLength;
    bool inputIsValid = int.TryParse(Console.ReadLine(), out validSideLength);

    if (inputIsValid)
    {
        Square ourSquare = new Square(validSideLength);
        Console.WriteLine($"The square has a side length {validSideLength}. It's area is {ourSquare.CalculateArea()} and it's perimeter is {ourSquare.CalculatePerimeter()}");
    }


    Console.WriteLine("Would you like to go again? (y/n)");
    var yn = Console.ReadLine().ToLower();
    if (yn == "n")
        break;
}