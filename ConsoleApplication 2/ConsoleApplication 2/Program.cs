using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_2
{
    class GradeBook
    {
        //static void Main(string[] args)
        //{
        //    GradeBook myGradeBook = new GradeBook();
        //    myGradeBook.DisplayMessage("Niels");
        //}

        public void DisplayMessage(string courseName)
        {
            Console.WriteLine("Welcome to the Grade Book for {0}!", courseName);
            Console.ReadLine();
        }
    }

    class GradeBookTest
    {
        public static void Main(string[] args)
        {
            GradeBook myGradeBook = new GradeBook();

            Console.WriteLine("Please enter your gradebook name");
            string nameOfCourse = Console.ReadLine();
            Console.WriteLine();

            myGradeBook.DisplayMessage(nameOfCourse);
        }
    }
}
