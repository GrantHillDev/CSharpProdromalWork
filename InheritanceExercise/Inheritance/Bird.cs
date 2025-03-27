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
        //public Bird()//useless.
        //{

        //}
        //public Bird(string name, string description, string typeofBeak, int numberofTalons, int numberofWings, string featherColor)//custom constructor.
        //{
        //    Name = name;
        //    Description = description;
        //    TypeofBeak = typeofBeak;
        //    NumberofTalons = numberofTalons;
        //    NumberofWings = numberofWings;
        //    FeatherColor = featherColor;
        //}
    }
    
}
