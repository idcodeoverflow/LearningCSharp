using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCourseLesson5Practice
{
    class UProgram
    {
        public string ProgramName { get; set; }
        public string DepartmentHead { get; set; }
        public Degree Degree { get; set; }

        public UProgram()
        {
            
        }

        public UProgram(string programName, string departmentHead, Degree degree)
        {
            ProgramName = programName;
            DepartmentHead = departmentHead;
            Degree = degree;
        }
    }
}
