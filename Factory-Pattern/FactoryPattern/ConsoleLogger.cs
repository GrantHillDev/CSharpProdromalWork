using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ConsoleLogger
    {
        public static void VehicleStartUp()//so, why not just make this a part of the IVehicle interface? Particularly if it's going to be implemented through each derived vehicle class? I need more of a visualization to see how much memory a static method such as this is actually saving, versus just a stubbed out method, or a regularly typed method.
        {
            Console.WriteLine("Sounds like there was a click of the ignition....");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Oh, and there goes the engine!");
            Console.WriteLine();
            Thread.Sleep(1000);
        }
    }
}
