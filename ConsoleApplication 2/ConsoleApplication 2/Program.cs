using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_2
{
    class GradeBook
    {
        private string _courseName;//name for this GradeBook

        public string CourseName
        {
            get
            {
                return _courseName;
            }
            set
            {
                _courseName = value;
            }
        }//end CourseName

        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the GradeBook of {0}", CourseName);
        }

    }//end GradeBook

    class GradeBookTest
    {
        public static void Main(string[] args)
        {
            GradeBook myGradeBook = new GradeBook();

            Console.WriteLine("Gradebook name is: {0}", myGradeBook.CourseName);

            Console.WriteLine("Please enter the course name:");//text
            myGradeBook.CourseName = Console.ReadLine(); // set CourseName
            Console.WriteLine();

            myGradeBook.DisplayMessage();//display the message from the instance we created.
            Console.ReadLine();

        }
    }
}//end namespace
