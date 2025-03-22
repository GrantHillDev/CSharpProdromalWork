using System;

namespace C_Sharp_Syntactic_Practice__Methods_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMessage();//if the method isn't defined with a static property, it will throw an error suggesting that an object reference is required for the non-static field, method, or property.
            CalculateArea1();

            // Check if the user provided exactly 3 arguments//from Miah.
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: dotnet run <number1> <operator> <number2>");
                return;
            }

            // Parse numbers from command-line arguments
            if (!double.TryParse(args[0], out double num1) || !double.TryParse(args[2], out double num2))
            {
                Console.WriteLine("Error: Please enter valid numbers.");
                return;
            }

            string operation = args[1];
            double result = 0;

            // Perform the requested operation
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        return;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Error: Unsupported operator. Use +, -, *, or /.");
                    return;
            }

            // Display the result
            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
        }
        public static void PrintMessage()
        {
            Console.WriteLine("message");
        }

        //Using your same example from above, this method can now be called without having to pass anything specific.

        //static void Main(string[] args)
        //{
        //PrintMessage();//This method doesn't expect anything to be passed into it, but still does what its script told it to.
        //}

        //As opposed to;

        public static void PrintMessage1(string message)//needs to have the static property added to it in order to prevent an error being thrown requiring a reference to an object.
        {
            Console.WriteLine(message);
        }

        //static void Main(string[] args)
        //{
            //PrintMessage1(message);//This would be a method that now accepts and expects a string to be passed into it -- else, it'll throw an error at you, as             you'd mentioned.
        //}

        //By the way-- why does the main method default to string[] and args?
        //Grant Hill — 3 / 7 / 2025 3:03 PM
        //Let me try your other examples just to see if I can create more examples of what I'm getting at;//This entire series of scripts was what I wrote to a TC C# instructor.

        public double CalculateArea(double width, double height)
        {
            return width * height;
        }

        //versus

        public static void CalculateArea1()
        {
            Console.WriteLine("please provide a number that represents height.");
            Console.WriteLine("");//For spacing.
            var height = int.TryParse(Console.ReadLine());
            Console.WriteLine("please provide a number that represents width.");
            Console.WriteLine("");
            var width = int.TryParse(Console.ReadLine());
        }

        //Could even make a do -while loop to ensure the values received for both variables are in fact integers, or something logical that could be passed into the script's method, even though it's not going to return anything, nor crash when certain value types aren't passed into it. 
        //I'll write the same example above with the do-while instance I was just mentioning.

        public static void CalculateArea2()
        {
            double height;//var height;//This variable type cannot be inferred if it is not initialized.
            double width;
            bool isANumber;
            {
                do
                {
                    Console.WriteLine("please provide a number that represents height.");
                    Console.WriteLine("");
                    isANumber = double.TryParse(Console.ReadLine(), out height);//This is to prevent the app from throwing errors and crashing.
                } while (!isANumber);
                Console.WriteLine("Your response did not represent a number, please try a again.");
                Console.WriteLine("");
            }
            do
            {
                Console.WriteLine("please provide a number which represents width.");
                Console.WriteLine("");
                isANumber = double.TryParse(Console.ReadLine(), out width);//again, the TryParse method requires a 
            } while (!isANumber);
            Console.WriteLine("Your response did not represent a number, please try a again.");
            Console.WriteLine("");
        }

        //So, I went to all the trouble of writing out this script because I wanted to illustrate just how much more versatile and robust the script itself was, than say writing it out in the first instance, where it passes values for variables of height and width(which may not always take in their expected integer values)....does that make sense ? It seems to me like this one has many more applications than the first instance....but, I'm sure there's something obvious I'm missing about why I wouldn't necessarily need to write a script this robust ? I also just like being able to call the method, in this case, CalculateArea, just like this when it's being called inside of the main method -- CalculateArea(); as opposed to -- CalculateArea(height,width); or even -- CalculateArea(4,7); 

    }
}
    
