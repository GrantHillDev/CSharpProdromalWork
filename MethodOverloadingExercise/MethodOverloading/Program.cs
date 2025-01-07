namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Add(2);//doesn't work because as VS Community suggests; no overload for the method, 'Add', takes only one argument.
            //Add(2,2);
            //Add(2.0m,2.0m);//the cool thing here is that VS Community is smart enough to know what version of the overloaded method we want to use just based upon the value types we're passing into it as it is called in the main method.
            Add(2, 2, true);//this method will still run when it is called inside of the main method even if no Boolean is expressed.... I wonder if this is because Boolean parameters are defaulted to true, especially if they're expressed as variables?
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            //return (decimal)num1 + (decimal) num2;//this works, but it's redundant -- the variables being passed through this overloaded method's parameters have already been declared there.
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool trueFalse)
        {
            if (trueFalse == true)//cannot complete an if statement without its else -- else, 'not all code paths return a value'.
            {
                return $"{num1} + {num2} dollars.";
            }
            else if (trueFalse == true && num1 + num2 == 1)
            {
                return $"{num1} + {num2} dollars.";
            }
            else
            {
                //return string.Empty;
                return "No cash.";
            }
        }
        //public static string Add(int num1, int num2, bool trueFalse)
        //{
        //    var sum = num1 + num2;
        //    if (trueFalse == true)
        //    {
        //        return $"{sum} dollars.";
        //    }
        //    else if (trueFalse == true && sum == 1)
        //    {
        //        return $"{sum} dollar.";//in the event the sum is equal to a single dollar.... wouldn't want to return a string interpolated value of 1 dollars.
        //    }
        //    else
        //    {
        //        return sum.ToString();
        //    }
        //}
    }
}
