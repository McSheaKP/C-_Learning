using System;
using Xunit;

namespace GradeBook.Tests
{
    
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        public int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetNameByRef(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        public void GetBookSetNameByRef(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }



        public void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Scott";
            name = MakeUpperCase(name);

            Assert.Equal("SCOTT", name);
        }

        private string MakeUpperCase(string name)
        {
            return name.ToUpper();
        }

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
