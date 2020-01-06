using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);
            int numGrades = grades.Count;
            double total = 0;
            foreach( var grade in grades)
            {
                total = grade + total;
            }
            total /= numGrades;

            Console.Write($"My average grade is equal to {total}");
        }
    }
}
