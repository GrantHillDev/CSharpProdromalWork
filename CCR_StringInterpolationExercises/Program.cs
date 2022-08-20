using System;

namespace CCR_StringInterpolationExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here we are with the CCR/Best Practices Exercise.");
            Console.WriteLine("");
            Console.WriteLine("We have four variables which each equal a specific value. When added together, we will get a new value.");
            Console.WriteLine("");
            int firstnumber = 1; int secondnumber = 2; int thirdnumber = 3; int fourthnumber = 4;
            if (firstnumber + secondnumber + thirdnumber + fourthnumber == 10) Console.WriteLine("Your total for these four variables is, 10.");
            Console.WriteLine("");
            Console.WriteLine("Else, if these four variables don't add up to their intended new value, we will get a message suggesting failure.");
            Console.WriteLine("");
            if (firstnumber + secondnumber + thirdnumber - fourthnumber != 10)  Console.WriteLine("Oh no! Your total for these four variables does not equal 10!");
            Console.WriteLine("");
            Console.WriteLine("The above two phrases were written in a condensed coding format, considered not to be a best practice, or CCR.");
            Console.WriteLine("");
            Console.WriteLine("We will repeat the same coding capacity, but with better 'readability', or CCR.");
            Console.WriteLine("");
            var firstNumber = 1;
            var secondNumber = 2;
            var thirdNumber = 3;
            var fourthNumber = 4;
            if (firstNumber + secondNumber + thirdNumber + fourthNumber == 10)
            {
                Console.WriteLine("Your total for these four variables is, 10");
                Console.WriteLine("");
                Console.WriteLine("Else, if these four variables don't add up to their intended new value, we will get a message suggesting failure.");
            }
            if (firstNumber + secondNumber + thirdNumber - fourthNumber != 10)
            {
                Console.WriteLine("");
                Console.WriteLine("Oh no! Your total for these four variables does not equal 10!");
                Console.WriteLine("");
            }

            Console.WriteLine("Now, onto the String Interpolation Exercise.");
            Console.WriteLine("");
            string npcName = "Buddy";
            string npcPetName = "Bud";
            string npcFavoriteSnack = "Bud Light";
            Console.WriteLine("Hey, {0}! I heard you had a big ol' pup named, {1}, how are they doing? I also heard that their favorite snack was {2}, is that right?", npcName, npcPetName, npcFavoriteSnack);
            Console.WriteLine("");
            Console.WriteLine("The above statement is expressed through a 'composite' coding format. The next statement will be expressed through a 'string interpolation' coding format.");
            Console.WriteLine("");
            Console.WriteLine($"Hello, {npcName}! I heard you had a big ol' pup named, {npcPetName}, how are they doing? I also heard that their favorite snack was {npcFavoriteSnack}, is that right?");
        }
    }
}
