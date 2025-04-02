namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int numOfWheels;//this just gives the input variable a strict means to ensure that its own output type is an integer utilizing the TryParse method.
            //int sumOfWheels;
            bool input = false;//we assume that user input is false by default, until it becomes something that's true, based upon the script we write for defining such below.
            //do
            //{
            //    Console.WriteLine("Today, it looks like we've been invited to an auto manufacturing facility, where they'll permit us to build different vehicles.... but first, got to select the number of wheels. ");
            //    Console.WriteLine();
            //    input = int.TryParse(Console.ReadLine(), out numOfWheels);
            //    Console.WriteLine();
            //} while (!input);//while input == false
            Console.WriteLine("Today, it looks like we've been invited to an auto manufacturing facility, where they'll permit us to build different vehicles.... but first, got to select the number of wheels. ");
            Console.WriteLine();//don't need a do while loop if we can just write out what we want the method to do to start....
            input = int.TryParse(Console.ReadLine(), out int numOfWheels);//here, we declare the value type ofr variable numOfWheels, and so any other usage of it no longer needs declaration. Redundancy.
            //numOfWheels = int.Parse(Console.ReadLine());
            while (input == false)//this works to validate whether or not the user's input is in the form of an integer. Else, the while loop forces them to keep trying with a valid response.
            {
                Console.WriteLine("It seems like your input wasn't acceptable.... by the facility -- did you ever think of trying a number?");
                Console.WriteLine();
                Console.WriteLine("input the number of wheels you'd like to see on an automotive.");
                Console.WriteLine();
                input = int.TryParse(Console.ReadLine(), out numOfWheels);//variable numOfWheels is a valid one, but it just needs to be implemented correctly in order for it to function.
                Console.WriteLine();
            }
            while (input == false || numOfWheels < 0 || numOfWheels > 5)//while (input == false)//man, I had to tinker with this one a bit just to get it right.... but it now does what I want it to.
            {//it just occurred to me that if I had written this while loop conditional with the && operand between numOfWheels < 1 numOfWheels < 2, then the while loop cannot operate; it cannot trigger because there's no physical or logical manner in which an integer could ever possibly be less than the value of 1 and greater than the value of 4.... math.
                Console.WriteLine("It seems like your input wasn't accepted by the facility -- they're limited with what automotives they can construct; try again.");
                Console.WriteLine();
                Console.WriteLine("input the number of wheels you'd like to see on an automotive.");
                Console.WriteLine();
                input = int.TryParse(Console.ReadLine(), out numOfWheels);
                Console.WriteLine();
                //Console.WriteLine();
                //if (numOfWheels != 1 || numOfWheels != 2 || numOfWheels != 3 || numOfWheels != 4)//now looking back on this line of code, it dawned on me that I could have written it more efficiently by way of describing a range of intergers, like if numOfwheels < 1 || numOfwheels > 4.
                //{
                //Console.WriteLine("it seems like your input wasn't accepted by the facility -- try again.");
                //Console.WriteLine();
                //Console.WriteLine("input the number of wheels you'd like to see on an automotive.");
                //Console.WriteLine();
                //}
            }
            //while (input == true && numOfWheels < 1 || numOfWheels > 4)//this one doesn't have the right filtration -- had to change the condition of input to false, and reading it now, it makes more logical sense to write it that way, because that while loop up above handles a wide variety of possible exceptions with ease.
            //{
            //    Console.WriteLine("It seems like your input wasn't acceptable.... by the facility -- did you ever think of trying a number?");
            //    Console.WriteLine();
            //    Console.WriteLine("input the number of wheels you'd like to see on an automotive.");
            //    Console.WriteLine();
            //    input = int.TryParse(Console.ReadLine(), out numOfWheels);//variable numOfWheels is a valid one, but it just needs to be implemented correctly in order for it to function.
            //    Console.WriteLine();
            //}
            Console.WriteLine();
            var vehicle = VehicleFactory.GetVehicle(numOfWheels);//this will look for a constructor; an instance of each derived class that inherits from the interface IVehicle, based upon whatever the value stored within the variable numOfWheels is -- this is why we needed to write out all of those blank constructors for each derived class.
            vehicle.Drive();
        }
    }
}
