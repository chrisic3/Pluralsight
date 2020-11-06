using System;
using Xunit;

namespace Gradebook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // Arrange
            Book book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // Act
            Statistics result = book.GetStatistics();

            // Assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter);
        }

        [Fact]
        public void BookAddInvalidGrade()
        {
            // Arrange
            Book book = new Book("");
            book.AddGrade(100);

            // Act
            book.AddGrade(105);
            Statistics results = book.GetStatistics();

            // Assert
            Assert.Equal(100, results.High);
        }
    }
}
