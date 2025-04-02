using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        //public int numberOfWheels { get; set; } = 2;

        public Motorcycle()
        {

        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUp();
            Console.WriteLine("Whoa, now this motorcycle is revving up....");
            Console.WriteLine("");
        }
    }
}
