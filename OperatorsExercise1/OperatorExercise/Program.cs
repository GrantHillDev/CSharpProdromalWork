namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //exercise 1
            Console.WriteLine("Welcome to the TC Operator Exercise.");
            Console.WriteLine("");
            Console.WriteLine("Here, we're defining different variables with stored integer values that will be called and used by other variables implementing the use of operators.");
            Console.WriteLine("");
            //Console.WriteLine($"{a}");//we cannot use the 'local' variable 'a' before it is declared -- thank you VS Community.
            int a = 22;//declaring and initializing new variables.
            int b = 14;

            int summation = a + b;//storing results of arithmetic based operations within new variables. Output should be 36.
            int subtraction = a - b;//output should be 8.
            int production = a * b;//output should be 308.
            int division = a / b;//output should be 1.something. This actually would be true if we weren't working within the context of integers, but decimals instead.
            int modulus = a % b;//output should be 8.

            Console.WriteLine($"Our a ({a}) variable + our b ({b}) variable would equal a value of {summation}, but if we subtract {a} from {b}, we'd get a value of {subtraction}..");//utilizing string interpolation to print yields to console.
            Console.WriteLine("");
            Console.WriteLine($"{a} multiplied by {b} would provide us with a product of {production}. {a} divided by {b} would give us a quotient of {division}.");//remember that integer based values will always round down, no matter what.
            Console.WriteLine("");
            Console.WriteLine($"{a} modulos'd by {b} first provides us with a quotient of {division}, but then leaves us with a remainder of {modulus}.");
            Console.WriteLine("");

            //exercise 2
            Console.WriteLine("In this next exercise we'll be calculating the area of a circle.");
            Console.WriteLine("");
            Console.WriteLine("Please provide a number for us to start with.");//.Parse always requires a type specified before its period to specify what data type its converting user input into.
            double radius = double.Parse(Console.ReadLine());//taking the user's input and converting it into a double value type (for more accuracy). double.Parse combined with Console.ReadLine function eliminates the possibility of errors caused by user input types.
            Console.WriteLine("");
            Console.WriteLine($"Great, we'll use your number of {radius} as a starting point for which we can then calculate the area of a circle.");
            Console.WriteLine("");
            Console.WriteLine($"The area of a circle with a radius of {radius} will be {AreaOfCircle(radius)}");//if you forget to type in the (radius) portion for this method when it's called, it won't know what value it's using to conduct its operation, but VS Community won't give you any errors.
            //exercise bonus
            //int i = 3;
            //int j = 4;
            //int k = ++i * j++;

            //Console.WriteLine(k); // What will this output?
            //This will output a value of 16, because presumably; the value of j isn't incremented yet, though the value of i already is, so it would be the result of 4 * 4.
        }

        static double AreaOfCircle(double radius)//return type is double, parameter type is double.
        {
            return Math.PI * Math.Pow(radius, 2);//need to return something; a value that matches the type the method is expecting, which in this case is a double type.
        }//PI and Pow are both double types when it comes to what their values are.
    }
}
