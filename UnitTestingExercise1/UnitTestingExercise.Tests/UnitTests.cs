using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestingExercise.Tests//letting the tests drive the development of how we write code -- test driven development.
{
    public class UnitTests//this is the class we can make instances of by calling upon its methods in other classes, like the calculator class, or the methods we wrote within it.
    {
        [Theory]//we can make as few or as many different tests as we want, and these are classified as individual lines of data, otherwise known as inline data.
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        //[InlineData(2, 3, 5, 10)]VSC knows if you have any redundant inline testing data.
        [InlineData(-2, 7, 12, 17)]//if one test isn't passing, try to check which line of inline data might be responsible for such, or check to see if the input you've give that inline data was correct (all tests will never pass unless the expected response is actually the correct response -- check your math).
        [InlineData(-14, -26, 21, -19)]//be sure to check the math on these, because the computer does in fact know how to math.
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var tester = new Calculator();//var tester = new UnitTests();//if we don't ensure that the unit testing exercise project file is referenced to this one (they appeared to be the same project file, regardless of which one's dependencies I right clicked on when choosing between each project), then the other project's code cannot be directly accessed by this one. Though; I'd think that this 

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = tester.Add(num1, num2, num3);//we needed to make an instance in the form of an object from the calculator class -- not the unit tests class. I'm thinking that this project was the only one that needed to referenced by the other one, and the other way around, as we have no need to call upon the programming in this class/program -- in the other one.
            //Assert
            Assert.Equal(expected, actual);//oh this makes sense -- how it's written. We assign what the 'expected' variable is going to be; what they're supposed to be, if the operations performed by our object based calculator, when running through a given method's arguments, are done correctly, and then the result of that operation gets stored into the actual variable which then gets passed as an argument against the expected variable by means of utilizing the Equals method from the predefined Assert class (probably from the system.Xunit namespace).
        }

        [Theory]
        [InlineData(1, 1, 0)]//Add test data <-------
        [InlineData(-2, 2, -4)]//deducting a negative integer from a positive integer makes for a negative integer.
        [InlineData(-3, -3, 0)]//deducting a negative integer from a negative integer makes the negative integer being deducted from a positive integer.
        [InlineData(4, -4, 8)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var tester = new Calculator();//var tester = new UnitTests();//here, we're making a new instance of the unit tests class, in the form of an object.
            //Act
            var actual = tester.Subtract(minuend, subtrahend);//tester.Add(minuend, subtrahend);//thinking this where the 2 programs combined begin to connect and communicate with each other to figure what one is expecting from the other, and vice versa.... in other words, so that we know which tests are being to what method in the calculator class/program.
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0, 0)]//[InlineData(0, 0, null)]//Add test data <-------//cannot divide by zero, so this test always fails. Perhaps an exception to it could be programmed though?
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(-3, 3, -9)]
        [InlineData(-4, -4, 16)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var tester = new Calculator();
            //Act
            var actual = tester.Multiply(num1, num2);
            //Assert
            Assert.Equal(actual, expected);//assert that what we're testing for is equal to what's expected.
        }

        [Theory]
        //[InlineData(num1, 0, null)]//Add test data <-------//tried using the test method's variables in the spectrum of its own inline data, but of course, its out of context error is going to get thrown because the variable hasn't been declared until after this line of code.
        [InlineData(0, 0, 0)]//I made an if statement that accounts for the values of num1 and num2 being equal to zero, just to prevent an error being thrown, but also to cheat the test, lol. The computer will just return a value of zero if num1 or num2 are equal to 0, so that it won't divide 0 into anything and generate the error.
        [InlineData(1, 1, 1)]
        [InlineData(16, 1, 16)]
        [InlineData(-16, 2, -8)]
        [InlineData(-16, -4, 4)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var tester = new Calculator();
            //Act
            var actual = tester.Divide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

    }
}
