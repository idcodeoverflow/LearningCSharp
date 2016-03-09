using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCourseLesson5Practice
{
    class Student : Person
    {
        private static int _studentCount = 0;

        public Stack Grades { get; set; }

        public int StudentCount {
            get 
            {
                return _studentCount;
            }
        }
        
        public Student()
        {
            _studentCount++;
            Grades = new Stack();
        }

        public Student(string firstName, string lastName, DateTime birthdate, 
            string addressLine1, string addressLine2, string city, string stateProvince, 
            int zipCode, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            StateProvince = stateProvince;
            ZipCode = zipCode;
            Country = country;
            Grades = new Stack();
        }
        
        public void DoTest()
        {
            throw new NotImplementedException("Need to implement DoTests Logic From Student class");
        }

    }
}
