using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class CarLot//so weird.... this VS Community had the audacity to tell me that my CarLot class wasn't making the newly defined list property type created down below 'accessible' enough when I gave the class a public access modifier. For some reason, VS Community prefers the interna; access modifier, which is actually less accessible than the public one.... very strange, VS Community.
    {
        public List<Car> ParkingLot { get; set; } = new List<Car>();//this is the new class's only defining property.

        public void CheckCars()//Here's a method written for the class to do something -- in this case, just listing out all of my crafted vehicles' year, make, and model.
        {
            foreach (var vehicle in ParkingLot)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
            }
        }

        public CarLot()
        {
            //purposefully left blank to make it into an open-ended constructor for the CarLot class.
        }

        public static int numberOfCars = 0;//static field for CarLot class. Starting at a number of cars equal to zero. This makes sense because the counter of cars created doesn't know how many cars it's going to count until after each instance of it has executed at runtime.
    }//cool thing I noticed here is that not all members of the an otherwise non-static class, such as CarLot, in this case, necessarily have to be marked or defined as static members, meaning that this offers increased control and flexibility within a given class's definition and blueprint.
}
