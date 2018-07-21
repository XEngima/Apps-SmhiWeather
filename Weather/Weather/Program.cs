using SmhiWeather;
using System;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize an SMHI object for Stockholm
            Smhi smhi = new Smhi(60.68m, 17.14m);

            var currentWeather = smhi.GetCurrentWeather();

            Console.WriteLine("Weather in Stockholm: " + currentWeather);
            Console.Read();
        }
    }
}
