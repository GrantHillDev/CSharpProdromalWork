using System;

namespace StaticExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68); // 20
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20); //68

            Console.WriteLine("A featured Temperature converter, displaying data pertaining to degrees Fahrenheit, and degrees Celsius.");
            Console.WriteLine("");
            Console.WriteLine("After conversion:");
            Console.WriteLine("");
            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine("");
            Console.WriteLine($"Fahrenheit {fahrenheit}");//sadly, a user's not going to know what numbers equate to what variable, in the context of Fahrenheit versus Celsius.
            Console.WriteLine("");

            var miles = DistanceConverter.KilometersToMiles(18);//we can call static class based methods here in the main method of the program by way of utilizing dot notation for the method's class itself (DistanceConverter.Method Name)
            var kilometers = DistanceConverter.MilesToKilometers(8.18);

            Console.WriteLine("A featured Distance converter, displaying data pertaining to miles as well as kilometers.");
            Console.WriteLine("");
            Console.WriteLine("After calculations have been performed for converting 18 total kilometers into miles:");
            Console.WriteLine("");
            Console.WriteLine($"{miles}");
            Console.WriteLine("");
            Console.WriteLine("After calculations have been performed for converting 8.18 total miles into kilometers:");//down here, a user will know what variable equates to what variable, instead of just randomly printed data to the console.
            Console.WriteLine("");
            Console.WriteLine($"{kilometers}");
            Console.WriteLine("");
        }
    }
}
