using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCourseLesson5Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Student[3];
            var teachers = new Teacher[3];

            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            students[0] = student1;
            students[1] = student2;
            students[2] = student3;

            Course course = new Course();
            course.CourseName = "Programming with C#";

            course.Students = students;

            Teacher teacher = new Teacher();
            teachers[0] = teacher;

            course.Teachers = teachers;

            Degree bachelor = new Degree();
            bachelor.degreeName = "Bachelor";

            bachelor.course = course;

            UProgram program = new UProgram();
            program.ProgramName = "Information Technology";
            program.Degree = bachelor;

            Console.WriteLine("{0} contains the degree of {1}", program.ProgramName, program.Degree.degreeName);
            Console.WriteLine();
            Console.WriteLine("{0} contains the course: {1}", bachelor.degreeName, bachelor.course.CourseName);
            Console.WriteLine();
            Console.WriteLine("{0} course have {1} students", course.CourseName, course.Students.Length);

        }
    }
}
