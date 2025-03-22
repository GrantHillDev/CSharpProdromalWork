using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var numberArray = new int[50];//inferred typed new array variable. This just defines the size of the array, but it doesn't specify what values it contains within its indexes.

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Console.WriteLine("Creating a method that creates an array of 51 numbers, and it will be instructed to contain values of numbers 0 through 50.");
            Console.WriteLine("");
            Populater(numberArray);
            Console.WriteLine("");

            //TODO: Print the first number of the array
            Console.WriteLine("Printing the first index of this array.");
            Console.WriteLine("");
            Console.WriteLine(numberArray[0]);//Get the value of numberArray at its first index.
            Console.WriteLine("");

            //TODO: Print the last number of the array
            Console.WriteLine("Printing the last index of this array.");
            Console.WriteLine("");
            Console.WriteLine(numberArray[numberArray.Length - 1]);//always with the syntactic errors (remember to use brackets, not parentheses, when expressing a variable of another variable). Get the value of numberArray at numberArray's last index.
            Console.WriteLine("");
            Console.WriteLine("All Numbers Original");
            Console.WriteLine("");
            Console.WriteLine("Using the 'NumberPrinter' method to print all stored values of this array to the console.");//UNCOMMENT this method to print out your numbers from arrays or lists
            Console.WriteLine("");
            NumberPrinter(numberArray);
            Console.WriteLine("");
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            Array.Reverse(numberArray);//it appears that you can have the same value within more than one index of a given array, unless otherwise specified.
            NumberPrinter(numberArray);
            Console.WriteLine("");
            ReverseArray(numberArray);
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            Console.WriteLine("");
            ThreeKiller(numberArray);//No need to have this method print its results to the console say by way of utilizing the NumberPrinter method because it's already called it within its scope.

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numberArray);//sorts all values of an arrays indexes by value, and they'll be grouped together.
            NumberPrinter(numberArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numbersList = new List<int>();//We don't know the size of the list or what values it will store.

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(numbersList.Capacity);//Capacity isn't the same as Count -- it deals in memory, and in the context of this exercise, that means if a list goes beyond a certain value as far as its length, then the memory allocated for such a length is doubled.... so, if a list has a number of indexes greater than 4, it will increase its capacity to 8, and if it features a number of indexes greater than 16, it will increase its capacity to 32, and so on.


            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numbersList);//not yet printed to console.

            //TODO: Print the new capacity
            Console.WriteLine(numbersList.Capacity);//presents a value of 64 each time its printed to the console because the number of indexes in the list will always be 50, which is grater than 32.

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int searchNumber;//kept this variable outside of an enclosed method and placed it here so that it could be used in more than one script.
            bool isANumber;
            do
            {
                Console.WriteLine("Please select a number to search for, and it will be checked to see if it is in the list.");
                isANumber = int.TryParse(Console.ReadLine(), out searchNumber);//here's where we're defining the checker to see if the variable serachNumber is in fact its declared type, which is an integer.
            } while (!isANumber);
            NumberChecker(numbersList, searchNumber);//any user inputted response that's an integer with a value less than or equal to 50, the script will return a response suggesting that the user's choice is included in the list.
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numbersList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numbersList.Sort();
            NumberPrinter(numbersList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable


            //TODO: Clear the list


            #endregion
        }

        //public static void numberSearcher (string[] args)
        // {
        //   
        //}
        //public static void CustomReverseArray()
        //{
        //
        //}

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)//int i will continue to run the script while the value of i is less than the length of the array for which it will be parsing through.
            {
                if (numbers[i] % 3 == 0)//if int i is divisible by the 3, and the remainder of such a division yields a value of zero, then we 'kill' that number by converting it into zero, and print it to the console as such.
                {
                    numbers[i] = 0;//if int i of array numbers is int fact divisible by 3, then let's set that value of int i to 0, and if it's printed to the console, it will show up as 0, which tells us that whatever number int i happened to parse through before setting it equal to 0, it was divisible by 3.
                }
            }
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)//method that accepts an argument of a list variable type, numberList.
        {
            //for (int i = 0; i < numberList.Count -1; i++)//incrementing int i when it is parsing through and consequently building out a list of indexes seems to entail the likelihood that such indexes aren't being parsed properly as they're being created, until the list has reached its ending index.... so creating a for loop that decrements from the end back to its list's beginning is a safer bet, at least when removing indexes from said list.
            //{
            //if (numberList[i] % 2 == 1)//if int i of numberList is divisible by 2 and yields a remainder (1 should work just fine for all instances here), then it must be an odd number.
            //{
            //numberList.Remove(numberList[i]);
            //}
            //}
            //NumberPrinter(numberList);//can input the numberprinter method here since the method here is void and therefore doesn't expect a return, rather than calling it in the main method.
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)//if (numberList[i] % 2 == 1)//This condition works well, and would have worked in my first above attempt.... though it appears that incrementing through indexes instead of decrementing through them, by starting at the ending index of a list when parsing through it, in an effort to remove any of its potential indexes (such as those containing odd numbers in this case), the logic is that going backwards instead of forwards when parsing through such a list is that the indexes may not have yet been generated, so to speak, as int i is incrementing through them, until it hits the end index of the list. However, if the list's length of indexes has already been generated prior to being parsed through by int i, then that means i has a much more clear and direct way of evaluating the value of each index in the list and can then determine per its instruction whether or not to remove the number.
                {
                    numberList.Remove(numberList[i]);
                }
            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"The searched number, {searchNumber}, is present.");
            }
            else
            {
                Console.WriteLine($"Sorry, the searched number, {searchNumber}, is not present.");
            }
        }

        //private static void Populater(List<int> numberList)//list
        //{
        //Random rng = new Random();
        //for (int a = 0; a < numberList.Count; a++)//again, .Count is used for lists.
        //{
        //numberList[a] = rng.Next();//gives us every index of numberList, via a.
        //}
        //}

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();//random appears to be a declarator, even though it doesn't seem to explicitly state what value type it generates, despite being a number generator.

            while (numberList.Count <= 50)//while int numberList is less than or equal to 50, add a value to numberList.
            {
                numberList.Add(rng.Next(0, 51));
            }
        }

        private static void Populater(int[] numbers)//array
        {
            Random rng = new Random();
            for (int b = 0; b < numbers.Length; b++)//again, .Length is used for arrays.
            {
                numbers[b] = rng.Next(0, 51);//gives us every index of numbers, via b. remember that the instructions specify the numbers within this array cannot just be any random number -- they must be numbers between 0 and 50.
            }//if minimum and maximum number values aren't expressed in the above live of code, per the 'Next' method, then the script returns any random number that it wants.

        }

        private static void ReverseArray(int[] array)
        {
            int start = 0;//first index of the array.
            int end = array.Length - 1;//last index of the array.

            while (start < end)//this functionality is actually already predefined in a method -- array.Reverse(), and therefore doesn't need to be written out like this, but this is just a reference.
            {
                int carrier = array[start];//int carrier is equal to array's first index.
                array[start] = array[end];//swapping values of starting index and ending index.
                array[end] = carrier;//at first, I didn't understand why the start and end indexes of the array needed to be swapped, but I'm thinking it's because of a technicality, for which syntactically, the script is going to run and parse through all of its array's indexed values in order of start to finish, so, by swapping out the start variable of the array for the end variable, then it seems like the end variable values would consequently get parsed through and printed to the console first, before the start ones are, which consequently displays all of the array's values in reverse order.
                start++;
                end--;//while the starting index variable is incrementing of the array, the ending one is decrementing, and because this is a while script running under the condition that the start variable is less than the end variable, it will have parsed through both ends of the array until they meet in the middle, so to speak, and we use the carrier variable to help the other two variables swap out values, as the start increments and the end decrements.
                //Console.WriteLine(array[start]);//This obviously didn't print out the indexed values to the console in the manner for which was intended, but tried anyway.
                //Console.WriteLine(array[end]);
            }

        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
