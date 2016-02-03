using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Speed = 30000000;
            car.Height = 5.5;
            Console.WriteLine("Speed is {0} and height is {1}", car.Speed, car.Height);
            car.Speed = 100;
            car.Height = -3.2;
            Console.WriteLine("Speed is {0} and height is {1}", car.Speed, car.Height);
        }
    }
}
