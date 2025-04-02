using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name = "Refrigerator", Price = 972.99 },
            new Product(){Name = "Mini-Fridge", Price = 364.99 },
            new Product(){Name = "Six Heating Element Induction Stovetop", Price = 3199.99 },
            new Product(){Name = "1.7 Cubic Metered Digital Microwave", Price = 189.99 },
            new Product(){Name = "Bug Spray 24 Oz", Price = 6.99 },
            new Product(){Name = "24-Pack of Single-Play toilet Paper", Price = 18.99 },
            new Product(){Name = "Steel Two-Handed Maul Extra Large", Price = 83.99 },
            new Product(){Name = "Rubber One-Handed Hammer", Price = 23.99 },
            new Product(){Name = "Medium Sized Screw Driver", Price = 8.99 },
            new Product(){Name = "SPF 39 Spray-On Sunscreen 16 Oz", Price = 3.99 },
            new Product(){Name = "Crazy Wild Weed Killer 20 Oz", Price = 11.99 },
            new Product(){Name = "Hydraulic Manual Jack-2 Ton Capacity", Price = 271.99 },
        };
        public List<Product> LoadData()
        {
            Console.WriteLine($"We're now reading data from the Mongo data archive.");
            Console.WriteLine();
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"We're now saving data to the Mongo database.");
            Console.WriteLine();
        }
    }
}
