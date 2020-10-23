using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using Xunit;

namespace Gradebook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            int x = GetInt();
            SetInt(x);

            Assert.Equal(3, x);
        }

        private int GetInt()
        {
            return 3;
        }

        private void SetInt(int x)
        {
            x = 42;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            Book book1 = GetBook("Book 1");
            Book book2 = GetBook("Book 2");

            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            Book book1 = GetBook("Book 1");
            Book book2 = book1;

            Assert.Same(book1, book2);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            Book book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            Book book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpCanPassByValue()
        {
            Book book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
