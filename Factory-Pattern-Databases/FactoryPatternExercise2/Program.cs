namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool responseValidity;
            string userResponse;
            //responseValidity = string.TryParse(Console.ReadLine(), out string userResponse);//I wonder; if there's a TryParse for potential string based user inputs, is there also a TryParse method established for the vice versa? Updated; there doesn't appear to be, because TryParse throws an error if attempting to parse string types.

            do// do while loops read alright, and make sense based upon how they're written, but they're just weird....
            {
                responseValidity = true;
                Console.WriteLine("Hello. Today's your lucky day -- we're featuring an assembly of differed databases.... and you get pick one!");
                Console.WriteLine();
                Thread.Sleep(1442);
                Console.WriteLine("Specials of the day pertaining to the databases menu this evening are the following; 'list', 'sql', and 'mongo'. Of course, there's always the default selection choice....");
                Console.WriteLine();
                Thread.Sleep(1442);
                Console.WriteLine("Please enter in your choice....");
                Console.WriteLine();
                userResponse = Console.ReadLine();
                if (userResponse != "list" && userResponse != "sql" && userResponse != "mongo" && userResponse != "defunct" && userResponse != "default" && userResponse != "")//the conditionals for this if statement ended up requiring the complete opposite of the || operands I'd logically figured they'd need in order to function properly.... wonder if that's because of the data type?
                {
                    responseValidity = false;
                    Console.WriteLine("No good, you've successfully input an invalid response. Try again.");
                    Console.WriteLine();
                    Thread.Sleep(1442);
                    Console.Clear();
                }
            } while (responseValidity == false);//while responseValidity equals false, loop back to the beginning of the do while script.

            IDataAccess databaseAccess = DataAccessFactory.GetDataAccessType(userResponse);//variable type IDataAccess named databaseAccess equals the userResponse passed through the GetDataAccessType method from the DataAccessFactory static class. 
            var products = databaseAccess.LoadData();

            foreach (var product in products)
            {
                Console.WriteLine($"Name of product; {product.Name}, Product price; ${product.Price}");
            }
            Console.WriteLine();
            databaseAccess.SaveData();
        }
    }
}
