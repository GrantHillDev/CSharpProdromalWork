//using System;
//using System.Collections.Generic;
//using System.Text;

namespace StaticExercise
{
    public static class DistanceConverter
    {
        public static double MilesToKilometers(double miles)
        {
            var result = miles * 2.2;
            return result;
        }

        public static double KilometersToMiles(double kilometers)
        {
            return kilometers / 2.2;//thinking I could have written it out this way for the above method as well, but differentiation makes for good practice.
        }
    }
}
