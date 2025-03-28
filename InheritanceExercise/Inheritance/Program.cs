using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common



            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            //var Pelican = new Animal();//would work, but doesn't retain the properties built into the bird class.
            //var Pelican = new Bird();
            var Bird1 = new Bird();//creating an object of the bird class.
            Bird1.Name = "Pelican";
            Bird1.Description = "Early bird gets the fish";
            Bird1.TypeofBeak = "Large and narrow with a pocket";
            Bird1.NumberofTalons = 0;
            Bird1.NumberofWings = 2;
            Bird1.FeatherColor = "White";
            Bird1.NumberofHeads = 1;
            Bird1.NumberofEyes = 2;
            Bird1.NumberofEars = 2;
            Bird1.NumberofArms = 0;
            Bird1.NumberofLegs = 2;
            Bird1.NumberofTails = 1;
            Bird1.ActiveNoise = "Kaw";
            Bird1.MatingCall = "Kaw KAW";
            Bird1.FavoriteBeverage = "Sea Water";
            Bird1.FavoriteFood = "Sardines";

            var Bird2 = new Bird()//object initializer. Works without crafting a constructor inside of the class. Updated; not true.
            {
                Name = "Cock A Doodle do",
                Description = "One strange lookin' rooster",
                TypeofBeak = "Long, wide and curved downwards, like a toucan",
                NumberofTalons = 24,
                NumberofWings = 4,
                FeatherColor = "Mahogany",
                NumberofHeads = 1,
                NumberofEyes = 6,
                NumberofEars = 3,
                NumberofArms = 0,
                NumberofLegs = 3,
                NumberofTails = 2,
                ActiveNoise = "Aroo",
                MatingCall = "AROOOOOOO",
                FavoriteBeverage = "Fresh water, distilled, unsalted",
                FavoriteFood = "Millet"
            };

            var Bird3 = new Bird("Bird is the word", "Chill, relaxed, enjoying life", "straight and narrow like a swordfish", 39, 6, "Silver", 1, 4, 4, 0, 4, 3, "Yokel", "YOKEL", "Puddle water", "Bird seed");//This actually won't work unless you've pre-defined it via a custom constructor instantiated within the class its from.


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            //var Alligator = new Reptile();
            var Reptile1 = new Reptile();//creating an instance of the reptile class.
            Reptile1.Name = "Alligator";
            Reptile1.Description = "Fearsome carnivorous beast";
            Reptile1.Habitat = "Swamp";
            Reptile1.IsColdBlooded = true;
            Reptile1.SkinType = "Dense Scales";
            Reptile1.NumberofTeeth = "Lots";
            Reptile1.NumberofHeads = 1;
            Reptile1.NumberofEyes = 2;
            Reptile1.NumberofEars = 2;
            Reptile1.NumberofArms = 0;
            Reptile1.NumberofLegs = 4;
            Reptile1.NumberofTails = 1;
            Reptile1.ActiveNoise = "Growl";
            Reptile1.MatingCall = "Grunt";
            Reptile1.FavoriteFood = "Everything";
            Reptile1.FavoriteBeverage = "Murky Swamp Water";

            var peanutGallery = new Animal[] { Bird1, Bird2, Bird3, Reptile1 };//because of how I set up and defined this base parent class, printing all of its defined properties to the console will not yield a very clear or understandable set of data -- we don't know who or what these printed property values belong to.... it'll just be a whole bunch of statistics for otherwise unknown specimen.

            //foreach (var animal in peanutGallery)
            //{
            // Console.WriteLine("Introducing some new members of our featured audience for the local circus happening this evening.");
            //Console.WriteLine("");
            //Console.WriteLine($"{animal.NumberofHeads}{animal.NumberofEyes}{Bird1.Name}");//{animal.Name} this doesn't work here because the Name property was never defined in the Animal class's blueprint.
            //}

            var peanutGallery1 = new Bird[] { Bird1, Bird2, Bird3 };

            Console.WriteLine("Introducing some new winged members of our featured audience for the local circus happening this evening.");

            foreach (var animal in peanutGallery1)//here, I've discovered that utilizng the inheritance based classes to print their respective property stored data to the console is  much more effective and efficient way of detailing them, so that their respetive defined properties are represerntaive of each of them exclusive rto each other.
            {
                Console.WriteLine("");
                Console.WriteLine($"A bird species by nature, the {animal.Name} is a {animal.Description} kind of specimen, with a {animal.TypeofBeak} type of beak, and it sports {animal.NumberofTalons} different talons on its feet, but it only grew {animal.NumberofWings} wings which do actually enable it to fly. The color of its feathers bears a {animal.FeatherColor} hue, even though it only has {animal.NumberofHeads} head on its shoulders, with {animal.NumberofEyes} eyes in it, and it listens with {animal.NumberofEars} different ears! Unfortunately, the {animal.Name} only has {animal.NumberofArms} arms in total, but it did come with a set of {animal.NumberofLegs} legs, so it can waddle its way around real good. The {animal.Name} only has {animal.NumberofTails} or more tails, but it does tend to utter a {animal.ActiveNoise} noise to communicate with other {animal.Name}s, but when it really wants to be heard it can {animal.MatingCall} at will. The {animal.Name}'s favorite substance to drink is {animal.FavoriteBeverage}, which may or may not benefit a healthy diet, though it also enjoys eating some {animal.FavoriteFood} in its spare time when it gets hungry.");//{animal.Name}this proeperty works down here because it was already defined in the Bird class's properties.
                Console.WriteLine("");
            }

            var peanutGallery2 = new Reptile[] { Reptile1 };//could actually just print this object's property data out to the coinsole without the use of an array, because there's only one such instance of its class.... but hey, practice makes perfect.

            Console.WriteLine("Introducing some new cold blooded members of our featured audience for the local circus happening this evening.");

            foreach (var animal in peanutGallery2)
            {
                Console.WriteLine("");
                Console.WriteLine($"A reptilian species in nature, the {animal.Name} is a {animal.Description} kind of specimen, featuring {animal.NumberofTeeth} of razor sharp teeth in its mouth, but is it cold blooded? {animal.IsColdBlooded}. It never grew any wings, but it did manifest a {animal.SkinType} skin type, which might come in handy when sitting in a {animal.Habitat} all day. Boy, that {animal.Name} sure is spooky to look at, even though it only has {animal.NumberofHeads} head on its shoulders, with {animal.NumberofEyes} eyes in it, and it listens with {animal.NumberofEars} different ears! Unfortunately, the {animal.Name} only has {animal.NumberofArms} arms in total, but it did come with a set of {animal.NumberofLegs} legs, so it can waddle its way around real good. The {animal.Name} only has {animal.NumberofTails} or more tails, but it does tend to utter a {animal.ActiveNoise} noise to communicate with other {animal.Name}s, but when it really wants to be heard it can {animal.MatingCall} at will. The {animal.Name}'s favorite substance to drink is {animal.FavoriteBeverage}, which may or may not benefit a healthy diet, though it also enjoys eating just about {animal.FavoriteFood} in its spare time when it gets hungry.");
                Console.WriteLine("");
            }
        }
    }
}
