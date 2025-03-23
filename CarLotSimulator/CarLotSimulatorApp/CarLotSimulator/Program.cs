using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var CarLotOne = new CarLot();//creating an instance of our newly defined CarLot class; initializing it here (similar to the manner in which we would declare and initialize a new variable)
            //TODO

            //Create a separate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //Now that the Car class is created we can instantiate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var carOne = new Car();//First scripted car manufacturing variation.
            carOne.Make = "Chevrolet";
            carOne.Model = "Malibu";
            carOne.Year = 2006;
            //carOne.EngineNoise = "Vroom";//not necessary per this object's own syntax -- it gets defined and called all at once through a custom crafted method.
            //carOne.HonkNoise = "Beep";//not necessary per this object's own syntax -- it gets defined and called all at once through a custom crafted method.
            carOne.IsDriveable = true;
            carOne.Mileage = 84142;
            carOne.AverageMilesPerGallon = 39.6134;

            Console.WriteLine($"Endtroducing the {carOne.Year} {carOne.Make} {carOne.Model}.");
            Console.WriteLine("");
            carOne.MakeEngineNoise("Vroom");
            carOne.MakeHonkNoise("Beep");
            Console.WriteLine("");

            CarLotOne.ParkingLot.Add(carOne);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car


            var carTwo = new Car()//Second scripted car manufacturing variation (Object initializer).
            {
                Make = "General Motors",
                Model = "H3 Hummer",
                Year = 2010,
                //EngineNoise = "REV",//not necessary per this object's own syntax -- it gets defined and called all at once through a custom crafted method.
                //HonkNoise = "Kaboom",//not necessary per this object's own syntax -- it gets defined and called all at once through a custom crafted method.
                IsDriveable = true,
                Mileage = 68453,
                AverageMilesPerGallon = 8.521
            };

            Console.WriteLine($"Endtroducing the {carTwo.Year} {carTwo.Make} {carTwo.Model}.");
            Console.WriteLine("");
            carTwo.MakeEngineNoise("REV");
            carTwo.MakeHonkNoise("Kaboom");
            Console.WriteLine("");

            CarLotOne.ParkingLot.Add(carTwo);

            var carThree = new Car("General Motors", "Escalade", 2012, "Whiz", "Bang", true, 47397, 13.6);//Third scripted car manufacturing variation (Custom constructor).
            //carThree.Make = "General Motors";
            //carThree.Model = "Escalade";
            //carThree.Year = 2012;
            //carThree.EngineNoise = "Whiz";
            //carThree.HonkNoise = "Bang";
            //carThree.IsDriveable = true;
            //carOne.Mileage = 47397;
            //carOne.AverageMilesPerGallon = 13.6;

            Console.WriteLine($"Endtroducing the {carThree.Year} {carThree.Make} {carThree.Model}.");
            Console.WriteLine("");
            carThree.MakeEngineNoise("Whiz");
            carThree.MakeHonkNoise("Bang");
            Console.WriteLine("");

            CarLotOne.ParkingLot.Add(carThree);

            var carFour = new Car("Honda", "Pilot", 2020, "Whoosh", "Honk", true, 19472, 24.762983561);//if all of these fields and properties (arguments here) aren't filled out to the standard set by the constructor of the class from which this object is based off of, then an error will be thrown suggesting that there aren't enough arguments being provided to the object to define it per its own blueprint.
            //carFour.Make = "Honda";
            //carFour.Model = "Pilot";
            //carFour.Year = 2020;
            //carFour.EngineNoise = "Whoosh";
            //carFour.HonkNoise = "Honk";
            //carFour.IsDriveable = true;
            //carFour.Mileage = 19472;
            //carFour.AverageMilesPerGallon = 24.762983561;

            Console.WriteLine($"Endtroducing the {carFour.Year} {carFour.Make} {carFour.Model}.");
            Console.WriteLine("");
            carFour.MakeEngineNoise("Whoosh");
            carFour.MakeHonkNoise("Honk");
            Console.WriteLine("");

            CarLotOne.ParkingLot.Add(carFour);

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instantiate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            CarLotOne.CheckCars();//This works well to efficiently list out all of my created vehicles because we used the .Add method extension at the end of our newly instantiated CarLotOne object, whilst using dot notation to ensure its newly defined list property was also being implemented (CarLotOne.ParkingLot.Add(carFour) as an example);.
        }
    }
}
