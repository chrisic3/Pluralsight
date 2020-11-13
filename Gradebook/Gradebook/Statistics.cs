using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    public class Statistics
    {
        
        public double High;
        public double Low;
        public double Sum;
        public int Count;
        public double Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }

        public char Letter
        {
            get
            {
                switch (this.Average)
                {
                    case double a when a >= 90.0:
                        return 'A';

                    case double a when a >= 80.0:
                        return 'B';

                    case double a when a >= 70.0:
                        return 'C';

                    case double a when a >= 60.0:
                        return 'D';

                    default:
                        return 'F';
                }
            }
        }

        public Statistics()
        {
            this.High = double.MinValue;
            this.Low = double.MaxValue;
            this.Sum = 0.0;
            this.Count = 0;
        }

        public void Add(double grade)
        {
            this.Sum += grade;
            this.Count++;
            this.Low = Math.Min(grade, this.Low);
            this.High = Math.Max(grade, this.High);
        }
    }
}
