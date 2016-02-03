using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Elevator
    {
        private readonly int maxFloor = 5;
        private readonly int minFloor = 1;

        private int floor;

        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value < minFloor)
                {
                    Console.WriteLine("Floor is too small!");
                }
                else if (value > maxFloor)
                {
                    Console.WriteLine("Floor is too big!");
                }
                else
                {
                    floor = value;
                }
            }
        }
    }
}
