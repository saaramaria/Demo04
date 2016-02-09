using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 9.2.2016
/// <summary>
/// Hamster-class
/// </summary>

namespace T7
{
    class Hamster : Pet
    {
        public string TerrariumSize { get; set; }
        public string Type { get; set; }

        public Hamster()
        {
        }

        public Hamster(string name, int age, string breed, string owner, string terrariumSize, string type)
            : base(name,age,breed,owner)
        {
            TerrariumSize = terrariumSize;
            Type = type;
        }

        public void FillCheeks()
        {
            Console.WriteLine("Hamster's cheeks are full of food!");
        }

        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine("Terrarium size: {0}", TerrariumSize);
            Console.WriteLine("Type: {0}", Type);
        }
    }
}
