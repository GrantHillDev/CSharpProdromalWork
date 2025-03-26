using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10

            ListingArrayIndexes1();
            /* Create a list of type int
             * Name the list "evens"
             */


            /* Create another list of type int
             * Name the list "odds"
             */


            /* Using either a foreach or for loop,
            * iterate through the array you populated with 10 numbers.
            * Inside the scope of the loop,
            * check to see if each number in the array is even or odd.
            * If the number is even, add it to the evens list.
            * If the number is odd, add it to the odds list.
            */



            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */


            /* Using a for loop,
             * display the numbers in your "odds" list
             */
        }
        public static void ListingArrayIndexes1()
        {
            List<int> evenNumbers = new List<int>();//explicitly typed. Remember to check your namespaces before writing out your code -- System.Collections.Generic in this case.... else, you'll just keep getting errors thrown at you.
            var oddNumbers = new List<int>();//inferred typed.
            int[] ListArray1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//Remember, slot indexes start at a value of zero, even though the zero indexed slot, in this case, is assigned to a value of 1, its slot within the array is the beginnning one set to zero.
            foreach (int num in ListArray1)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
                else
                {
                    oddNumbers.Add(num);
                }//For each 'num' in ListArray1, if num is divisible by 2 and leaves a remainder of 0, then please add the value of num to the list called, 'evenNumbers. Else, please add the value of num to the list of oddNumbers.
            }

            for (int i = 0; i < ListArray1.Length; i++)//Remember that the final index on the spectrum of an array must be deducted by 1 in order to ensure accuracy of the index's stored value.
            {
                Console.WriteLine(ListArray1[i]);
                Console.WriteLine("");
            }

            foreach (var num in evenNumbers)//We have to specify what it is that we want the variable 'num' to do, and what it needs to do within its assigned list.
            {
                Console.WriteLine(num);
                Console.WriteLine("");
            }

            for (var x = 0; x < oddNumbers.Count; x++)//for (var x = 0; x < oddNumbers.Length; x++)//for some reason, the .Length function works with arrays, but doesn't work with lists.... must use the .Count function instead.
            {//I don't see why the -1 value would be needed here regarding the oddNumbers.Count conditional, as it defines the total number of times x is going to not only execute its script, but also how many times it's going to print its value to the console.
                Console.WriteLine(oddNumbers[x]);//Console.WriteLine(x) -- this just prints the value of x as it increments each time the script is executed, so we need to instruct the script to print the value of x for ever 'count' of the 'oddNumbers' list.
                Console.WriteLine("");
            }
        }
    }
}
