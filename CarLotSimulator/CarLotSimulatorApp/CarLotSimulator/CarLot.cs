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

        public void CheckCars()//Here's a method written for the class to do something -- in this case,just listing out all of my crafted vehicles' year, make, and model.
        {
            foreach (var vehicle in ParkingLot)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
            }
        }
    }
}
