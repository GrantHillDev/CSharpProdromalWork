using System;

namespace WhiteBoardChallenge02
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public string ReturnWordBasedOnNumber(int input)//method takes in an integer -- be sure to ask an interviewer posing this sort of problem to you what the parameter type is; double, integer, decimal?
        {
            var response = "";//variable placeholder of string type.

            //if (input / 3)//this didn't work because if statements only make use of conditionals that are Boolean in nature.... it's an integer division; not expressing a Boolean. Seems like it's a syntactic error, as the same idea can be applied here with the use of a modulus. I think it's because C# sees the iteration statement as an operation, and not as a Boolean.
            //{
            //    response = "fizz";
            //}
            //else if (input / 5 = 0)//doesn't make sense to change the input variable to a Boolean, because then it cannot be directly compared to integers... and therefore cannot also perform operations associated with them.
            //{
            //    response = "buzz";//this didn't work either because syntactically, the left-hand side of the iteration statement must be a variable, property, or indexer.
            //}
            //else if (input / 3 && input / 5)//if (input / 3 || input / 5)
            //{
            //    response = "fizzbuzz";
            //}
            if ((input / 3 * 3) == input)//this technique reverse enigneers divisibility. if input is divisible by 3 and then multiplied by 3, it should be equal to itself. 
            {
                response = "fizz";
            }
            else if ((input / 5) * 5 == input)
            {
                response = "buzz";
            }
            else if ((input / 3) * 3 == input && (input / 5) * 5 == input)
            {
                response = "fizzbuzz";
            }
            return response;//all code paths must return a value. I imagine that response outside of these three selections statements would return its default value of blank.
        }
        public string ReturnStringBasedOnNumber(int userInput)
        {
            var reply = "";

            if (userInput % 3 == 0)//this might just be the only way I can think of to do this correctly.
            {
                reply = "fizz";
            }
            if (userInput % 5 == 0)
            {
                reply += "buzz";//not a bad way to avoid using 3 selection statements.... I'm thinking that because of the order in which this method's code was written, that this actually works, whereas it wouldn't have worked if the buzz word had been written into the first if statement (since the computer reads and interprets your code from top to bottom).
            }
            return reply;//all code paths must return a value. Thanks to VS Community; this notion has been drilled into my head time and again.... at least when a written method is expecting a return.
        }
        public string ReturnReferenceTypeBasedOnNumbers(int userNumber)//disregard this one.
        {
            var answer = "";

            if ((userNumber / 3) == userNumber)//this made sense to me initially, but all this is checking for is to see if userNumber is equal to one third of itself.... multiplying itself by 3 after dividing itself by 3 ensures there's no remainder, essentially doing exactly what a modulus operator does.
            {
                answer = "fizz";
            }
            else if ((userNumber / 5) == userNumber)
            {
                answer = "buzz";
            }
            else if ((userNumber / 3) == userNumber && (userNumber / 5) == userNumber)
            {
                answer = "fizzbuzz";
            }
            return answer;
        }
    }
}
