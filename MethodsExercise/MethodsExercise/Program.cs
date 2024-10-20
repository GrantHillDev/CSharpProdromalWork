namespace MethodsExercise
{
    public class Program
    {
        public static void WriteToConsole() //this method can be defined or below the scope of the Main method; it doesn't matter, so long as it's within the same class as the Main method.
        {
            Console.WriteLine("Greetings!");
            Console.WriteLine("");
            Console.WriteLine("In this exercise, we'll be taking in user input to help write a creative story.");
            Console.WriteLine("");
            Console.WriteLine("Press the return key to continue.");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Pick a name for a character.");
            var charName = Console.ReadLine(); //could also write this out as a string charName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Wonderful, our story's character's name is {charName}. What's their age?");
            var charAge = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Alright, and what sort of food allergen might {charName} have? ");
            var charFoodallergen = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Ok, and a different allergy that {charName} has?");
            var charAllergy = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"What's the allergic reaction of {charName}?");
            var charAllergicReaction = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Where should {charName} go when they're experiencing symptoms of {charAllergicReaction}?");
            var charSeekHelp = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("It ain't my bedtime just yet, but it appears it is storytime.");
            Console.WriteLine("");
            Console.WriteLine($"{charName} was a goofy velociraptor on her quest for world domination. At the youthful ripe age of {charAge} years old, she was relentless in her mission; enlisting the help of other dinosaurs.");
            Console.WriteLine("");
            Console.WriteLine($"{charName} really liked to eat, and she enjoyed consuming fresh meat despite her {charFoodallergen} allergy.... but hey, it can't be as bad as that trending gluten allergy, right?");
            Console.WriteLine("");
            Console.WriteLine($"Unfortunately, {charName} was also really allergic to {charAllergy}, and it would not only make her skin really itchy, but it'd cause her to break out in hives too!");
            Console.WriteLine("");
            Console.WriteLine($"In addition to breaking out in hives and having really itchy skin, {charName}'s allergen woes didn't end there.... sometimes if she's having a bad day she might experience {charAllergicReaction}!!!");
            Console.WriteLine("");
            Console.WriteLine($"Despite all of the adversity {charName} faced in life, she had reliable friends who could bring her to a {charSeekHelp}.");
        }

        public static int Addition(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        public static int Subtraction(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }

        public static int Multiplication(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }

        public static int Division(int numberOne, int numberTwo)
        {
            return numberOne / numberTwo;
        }

        public static int Summation(params int[] collectionofNumbers) //we've created an array of integers here, and named it.
        {
            int sum = 0; //this acts as a placeholder. This will eventually be filled with our actual sum.

            foreach (int number in collectionofNumbers) //foreach loop allows us to go through every single number inside of this collection of numbers.
            {
                sum = sum + number; //taking the sum as is (which is 0 at the moment) and then adding it to whatever the other number is.
                //sum += number; //Does the same thing as the above line of code.
            }
            return sum; //returns the value of the sum we just defined in our foreach loop, right above.
        }

        static decimal Amalgamation(params decimal[] groupofNumbers)//an amalgamation of numbers.
        {
            decimal amalgamation = 1.00m;//Set this value equal to or greater than one because anything times zero is going to equal 0.
            foreach (decimal number in groupofNumbers)
            {
                amalgamation = amalgamation * number * number * number;
            }
            return amalgamation;
        }

        static void StoryTime()//So, initially, this method's font color was a darkened yellow colored font, and querying the internet for why this was proved to be most unhelpful.
        {//However, I had a hunch that if I called this method somewhere within this program, that feature might change, to reflect the brightened yellow colored font that all of my other methods seem to have -- I was right.
            //All of my user input based variables reading the user's data and storing it for later use are listed here for reference, as I try to write a story; var charName, var charAge, var charFoodallergen, var charAllergy, var charAllergicReaction, var charSeekHelp.
            //WriteToConsole();
            //Console.WriteLine("It ain't my bedtime just yet, but it appears it is Storytime.");
            //Console.WriteLine("");
            //Console.WriteLine($"{charName}");
            //Console.WriteLine("");
            //Looks like user input data can't be called from another method in which it was stored, despite being stored into variables....
        }
        static void Main(string[] args)
        {
            WriteToConsole(); //Don't want this method to run every time I'm testing out other lines of code.
            //Console.WriteLine("");
            //Console.WriteLine("Now, we'll go ahead and implement your input into a creative story.");
            //Console.WriteLine("");
            //StoryTime();
            Console.WriteLine("");
            Console.WriteLine("This next sequence represents a second exercise -- Math Operations Methods.");
            Console.WriteLine("");
            Console.WriteLine(Addition(2, 2));//Console.WriteLine is a method, and here we're using its function to call another method, but to also print the data generated by what we instructed that method to do.
            int addedNums = Addition(2, 2);//This is just another way of writing out the same procedure as what's above; does the same thing. It does not print its data to the console, however.
            Console.WriteLine(addedNums);//Now, we're able to print that data stored within the variable, 'addedNums', just above, because we've utilized a function that does this.
            Console.WriteLine(Subtraction(2, 2));
            int subtractedNums = Subtraction(2, 2);
            Console.WriteLine(subtractedNums);
            Console.WriteLine(Multiplication(2, 2));
            Console.WriteLine(Division(2, 2));
            Console.WriteLine(Summation(7, 7, 7, 7));
            Console.WriteLine(Amalgamation(9.1m, 9.2m, 9.33m, 9.87m));
        }
    }
}
