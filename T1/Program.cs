using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();

            Console.WriteLine("You are in Dynamo's elevator.");
            Console.WriteLine("Exit the elevator by typing exit.");

            int floor;
            bool result;
            string line;
            
            while (true)
            {
                Console.WriteLine();
                Console.Write("Give a new floor number (1-5) > ");
                line = Console.ReadLine();
                result = int.TryParse(line, out floor);

                if (result)
                {
                    elevator.Floor = floor;
                    Console.WriteLine("Elevator is now in floor: " + elevator.Floor);
                }
                else if (line.ToLower() == "exit")
                {
                    Console.WriteLine("Bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("You didn't give a number!");
                    Console.WriteLine("Elevator is now in floor: " + elevator.Floor);
                }
            }
        }
    }
}
