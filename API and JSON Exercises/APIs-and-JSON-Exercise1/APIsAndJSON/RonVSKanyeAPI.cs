using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices.JavaScript;

namespace APIsAndJSON;//are uri and url the same thing? No; uri = Uniform Resource Identifier. A string of characters used to uniquely identify a resource, such as a web page, image, or document. It provides a way to distinguish one resource from another, either by its name, location, or both. 
//url = Uniform Resource Locator. A specific type of URI that not only identifies a resource but also provides the means to locate it by specifying its access mechanism (e.g., HTTP, FTP).
public class QuoteGenerator//RonVSKanyeVSChuckAPI
{
    public static void KanyeQuote()
    {
        var client = new HttpClient();//storing the internet website address format inside of the variable client.
        var KanyeURL = "https://api.kanye.rest";//storing the actual web address of the Kanye quotes API.
        var kanyeResponse = client.GetStringAsync(KanyeURL).Result;//storing the result of parsing the Kanye quotes API inside of the variable kanyeResponse, with the help of variable client defining the format of the web address.
        var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();//statically written method, because there's no instance of the class being implemented here. We're then getting (reading) the value of what's stored within "quote". Then, I'm guessing it gets converted into a string at the end. If this works as intended, then our kanyeQuote variable should be able to emulate the converted to string value of "quote".
        Console.WriteLine(" ");
        Console.WriteLine($"Kanye Says: {kanyeQuote}.");
        Console.WriteLine("----------------------------------");
    }

    public static void RonQuote()
    {
        var client = new HttpClient();
        var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
        var ronResponse = client.GetStringAsync(ronURL).Result;
        var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();//because the API associated with Ron Swanson's quotes comes in the format of arrays, we have to use a different parsing technique in order to parse each index (json format) of it, and then properly segregate them from each other, after they've each been converted into strings.
        Console.WriteLine(" ");
        Console.WriteLine($"Ron Retorts: {ronQuote}");
        Console.WriteLine("----------------------------------");
    }

    public static void ChuckQuote()
    {
        var client = new HttpClient();
        var chuckURL = "https://api.chucknorris.io/jokes/random?category=science";//the api had you pick a category if you chose to, but you had to reformat the url address to reflect what that selected category was.
        var chuckResponse = client.GetStringAsync(chuckURL).Result;
        var chuckQuote = JObject.Parse(chuckResponse).GetValue("value").ToString();//had to change the value of GetValue to "value" from quotes because of the way in which the api had its json material formatted (referenced). Otherwise, you'll get a runtime error.
        Console.WriteLine(" ");
        Console.WriteLine($"Chuck Blurts: {chuckQuote}");
        Console.WriteLine("----------------------------------");
    }//https://api.chucknorris.io/jokes/random //don't use this one!
}//https://api.chucknorris.io/jokes/random?category=science
