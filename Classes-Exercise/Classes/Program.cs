namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var VehicleOne = new Vehicle();
            VehicleOne.Make = "Honda";
            VehicleOne.Model = "CR-V";
            VehicleOne.Year = 2021;
            VehicleOne.Mileage = 7;

            Console.WriteLine($"Introducing the {VehicleOne.Make} {VehicleOne.Model}, crafted in the year, {VehicleOne.Year}. I bought it brand new -- it only had {VehicleOne.Mileage} miles on it.");
            Console.WriteLine("");

            var VehicleTwo = new Vehicle();
            VehicleTwo.Make = "Mitsubishi";
            VehicleTwo.Model = "Galant";
            VehicleTwo.Year = 2009;
            VehicleTwo.Mileage = 69871;

            Console.WriteLine($"Introducing the {VehicleTwo.Make} {VehicleTwo.Model}, crafted in the year, {VehicleTwo.Year}. I bought it used -- it actually had {VehicleTwo.Mileage} miles on it.");
            Console.WriteLine("");

            var HouseOne = new House();
            HouseOne.HouseType = "Single Family";
            HouseOne.Location = "Maryland";
            HouseOne.YearBuilt = 1997;
            HouseOne.ListingPrice = 789000.97M;

            Console.WriteLine($"Featuring a large 4,000 squarefoot {HouseOne.HouseType} home, located here in the Northern {HouseOne.Location} region, built back in {HouseOne.YearBuilt}, it's just beeen listed on the market for ${HouseOne.ListingPrice}.");
            Console.WriteLine("");

            var HouseTwo = new House();
            HouseTwo.HouseType = "Town";
            HouseTwo.Location = "Virginia";
            HouseTwo.YearBuilt = 2015;
            HouseTwo.ListingPrice = 453000.67M;

            Console.WriteLine($"Featuring a large 1,800 squarefoot {HouseTwo.HouseType} home, located here in the Northern {HouseTwo.Location} region, built back in {HouseTwo.YearBuilt}, it's just beeen listed on the market for ${HouseTwo.ListingPrice}.");
            Console.WriteLine("");
        }
    }
}
