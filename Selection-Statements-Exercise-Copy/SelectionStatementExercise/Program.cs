using System;//may not be necessary for this series of programs.
namespace SelectionStatementExercises//(1 & 2)
{
    public class Program
    {
        static void Main(string[] args)//Exercise 1
        {
            Console.WriteLine("Hello, and welcome to a C# statement selection exercise.");
            Console.WriteLine("");
            Console.WriteLine("We'll play a simple numbers guessing game.");//Making the correct number in this game random makes the game itself more replay able.
            Console.WriteLine("");
            Console.WriteLine("This program will randomly pick a favorite number between numbers 1 and 17.");
            Console.WriteLine("");
            //var randomNumber = new Random();
            //var favoriteNumber = Random.Next(1,17);//this is a method that will return a non-negative random integer. These two lines of code got commented out because VS Community was giving me an error I didn't understand.

            //var randomNumber = new Random();
            //var favoriteNumber = randomNumber.Next(1, 17);//fixed the problem I was experiencing above on these two lines -- the issue was the method 'Next' didn't know what variable is supposed to be calling, or it was written incorrectly (the class of that variable was written in above, not the variable itself), and so the CS0120 error popped up because this line of code couldn't identify its 'object' since it wasn't typed in properly.

            Random randomNumber = new Random();//This line creates a new `Random` object, which is used to generate random numbers. 'Random' is a class, and on this line of code, we've created a new variable within this class that has been initilazed into a new instance of that class; consequently, a new object of that class.
            int favoriteNumber = randomNumber.Next(1, 17);//It looks like we don't even need to declare the class of the variable 'randomNumber' because it's already defined in the system being used for the program, and we're just telling VS Community that we're making a new instance of that class by the initializing the assigned variable as such.

            int userInput = 0;//userInput variable must be declared and initialized here, or else the while condition won't know what 'userInput' is. Also, we're utilizing 0 as a placeholder for our new int type variable, until the user replaces that number with their own selection.
            while (userInput != favoriteNumber)//Here, we create a condition that tells the program what to do if the user guesses the wrong number -- in this case, giving them an unlimited number of attempts to keep guessing the right number.
            {//If we didn't create the while condition here, then the program would only run once and then terminate right after the user has made their first guess, without ever really giving them other chances to figure out what correct number here is.
                Console.WriteLine("Make your guess.");
                userInput = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (userInput < favoriteNumber)
                {
                    Console.WriteLine("No, that's too low.");
                    //Console.WriteLine("");
                    //Console.WriteLine($"{favoriteNumber++}");This line of code actually increases the value of 'favoriteNumber' by 1 every time the user guesses the number not only incorrectly, but if their guess is too low.
                    Console.WriteLine("");
                    Console.WriteLine($"Here's a hint; the correct number is close to {favoriteNumber + 3}");//Thought of a creative way to help drop the player hints.
                    favoriteNumber++;//This makes the game much more challenging! Every time the user guesses an incorrect number that is too low, the correct number increases by 1! This would be especially evil if the hints were omitted.
                }
                else if (userInput > favoriteNumber)
                {
                    Console.WriteLine("No, that's too high.");
                    //Console.WriteLine("");
                    //Console.WriteLine($"{favoriteNumber--}");
                    Console.WriteLine("");
                    Console.WriteLine($"Here's a hint; the correct number is close to {favoriteNumber - 3}");
                    favoriteNumber--;
                }
                else
                {
                    Console.WriteLine("Yes, that's correct!");
                }//Now, one major limitation to this program that sets its capacity back is the format in which the user's input is given -- we're limiting them to just integers. If they were to type in a decimal answer, the program will terminate per an error suggesting an unhandled exception.
            }
            MoreSelectionStatements();//This tells the Main method which runs by default when the program executes, to rum the other method I just defined below before the whole program terminates.

            MoreSelectionStatementsContinued();//This is a bonus continuation to the above called method.

            CalculatorExecute();//This is a code wars based kata.//BonusStatementSelectionExercise1 (previous method title, but redacted in favor of the previously formatted kata).
        }

        static void MoreSelectionStatements()//Exercise 2
        {//There's no need to pass any parameters or args here for this method, as it's only going to print stuff to the console and execute different cases within selection statements.
            Console.WriteLine("");
            Console.WriteLine("Moving on to another selection statements exercise based on your favorite school subject....");//This format of switch statement selection has a limitation where the default case will always be selected if the user doesn't know what the selections are.
            Console.WriteLine("");
            Console.WriteLine("Press the return key to continue.");//Pressing any key doesn't work here -- enter button has to be pressed.
            Console.WriteLine("");
            Console.ReadKey();//Takes the user input in the form of any single button pressed to loop through to the next line of code -- actually, it's just the return key.
            Console.WriteLine("");
            Console.WriteLine("What would be your favored school subject?");
            string subject = Console.ReadLine();//If the user inputs an integer or numerical value as a string in this case, would, the int.Parse function be necessary in conjunction with the Console.ReadLine function?

            switch (subject.ToLower())//.ToLower enables the variable to be started with either an upper case or lower case letter, instead of differentiating between them.
            {//Super important; the.ToLower method will not work properly unless the initial string values expressed for each case condition aren't all lower cased letters -- making them start with upper cased letters will nullify the intended function of the .ToLower method.
                case "history"://It's possible to leave this string blank, and the case will still execute.
                    Console.WriteLine("Hey, it's good to know what happened in the past, especially if it's to learn from its mistakes.");
                    break;
                case "math"://It's possible to write a case that doesn't have any content, but obviously that would be pointless.
                    Console.WriteLine("Hard to live without this one! Defines everything around us.");
                    break;
                case "composition"://Can make a series of different cases for one execution.
                case "literature":
                case "english":
                    Console.WriteLine("Imperative not only within the context of communication, but also with regards to interpretation and speech.");
                    break;
                case "photography"://Can craft a series of different topics referencing the same genre of subject (in this case, art).
                case "ceramics":
                case "drama":
                case "improv":
                case "painting":
                case "drawing":
                case "animation":
                    Console.WriteLine("An underrated subject for sure; we all need an artistic outlet.");
                    break;
                case "study hall"://Case cannot utilize the '' single character reference type here.
                    Console.WriteLine("And who said dedicated free time throughout the school day was a bad thing?");
                    break;
                case "science":
                case "physics":
                case "biology":
                case "chemistry":
                    Console.WriteLine("Hey, I'm a science nerd too -- nerds unite!");
                    break;
                case "art history":
                    Console.WriteLine("Perception is reality.");
                    break;
                default:
                    Console.WriteLine("Interesting choice -- what do you like about it?");
                    break;
                    //Console.WriteLine("");//these next four lines of code won't be executed because of the break feature under each case, including the default one.
                    //Console.ReadLine();//though, perhaps a method could be written to encompass these four lines that could be set to execute when such a method is called, but only after the above method has been called and fully executed.
                    //Console.WriteLine("");
                    //Console.WriteLine("Ok.");
            }
        }

        static void MoreSelectionStatementsContinued()//bonus extension to exercise 2 (I know this is extra and deson't need to be turned in).
        {//Remember; defining methods doesn't require the syntax of the ';' at the end -- this throws the IDE into chaos with errors otherwise.
            Console.WriteLine("");//Wrote some more lines of code here to give the user closure at the end of the previously called method, regardless of what case they consequently ended up selecting.
            Console.WriteLine("Press the return key to continue.");
            Console.ReadKey();
            Console.WriteLine("Apologies if this inquiry is redundant, but what was it you liked about that subject you chose?");//This string is expressing a redundant notion in the event the default case is selected in the previous method called before this one has been executed, but otherwise serves as a nice way to prompt the user prior to the entire program terminating.
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ok.");
        }//Why is it that TC doesn't want me to incorporate the utilization of a loop? What's so bad about it?
    //
    //public static class Calculator//Can we not call the methods from other classes inside of another class?
    //{
        static double CalculatorExecute(double num1, char op, double num2)//bonus exercise 1 (I know this is extra and doesn't need to be turned in, but am formatting this entire program in this manner for easier archiving related reasons).
        {//Taken directly from codewars kata. The following block of code serves as the answer to the method and its potential class as an expressed inquiry (test), but I'm still getting errors on it in inside of this IDE (VS community).
            switch (op)//is op an abbreviation for operator?
            {//This solution passed all tests and attempts in the code wars kata -- bumped my rank up to 6 kyu.
                case '+'://I'm thinking that all of these switch - case statements could be written as if else statements as well, but would take up more scope space.
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    {
                        if (num2 == 0)
                            throw new System.ArgumentException("");
                        return num1 / num2;
                    }
                default:
                    throw new System.ArgumentException("");
                    //throw new NotImplementedException();
            }
        }
    }
}
