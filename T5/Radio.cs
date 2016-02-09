using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 8.2.2016
/// <summary>
/// Radio-class
/// </summary>

namespace T5
{
    class Radio
    {
        // properties
        public bool IsOn { get; set; }

        // field variables
        private readonly int maxVolume = 9;
        private readonly int minVolume = 0;
        private readonly double maxFrequency = 26000.0;
        private readonly double minFrequency = 2000.0;

        private int volume;
        private double frequency;

        //property variables
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < minVolume)
                {
                    volume = minVolume;
                    Console.WriteLine("Volume is too small, set to min");
                }
                else if (value > maxVolume)
                {
                    volume = maxVolume;
                    Console.WriteLine("Volume is too big, set to max");
                }
                else
                {
                    volume = value;
                }
            }
        }

        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (value < minFrequency)
                {
                    frequency = minFrequency;
                    Console.WriteLine("Frequency is too small, set to min");
                }
                else if (value > maxFrequency)
                {
                    frequency = maxFrequency;
                    Console.WriteLine("Frequency is too big, set to max");
                }
                else
                {
                    frequency = value;
                }
            }
        }

        public Radio()
        {
            IsOn = false;
        }

        //turn radio on
        public void On()
        {
            IsOn = true;
            Console.WriteLine("Radio is now on!");
        }

        //turn radio off
        public void Off()
        {
            IsOn = false;
            Console.WriteLine("Radio is now off!");
        }

        //print properties to console
        public void PrintData()
        {
            Console.WriteLine();
            Console.WriteLine("Radio information:");
            Console.WriteLine("- Is on: {0}", IsOn);
            Console.WriteLine("- Volume: {0}", Volume);
            Console.WriteLine("- Frequency: {0}", Frequency);
        }
    }
}
