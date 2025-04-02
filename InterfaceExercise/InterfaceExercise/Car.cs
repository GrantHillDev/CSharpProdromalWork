using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany//we must bring over every single member created within each interface into any class that's inheriting from them -- the purpose of this is to ensure conformity to the interface.
    {
        public bool HasSunRoof { get; set; } = true;//Car properties
        public bool IsStickShift { get; set; } = false;
        public string Model { get; set; } = "CR-V";//IVehicle properties
        public int Year { get; set; } = 2009;
        public int NumberOfWheels { get; set; } = 4;
        public int NumberOfSeats { get; set; } = 5;
        public string TypeOfFuel { get; set; } = "87 Octane fuel";
        public int NumberOfDoors { get; set; } = 4;
        public string CompanyName { get; set; } = "Honda";//ICompany properties
        public int NumberOfYearsAsATopTen { get; set; } = 10;
        public string Logo { get; set; } = "Honda Symbol";
        public string Motto { get; set; } = "The Power of Dreams";

        public void DisplayInformation()//ICompany stubbed out method.
        {
            Console.WriteLine($"The {CompanyName} corporation has allegedly spent {NumberOfYearsAsATopTen} or more years as a top ten auto manufacturer, commercially displaying their {Logo} and they go by the '{Motto}' motto. Their {Year} {Model}'s sun roof {HasSunRoof}ly is awesome to open up and wave your hand through whilst driving down the highway in the summertime, and its non manual stick shift driving {IsStickShift}ly makes it a sweet ride to show off. It sports {NumberOfWheels} different wheels, but it comes equipped with {NumberOfSeats} total seats, accepts a {TypeOfFuel} gasoline type, and it even comes with {NumberOfDoors} doors.");
            Console.WriteLine();
        }

        //Console.WriteLine();

        public void Drive()//IVehicle stubbed out methods.
        {
            if (HasSunRoof == true && IsStickShift == false)
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
            if (HasSunRoof == true && IsStickShift == false)
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
