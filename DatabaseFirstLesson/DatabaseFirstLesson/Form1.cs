using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseFirstLesson
{
    public partial class Form1 : Form
    {
        private WindesheimEntities1 _db = new WindesheimEntities1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (Cours course in _db.Courses)
            {
                lbCourses.Items.Add(course.Title);
            }

            //Dictionary<int, string> items = new Dictionary<int, string>();

            //foreach(Teacher teacher in _db.Teachers)
            //{
            //    items.Add(teacher.ID, teacher.FirstName + " " + teacher.LastName);
            //}

            //cbTeachers.DataSource = new BindingSource(items, null)

        }

        private void lbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourse = (string)lbCourses.SelectedItem;

            var courses = from course in _db.Courses
                          where course.Title == selectedCourse
                          select course;

            Cours selectedCourseObject = courses.First();

            if(selectedCourseObject.Teacher != null)
            {
            tbTeacher.Text = selectedCourseObject.Teacher.FirstName + " " +
                             selectedCourseObject.Teacher.LastName;
            }

            foreach (Student student in selectedCourseObject.Students)
            {
                lbStudents.Text = student.FirstName + " " +
                                  student.LastName;
            }
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tbTeacher_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            Cours newCourse = new Cours();



            newCourse.Title = AddCourse.Text;

            _db.Courses.Add(newCourse);
            _db.SaveChanges();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string search = searchText.Text;

            var students = from student in _db.Students
                           where student.FirstName.Contains(search) ||
                                 student.LastName.Contains(search)
                           select student;

            string outputText = "";

            if(!students.Any())
            {
                outputText = "No students found..";
            } else {
                foreach (Student student in students)
                {
                    outputText += "Student: \n";
                    outputText += "Name: " + student.FirstName + " " + student.LastName + "\n";
                    outputText += "DoB: " + student.DateOfBirth.ToString() + "\n\n\n";
                }
            }

            MessageBox.Show(outputText);
        }
    }
}
