using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    public abstract class Book : NamedObject
    {
        public Book(string name) : base(name)
        {
        }

        public abstract void AddGrade(double grade);
    }
}
