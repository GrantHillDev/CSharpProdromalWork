using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Placebo : IVehicle
    {
        public void Drive()//seems like I didn't need a constructor of this class.
        {
            Console.WriteLine("Hmm, well that was interesting.... you've successfully managed to cause the vehicle facility to produce a completely worthless non-functioning placebo.... a dubious achievement.");
            Console.WriteLine("");
        }
    }
}
