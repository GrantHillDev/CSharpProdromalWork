using System;
namespace UnitTestingExercise
{
    public class Calculator//it seems like there's a way to connect different project files together by listing them as references of each other, rather than simply relying on a constructed classes with defined members to be instantiated in one another.... might be more efficient, but entirely relevant.
    {
        // Step 1: Add a reference to your UnitTestingExercise project:

        // Right-click on the 'Dependencies' folder in your UnitTestingExercise.Tests project
        // and add your reference to the UnitTestingExercise project



        // Step 2: Create an Add method that accepts 3 integers, adds those integers, and returns an integer
        //For Example:
        public int Add(int num1, int num2, int num3)
        {
            //Console.WriteLine(num1 + num2 + num3);//return num1 + num2 + num3;
            return num1 + num2 + num3;
        }


        // Step 3: Navigate to the UnitTests.cs file and complete the AddTest unit test method 


        // Step 4: 
        // Create a Subtract method that accepts 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int minuend, int subtrahend)//Subtract(int num1, int num2, int num3)
        {//here, we can build the blueprint for the method it is we wish to test, without even having to write them out completely.... these are just shells
            //throw new NotImplementedException();//return num1 - num2;
            //return subtrahend - minuend;
            return minuend - subtrahend;
        }

        // Step 5: Navigate to the UnitTests.cs file and complete the SubtractTest unit test method


        // Step 6: 
        // Create a Multiply method that passes 2 integers
        public int Multiply(int num1, int num2)//so, I noticed that VSC throws compile errors if the method's written in another class; I should say that instantiated into one class such as this one from another one that's acting as their parent class, in the context of unit tests, the method must pass the same number of arguments or parameters as its respective unit test method does, which makes logical sense.
        {
            return num1 * num2;//throw new NotImplementedException();
        }

        // Step 7: Navigate to the UnitTests.cs file and complete the MultiplyTest unit test method 


        // Step 8: 
        // Create a Divide method that passes 2 integers
        public int Divide(int num1, int num2)
        {
            //if (num1 || num2 == 0)
            //{
            //    return null;
            //}
            if (num1 == 0 || num2 == 0)
            {
                //return null;//didn't work for integer argument types.
                //throw new NotImplementedException();//didn't pass
                return 0;
            }
            return num1 / num2;//throw new NotImplementedException();
        }
        // Step 9: Navigate to the UnitTests.cs file and complete the DivideTest unit test method 


        //*****NOW RUN ALL OF YOUR TESTS*********//
    }
}
