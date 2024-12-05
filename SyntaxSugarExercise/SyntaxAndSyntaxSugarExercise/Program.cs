
namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running a program that converted explicitly typed variables into inferred types, and utilized string interpolation, with a ternary operator.");
            Console.WriteLine("");
            //int answer = 4;
            var answer = 4;//changed explicitly typed variable to inferred type.
            //string response;//there's nothing written here in this original block of code that tells the program to print something to the console.... so how's a user supposed to know what the program's doing?
            var response = (answer < 9) ? $"{answer} is less than nine." : $"{answer} is greater than nine.";//instance of a ternary operator expressing a condition with two different outcomes depending on what the value of its variable is.
            Console.WriteLine(response);//This will at least print something to the console, telling us what the program is doing. it appears as though the $ {} syntax doesn't necessarily require the function of Console.WriteLine to be called in order to be executed.
            //if (answer < 9)
            //{
                //response = answer + " is less than nine.";
                //response = Console.WriteLine($"{answer} is less than nine.");//instance of string interpolation converting above line of code.
            //}
            //else
            //{
                //response = answer + " is greater than or equal to nine.";
            //}
            Console.WriteLine("");
            Console.WriteLine("Please press enter to continue.");
            Console.ReadKey();
            Console.WriteLine("");
            MoreSyntaxSugar();
        }

        static void MoreSyntaxSugar()
        {
            Console.WriteLine("Here, we'll run the same code built into the main method, but now with user input -- please select a number.");
            Console.WriteLine("");
            var input = double.Parse(Console.ReadLine());//more specific than int.Parse, and remember to implement the .Parse method in tandem with the Console.ReadLine method especially when it comes to user input so as to avoid more potential errors being encountered depending on what the user enters as a variable into the program.
            Console.WriteLine("");//pressing the return key during user input instances throws an error.
            var reply = (input < 9) ? $"{input} is less than nine." : $"{input} is greater than nine.";
            Console.WriteLine(reply);//it's tempting to want to utilize string interpolation here, where the 'reply' variable could consequently be expressed as a string by way of the $ {} syntax, but expressing the 'reply' variable by itself and without a type is easier.
        }
    }
}
