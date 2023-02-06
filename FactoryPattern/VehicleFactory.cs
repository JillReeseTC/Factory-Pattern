using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfWheels)
        {

            switch (numberOfWheels)
            {
                case 2:
                    return new Motorcycle();
                case 3:
                    return new ATV();
                case 4:
                    return new Car();
                default:
                    Console.WriteLine($"You have a unique vehicle!");
                    return new Car();
            }
        }
    }
}