using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Kevin's Grade book");

            book.AddGrade(78.1);
            book.AddGrade(89.1);
            book.AddGrade(77.5);
            book.ShowStatics();

        }
    }
}
