namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        static void NumberPrinter()//tested -- this method works.
        {
            Console.WriteLine("");
            Console.WriteLine("Method that counts all numbers between -1000 and 1000.");
            for (int d = -1000; d <= 1000; d++)
            {
                //d++;//this was unnecessary, causing the counter variable to skip every other number.
                Console.WriteLine("");
                Console.WriteLine(d);
            }
        }

        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()

        static void EveryThirdNumberPrinter()//tested -- this method works.
        {
            Console.WriteLine("");
            Console.WriteLine("Method that counts all third numbers between 3 and 999.");
            for (int g = 3; g < 1000; g += 3)//syntax -- otherwise, I already had this one figured out on my own.
            {
                Console.WriteLine("");
                Console.WriteLine(g);
                //Console.WriteLine(g+2);
            }
        }

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        static void AreNumbersEqual(int num1, int num2)//if an access modifier isn't provided here for a method, the program will default to one anyway.... public isn't the default -- it might be internal.
        {//tested -- this method works.
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} is the same as {num2}.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"{num1} is not the same as {num2}.");
                Console.WriteLine("");
            }
        }

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        static void IsEven(int number)//tested -- this method works.
        {
            if (number % 2 == 0)//this just means that if a number that is divisible by has a remainder of zero, like there's nothing else left after being divided by 2, then the number itself must be an even number, which makes logical sense.
            {
                Console.WriteLine($"{number} is an even number.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"{number} is not an even number.");
                Console.WriteLine("");
            }
            //if (number == number / 2)//tried testing this when called down below in the main method, and as I'd thought; it does not work as intended.
            //{
            //    Console.WriteLine($"{number} is an even number.");
            //    Console.WriteLine("");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not an even number.");
            //    Console.WriteLine("");
            //}
        }

        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        static void IsPositive(int numero)//tested -- this method works.
        {
            if (numero > 0)
            {
                Console.WriteLine($"{numero} is a positive number.");
                Console.WriteLine("");
            }
            else if (numero == 0)
            {
                Console.WriteLine($"{numero} is equal to zero.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"{numero} is a negative number.");
                Console.WriteLine("");
            }
        }

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.

        public static void CanVoteUpgraded()//no return expected; no parameters anticipated by this program. They will instead be defined below within the scope -- this provides for greater flexibility with how the variables will be processed by the program itself.
        {//tested-- this method works.
            Console.WriteLine("Greetings. We're short on voters this year -- please tell us how old you are?");
            Console.WriteLine("");
            var parseAge = int.TryParse(Console.ReadLine(), out int age);//here, parseAge is a variable that is implicitly typed, whereas the age variable is explicitly typed.
            while (parseAge == false)//this is a first checker.
            {
                Console.WriteLine("Please enter an actual age.");
                Console.WriteLine("");//if we forget to include another .TryParse(ConsoleReadLine()) prompt, like the one below this line, then the program will never terminate -- it remains in its own indefinite loop, unable to terminate.
                parseAge = int.TryParse(Console.ReadLine(), out age);//here, we took out the var aspect of the same line of code written in above for this method, because the variable parseAge has already been declared. The same goes for the age variable. Remember C3 is a strongly statically typed object oriented coding language, meaning consequently that one a variable type has been declared it cannot changed.
            }

            if (age >= 18)//utilizing my already written script. Think of this as a second checker.
            {
                Console.WriteLine($"Well then there, you're aged {age} years old -- you can vote!");
                Console.WriteLine("");
            }
            else//remember, the else component doesn't expect any conditional or variable, just leave it blank.
            {
                Console.WriteLine($"Hold up, you're aged {age} years old -- you can't vote yet.");
                Console.WriteLine("");
            }
        }
        //public static void CanVote(int age)//the way in which this method is written leaves it vulnerable to user input failure, where the program can terminate just because they didn't make their response in the form of something that was otherwise numerical.
        //{//tested-- this method works.
        //    if (age >= 18)
        //    {
        //        Console.WriteLine($"Well then there, you're aged {age} years old -- you can vote!");
        //        Console.WriteLine("");
        //    }
        //    else//remember, the else component doesn't expect any conditional or variable, just leave it blank.
        //    {
        //        Console.WriteLine($"Hold up, you're aged {age} years old -- you can't vote yet.");
        //        Console.WriteLine("");
        //    }
        //}
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        public static void IsYourIntegerWithinRange()
        {//tested-- this method works.
            Console.WriteLine("Hey, let's see if you can come up with a number that's within a random, but very specific range.");
            Console.WriteLine("");
            Console.WriteLine("Please provide a number.");
            var canParseInt = double.TryParse(Console.ReadLine(), out double userResponse);//so, here, I just learned that when utilizing such a line of code as this, where you have a variable initialized as a .TryParse(Console.ReadLine()), you cannot have the TryParse method trying to parse a type of data that is not equal to its output variable, which, in this case, would be userResponse (in other words, if it's a double type, don't try to declare the output variable as an integer, or anything else, but a double type).

            while (canParseInt == false)//what to while all outcomes of the user's response are false.
            {
                Console.WriteLine("Well, it appears your response was invalid, please try again.");
                Console.WriteLine("");
                canParseInt = double.TryParse(Console.ReadLine(), out userResponse);
            }
            if (userResponse >= -10 && userResponse <= 10)//what to do if the any of the user's inputs return true.
            {
                Console.WriteLine($"Well, I'll be! You're guessed input of {userResponse} is within range!");
                Console.WriteLine("");
            }
            else//what to do if the user's input is valid, but is not within range.
            {
                Console.WriteLine($"Huh, that's funny, the response of {userResponse} you've provided doesn't seem to be within range.");
                Console.WriteLine("");
                Console.WriteLine("It's ok -- better luck next time.");
            }
        }
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        public static void DisplayMultipicationTable(int numericValue)//so now, this method is not only expecting a numeric value to be passed through it, but's parameter type has already been declared up here, so it no longer needs to be down below.
        //public static void DisplayMultipicationTable()
        {//tested-- this method works.
            Console.WriteLine("Hi there. Please provide a number which we can showcase a table of multiplication for.");
            Console.WriteLine("");
            var pArseable = int.TryParse(Console.ReadLine(), out numericValue);//the good news here is that despite the fact that the numericValue variable has already been declared in the method, we aren't changing it's declared type here in the scope, so we're Gucci. But don't re-declare the same type for this variable as it's been already been declared.... otherwise, error shows up.

            while (pArseable == false)
            {
                Console.WriteLine("Invalid response. Please try again.");
                Console.WriteLine("");
                pArseable = int.TryParse(Console.ReadLine(), out numericValue);
            }//if else statements aren't needed here, and would create an excess of code.
            //if (numericValue == int)//cannot set the declared value equal to a predefined type, let alone a type versus a value, even though it's intended for the program just to check and see if the user's input is an integer.
            Console.WriteLine($"Alright, here we'll list out your provided input of {numericValue}, from 1, all the way up to 17.");
            Console.WriteLine("");
            Console.WriteLine($"One times {numericValue} is {numericValue * 1}.");
            Console.WriteLine($"Two times {numericValue} is {numericValue * 2}.");
            Console.WriteLine($"Three times {numericValue} is {numericValue * 3}.");
            Console.WriteLine($"Four times {numericValue} is {numericValue * 4}.");
            Console.WriteLine($"Five times {numericValue} is {numericValue * 5}.");
            Console.WriteLine($"Six times {numericValue} is {numericValue * 6}.");
            Console.WriteLine($"Seven times {numericValue} is {numericValue * 7}.");
            Console.WriteLine($"Eight times {numericValue} is {numericValue * 8}.");
            Console.WriteLine($"Nine times {numericValue} is {numericValue * 9}.");
            Console.WriteLine($"Ten times {numericValue} is {numericValue * 10}.");
            Console.WriteLine($"Eleven times {numericValue} is {numericValue * 11}.");
            Console.WriteLine($"Twelve times {numericValue} is {numericValue * 12}.");
            Console.WriteLine($"Thirteen times {numericValue} is {numericValue * 13}.");
            Console.WriteLine($"Fourteen times {numericValue} is {numericValue * 14}.");
            Console.WriteLine($"Fifteen times {numericValue} is {numericValue * 15}.");
            Console.WriteLine($"Sixteen times {numericValue} is {numericValue * 16}.");
            Console.WriteLine($"Seventeen times {numericValue} is {numericValue * 17}.");
            //Console.WriteLine($"{numericValue*3}");
            //Console.WriteLine($"{numericValue*4}");
            //Console.WriteLine($"{numericValue*5}");
            //Console.WriteLine($"{numericValue*6}");
            //Console.WriteLine($"{numericValue*7}");
            //Console.WriteLine($"{numericValue*8}");
            //Console.WriteLine($"{numericValue*9}");
            //Console.WriteLine($"{numericValue*10}");
            //Console.WriteLine($"{numericValue*11}");
            //Console.WriteLine($"{numericValue*12}");
            //Console.WriteLine($"{numericValue*13}");
            //Console.WriteLine($"{numericValue*14}");
            //Console.WriteLine($"{numericValue*15}");
            //Console.WriteLine($"{numericValue*16}");
            //Console.WriteLine($"{numericValue*17}");
            //Console.WriteLine($"{numericValue*18}");//I lied; I made it go up to 18 instead.
        }
        public static void QuickerMultiplicationTable(int valueNumeric)
        {
            Console.WriteLine("Hi there. Please provide a number which we can showcase a table of multiplication for.");
            Console.WriteLine("");
            var pArseable = int.TryParse(Console.ReadLine(), out valueNumeric);
            while (pArseable == false)
            {
                Console.WriteLine("Invalid repsonse. Please try again.");
                Console.WriteLine("");
                pArseable = int.TryParse(Console.ReadLine(), out valueNumeric);
            }
            for (int i = 0; i <= 17; i++)
            {
                Console.WriteLine($"{valueNumeric} x {i} = {valueNumeric * i}");
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)//if an access modifier isn't provided here for a method, the program will default to one anyway.... public isn't the default -- it might be internal.
        {//might not be a bad idea to just get into the habit of writing out each method's access modifier moving forward, just by default of program syntax (formatting).
            //NumberPrinter();//down here, we can test each individual method mutually exclusive to others by commenting them all out, with the exception of the one being tested. This is a good way to test the other methods that require a paramter to be passed into them in order to work.... this would eliminate my proclivity for wanting to turn every single method I write into a one that incorporates the use of user based input, and thereby saves me time on assignments (just want to see if the program;s working ok).
            //EveryThirdNumberPrinter();
            //AreNumbersEqual(2, 2);//here, we have to provide values that can be passed through the method that's calling for them within its parameters. If we don't do this, the IDE will throw an error suggesting that no argument is given which corresponds to the required parameter of the program, or method,'AreNumbersEqual')
            //IsEven(4);//here, the IsEven method expects a value to be passed through its parameter, which in this case would be a single number. This remains true despite retaining a void return type.
            //IsPositive(0);//again, this method only has one parameter it's expecting to have a value passed through. This remains true despite retaining a void return type.
            //CanVote(19);
            //CanVoteUpgraded();//as mentioned above, this method doesn't necessarily have to determine specific parameters for itself; to be passed through it, as those would likely only inhibit its flexibility to take data stored from user input.
            //IsYourIntegerWithinRange();
            DisplayMultipicationTable(3);//so, I just learned that if we assign one or more parameters to a method, not only will it expect a value of that parameter's type to be passed through it, namely when it is being called, but it also will still run as a program that can take a user's input, if already defined within its script. In other words, this method runs just like other methods I've written within this exercise similar to it (utilizing the while loops, as well as the if else statements), but need to remember to give it a value within its parentheses when it's called because that is what it is expecting, regardless of how its script behaves.
            QuickerMultiplicationTable(7);//wish I'd thought of the for loop first!
        }
    }
}
