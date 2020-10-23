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
    }
}