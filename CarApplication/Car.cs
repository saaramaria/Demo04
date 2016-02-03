using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        // field variables
        private readonly int maxSpeed = 200;
        private readonly double maxHeight = 4.5;

        private int speed;
        private double height;

        //property variables
        public double Height {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Too small, set to zero");
                    height = 0;
                }
                else if (value > maxHeight)
                {
                    Console.WriteLine("Too high, set to max");
                    height = maxHeight;
                }
            }

        }

        public int Speed {
            get
            {
                return speed;
            }
            set
            {
                if (value <= maxSpeed) speed = value;
                else
                {
                    Console.WriteLine("Too much speed, set to max");
                    speed = maxSpeed;
                }
            }
        }
    }
}
