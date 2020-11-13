using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class InMemoryBook : Book
    {
        private List<double> grades;

        public InMemoryBook(string name) : base(name)
        {
            this.Name = name;
            grades = new List<double>();
        }

        public override void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }
        
        public override Statistics GetStatistics()
        {
            Statistics result = new Statistics();

            foreach (double grade in grades)
            {
                result.Add(grade);
            }

            return result;
        }


        public override event GradeAddedDelegate GradeAdded;
    }
}