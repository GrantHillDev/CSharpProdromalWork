using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static double GetTemp(string weatherUrl)
        {
            var client = new HttpClient();

            var response = client.GetStringAsync(weatherUrl).Result;

            var temp = double.Parse(JObject.Parse(response)["main"]?["temp"]?.ToString() ?? "0");

            return temp;
        }
    }
}
