using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var vehiclesList = new List<Vehicle>();//made a new list titled vehiclesList of class type Vehicle.

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constructors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            var carOne = new Car() { HasTrunk = true, Make = "Honda", Model = "HR-V", Year = "2017" };//var carOne = new Car();//instructions were to instantiate these objects in the format of object initializer syntax.
            var motorCycleOne = new Motorcycle() { HasSideCar = true, Make = "Harley Davidson", Model = "Sportster", Year = "2016" };//this still runs without the parentheses written in at the end var motorCycleOne = new Motorcycle instead of var motorCycleOne = new Motorcycle().
            //var VehicleOne = new Vehicle();//Remember, we cannot create an instance of a base abstract class.
            var vehicleOne = new Car() { Make = "Mitsubishi", Model = "Galant", Year = "2009" };//used a constructor written within the car class.
            var vehicleTwo = new Motorcycle() { Make = "Yamaha", Model = "MT-07", Year = "2021" };//used a constructor written within the Motorcycle class.
            var vehicleThree = new MotorScooter() { Make = "EMOVE", Model = "Cruiser S 52V Dual Suspension", Year = "2024" };//wow, this new instance of the vehicle class worked via instantiating it through the MotorScooter class when it had literally nothing written within its scope.... it had only inherited from the vehicle base abstract class.

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            vehiclesList.Add(carOne);
            vehiclesList.Add(motorCycleOne);
            vehiclesList.Add(vehicleOne);
            vehiclesList.Add(vehicleTwo);//vehiclesList now contains indexes of each vehicle defined.
            vehiclesList.Add(vehicleThree);

            //for (int i = 0; i < vehiclesList.Count; i++)//lol, I quickly realized that a foreach loop was asked for -- not a for loop.
            //{
            //    vehiclesList.Add(vehicleOne);
            //}

            Console.WriteLine("Now bringing to you our hottest line up of recently donated vehicles -- we'll tell you all about them.");

            foreach (var vehicle in vehiclesList)
            {
                Console.WriteLine();
                Console.WriteLine($"The {vehicle.Year} {vehicle.Make} {vehicle.Model}."); //Does it come with a trunk? {vehicle.HasTrunk}");//this is not included in the vehicle class as a property.
                Console.WriteLine();
                vehicle.DriveAbstract();
                Console.WriteLine();
                vehicle.DriveVirtual();
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle

            Console.WriteLine("These vehicles actually did have some added features we wanted to ensure were made mention of to you.");
            Console.WriteLine();
            Console.WriteLine($"Does the {carOne.Year} {carOne.Make} {carOne.Model} have its own trunk? {carOne.HasTrunk}.");
            Console.WriteLine();
            Console.WriteLine($"Does the {motorCycleOne.Year} {motorCycleOne.Make} {motorCycleOne.Model} have its own side car? {motorCycleOne.HasSideCar}.");

            //var carList = new List<Car>();//has to be a list of type Car (class) -- a class that;'s alreayd been defined.

            //foreach (var car in carList)//decided I'd write out lists to do the printing to the console work, instead of just doing mutliple Console.WriteLines.
            //{
            //    Console.WriteLine($"Does the {carOne.Year} {carOne.Make} {carOne.Model} have its own trunk? {carOne.HasTrunk}.");
            //    Console.WriteLine();
            //}

            //var motorCycleList = new List<Motorcycle>();

            //foreach (var motorcycle in motorCycleList)
            //{
            //    Console.WriteLine($"Does the {carOne.Year} {carOne.Make} {carOne.Model} have its own trunk? {carOne.HasTrunk}.");
            //    Console.WriteLine();
            //}

            #endregion
            //Console.ReadLine();//don't know who wrote this here, but it's not needed.
        }
    }
}
