using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ATV : IVehicle
    {
        public ATV() 
        {
           Console.WriteLine($"Building a new ATV!");
        }

        public int NumberOfWheels { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving my ATV over all the dirt!");
        }
    }
}
