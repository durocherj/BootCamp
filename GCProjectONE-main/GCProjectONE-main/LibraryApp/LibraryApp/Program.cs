using LibraryApp;
using LibraryApp.BusinessLayer;
using LibraryApp.DataAccessLayer.Repositories;

bool repeat = true;
string error = "\nI'm sorry, that is not a valid option.";
var librarian = new Librarian();



while (repeat)
{
    Console.WriteLine("\nWelcome to the library! What would you like to do? (Please choose a number below)" +
        "\n 1. View list of books 2. Search books 3. Check out a book 4. Return a book 5. Exit");
    int userInput;
    bool tryParseBool = int.TryParse(Console.ReadLine(), out userInput);

    if (tryParseBool)
    {
        switch (userInput)
        {
            case 1:
                var displayMe = librarian.getBookList();
                librarian.DisplayList(displayMe);
                break;

            case 2:
                var displaySearchResults = librarian.BookSearch();
                librarian.DisplayList(displaySearchResults);
                break;

            case 3:
                var checkOutDisplayMe = librarian.getBookList();
                librarian.DisplayList(checkOutDisplayMe);
                Console.WriteLine("\nPlease enter the number of the book you would like to check out:");
                int checkOutInt;
                bool checkOutInputParse = int.TryParse(Console.ReadLine(), out checkOutInt);
                while (!checkOutInputParse || checkOutInt >= checkOutDisplayMe.Count || checkOutInt <= 0)
                {
                    Console.WriteLine(error);
                    checkOutInputParse = int.TryParse(Console.ReadLine(), out checkOutInt);
                }
                //Adjusts the users input to match the index of the book they've selected                    
                librarian.CheckOutBook(checkOutDisplayMe[checkOutInt - 1]);
                break;

            case 4:
                var returnDisplayMe = librarian.getBookList();
                librarian.DisplayList(returnDisplayMe);
                Console.WriteLine("\nPlese enter the number of the book you would like to return:");
                int returnInt;
                bool returnParse = int.TryParse(Console.ReadLine(), out returnInt);
                while(!returnParse || returnInt >= returnDisplayMe.Count || returnInt <= 0)
                {
                    Console.WriteLine(error);
                    returnParse = int.TryParse(Console.ReadLine(), out returnInt);
                }
                librarian.ReturnBook(returnDisplayMe[returnInt - 1]);
                break;

            case 5:
                repeat = false;
                break;

            default:
                Console.WriteLine(error);
                break;
        }
    }
    else
        Console.WriteLine(error); 
}