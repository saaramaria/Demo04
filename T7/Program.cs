using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 9.2.2016
/// <summary>
/// T7 (OOP)
/// </summary>

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Tuutikki", 2, "Japanese Spitz", "Saara Virtanen", "Dino", 10);
            Console.WriteLine("Dog information:");
            dog.PrintData();
            dog.Bark();

            Console.WriteLine();

            Cat cat = new Cat("Kisu", 5, "Birman", "Kirsi Kernel", true);
            Console.WriteLine("Cat information:");
            cat.PrintData();
            cat.Meow();

            Console.WriteLine();

            Hamster hamster = new Hamster("Tarmo", 1, "Syrian hamster", "Matti Meikäläinen", "40 x 50 x 30 cm", "Long-haired cream roan");
            Console.WriteLine("Hamster information:");
            hamster.PrintData();
            hamster.FillCheeks();

            /*
            TULOSTAA:
            Dog information:
            Name: Tuutikki
            Age: 2
            Breed: Japanese Spitz
            Owner: Saara Virtanen
            Favourite toy: Dino
            Toy count: 10
            Woof!

            Cat information:
            Name: Kisu
            Age: 5
            Breed: Birman
            Owner: Kirsi Kernel
            Is furry: True
            Meow!

            Hamster information:
            Name: Tarmo
            Age: 1
            Breed: Syrian hamster
            Owner: Matti Meikäläinen
            Terrarium size: 40 x 50 x 30 cm
            Type: Long-haired cream roan
            Hamster's cheeks are full of food!
            */
        }
    }
}
