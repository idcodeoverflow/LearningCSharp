using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCourseTask2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsNumber = 8;
            int columnsNumber = 8;
            bool columnPair;
            
            for(int row = 0; row < rowsNumber; row++)
            {
                string toPrint = "";
                for(int column = 0; column < columnsNumber; column++)
                {
                    columnPair = Convert.ToBoolean(column % 2);
                    if(row % 2 != 0)
                    {
                        if (columnPair)
                        {
                            toPrint += "X";
                        }
                        else
                        {
                            toPrint += "O";
                        }
                    }
                    else
                    {
                        if (columnPair)
                        {
                            toPrint += "O";
                        }
                        else
                        {
                            toPrint += "X";
                        }
                    }
                }
                Console.WriteLine(toPrint);
            }
        }
    }
}
