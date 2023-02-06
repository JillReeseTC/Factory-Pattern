using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car() 
        {
            Console.WriteLine($"Building a new car!");
            
        }
        public int NumberOfWheels { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving my car with the radio on!");
        }



    }
}
