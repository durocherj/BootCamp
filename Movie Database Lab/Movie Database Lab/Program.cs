
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

List<Movie> movieList = new List<Movie>()
    {
        movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10
    };


while (repeat)
{
    

    Console.WriteLine("Welcome to the Movie Database!!! Please choose a genre below!" +
        "\n1. Drama" +
        "\n2. Horror" +
        "\n3. Animated" +
        "\n4. Sci Fi");

    int actualInput;
    bool isInputValid = int.TryParse(Console.ReadLine(), out actualInput);
    if (!isInputValid)
    {
        Console.WriteLine(error);
        continue;
    }
    switch (actualInput)
    {
        case 1:
            Console.WriteLine("The following films fall under the 'Drama' category:");
            List<Movie> dramaList = movieList.Where(x => x.GetCategory() == "Drama").ToList();
            foreach (Movie movie in dramaList)
            {
                Console.WriteLine(movie.GetTitle());
            }
            //foreach(Movie movie in movieList)
            //{
            //    if (movie.GetCategory() == "Drama")
            //        Console.WriteLine(movie.GetTitle());
            //}            
            break;
        case 2:
            Console.WriteLine("The following films fall under the 'Horror' category:");
            List<Movie> horrorList = movieList.Where(x => x.GetCategory() == "Horror").ToList();
            foreach (Movie movie in horrorList)
            {
                Console.WriteLine(movie.GetTitle());
            }
            //foreach (Movie movie in movieList)
            //{
            //    if (movie.GetCategory() == "Horror")
            //        Console.WriteLine(movie.GetTitle());
            //}
            break;
        case 3:
            Console.WriteLine("The following films fall under the 'Animated' category:");
            List<Movie> animatedList = movieList.Where(x => x.GetCategory() == "Animated").ToList();
            foreach (Movie movie in animatedList)
            {
                Console.WriteLine(movie.GetTitle());
            }
            //foreach (Movie movie in movieList)
            //{
            //    if (movie.GetCategory() == "Animated")
            //        Console.WriteLine(movie.GetTitle());
            //}
            break;
        case 4:
            Console.WriteLine("The following films fall under the 'Sci Fi' category:");
            List<Movie> scifiList = movieList.Where(x => x.GetCategory() == "Sci Fi").ToList();
            foreach (Movie movie in scifiList)
            {
                Console.WriteLine(movie.GetTitle());
            }
            //foreach (Movie movie in movieList)
            //{
            //    if (movie.GetCategory() == "Sci Fi")
            //        Console.WriteLine(movie.GetTitle());
            //}
            break;

        default:
            Console.WriteLine(error);
            continue;
    }



    Console.WriteLine("Would you like to go again? (y/n)");
    var yn = Console.ReadLine().ToLower();
    if (yn == "n")
        break;
}
