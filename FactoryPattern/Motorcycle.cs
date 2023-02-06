using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle() 
        {
            Console.WriteLine($"Building a new motorcycle!");
        }

        public int NumberOfWheels { get; set; } 
        
        public void Drive()
        {
            Console.WriteLine($"Driving my motorcycle with the wind in my hair!");
        }

        

    }
}
