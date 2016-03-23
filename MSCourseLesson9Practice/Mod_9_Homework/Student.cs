using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
    class Student
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String City { get; set; }

        public Student()
        {
            this.FirstName = "";
            this.LastName = "";
            this.City = "";
        }

        public Student(String FirstName, String LastName, String City)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.City = City;
        }
    }
}
