using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string TypeofBeak { get; set; }
        public int NumberofTalons { get; set; }
        public int NumberofWings { get; set; }
        public string FeatherColor { get; set; }
        public Bird()//useless. Joking -- this constructor is needed to instantiate the second object of this class, in the form of an object initializer.
        {

        }
        public Bird(string name, string description, string typeofbeak, int numberoftalons, int numberofwings, string feathercolor, int numberofHeads, int numberofEyes, int numberofEars, int numberofArms, int numberofLegs, int numberofTails, string activeNoise, string matingCall, string favoriteBeverage, string favoriteFood)//custom constructor.
        {
            Name = name;//name = name;//make certain not to have the argument be typed in exactly the same as its corresponding property -- else, the computer thinks you're trying to mess around with it, and will assume that an assignment was made to the same variable.
            Description = description;
            TypeofBeak = typeofbeak;
            NumberofTalons = numberoftalons;
            NumberofWings = numberofwings;
            FeatherColor = feathercolor;//feathercolor//also make sure that each property defined for this custom constructor matches the actual class's property and how it was written, or else an error will get thrown at you that suggests the property in question doesn't exist within its current context.
            NumberofHeads = numberofHeads;
            NumberofEyes = numberofEyes;
            NumberofEars = numberofEars;
            NumberofArms = numberofArms;
            NumberofLegs = numberofLegs;
            NumberofTails = numberofTails;
            ActiveNoise = activeNoise;
            MatingCall = matingCall;
            FavoriteBeverage = favoriteBeverage;
            FavoriteFood = favoriteFood;
        }
    }

}
