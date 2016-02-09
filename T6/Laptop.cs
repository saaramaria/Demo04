using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 9.2.2016
/// <summary>
/// Laptop-class
/// </summary>

namespace T6
{
    class Laptop : Device
    {
        public double RamMemory { get; set; }
        public string Processor { get; set; }

        public Laptop()
        {
        }

        public Laptop(string brand, string model, string operatingSystem, bool hasKeyboard, double ram, string processor)
            : base(brand,model,operatingSystem,hasKeyboard)
        {
            RamMemory = ram;
            Processor = processor;
        }

        public override void PrintData()
        {
           base.PrintData();
           Console.WriteLine("RAM: {0}", RamMemory);
           Console.WriteLine("Processor: {0}", Processor);
        }
    }
}
