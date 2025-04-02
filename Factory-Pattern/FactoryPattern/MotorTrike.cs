using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class MotorTrike : IVehicle
    {
        //public int numberOfWheels { get; set; } = 3;

        public MotorTrike()
        {

        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUp();
            Console.WriteLine("Hey, so the motortrike is cruising down the street....");
            Console.WriteLine("");
        }
    }
}
