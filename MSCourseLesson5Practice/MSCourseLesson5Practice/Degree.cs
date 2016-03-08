using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCourseLesson5Practice
{
    class Degree
    {
        public string degreeName { get; set; }
        public int creditsRequired { get; set; }
        public Course course { get; set; }

        public Degree()
        {

        }

        public Degree(string degreeName, int creditsRequired, Course course)
        {
            this.degreeName = degreeName;
            this.creditsRequired = creditsRequired;
            this.course = course;
        }
    }
}
