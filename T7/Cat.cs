using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 9.2.2016
/// <summary>
/// Cat-class
/// </summary>

namespace T7
{
    class Cat : Pet
    {
        public bool IsFurry { get; set; }

        public Cat()
        {
        }

        public Cat(string name, int age, string breed, string owner, bool isFurry)
            : base(name,age,breed,owner)
        {
            IsFurry = isFurry;
        }

        public void Meow()
        {
            Console.WriteLine("Meow!");
        }

        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine("Is furry: {0}", IsFurry);
        }
    }
}
