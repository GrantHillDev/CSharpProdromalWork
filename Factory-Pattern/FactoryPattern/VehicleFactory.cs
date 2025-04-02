using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory//there's never going to be an instance of this class -- it just does stuff.
    {
        public static IVehicle GetVehicle(int numberOfWheels)//returns something that conforms to IVehicle. If we left it as a void return type, then it wouldn't have to worry about all code paths returning a value.
        {
            //Console.WriteLine("Today, it looks like we've been invited to an auto manufacturing facility, where they'll permit us to build different vehicles.... but first, got to select the number of wheels. ");
            //Console.WriteLine("");//This was a good way to see just how non-instantiated this static class can be.... its functionality comes second to whatever is being prompted for in either its derived classes if it has any, or in programs that call for its functionality.
            if (numberOfWheels == 4)
            {
                return new Car();
            }
            else if (numberOfWheels == 3)
            {
                return new MotorTrike();
            }
            else if (numberOfWheels == 2)
            {
                return new Motorcycle();
            }
            else if (numberOfWheels == 1)
            {
                return new ElectricUnicycle();
            }
            else//based on how I wrote out the scripting for the program that's calling all of these classes within its main method, it would behoove me to create at least a couple of possibilities in which if a user were to enter in a value that wasn't equivalent to one of the four defined vehicle types of the derived classes....
            {
                //Console.WriteLine("It seems like your input wasn't accepted by the facility -- try again.");
                //Console.WriteLine("");
                return new Placebo();//remember, all code paths must return a value that conforms to IVehicle, so we can't just leave this statement without a return of such, or else the error will keep showing up.... even if it wouldn't necessarily make sense create a return of a vehicle type we customized for the interface itself. So, let's make a placebo in this case. Why not?
            }
        }
    }
}
