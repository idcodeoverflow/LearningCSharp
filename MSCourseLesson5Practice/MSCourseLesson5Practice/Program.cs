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
            Student student1 = new Student("Carlos", "Martinez", new DateTime(), 
                "street 1 #105", "", "Jalisco", "Guadalajara", 30333, "Mexico");
            Student student2 = new Student("Miguel", "Torres", new DateTime(),
                "street 2 #104", "", "Guerrero", "Morelia", 30335, "Mexico");
            Student student3 = new Student("Fernando", "Lopez", new DateTime(),
                "street 3 #106", "", "Guanajuato", "Celaya", 30338, "Mexico");

            student1.Grades.Push(100);
            student1.Grades.Push(90);
            student1.Grades.Push(80);
            student1.Grades.Push(70);
            student1.Grades.Push(60);

            student2.Grades.Push(100);
            student2.Grades.Push(90);
            student2.Grades.Push(80);
            student2.Grades.Push(70);
            student2.Grades.Push(60);

            student3.Grades.Push(100);
            student3.Grades.Push(90);
            student3.Grades.Push(80);
            student3.Grades.Push(70);
            student3.Grades.Push(60);

            Course course = new Course();
            course.CourseName = "Programming with C#";

            course.Students.Add(student1);
            course.Students.Add(student2);
            course.Students.Add(student3);

            Teacher teacher = new Teacher();
            
            course.Teachers.Add(teacher);

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
            Console.WriteLine("{0} course have {1} students", course.CourseName, course.Students.Count);
            Console.WriteLine();

            course.ListStudents();
        }
    }
}
