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
            InMemoryBook book1 = GetBook("Book 1");
            InMemoryBook book2 = GetBook("Book 2");

            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            InMemoryBook book1 = GetBook("Book 1");
            InMemoryBook book2 = book1;

            Assert.Same(book1, book2);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            InMemoryBook book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            InMemoryBook book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [Fact]
        public void CSharpCanPassByValue()
        {
            InMemoryBook book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        private InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
