using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 9.2.2016
/// <summary>
/// Pet-class
/// </summary>

namespace T7
{
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Owner { get; set; }

        public Pet()
        {
        }

        public Pet(string name, int age, string breed, string owner)
        {
            Name = name;
            Age = age;
            Breed = breed;
            Owner = owner;
        }

        public virtual void PrintData()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Breed: {0}", Breed);
            Console.WriteLine("Owner: {0}", Owner);
        }
    }
}
