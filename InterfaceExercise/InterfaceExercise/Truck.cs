using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany//if it hasn't already been mentioned in here; derived classes can inherit from as many interfaces as they want to -- yielding unparalelled customizability.
    {
        public bool CarriesHeavyLoads { get; set; } = true;//Truck properties
        public bool CanTow { get; set; } = true;
        public string Model { get; set; } = "F250";//IVehicle properties
        public int Year { get; set; } = 2014;
        public int NumberOfWheels { get; set; } = 8;
        public int NumberOfSeats { get; set; } = 6;
        public string TypeOfFuel { get; set; } = "Bio Diesel";
        public int NumberOfDoors { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";//ICompany properties
        public int NumberOfYearsAsATopTen { get; set; } = 7;
        public string Logo { get; set; } = "Ford Symbol";
        public string Motto { get; set; } = "To do more for the world than the world does for you. That is success.";

        public void DisplayInformation()//ICompany stubbed out method.
        {
            Console.WriteLine($"The {CompanyName} corporation has allegedly spent {NumberOfYearsAsATopTen} or more years as a top ten auto manufacturer, commercially displaying their {Logo} and they go by the '{Motto}' motto. Their {Year} {Model} {CarriesHeavyLoads}ly does carry heavy loads, and it {CanTow}ly can tow other lesser vehicles. It sports {NumberOfWheels} different wheels, but it comes equipped with {NumberOfSeats} total seats, accepts a {TypeOfFuel} gasoline type, and it even comes with {NumberOfDoors} doors.");
            Console.WriteLine();
        }

        public void Drive()//IVehicle stubbed out methods.
        {
            if (CarriesHeavyLoads == true && CanTow == true)
            {
                Console.WriteLine($"The {GetType().Name} is now driving forwards, with a huge stack of bricks on its cargo bed.... and it's even towing a schmucky old prius behind it!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"The {GetType().Name} is now driving forwards.");
                Console.WriteLine();
            }
        }

        public void Park()
        {
            Console.WriteLine($"The {GetType().Name} has now been shifted into park.");
            Console.WriteLine();
        }

        public void Reverse()
        {
            if (CarriesHeavyLoads == true)
            {
                Console.WriteLine($"The {GetType().Name} is now driving in reverse, with a huge stack of bricks on its cargo bed....");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"The {GetType().Name} is now driving in reverse.");
                Console.WriteLine();
            }
        }
    }
}
