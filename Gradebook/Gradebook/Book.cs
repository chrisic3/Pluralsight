using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    class Book
    {
        private string name;
        private List<double> grades;

        public Book(string name)
        {
            this.name = name;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        
        public void ShowStatistics()
        {
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