using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 9.2.2016
/// <summary>
/// Phone-class
/// </summary>

namespace T6
{
    class Phone : Device
    {
        public string Display { get; set; }
        public int Weight { get; set; }

        public Phone()
        {
        }

        public Phone(string brand, string model, string operatingSystem, bool hasKeyboard, string display, int weight)
            : base(brand,model,operatingSystem,hasKeyboard)
        {
            Display = display;
            Weight = weight;
        }

        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine("Display: {0}", Display);
            Console.WriteLine("Weight (g): {0}", Weight);
        }
    }
}
