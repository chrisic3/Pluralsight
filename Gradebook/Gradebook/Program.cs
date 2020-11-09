using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("1st Gradebook");
            //book.AddGrade(89.1);
            //book.AddGrade(90.5);
            //book.AddGrade(77.5);

            do
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    double grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            } while (true);

            Statistics stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low:N1}");
            Console.WriteLine($"The highest grade is {stats.High:N1}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
