using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)//static means that it belongs exclusively tot he class its from, especially in this context.
        {
            var result = (fahrenheit - 32) / 1.8;//C# actually utilizes basic mathematical fundamentals such as PEMDAS. The 1.8 was written in here instead of 5/9 notion, because as an integer, the value itself is going to be rounded to the nearest whole number, which would detract from accuracy in this context.

            return result;
        }

        public static double CelsiusToFahrenheit(double celsius)//has to be marked as a static method because the class its based from is a static class.
        {
            return (celsius * 9) / 5 + 32;
        }
    }
}
