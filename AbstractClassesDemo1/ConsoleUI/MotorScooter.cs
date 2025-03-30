using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class MotorScooter : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("The motor scooter is just barely dodging innocent pedestrians as it rolls along the sidewalk....");//if 'throw new NotImplementedException();' is left here, then not only will this method not execute at runtime, but neither will the inherited vehicle class's virtual method.
        }
    }
}
