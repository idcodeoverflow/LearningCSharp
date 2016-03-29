using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCourseCSPractice3
{
    //TODO: Divide by the corresponding classes
    class Program
    {
        #region Get Information methods
        public static void GetStudentInformation()
        {
            string firstName;
            string lastName;
            DateTime birthdate;
            string addressLine1;
            string addressLine2;
            string city;
            string stateProvince;
            string zipCode;
            string country;

            Console.WriteLine("Enter the student's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            lastName = Console.ReadLine();
            enterDate:
            try
            {
                Console.WriteLine("Enter the student's birthdate: ");
                birthdate = ValidateDate(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                goto enterDate;
            }
            Console.WriteLine("Enter the student's address line 1: ");
            addressLine1 = Console.ReadLine();
            Console.WriteLine("Enter the student's address line 2: ");
            addressLine2 = Console.ReadLine();
            Console.WriteLine("Enter the student's city: ");
            city = Console.ReadLine();
            Console.WriteLine("Enter the student's province/state: ");
            stateProvince = Console.ReadLine();
            Console.WriteLine("Enter the student's zipcode: ");
            zipCode = Console.ReadLine();
            Console.WriteLine("Enter the student's country: ");
            country = Console.ReadLine();

            PrintStudentDetails(firstName, lastName, birthdate);
        }

        public static void GetTeacherInformation()
        {
            string firstNameTeacher;
            string lastNameTeacher;
            DateTime birthdateTeacher;
            string addressLine1Teacher;
            string addressLine2Teacher;
            string cityTeacher;
            string stateProvinceTeacher;
            string zipCodeTeacher;
            string countryTeacher;

            Console.WriteLine("Insert the teacher's first name: ");
            firstNameTeacher = Console.ReadLine();
            Console.WriteLine("Insert the teacher's last name: ");
            lastNameTeacher = Console.ReadLine();
            Console.WriteLine("Insert the teacher's birthdate: ");
            birthdateTeacher = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Insert the teacher's address line 1: ");
            addressLine1Teacher = Console.ReadLine();
            Console.WriteLine("Insert the teacher's address line 2: ");
            addressLine2Teacher = Console.ReadLine();
            Console.WriteLine("Insert the teacher's city: ");
            cityTeacher = Console.ReadLine();
            Console.WriteLine("Insert the teacher's state/province: ");
            stateProvinceTeacher = Console.ReadLine();
            Console.WriteLine("Insert the teacher's zip code: ");
            zipCodeTeacher = Console.ReadLine();
            Console.WriteLine("Insert the teacher's country: ");
            countryTeacher = Console.ReadLine();

            PrintTeacherDetails(firstNameTeacher, lastNameTeacher, birthdateTeacher);
        }

        public static void GetUProgramInformation()
        {
            Console.WriteLine("Insert the UProgram's Program Name: ");
            string programName = Console.ReadLine();
            Console.WriteLine("Insert the UProgram's Department Head: ");
            string departmentHead = Console.ReadLine();
            Console.WriteLine("Insert the UProgram's degrees: ");
            string degress = Console.ReadLine();//TODO: This should be a list of Degrees objects as while i'll use it as a string

            PrintUProgramDetails(programName, departmentHead, degress);
        }

        public static void GetDegreeInformation()
        {
            Console.WriteLine("Insert the degree's name: ");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Insert the degree's credits: ");
            int creditsRequired = Convert.ToInt32(Console.ReadLine());

            PrintDegreeInformation(degreeName, creditsRequired);
        }

        public static void GetCourseInformation()
        {
            Console.WriteLine("Insert the course's name: ");
            string courseName = Console.ReadLine();
            Console.WriteLine("Insert the course's credits: ");
            int credits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the course's duration weeks: ");
            int durationWeeks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the course's teacher: ");
            string teacher = Console.ReadLine();//TODO: create a Teacher object;

            PrintCourseInformation(courseName, durationWeeks, credits, teacher);
        }
        #endregion Get Information Methods

        #region Print Information Methods
        public static void PrintStudentDetails(string firstName = "", string lastName = "", 
            DateTime birthdate = new DateTime())
        {
            Console.WriteLine("Student's first name: {0}", firstName);
            Console.WriteLine("Student's last name: {0}", lastName);
            Console.WriteLine("Student's birthdate: {0}", birthdate.ToString());
        }

        public static void PrintTeacherDetails(string firstName = "", string lastName = "",
            DateTime birthdate = new DateTime())
        {
            Console.WriteLine("Teacher's first name: {0}", firstName);
            Console.WriteLine("Teacher's last name: {0}", lastName);
            Console.WriteLine("Teacher's birthdate: {0}", birthdate.ToString());
        }

        public static void PrintUProgramDetails(string programName = "", 
            string departmentHead = "", string degrees = "")
        {
            Console.WriteLine("UProgram's name: {0}", programName);
            Console.WriteLine("UProgram's department head: {0}", departmentHead);
            Console.WriteLine("UProgram's degrees: {0}", degrees);
        }

        public static void PrintDegreeInformation(string degreeName = "", 
            int creditsRequired = 0)
        {
            Console.WriteLine("Degrees' name: {0}", degreeName);
            Console.WriteLine("Degrees' department head: {0}", creditsRequired.ToString());
        }

        public static void PrintCourseInformation(string courseName = "", 
            int credits = 0, int durationWeeks = 0, string teacher = "")
        {
            Console.WriteLine("Course's name: {0}", courseName);
            Console.WriteLine("Course's credits: {0}", credits.ToString());
            Console.WriteLine("Course's duration weeks: {0}", durationWeeks.ToString());
            Console.WriteLine("Course's teacher: {0}", teacher);
        }
        #endregion Print Information Methods

        #region Validators
        public static bool ValidateDate(DateTime date)
        {
            throw new NotImplementedException("ValidateDate method is not implemented.");
        }

        public static DateTime ValidateDate(string dateStr)
        {
            try
            {
                return DateTime.Parse(dateStr);
            }
            catch (Exception e)
            {
                throw new FormatException("The date typed is wrong");
            }
        }
        #endregion Validators

        static void Main(string[] args)
        {
            GetStudentInformation();
            GetTeacherInformation();
            GetUProgramInformation();
            GetDegreeInformation();
            GetCourseInformation();
            
            //Test thrown exception in method not implemented
            ValidateDate(new DateTime());
        }
        
    }
}
