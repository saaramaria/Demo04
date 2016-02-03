using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Teacher : Person
    {
        public string Room { get; set; }

        public Teacher()
        {
        }

        public Teacher(string firstname, string lastname, string address, string room)
            : base(firstname,lastname,address)
        {
            Room = room;
        }

        public void TeacherMethod()
        {
            Console.WriteLine("Teaching OOP!");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Room;
        }

    }
}
