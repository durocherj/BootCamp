using LibraryApp.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.BusinessLayer
{
    public class Librarian
    {
        List<Book> BookList { get; set; }
        Member Member { get; set; }
        private BookRepo _bookRepo; 

        //public Librarian (List<Book> listOfBooks, Member member)
        //{
        //    this.BookList = listOfBooks;
        //    this.Member = member;
        //}
        public Librarian()
        {
            _bookRepo = new BookRepo();
        }

        public void DisplayList(List<Book> bookList)
        {
            
            foreach (Book book in bookList)
            {
                Console.Write($"{book.id}. {book.title}, by {book.author}.");
                //checks if the book is currently checked out, since the status bool is set to true when it is
                if (book.status)
                {
                    
                    //display due date if book is checked out using DateTime.Parse
                    var displayDueDate = DateTime.Parse(book.dueDate);
                    Console.WriteLine($" This book is checked out and due back {displayDueDate}");
                }
                //this is for formatting purposes since the first half of our output (before the if statement) does not have a line break
                else
                    Console.WriteLine();
                    
            }
        }

        public List<Book> getBookList()
        {
            return _bookRepo.GetBooks();
        }

        public void CheckOutBook(Book book)
        {
            /// select a book from the list
            /// if its checked out let them know
            if (book.status == true)
            {
                Console.WriteLine("\nThis book is already checked out, please select another.");
            }
            else
            {
                /// if its not checked out - check it out to them and set due date for 2 weeks from today
                book.status = true;
                var dueDate = DateTime.Now.AddDays(14);
                book.dueDate = dueDate.ToString();

                _bookRepo.UpdateBook(book);

                Console.WriteLine($"\nI have checked out {book.title} for you - please return it in two weeks on {book.dueDate}");
            }
        }

        public List<Book> BookSearch()
        {
            //Prompt user and parse their input
            Console.WriteLine("\nWould you like to search by:\n1. Author 2. Title");
            int userInputSearchOption;
            bool tryParseBoolSearch = int.TryParse(Console.ReadLine(), out userInputSearchOption);

            //this will loop the user until they enter a valid input
            while (!tryParseBoolSearch)
            {
                Console.WriteLine("\nWould you like to search by:\n1. Author 2. Title");
                tryParseBoolSearch = int.TryParse(Console.ReadLine(), out userInputSearchOption);
            }

            //Prompts user for author name, then feeds it through the search method
            if(userInputSearchOption == 1)
            {
                Console.WriteLine("\nPlease enter the name of the author you're looking for:");
                var authorInput = Console.ReadLine();
                var returnAuthorSearch = _bookRepo.GetByAuthor(authorInput);
                return returnAuthorSearch;
            }

            //Prompts user for book title, then feeds it through the search method
            else
            {
                Console.WriteLine("\nPlease enter the title of the book you're looking for:");
                var titleInput = Console.ReadLine();
                var returnTitleSearch = _bookRepo.GetByTitleKeyword(titleInput);
                return returnTitleSearch;
            }
        }

        public void ReturnBook(Book book)
        {
            // what do we want this to look like? 
            if (book.status == false)
            {
                Console.WriteLine("\nThis book is already returned");
            }
            else
            {
                book.status = false;
                book.dueDate = "";
                _bookRepo.UpdateBook(book);
                Console.WriteLine("\nThis book is now returned, thank you!");
            }

        }
        public void createNewMembership()
        {
            throw new NotImplementedException();
        }

        public void cancelMembership()
        {
            throw new NotImplementedException();
        }

        public void calculateFees()
        {
            throw new NotImplementedException();
        }

        public void trackBookStatus()
        {
            throw new NotImplementedException();
        }


    }
}



// this will have a list of book
// this will have an instance of book
// this will have our methods