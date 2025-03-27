using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string NumberofTeeth {get; set;}//int
        public bool IsColdBlooded { get; set; }
        public string SkinType { get; set; }
        public string Habitat { get; set; }

    }
}
