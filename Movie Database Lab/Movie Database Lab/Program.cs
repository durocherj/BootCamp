
using Movie_Database_Lab;

bool repeat = true;
string error = "I'm sorry, that is not a valid option.";
var movie1 = new Movie("Schindler's List", "Drama");
var movie2 = new Movie("2001: A Space Odyssey", "Sci Fi");
var movie3 = new Movie("");
var movie4;
var movie5;
var movie6;
var movie7;
var movie8;
var movie9;
var movie10;


while (repeat)
{



    Console.WriteLine("Would you like to go again? (y/n)");
    var yn = Console.ReadLine().ToLower();
    if (yn == "n")
        break;
}
