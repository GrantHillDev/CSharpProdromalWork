using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class DefunctDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name = "Derp", Price = 2.66 },
            new Product(){Name = "Derpity", Price = 1204.57575757 },
            new Product(){Name = "Derped", Price = -2532.1111 },
            new Product(){Name = "Derpragious", Price = -6040.07 },
            new Product(){Name = "Out of this Derp", Price = -81917.99 },
            new Product(){Name = "HerpaDerp", Price = -4.49 },
            new Product(){Name = "HerptyDerp", Price = 15.777777777 },
            new Product(){Name = "Derptastic", Price = 129347856239407.901832654903241856 },
            new Product(){Name = "Derp Much?", Price = 901247124712471247.0000 },
            new Product(){Name = "What is the value of Derp", Price = 11691.44444444444 },
            new Product(){Name = "How to Derp", Price = 0.76 },
            new Product(){Name = "DerpaDerp", Price = 314.01 },
        };
        public List<Product> LoadData()
        {
            Console.WriteLine($"We're now reading data from the Defunct data archive.");
            Console.WriteLine();
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"We're now saving this data to the Defunct database.");
            Console.WriteLine();
        }
    }
}
