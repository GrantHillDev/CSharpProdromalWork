using System;

namespace _360DegreeMultipliers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Three60degreeMultiplier1();
            Three60degreeMultiplier2();
            Three60degreeMultiplier3();
            Three60degreeMultiplier4();
            Three60degreeMultiplier5();
            Three60degreeMultiplier6();
        }
        public static void Three60degreeMultiplier1()
        {
            var number = 1;
            for (int i = 1; i < 10; i++)
                Console.WriteLine(number * 36 * i);
        }
        public static void Three60degreeMultiplier2()
        {
            var number = 1;
            for (int i = 1; i < 10; i++)
                Console.WriteLine((number * 36 * i) + 6);
        }
        public static void Three60degreeMultiplier3()
        {
        var number = 1;
            for (int i = 1; i< 10; i++)
                Console.WriteLine((number* 36 * i) + 12);
        }
        public static void Three60degreeMultiplier4()
        {
            var number = 1;
            for (int i = 1; i < 10; i++)
                Console.WriteLine((number * 36 * i) + 18);
        }
        public static void Three60degreeMultiplier5()
        {
            var number = 1;
            for (int i = 1; i < 10; i++)
                Console.WriteLine((number * 36 * i) + 24);
        }
        public static void Three60degreeMultiplier6()
        {
            var number = 1;
            for (int i = 1; i < 10; i++)
                Console.WriteLine((number * 36 * i) + 30);
        }
    }
}
