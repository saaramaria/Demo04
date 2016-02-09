using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 9.2.2016
/// <summary>
/// T6 (OOP)
/// </summary>

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("Asus", "X550C", "Windows 8", true, 8.0, "Intel Core i5-3337U 1.8GHz");
            Console.WriteLine("Laptop properties:");
            laptop.PrintData();

            Console.WriteLine("-----------------");

            Phone phone = new Phone("HTC", "One M7", "Android", false, "4.7 inch, Full HD 1080p", 143);
            Console.WriteLine("Phone properties:");
            phone.PrintData();

            /*
            TULOSTAA:
            Laptop properties:
            Brand: Asus
            Model: X550C
            OS: Windows 8
            Keyboard: True
            RAM: 8
            Processor: Intel Core i5-3337U 1.8GHz
            -----------------
            Phone properties:
            Brand: HTC
            Model: One M7
            OS: Android
            Keyboard: False
            Display: 4.7 inch, Full HD 1080p
            Weight (g): 143
            */
        }
    }
}
