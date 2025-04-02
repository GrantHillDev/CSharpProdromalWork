using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany//if it hasn't already been mentioned in here; derived classes can inherit from as many interfaces as they want to -- yielding unparalelled customizability.
    {
        public bool carriesHeavyLoads { get; set; } = true;//Truck properties
        public bool canTow { get; set; } = true;
        public string model { get; set; } = "F250";//IVehicle properties
        public int year { get; set; } = 2014;
        public int numberOfWheels { get; set; } = 8;
        public int numberOfSeats { get; set; } = 6;
        public string typeOfFuel { get; set;} = "Bio Diesel";
        public int numberOfDoors { get; set; } = 4;
        public string companyName { get; set; } = "Ford";//ICompany properties
        public int numberOfYearsAsATopTen { get; set; } = 7;
        public string logo { get; set; } = "Ford Symbol";
        public string motto { get; set; } = "To do more for the world than the world does for you. That is success.";

        public void DisplayInformation()//ICompany stubbed out method.
        {
            Console.WriteLine($"The {companyName} corporation has allegedly spent {numberOfYearsAsATopTen} or more years as a top ten auto manufacturer, commercially displaying their {logo} and they go by the '{motto}' motto. Their {year} {model} {carriesHeavyLoads}ly does carry heavy loads, and it {canTow}ly can tow other lesser vehicles. It sports {numberOfWheels} different wheels, but it comes equipped with {numberOfSeats} total seats, accepts a {typeOfFuel} gasoline type, and it even comes with {numberOfDoors} doors.");
            Console.WriteLine();
        }

        public void Drive()//IVehicle stubbed out methods.
        {
            if(carriesHeavyLoads == true && canTow == true)
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
            if (carriesHeavyLoads == true)
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
