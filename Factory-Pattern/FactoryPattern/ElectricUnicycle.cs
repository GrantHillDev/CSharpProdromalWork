using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ElectricUnicycle : IVehicle
    {
        //public int numberOfWheels { get; set; } = 1;

        public ElectricUnicycle()
        {

        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUp();//I suppose if we wrote out this method from this class, then we can just call it inside of another method within the derived class that's going to implement it, like in this instance.... rather than just writing out separate method for it in the same derived class, provided it was written out as a stubbed out method within the interface which such a derived class would be inheriting from.... seems relative to me.
            Console.WriteLine("Ha, check out that motorized unicycle making its way down the sidewalk....");
            Console.WriteLine("");
        }
    }
}
