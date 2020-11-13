using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Gradebook
{
    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override void AddGrade(double grade)
        {
            using (StreamWriter output = File.AppendText($"{this.Name}.txt"))
            {
                output.WriteLine(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }

        public override event GradeAddedDelegate GradeAdded;
    }
}
