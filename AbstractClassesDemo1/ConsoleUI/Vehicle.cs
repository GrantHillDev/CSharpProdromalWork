using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        //public string Make = "Brand";//while programed defaults weren't necessary here, the assignment called for such to be implemented anyway.
        //public string Model = "Shape";//these are written in as fields, not properties.
        //public int Year = 2000;//Abstract classes can have fields, but interfaces cannot.

        public string Make { get; set; } = "Brand";//while programed defaults weren't necessary here, the assignment called for such to be implemented anyway.
        public string Model { get; set; } = "Shape";//a string such as "default value" would have worked for all three of these properties as well.
        public string Year { get; set; } = "Year";

        //public abstract void Testing1();//Ah, now I see that if I don't code in an abstract stubbed out method within its base abstract class, that its subsequent derivative classes won't be required to have such members moved over to them.... but on the other hand, if they are written in here, then C# will expect you to also include them in any derived classes that inherit them from the base class which they're written in.

        //public abstract void Testing2()//Once again, abstractly marked methods cannot be instantiated within the base class, even if they aren't technically stubbed out method types.
        //{
        //Console.WriteLine("Derp.");
        //

        //public void DriveMethod()//an example of a stubbed out method (a method with an access modifier, return type, and its own signature that is intentionally left blank so that its functionality can be sculpted later on by its inherited classes which invoke it).
        //{//stubbed methods obviously have no implementation, and even if they did, there'd be no point to them being instantiated.
        //the main point of incorporating such a method type here is to ensure that whenever it gets called later on, that it's supposed to do something, and that behavior gets determined through any classes which inherit it and make use of it specifically.
        //}
        public abstract void DriveAbstract();//abstractly marked methods within a class cannot have curled brackets {} as they're not needed, but C# will throw an error at you if you attempt to write them in, even if the scope they govern contains nothing.

        public virtual void DriveVirtual()//looks like virtual method types can be coded with no defined body as well.
        {
            Console.WriteLine("Drive");//something which can be overridden by inherited classes from this base abstract class.
        }//could have even made a default string that read something like, 'default vehicle drive.'.
    }
}
