using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class Product//guessing that because this class's access modifier is public, that its defined members/properties can be accessed by any other class seeking to use them within the program, without having to necessarily inherit from said class.
    {
        public string Name { get; set; } = "";//for some reason, VS Community was bugging me to ensure that this property had a non-null value when exiting the constructor.... so I gave it a placeholder to make it happy.
        public double Price { get; set; }
    }
}
