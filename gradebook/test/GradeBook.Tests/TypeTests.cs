using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void CanChangeNameBooks()
        {
            //arrange
            var book1 = GetBook("Book1");
            SetName(book1, "New Name");
            
            //assert
            Assert.Equal("New Name", book1.Name);        
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }


        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            //arrange
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");

            //act
            //assert
            Assert.Equal("Book1", book1.Name);
            Assert.Equal("Book2", book2.Name);

        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            //arrange
            var book1 = GetBook("Book1");
            var book2 = book1;

            //act
            //assert
            Assert.Equal("Book1", book1.Name);
            Assert.Equal("Book1", book2.Name);
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1,book2));

        }


        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
