using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara Virtanen
/// @version 8.2.2016
/// <summary>
/// T5, using Radio-class
/// </summary>

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume;
            double frequency;

            Radio radio = new Radio();

            Console.Write("Turn the radio on by typing on > ");
            string turnon = Console.ReadLine();
            if (turnon == "on") radio.On();
            else Console.WriteLine("You didn't turn the radio on!");

            Console.Write("Set radio volume > ");
            string volumeset = Console.ReadLine();
            bool result = int.TryParse(volumeset, out volume);
            if (result) radio.Volume = volume;
            else Console.WriteLine("You didn't give a number!");
            
            Console.Write("Set radio frequency > ");
            string freqset = Console.ReadLine();
            bool result2 = double.TryParse(freqset, out frequency);
            if (result2) radio.Frequency = frequency;
            else Console.WriteLine("You didn't give a number!");

            radio.PrintData();

            /*
            TULOSTAA ESIM:
            Turn the radio on by typing on > on
            Radio is now on!
            Set radio volume > 3
            Set radio frequency > 100
            Frequency is too small, set to min

            Radio information:
            - Is on: True
            - Volume: 3
            - Frequency: 2000
            */
        }
    }
}
