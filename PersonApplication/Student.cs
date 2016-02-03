using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Student : Person
    {
        public string StudentID { get; set; }

        public Student()
        {
        }

        public Student(string firstname, string lastname, string address, string studentID)
            : base(firstname,lastname,address)
        {
            StudentID = studentID;
        }

        public void StudentMethod()
        {
            Console.WriteLine("Learning OOP!");
        }

        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }
    }
}
