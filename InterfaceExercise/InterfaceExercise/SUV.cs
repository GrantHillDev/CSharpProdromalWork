using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool IsAllWheelDrive { get; set; } = true;//SUV properties//we can display the functionality of this property without ever having to print its value to the console.... we can achieve this via writing out a method that implements it as such (see below).
        public bool HasAdaptiveCruiseControl { get; set; } = true;
        public string Model { get; set; } = "Optiq";//IVehicle properties
        public int Year { get; set; } = 2025;
        public int NumberOfWheels { get; set; } = 4;
        public int NumberOfSeats { get; set; } = 7;
        public string TypeOfFuel { get; set; } = "89 Octane fuel";
        public int NumberOfDoors { get; set; } = 4;
        public string CompanyName { get; set; } = "Cadillac";//ICompany properties
        public int NumberOfYearsAsATopTen { get; set; } = 1;
        public string Logo { get; set; } = "Cadillac Symbol";
        public string Motto { get; set; } = "People in motion";

        public void DisplayInformation()//ICompany stubbed out method.
        {
            Console.WriteLine($"The {CompanyName} corporation has allegedly spent {NumberOfYearsAsATopTen} or more years as a top ten auto manufacturer, commercially displaying their {Logo} and they go by the '{Motto}' motto. Their {Year} {Model} {IsAllWheelDrive}ly does feature an all-wheel drive functionality, and it {HasAdaptiveCruiseControl}ly has its own adaptive cruise control. It sports {NumberOfWheels} different wheels, but it comes equipped with {NumberOfSeats} total seats, accepts a {TypeOfFuel} gasoline type, and it even comes with {NumberOfDoors} doors.");
            Console.WriteLine();
            //Console.WriteLine($"Currently, this {year}{companyName}{model} ");
        }

        public void Drive()//IVehicle stubbed out methods.
        {
            if (IsAllWheelDrive == true && HasAdaptiveCruiseControl == true)
            {
                Console.WriteLine($"The {GetType().Name} is now driving straight ahead, implementing a nifty adaptive cruise control feature, using all four of its wheels.");//here's one way of how we can provide an already defined method with even more functionality (per my note above).
                Console.WriteLine();
            }
            //if (hasAdaptiveCruiseControl == true)
            //{
            //
            //}
            else//learned that if the else statement isn't expressed here, then the script initiated by the if statement just continues to loop into whatever else is written inside of the method, beyond the if statement itself, unless an else if or else statement is explicitly typed in here with the remainder of what was written into this method as part of its scope, in which case, it will no longer execute, as the conditions of the else statement are never met in this instance.
            {
                Console.WriteLine($"The {GetType().Name} is now driving straight ahead, using only two of its wheels.");
                Console.WriteLine();
            }
        }

        public void Park()
        {
            Console.WriteLine($"The {GetType().Name} has had its gear shifted into park.");
            Console.WriteLine();
        }

        public void Reverse()
        {
            if (IsAllWheelDrive == true && HasAdaptiveCruiseControl == true)//adaptive cruise control probably doesn't retain as much validity when being applied to a vehicle going in reverse scenario.... but why not.
            {
                Console.WriteLine($"The {GetType().Name} has been shifted into reverse, using all four of its wheels.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"The {GetType().Name} has been shifted into reverse, implementing a nifty adaptive cruise control feature, using only two of its wheels.");
                Console.WriteLine();
            }
        }
    }
}
