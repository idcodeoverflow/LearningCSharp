using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCourseLesson5Practice
{
    class Teacher : Person
    {
       
        public Teacher()
        {

        }

        public Teacher(string firstName, string lastName, DateTime birthdate,
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
        }

        public void GradeTests()
        {
            throw new NotImplementedException("Need to implement gradeTests Logic from Teachers class");
        }
    }
}
