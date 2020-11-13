using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    public interface IBook
    {
        string Name { get; }
        void AddGrade(double grade);
        Statistics GetStatistics();
        event GradeAddedDelegate GradeAdded;
    }
}
