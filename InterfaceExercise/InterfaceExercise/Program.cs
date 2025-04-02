using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

            var carOne = new Car();
            var truckOne = new Truck();
            var suvOne = new SUV();

            Console.WriteLine("On display at our automotive show today, are three different vehicles.");
            Console.WriteLine();
            //Console.WriteLine($"");
            carOne.DisplayInformation();//rather than write the displayed information for each object here in the format of a Console.WriteLine, I thought I'd just go ahead utilize an interface class to write out a stubbed out method that would enable me to customize such inside of each derived class from the interface.
            Console.WriteLine("Wanna see it go?");
            carOne.Drive();
            Console.WriteLine("Perhaps put it in park?");
            carOne.Park();
            Console.WriteLine("What about in reverse?");
            carOne.Reverse();
            Console.WriteLine();
            //Console.WriteLine($"");
            truckOne.DisplayInformation();
            Console.WriteLine("Wanna see it go?");
            truckOne.Drive();
            Console.WriteLine("Perhaps put it in park?");
            truckOne.Park();
            Console.WriteLine("What about in reverse?");
            truckOne.Reverse();
            Console.WriteLine();
            //Console.WriteLine($"");
            suvOne.DisplayInformation();
            Console.WriteLine("Wanna see it go?");
            suvOne.Drive();
            Console.WriteLine("Perhaps put it in park?");
            suvOne.Park();
            Console.WriteLine("What about in reverse?");
            suvOne.Reverse();
            Console.WriteLine();
        }
    }
}
