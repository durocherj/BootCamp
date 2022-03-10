
using Exercise_46__Triangle_Class_;

bool repeat = true;
string error = "I'm sorry, that is not a valid input.";



while (repeat)
{
    Console.WriteLine("Please enter the length of side A");
    double actualA;
    bool isAValid = double.TryParse(Console.ReadLine(), out actualA);
    if (!isAValid)
    {
        Console.WriteLine(error);
        continue;
    }
    

    Console.WriteLine("Please enter the length of side B");
    double actualB;
    bool isBValid = double.TryParse(Console.ReadLine(), out actualB);
    if (!isBValid)
    {
        Console.WriteLine(error);
        continue;
    }
    

    Console.WriteLine("Please enter the length of side C");
    double actualC;
    bool isCValid = double.TryParse(Console.ReadLine(), out actualC);
    if (!isCValid)
    {
        Console.WriteLine(error);
        continue;
    }
    Triangle ourTriangle = new Triangle(actualA, actualB, actualC);


    var area = ourTriangle.GetArea();
    //Console.WriteLine(triangle.GetPerimeter(triangle));
    Console.WriteLine($"The area of a triangle with sides {ourTriangle.sideLengthA}, {ourTriangle.sideLengthB}, {ourTriangle.sideLengthC} is {area}");



    Console.WriteLine("Would you like to go again? (y/n)");
    var yn = Console.ReadLine().ToLower();
    if (yn == "n")
        break;
}