using System;
using System.Net.Http;
using System.Net;

namespace Weather
{
    class WeatherApp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter your zipcode");
            var zipcode = Console.ReadLine();
            var url = String.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&mode={1}&units=metric&cnt=2",zipcode,"xml");
            var Client = new HttpClient();
            var response = Client.GetAsync(url).Result;
            var responseContent = response.Content;
            string responsestring = responseContent.ReadAsStringAsync().Result;
            Console.WriteLine(responsestring);

        }
    }
}
