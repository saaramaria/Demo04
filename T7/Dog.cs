using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 9.2.2016
/// <summary>
/// Dog-class
/// </summary>

namespace T7
{
    class Dog : Pet
    {
        public string FavouriteToy { get; set; }
        public int ToyCount { get; set; }

        public Dog()
        {
        }

        public Dog(string name, int age, string breed, string owner, string favtoy, int toycount)
            : base(name,age,breed,owner)
        {
            FavouriteToy = favtoy;
            ToyCount = toycount;
        }

        public void Bark()
        {
            Console.WriteLine("Woof!");
        }

        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine("Favourite toy: {0}", FavouriteToy);
            Console.WriteLine("Toy count: {0}", ToyCount);
        }
    }
}
