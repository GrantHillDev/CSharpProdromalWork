using System;//?
// when the number is divisible by 3 return the word fizz

// when the number is divisible by 5 return the word buzz

// when the number is divisible by both, return the word fizzbuzz
namespace WhiteBoardChallenge01//utilizing VS Code so as to avoid the proclivity of VS Community's intelliSense....no compile errors marked here.
{
    public class program//just noticed that in VS Code the colored font of written in programming only seems to show up if the syntax of said code is proeprly typed in.... not a bad way to check yourself.
    {
        public string ReturnWordBasedOnNumber(int input)//method takes in an integer -- be sure to ask an interviewer posing this sort of problem to you what the parameter type is; double, integer, decimal?
        {
            var response = "";//variable placeholder of string type.

            if (input / 3)
            {
                response = "fizz";
            }
            if (input / 5)
            {
                response = "buzz";
            }
            if (input / 3 || input / 5)
            {
                response = "fizzbuzz";
            }
            return response;//all code paths must return a value. I imagine that response outside of these three selections statements would return its default value of blank.
        }

        public string ReturnStringBasedOnNumber(int userInput)
        {
            var reply = "";

            if (userInput % 3 == 0)
            {
                reply = "fizz";
            }
            if (userInput % 5 == 0)
            {
                reply += "buzz";//not a bad way to avoid using 3 selection statements.... I'm thinking that because of the order in which this method's code was written, that this actually works, whereas it wouldn't have worked if the buzz word had been written into the first if statement (since the computer reads and interprets your code from top to bottom).
            }
            return reply;//all code paths must return a value. Thanks to VS Community; this notion has been drilled into my head time and again.... at least when a written method is expecting a return.
        }
    }
}