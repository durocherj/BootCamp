using LibraryApp;
using LibraryApp.BusinessLayer;
using LibraryApp.DataAccessLayer.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryAppTests.DataAccessLayer.Repositories.Tests
{
    [TestFixture()]
    public class LibrarianTests
    {
        private Librarian _librarian;
        private BookRepo _bookRepo;
        private Book _book;

        [Test]
        public void GetBookListTest()
        {
            // Arrange
            _librarian = new Librarian();

            //Act
            var bookList = _librarian.getBookList();

            Assert.IsNotNull(bookList);
        }

        [TestCase(2, false)]
        public void CheckOutBookTest_false(int id, bool initialStatus)
        {

            // Arrange
            _librarian = new Librarian();
            _bookRepo = new BookRepo();

            var testBook = _bookRepo.GetBookById(id);
            testBook.status = initialStatus;

            // Act
            _librarian.CheckOutBook(testBook);

            var resultBook = _bookRepo.GetBookById(id);

            // Assert
            Assert.AreNotEqual(initialStatus, resultBook.status);
            Assert.AreEqual(DateTime.Today, resultBook.checkedOutDateDate);
            Assert.AreEqual(DateTime.Today.AddDays(14), resultBook.dueDate);
        }

        [TestCase(2, true)]
        public void CheckOutBookTest_true(int id, bool initialStatus)
        {

            // Arrange
            _librarian = new Librarian();
            _bookRepo = new BookRepo();

            var testBook = _bookRepo.GetBookById(id);
            testBook.status = initialStatus;

            // Act
            _librarian.CheckOutBook(testBook);

            // Assert
            Assert.AreEqual(initialStatus, testBook.status);
            Assert.AreEqual(DateTime.Today, null);
            Assert.AreEqual(DateTime.Today.AddDays(14), null);
        }

        [TestCase("Douglas Adams")]
        public void BookSearch_ByAuthor(string criteria)
        {
            // Arrange
            _librarian = new Librarian();

            // Act
            var result = _librarian.BookSearch();
            var resultBook = result.First(r => r.author == criteria);

            // Assert
            Assert.AreEqual(resultBook.author, criteria);
        }

        [TestCase("The Ultimate Hitchhiker's Guide To The Galaxy")]
        public void BookSearch_ByTitle(string criteria)
        {
            // Arrange
            _librarian = new Librarian();

            // Act
            var result = _librarian.BookSearch();

            var resultBook = result.First(r => r.title == criteria);

            // Assert
            Assert.AreEqual(resultBook.title, criteria);
        }

    }
}