using System;//this app actually can run without this directive....
using Newtonsoft.Json.Linq;
//utilizing that awesome alt + enter hotkey combo, when hovering the cursor over the JObject portion of the fourth line of code descending down from the main method, VSC was able to figure out that JObject is part of a predefined class within the archive that's been coded into the NuGet package that was just added here. Without having added that NuGet package, VSC would have no idea what JObject was.
using System.Threading.Tasks;
//using System.Threading;//thought this was required in order for commands or functions like Thread.Sleep(); to work? No compile errors though....
using System.Net.Http;
using System.IO;

namespace APIsAndJSON//you don't have to reinvent the wheel; others have created APIs out there -- use them. But.... where do you find them??
{

    public class Program//one of the instructors recently showed me how to create a json file from within the IDE, as opposed to doing it via an operating system interface, like Windows, and doing so by adding it to the solution file, in the same way you would as if you were to create a new class.... the benefit of its implementation here was to help define some privacy or security regarding my API key.... which could still be stored within the same variable name that I'd given it originally here in the main program cs file, but it's important that the IDE knows where to find this json file, which seems to require messing around with the solution file's csproj file.
    {
        //private static readonly HttpClient client = new HttpClient();//the HttpClient client variable was apparently not being used, so it got commented out here.
        static void Main(string[] args)
        {//Exercise #1
            Console.WriteLine("One evening, a group of three men happened upon each other, as they each sat down at their favorite table, and at their favorite bar....");
            Console.WriteLine();
            Thread.Sleep(1750);
            Console.WriteLine("Little did either of them know that they all liked the same table, at that same bar....");
            Console.WriteLine();
            Thread.Sleep(1750);
            Console.WriteLine("A dubious conversation of epic proportions was about to go down....");
            Console.WriteLine();
            Thread.Sleep(1750);
            for (var i = 10; i > 0; i--)//created a for loop here because it was easier and more efficient than making it in the other cs file, containing the class method definitions. So now, it's almost like Ron Swanson and Kanye West are having a conversation. And Chuck Norris.
            {
                QuoteGenerator.KanyeQuote();
                Thread.Sleep(3000);
                QuoteGenerator.RonQuote();
                Thread.Sleep(1750);
                QuoteGenerator.ChuckQuote();
                Thread.Sleep(6000);
            }
            Console.WriteLine();
            Console.WriteLine("- End of conversation -\n");
            Console.WriteLine();
            //weather api -- Exercise #2
            const string keyfile = "appsettings.json";//not too familiar with constant variable types, but research suggests that the purpose of a const variable type is to ensure that its contained value never changes; it always stores the same value so that others cannot necessarily alter it.
            //if (!File.Exists(keyfile))
            //{
            //    Console.WriteLine($"Current working directory: {Directory.GetCurrentDirectory()}");
            //    Console.WriteLine($"Looking for file at: {Path.GetFullPath("appsettings.json")}");
            //    Console.ReadLine();
            //}

            string keyJson = File.ReadAllText(keyfile);//it's good practice to maintain the same sort of typing format when it comes to writing and designing program and its respective variables; so, if you're starting with inferred typing for variables, then stick with it, and likewise if you're starting with explicit typing.
            Console.WriteLine("Now, begins another program.... wouldn't you like to know what the local weather forecast was in an area of your choosing?");
            Console.WriteLine();
            while (true)
            {
                string APIkey = JObject.Parse(keyJson).GetValue("APIkey")?.ToString() ?? "";//the question marks here denote the notion of nullable -- something taught in a previous module, but can be applied here even within the context of something such as a JObject class with its respective method extensions and included variables.... and the ultimate goal of making such items nullable is to help prevent them from being as likely to throw errors upon a program's execution, say at runtime (remember back when there were those assignments in earlier modules that not only discussed exception handling, but also entailed specific forms of it, where you could use iteration statements to act as checkers for potentially non-nullable inputs and if such were true, they could be converted into values of 0, before allowing them to be passed through into the remainder of the code, so as to inhibit the program from prematurely terminating or throwing an error).
                Thread.Sleep(2272);
                Console.WriteLine("Of course you would.");
                Console.WriteLine();
                Thread.Sleep(2272);
                Console.WriteLine("Please enter a zip code.");//when querying the open whether website's api for information regarding the local, current weather of a given area, a reasonable input for such would involve utilizing that region's zip code, which is acceptable to the website's intake of such queries.... but, in order to properly ask for this information of the site's API, the URL being queried has to have that zip code aspect as an inclusion within the URL itself (see the weatherUrl variable below), as well as a variable that has the API key assigned the user stored within it (authorized site access?). The original URL copied and pasted into this code didn't have the zip code query included in it; only those for geographical coordinates based on variables of latitude and longitude.... but knowing how to change that notion in an accurate syntactic manner is key to making it work the way we want it to in this case.

                string zipCode = Console.ReadLine();//it's been advised that multiple programs of a certain relevancy should be grouped together as project files within the same solution file.... as per the professional world.

                string weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIkey}";//so, as it turns out; it's perfectly fine for a URL to include fonts of multiple or differing colors, rather than all being the same font color, as many other URLs I've witnessed inside of this IDE being displayed as.... should have just tested it first, before drawing assumption.

                double temp = OpenWeatherMapAPI.GetTemp(weatherUrl);//hey, so I noticed that the URL being queried asks for imperial units -- do those equate to degrees Fahrenheit? I don't see any conversion for degrees to Fahrenheit, otherwise.

                Console.WriteLine($"\n It is currently: {temp:F1} degrees in your location.");//the /n inclusion within a string serves as a means of spacing -- almost as if one were to write another Console.WriteLine(); above this line of code, in this instance.
                Thread.Sleep(2500);
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();//this is to prevent the program from terminating prematurely -- it enables the user to at least see what the console has had printed to it, based upon their input, via the program prompt.
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Interested in finding out the weather forecast for another location?");
                Console.WriteLine();
                string userAnswer = Console.ReadLine();
                //AddSpaces(2);//for some reason, this function remains undefined, despite researched using directives that the internet says implement it within their respective archives, of which at one or more are used here, in this program.
                //AddSpaces(2);//presumably, this function is part of the System directive.
                if (userAnswer.ToLower().Trim() == "no")
                {
                    break;
                }
                Console.WriteLine();
            }
        }
        //    static void Main(string[] args)//this represents one way in which you could go about writing out the code to be executed, but it might be easier to read if we took this block of code and placed inside of a method, then called upon here inside the main method.
        //    {
        //        var client = new HttpClient();//anytime you see a question mark within a URL, that's a query (for instance, on an http styled website URL).
        //        var KanyeURL = "https://api.kanye.rest";
        //        var kanyeResponse = client.GetStringAsync(KanyeURL).Result;
        //        var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();//statically written method, because there's no instance of the class being implemented here. We're then getting (reading) the value of what's stored within "quote". Then, I'm guessing it gets converted into a string at the end. If this works as intended, then our kanyeQuote variable should be able to emulate the converted to string value of "quote".
        //        Console.WriteLine($"{kanyeQuote}");
        //    }
    }
}
