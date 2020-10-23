using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("1st Gradebook");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            List<double> grades = new List<double>() { 3.2, 53.2 };

            double result = 0.0;
            double highGrade = double.MinValue;
            double lowGrade = double.MaxValue;
            foreach (double number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The lowest grade is {lowGrade:N1}");
            Console.WriteLine($"The highest grade is {highGrade:N1}");
            Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}
