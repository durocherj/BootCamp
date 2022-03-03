
bool repeat = true;
string error = "I'm sorry, that is not a valid input.";


while (repeat)
{



    Console.WriteLine("Would you like to go again? (y/n)");
    var yn = Console.ReadLine().ToLower();
    if (yn == "n")
        break;
}