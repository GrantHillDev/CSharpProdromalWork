using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; }

        public override void DriveAbstract()//the other detail I noticed when having VS Community bring over any abstract marked methods written into the base class over to its inherited classes -- it automatically replaces the abstract keyword with the override keyword.
        {
            Console.WriteLine("The car is cruising at a high speed....");//throw new NotImplementedException();
        }

        //public void DriveVirtual()//public virtual void DriveVirtual()//keeping the virtual keyword for this method serves no purpose here, in the inherited class, and essentially is really just a placeholder for the override keyword to be written in its place.
        //{
        //Console.WriteLine("The car is cruising at a high speed....");//Now, we can alter the behavior of this previously virtual method created in the base class to whatever we want it to do for this inherited class.
        //}//as noticed here, not all members of an abstract class have to be marked as abstract members, but some can be if desired. It's also worth noting that derived classes inheriting from an abstract class don't necessarily have to be marked as abstract types either.

        //public override void Testing1()//so, as it turns out, this whole block of code can be called over/moved over with the click of a button -- here's how it works. First, and abstract method must be written within the abstract base class, and regardless of whether it's stubbed out or not as a method, you can still right click on the derived class (which is Car in this case) and select the quick actions and refactoring option, which will then offer you the choice of including missing abstract members, and the following block of code as shown here in this example is what's brought over, with you having to type any of it out.
        //{//it's also wroth mentioning that any derived class inheriting from a parent abstract class with any of its special members marked with the abstract keyword will have a red squiggly line underneath them, indicating that the inherited class itself is missing an otherwise required abstract class member from the parent abstract class that it's supposed to have. Of there's no abstract marked member written within the base abstract class, then no such error will appear, and no such option to move over such members will be available when right clicking on the inherited class.
        //throw new NotImplementedException();
        //}
    }
}
