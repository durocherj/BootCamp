using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.DataAccessLayer.Repositories
{
    public class BookRepo
    {
        //private List<Book> Cache { get; set; } = new List<Book> { };

        public List<Book> GetBooks()
        {
            string executableLocation = AppDomain.CurrentDomain.BaseDirectory;

            
            string[] files = Directory.GetFiles(executableLocation + @"\Database\BookTable\", "*.json", SearchOption.TopDirectoryOnly);
            //string[] files = Directory.GetFiles(@"~\desktop\midtermrepo\")

            var books = new List<Book>();

            //Iterate through the files and deserialize them
            foreach (var f in files)
            {
                var b = JsonConvert.DeserializeObject <Book>(File.ReadAllText(f));

                if(b != null)
                {
                    //AddToCache(b);
                    books.Add(b);
                }
            }

            books = books.OrderBy(x => x.id).ToList();

            return books;

        }

        public List<Book> GetByAuthor(string author)
        {
            /// get all books
            var book = GetBooks();
            /// filter book by author
            return book.Where(x => x.author.ToLower() == author.ToLower()).ToList();
        }

        public List<Book> GetByTitleKeyword(string keyword)
        {
            /// get books
            var book = GetBooks();
            /// filter by keyword
            return book.Where(x => x.title.ToLower().Contains(keyword.ToLower())).ToList();
        }

        public Book GetBookById (int id)
        {
            string executableLocation = AppDomain.CurrentDomain.BaseDirectory;

            string text = File.ReadAllText(executableLocation + @$"\Database\BookTable\{id}.json");
            var book = JsonConvert.DeserializeObject<Book>(text);

            return book;
        }

        public void UpdateBook(Book book)
        {
            /// grab book by id 
            var bookToUpdate = GetBookById(book.id);
            bookToUpdate.status = book.status;
            bookToUpdate.dueDate = book.dueDate;

            string executableLocation = AppDomain.CurrentDomain.BaseDirectory;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(bookToUpdate, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(executableLocation + @$"\Database\BookTable\{book.id}.json", output);
 
        }
                
    }
}
