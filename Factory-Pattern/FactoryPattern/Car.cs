using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        //public int numberOfWheels { get; set; } = 4;//remember, this isn't a field, but a property -- get; set;//public int numberOfWheels = 4.
        public Car()
        {

        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUp();
            Console.WriteLine("Alright, so the car is now currently driving....");
            Console.WriteLine("");
        }
    }
}
