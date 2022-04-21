using LibraryApp;
using LibraryApp.DataAccessLayer.Repositories;
using NUnit.Framework;
using System.Linq;

namespace LibraryAppTests.DataAccessLayer.Repositories.Tests
{
    [TestFixture()]
    public class BookRepoTests
    {
        private BookRepo _bookRepo;

        [Test]
        public void GetBooksTest()
        {
            // Arrange
            _bookRepo = new BookRepo();

            // Act
            var result = _bookRepo.GetBooks();

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void GetBookByIdTest()
        {

            // Arrange
            _bookRepo = new BookRepo();

            Book testBook = new Book()
            {
                id = 1,
                title = "Sahara",
                author = "Clive Cussler",
                status = false
            };

            // Act
            var result = _bookRepo.GetBookById(testBook.id);

            Assert.AreEqual(testBook.title, result.title);
            Assert.AreEqual(testBook.author, result.author);
            Assert.AreEqual(testBook.checkedOutDateDate, result.checkedOutDateDate);
            Assert.AreEqual(testBook.dueDate, result.dueDate);
            Assert.AreEqual(testBook.status, result.status);
        }

        [Test]
        public void GetByAuthorTest()
        {
            // Arrange
            _bookRepo = new BookRepo();

            var testBook = new Book()
            {
                author = "Clive Cussler"
            };

            // Act
            var result = _bookRepo.GetByAuthor(testBook.author);

            // Assert
            var resultBook = result.First(r => r.author == testBook.author);

            Assert.AreEqual(testBook.author, resultBook.author);
        }

        [TestCase("Troopers")]
        [TestCase("TrOoPeRs")]
        [TestCase("TROOPERS")]
        [TestCase("troopers")]
        public void GetByTitleKeywordTest(string key)
        {
            // Arrange
            _bookRepo = new BookRepo();

            var testBook = new Book()
            {
                title = "Starship Troopers"
            };

            var keyword = key;

            // Act
            var result = _bookRepo.GetByTitleKeyword(keyword);
            var resultBook = result.First(r => r.title == testBook.title);

            // Assert
            Assert.AreEqual(testBook.title, resultBook.title);
        }

        [TestCase(1)]
        public void UpdateBookTest(int id) 
        { 
            // Arrange
            var _bookRepo = new BookRepo();
            var testBook = _bookRepo.GetBookById(id);

            var intitCheckoutDate = testBook.checkedOutDateDate;
            var initStatus = testBook.status;
            var initDueDate = testBook.dueDate;

            // Act
            _bookRepo.UpdateBook(testBook);
            var updatedBook = _bookRepo.GetBookById(id);

            //Assert
            Assert.AreNotEqual(updatedBook.status, initStatus);
            Assert.AreNotEqual(updatedBook.checkedOutDateDate, intitCheckoutDate);
            Assert.AreNotEqual(updatedBook.dueDate, initDueDate);
            Assert.IsNotNull(updatedBook.dueDate);
        }
    }
}