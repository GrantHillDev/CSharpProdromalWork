using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        public int Mileage { get; set; }
        public double AverageMilesPerGallon { get; set; }
        //CarLot.numberOfCars++;//seems like this has to be called inside the constructor of a class, as opposed to within the class itself.
        public void MakeEngineNoise(string engineNoise)
        {
            EngineNoise = engineNoise;
            Console.WriteLine($"Now bringing forth the {Year} {Make} {Model}, which revs up with a {EngineNoise} when pressing on its accelerator. Is it drive-able? {IsDriveable}");
        }
        public void MakeHonkNoise(string honkNoise)
        {
            HonkNoise = honkNoise;
            Console.WriteLine($"The {Year} {Make} {Model} emits a {HonkNoise} when you're pissed off at another driver. Oh, and it comes with {Mileage} miles already on it, as well an estimated average of {AverageMilesPerGallon} miles per gallon.");
        }

        public Car()//is this what a constructor is?
        {
            //Purposefully left blank for the second scripted car manufacturing technique.... but I've noticed that having all three of these constructor formats pre-written before calling them as objects in the main program.cs (where they're being instantiated within the defaulted main method) provides for greater versatility in how each can be written, at least without running into as many thrown errors.... because VS Community understand what it is you're doing, as you've dictated within each of the constructs themselves (provided you abide by the formats you wrote for each of them).
            CarLot.numberOfCars++;//Taking the static field written into the CarLot class and calling it here as a sort of method extension from that class.//created an instance of the static field crafted for the CarLot class here because this is one of the Car class's established methods of building cars (via its own blueprint).
        }

        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDriveable, int mileage, double averageMilesPerGallon)//custom constructor.
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            Mileage = mileage;
            AverageMilesPerGallon = averageMilesPerGallon;
            CarLot.numberOfCars++;//created an instance of the static field crafted for the CarLot class here because this is one of the Car class's established methods of building cars (via its own blueprint).
        }

    }
}
