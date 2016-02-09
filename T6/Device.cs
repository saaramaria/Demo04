using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 9.2.2016
/// <summary>
/// Device-class
/// </summary>

namespace T6
{
    class Device
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string OperatingSystem { get; set; }
        public bool HasKeyboard { get; set; }

        public Device()
        {
        }

        public Device(string brand, string model, string operatingSystem, bool hasKeyboard)
        {
            Brand = brand;
            Model = model;
            OperatingSystem = operatingSystem;
            HasKeyboard = hasKeyboard;
        }

        public virtual void PrintData()
        {
            Console.WriteLine("Brand: {0}", Brand);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("OS: {0}", OperatingSystem);
            Console.WriteLine("Keyboard: {0}", HasKeyboard);
        }

    }
}
