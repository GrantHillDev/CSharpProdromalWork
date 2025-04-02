using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany//we must bring over every single member created within each interface into any class that's inheriting from them -- the purpose of this is to ensure conformity to the interface.
    {
        public bool hasSunRoof { get; set; } = true;//Car properties
        public bool isStickShift { get; set; } = false;
        public string model { get; set; } = "CR-V";//IVehicle properties
        public int year { get; set; } = 2009;
        public int numberOfWheels { get; set; } = 4;
        public int numberOfSeats { get; set; } = 5;
        public string typeOfFuel { get; set; } = "87 Octane fuel";
        public int numberOfDoors { get; set; } = 4;
        public string companyName { get; set; } = "Honda";//ICompany properties
        public int numberOfYearsAsATopTen { get; set; } = 10;
        public string logo { get; set; } = "Honda Symbol";
        public string motto { get; set; } = "The Power of Dreams";

        public void DisplayInformation()//ICompany stubbed out method.
        {
            Console.WriteLine($"The {companyName} corporation has allegedly spent {numberOfYearsAsATopTen} or more years as a top ten auto manufacturer, commercially displaying their {logo} and they go by the '{motto}' motto. Their {year} {model}'s sun roof {hasSunRoof}ly is awesome to open up and wave your hand through whilst driving down the highway in the summertime, and its non manual stick shift driving {isStickShift}ly makes it a sweet ride to show off. It sports {numberOfWheels} different wheels, but it comes equipped with {numberOfSeats} total seats, accepts a {typeOfFuel} gasoline type, and it even comes with {numberOfDoors} doors.");
            Console.WriteLine();
        }

        //Console.WriteLine();

        public void Drive()//IVehicle stubbed out methods.
        {
            if (hasSunRoof == true && isStickShift == false)
            {
                Console.WriteLine($"The {GetType().Name} is now driving forward, with its sun roof wide open.... too bad it doesn't have a stick shift.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"The {GetType().Name} is now driving forward.");//GetType is a predefined method that still needs the () parentheses marked right by it, despite utilizing dot notation.... though I've noticed that this sort of syntax isn;t necessarily required when its an instance of class calling such method using the same sort of dot notation (like CarOne.Name as an example).
                Console.WriteLine();
            }
        }

        public void Park()
        {
            Console.WriteLine($"The {GetType().Name} is now set in park.");//GetType is also referred to what's known as a filter method. Updated; I take that back -- we're not on LINQ system functionality yet with this project.
            Console.WriteLine();
        }

        public void Reverse()
        {
            if (hasSunRoof == true && isStickShift == false)
            {
                Console.WriteLine($"The {GetType().Name} is now reversing, with its sun roof wide open.... too bad it doesn't have a stick shift.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"The {GetType().Name} is now reversing.");
                Console.WriteLine();
            }
        }
    }
}
