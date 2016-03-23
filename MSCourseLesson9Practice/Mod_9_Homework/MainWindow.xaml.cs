using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();
        private int studentIndex = -1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            #region Create and add the student to the collection
            Student student = new Student();
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.City = txtCity.Text;
            #endregion Create and add the student to the collection
            #region Clear XAML fields
            students.Add(student);
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            #endregion Clear XAML fields
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            //Skip null pointer exception
            if (students != null)
            {
                //Skip an overflow
                if (studentIndex - 1 >= 0)
                {
                    studentIndex--;
                }
                else if(studentIndex - 1 <= 0 && students.Count != 0)
                {
                    //Restart index
                    studentIndex = students.Count - 1;
                }
                else
                {
                    return;
                }
                Student student = students.ElementAt(studentIndex);
                updateStudentsFields(student);
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            //Skip null pointer exception
            if (students != null)
            {
                //Skip an overflow
                if (studentIndex + 1 < students.Count)
                {
                    studentIndex++;
                }
                else if (studentIndex + 1 >= students.Count && students.Count > 0)
                {
                    //Restart index
                    studentIndex = 0;
                }
                else
                {
                    return;
                }
                Student student = students.ElementAt(studentIndex);
                updateStudentsFields(student);
            }
        }

        private void updateStudentsFields(Student student)
        {
            if (student != null)
            {
                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtCity.Text = student.City;
            }
        }
    }
}
