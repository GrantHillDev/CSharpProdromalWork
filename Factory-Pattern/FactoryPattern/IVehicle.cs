using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IVehicle//I noticed that for some reason, this program was throwing an error regarding building projects that targeted .net version that were 6.0 or below, and not above, and I did some digging around to locate the cause of the problem, which was embedded within the program's .csproj file (the selection below the program's solution file shown at the top of the solution explorer). Then, I altered the version of the .net version the program was targeting to a value that fit its spectrum, and problem solved. <TargetFramework>net6.0</TargetFramework>
    {
        //public int numberOfWheels { get; set; }//this unfortunately didn't end up being necessary for differentiating between what vehicle type was going to be built in the vehicle factory class.
        public void Drive();//this stubbed out method can exist in this format strictly because it's written inside of an interface, whereas if it were written within a class, it would at minimum have to feature its own scope or body.
    }
}
