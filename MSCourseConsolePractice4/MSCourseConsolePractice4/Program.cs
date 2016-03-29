using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCourseConsolePractice4
{
    class Program
    {
        #region Structs declaration
        public struct Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime Birthdate { get; set; }
            public string AddressLine1 { get; set; }
            public string AddressLine2 { get; set; }
            public string City { get; set; }
            public string StateProvince { get; set; }
            public int ZipCode { get; set; }
            public string Country { get; set; }
        }

        public struct Teacher
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime Birthdate { get; set; }
            public string AddressLine1 { get; set; }
            public string AddressLine2 { get; set; }
            public string City { get; set; }
            public string StateProvince { get; set; }
            public int ZipCode { get; set; }
            public string Country { get; set; }
        }

        public struct UProgram
        {
            public string ProgramName { get; set; }
            public string DepartmentHead { get; set; }
            public string Degrees { get; set; }
        }

        public struct Course
        {
            public string CourseName { get; set; }
            public int Credits { get; set; }
            public short DurationWeeks { get; set; }
            public Teacher Teacher { get; set; }
        }

        #endregion Structs declaration

        static void Main(string[] args)
        {
            Student[] Students = new Student[5];

            #region Student values assignment 
            Students[0].FirstName = "Miguel";
            Students[0].LastName = "Martinez";
            Students[0].Birthdate = Convert.ToDateTime("12/10/1991");
            Students[0].AddressLine1 = "Street Miguel de la Madrid #313";
            Students[0].AddressLine2 = "San Jose";
            Students[0].City = "Guadalajara";
            Students[0].StateProvince = "Guadalajara";
            Students[0].ZipCode = 21291;
            Students[0].Country = "Mexico";
            #endregion Student values assignment 

            #region Print student information
            Console.WriteLine("Student's first name: {0}", Students[0].FirstName);
            Console.WriteLine("Student's last name: {0}", Students[0].LastName);
            Console.WriteLine("Student's birthdate: {0}", Students[0].Birthdate);
            Console.WriteLine("Student's address: {0} {1}", Students[0].AddressLine1, Students[0].AddressLine2);
            Console.WriteLine("Student's city: {0}", Students[0].City);
            Console.WriteLine("Student's state/province: {0}", Students[0].StateProvince);
            Console.WriteLine("Student's zip code: {0}", Students[0].ZipCode);
            Console.WriteLine("Student's country: {0}", Students[0].Country);
            #endregion Print student information
        }
    }
}
