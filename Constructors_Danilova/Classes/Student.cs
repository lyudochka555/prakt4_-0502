using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Constructors_Danilova.Classes
{
    public class Student
    {
        public string Firstname = "";
        public string Lastname = "";
        public string Surname = "";
        public bool Scholarship = false;

        public int Course = 4;

        public Student(string Firstname, string Lastname, string Surname)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Surname = Surname;

        }
        public Student(string Firstname, string Lastname, string Surname, bool Scholarship)
            : this(Firstname, Lastname, Surname)
        {
            this.Scholarship = Scholarship;
        }
        public Student(string Firstname, string Lastname, string Surname, bool Scholarship, int Course)
            : this(Firstname, Lastname, Surname, Scholarship) { 
            this. Course = Course;
        }
        public string GetFI0()
        {
            return $" {Lastname} {Firstname} {Surname}";
        }
    }
}