using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Course_Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region General values

            const string TYPE_REQUEST = "Enter the";
            const string FOR_STUDENT = "for the student";
            const string DATE_FORMAT = "YYYY/MM/DD";
            #endregion General values

            #region Values for the student

            string firstName = "";
            string lastName = "";
            DateTime birthDate = new DateTime();
            string bDateTemporalEntry = "";
            string addressLine1 = "";
            string addressLine2 = "";
            string city = "";
            string stateProvince = "";
            int zipCode = 0;
            string country = "";

            const string FIRST_NAME = "First name";
            const string LAST_NAME = "Last name";
            const string BIRTHDATE = "Birth date";
            const string ADDRESS = "Address";
            const string ADDRESS_L1 = "Address line 1";
            const string ADDRESS_L2 = "Address line 2";
            const string CITY = "City";
            const string STATE_PROVINCE = "State/province";
            const string ZIP_CODE = "Zip code";
            const string COUNTRY = "Country";
            #endregion Values for the student

            #region Read from console area

            Console.WriteLine("{0} {1} {2}: ", TYPE_REQUEST, FIRST_NAME, FOR_STUDENT);
            firstName = Console.ReadLine();
            Console.WriteLine("{0} {1} {2}: ", TYPE_REQUEST, LAST_NAME, FOR_STUDENT);
            lastName = Console.ReadLine();
            Console.WriteLine("{0} {1} {2} {3}: ", TYPE_REQUEST, BIRTHDATE, FOR_STUDENT, DATE_FORMAT);
            bDateTemporalEntry = Console.ReadLine();
            string[] date = bDateTemporalEntry.Split('/');
            int year = Int32.Parse(date[0]);
            int month = Int32.Parse(date[1]);
            int day = Int32.Parse(date[2]);
            birthDate = new DateTime(year, month, day);
            Console.WriteLine("{0} {1} {2}: ", TYPE_REQUEST, ADDRESS_L1, FOR_STUDENT);
            addressLine1 = Console.ReadLine();
            Console.WriteLine("{0} {1} {2}: ", TYPE_REQUEST, ADDRESS_L2, FOR_STUDENT);
            addressLine2 = Console.ReadLine();
            Console.WriteLine("{0} {1} {2}: ", TYPE_REQUEST, CITY, FOR_STUDENT);
            city = Console.ReadLine();
            Console.WriteLine("{0} {1} {2}: ", TYPE_REQUEST, STATE_PROVINCE, FOR_STUDENT);
            stateProvince = Console.ReadLine();
            Console.WriteLine("{0} {1} {2}: ", TYPE_REQUEST, ZIP_CODE, FOR_STUDENT);
            zipCode = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} {1} {2}: ", TYPE_REQUEST, COUNTRY, FOR_STUDENT);
            country = Console.ReadLine();

            #endregion Read from console area

            #region Print to console area

            Console.WriteLine("------------------Student information--------------------");
            Console.WriteLine("{0}: {1}", FIRST_NAME, firstName);
            Console.WriteLine("{0}: {1}", LAST_NAME, lastName);
            Console.WriteLine("{0}: {1}", BIRTHDATE, birthDate);
            Console.WriteLine("{0}: {1} {2}", ADDRESS, addressLine1, addressLine2);
            Console.WriteLine("{0}: {1}", CITY, city);
            Console.WriteLine("{0}: {1}", STATE_PROVINCE, stateProvince);
            Console.WriteLine("{0}: {1}", ZIP_CODE, zipCode);
            Console.WriteLine("{0}: {1}", COUNTRY, country);
            Console.WriteLine("---------------------------------------------------------");

            #endregion Print to console area
        }
    }
}
