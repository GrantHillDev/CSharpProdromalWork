using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Follow the instructions provided in each comment below to complete the exercise.
            // Use the example given to guide your implementation.

            //Create a List called "numbers" - DONE!
            List<int> numbers = new List<int>();  //DO NOT ERASE THIS! You will use this in the exercise.
            
            //-----START HERE------------------------------------------

            //TODO - Create a variable of type int and name it "num" -- completed.
            int num;

            //TODO - Initialize the variable with a value of 0 -- completed.
            num = 0;
            Console.WriteLine("Beginning with a 'Do-While' script.");
            Console.WriteLine("");
            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");
            Console.WriteLine("");
            //TODO - Create a do-while loop using the existing brackets as a template. -- completed.
            // The existing brackets are placeholders for your loop code.
            // Inside this loop:
            // a) Increment "num" by 1 -- completed.
            // b) Then add "num" to the collection "numbers" -- completed.
            //    Hint: Use "numbers.Add(num);" to add the current value of "num" to the list. -- completed.
            do
            {
                num++;
                numbers.Add(num); //uncomment out `num` to add it to the collection "numbers" -- completed.
                Console.WriteLine($"{num}");//print the values of the variable num to the console just to see what the script is doing.
                Console.WriteLine("");
                //Console.WriteLine($"{numbers}");//print the values of the variable numbers to the console just to see what the script is doing.
                Console.WriteLine("");//printing the collection itself to the console doesn't work as intended.
            } while (numbers.Count < 100);
            //TODO - Continue the loop while "num" is less than 100 -- completed.


            //TODO - Create a while loop using the existing brackets as a template. -- completed.
            //TODO - Continue the loop while "num" is less than 200 -- completed.
            // The existing brackets are placeholders for your loop code. -- completed.
            // Inside this loop:
            // a) Increment "num" by 1 -- completed.
            // b) Then add "num" to the collection "numbers" -- completed.
            //    Hint: You can copy how this was done in the do-while loop -- completed.
            Console.WriteLine("Now looping to the 'while' loop script.");
            while (num < 200)
            {
                num++;
                numbers.Add(num);
                Console.WriteLine("");
                Console.WriteLine($"{num}");
                // Console.WriteLine($"{numbers}");//print the values of the variable numbers to the console just to see what the script is doing.
            }//printing the collection itself to the console doesn't work as intended.



            // This is to show the user that the numbers will start increasing on the console
            //Console.WriteLine("Increase:");
            Console.WriteLine("");
            Console.WriteLine("Will now be printing the numbers added to the numbers collection to the console.");
            //TODO - Create a foreach loop using the existing brackets as a template.
            // The existing brackets are placeholders for your loop code.
            // Inside this loop, print each number in "numbers".
            foreach (int number in numbers)//num cannot be used as a variable in this foreach loop beacse it has already been initialized outside of the loop, whereas the foreach loop itself relies on being able to 
            {//initialize its own variable as a means of executing its own block of code.
                Console.WriteLine("");
                //Console.WriteLine($"{numbers[num]}");
                Console.WriteLine($"{number}");//I guess the quotation marks aren't necessary here.
            }//number appears to be initialized within the foreach definition, thereby allowing it to be used in this block of code, much like we would initialize a variable like i in a for loop.


            Console.WriteLine("");
            Console.WriteLine("Now looping a count down script via a for loop.");
            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            //TODO - Create a for loop using the existing brackets as a template. -- completed.
            // The existing brackets are placeholders for your loop code.
            // This loop will print the numbers in reverse order - from 200 to 1. -- completed.

            // a) In your initializer, set the value of "i" to 199 -- completed.
            // b) In your conditional, ensure that the loop continues as long as "i" is: -- completed.
            //    - Less than or equal to the number of items in "numbers" (use "numbers.Count") -- completed.
            //    - Greater than or equal to 0 -- completed.
            // c) Decrement "i" by 1 in each iteration -- completed.
            for (int i = 199; i >= 0; i--)
            {
                //TODO - Inside the loop, place numbers[i] inside of the Console.WriteLine() method
                Console.WriteLine(numbers[i]); // Example placement of numbers[i] inside Console.WriteLine
            }//This is one way to print a collection of numbers to the console.

            //------------End of exercise

        }
    }
}
