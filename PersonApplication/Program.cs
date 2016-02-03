using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Kirsi","Kernel","Piippukatu 2","K1698");
            Console.WriteLine("Student = " + student.ToString());

            Teacher teacher = new Teacher("Pasi", "Manninen", "Piippukatu 2", "D426");
            Console.WriteLine("Teacher = " + teacher.ToString());
        }
    }
}
