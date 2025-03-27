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
            Bird1.Description = "Early bird gets the fish.";
            Bird1.TypeofBeak = "Large and narrow with a pocket.";
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

            var Bird2 = new Bird()//object initializer. Works without crafting a constructor inside of the class.
            {
                Name = "Cock A Doodle do",
                Description = "One strange lookin' rooster.",
                TypeofBeak = "Long, wide and curved downwards, like a toucan.",
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
                FavoriteBeverage = "Fresh water, distilled, unsalted.",
                FavoriteFood = "Millet"
            };

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            //var Alligator = new Reptile();
            var Reptile1 = new Reptile();//creating an instance of the reptile class.
            Reptile1.Name = "Alligator";
            Reptile1.Description = "Fearsome carnviorus beast.";
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
        }
    }
}
