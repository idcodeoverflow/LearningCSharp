using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCourseLesson5Practice
{
    class Course
    {
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public short DurationWeeks { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }

        public Course()
        {
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }

        public Course(string courseName, int credits, short durationWeeks,
            List<Teacher> teachers, List<Student> students)
        {
            CourseName = courseName;
            Credits = credits;
            DurationWeeks = durationWeeks;
            Teachers = teachers;
            Students = students;
        }

        public void ListStudents()
        {
            #region printing area for module 7
            Console.WriteLine("-----------------------------------------");
            foreach (Student element in Students)
            {
                Student student = element;
                Console.WriteLine("Student's first name: {0}", student.FirstName);
                Console.WriteLine("Student's last name: {0}", student.LastName);
                Console.WriteLine("-----------------------------------------");
            }
            #endregion printing area for module 7
        }
    }
}
