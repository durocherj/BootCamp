
using Movie_Database_Lab;

bool repeat = true;
string error = "I'm sorry, that is not a valid option.";
var movie1 = new Movie("Schindler's List", "Drama");
var movie2 = new Movie("2001: A Space Odyssey", "Sci Fi");
var movie3 = new Movie("House of Gucci","Drama");
var movie4 = new Movie("Aliens", "Sci Fi");
var movie5 = new Movie("A Few Good Men", "Drama");
var movie6 = new Movie("Halloween", "Horror");
var movie7 = new Movie("Nightmare on Elm Street", "Horror");
var movie8 = new Movie("Gremlins", "Horror");
var movie9 = new Movie("Finding Nemo", "Animated");
var movie10 = new Movie("Spirited Away","Animated");


while (repeat)
{



    Console.WriteLine("Would you like to go again? (y/n)");
    var yn = Console.ReadLine().ToLower();
    if (yn == "n")
        break;
}
