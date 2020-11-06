﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    public class Book
    {
        public string Name;
        private List<double> grades;

        public Book(string name)
        {
            this.Name = name;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
        }
        
        public Statistics GetStatistics()
        {
            Statistics result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (double grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            switch(result.Average)
            {
                case double a when a >= 90.0:
                    result.Letter = 'A';
                    break;

                case double a when a >= 80.0:
                    result.Letter = 'B';
                    break;

                case double a when a >= 70.0:
                    result.Letter = 'C';
                    break;

                case double a when a >= 60.0:
                    result.Letter = 'D';
                    break;

                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }
    }
}