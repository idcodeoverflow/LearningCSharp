using System;
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
        public Teacher[] Teachers { get; set; }
        public Student[] Students { get; set; }

        public Course()
        {

        }

        public Course(string courseName, int credits, short durationWeeks, 
            Teacher[] teachers, Student[] students)
        {
            CourseName = courseName;
            Credits = credits;
            DurationWeeks = durationWeeks;
            Teachers = teachers;
            Students = students;
        }
    }
}
