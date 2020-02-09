using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string name;

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;            

            var highestGrade = double.MinValue;            
            var lowestGrade = double.MaxValue;

            foreach (var grade in grades)
            {
                lowestGrade = Math.Min(grade, lowestGrade);
                highestGrade = Math.Max(grade, highestGrade);
                result.Average += grade;
            }

            result.Average /= grades.Count;          

            return result;
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
