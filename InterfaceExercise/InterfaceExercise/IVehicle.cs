using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle//C# now knows what kind class Vehicle is because it starts with a capital I (though technically, interface isn't necessarily a class). Updated; this is only partially correct -- C# needs to know that it's marked as an interface instead of a class, otherwise, it will continue thinking that it's a class.
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfSeats { get; set; }
        public string TypeOfFuel { get; set; }
        public int NumberOfDoors { get; set; }

        public void Drive();
        public void Park();//it's important to understand that this is how real methods are formed -- we don't always know exactly what it is that we are going to write out for them, and therefore build them as we go. This is actually very true with regard to my self-taught skills with programming and graphic design for my side projects, beyond this course, as well as sound manipulation.... I have a rough idea of what it is I want to do, and then I find a means to execute it, and can then refine such a solution for future instances either within the same side project, or others.
        public void Reverse();
    }
}
