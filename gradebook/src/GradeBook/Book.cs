using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        private List<double> grades;
        private string name;

        public void ShowStatics()
        {
            var highestGrade = double.MinValue;
            var result = 0.0;
            var lowestGrade = double.MaxValue;
            foreach (var number in grades)
            {
                lowestGrade = Math.Min(number, lowestGrade);
                highestGrade = Math.Max(number, highestGrade);
                result += number;
            }
            result /= grades.Count;
            Console.Write($"The lowest grade is equal to {lowestGrade }");
            Console.Write($"The lowest grade is equal to {highestGrade }");
            Console.Write($"My average grade is equal to {result: N1}");
        }

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}
