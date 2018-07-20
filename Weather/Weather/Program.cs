using SmhiWeather;
using System;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Smhi smhi = new Smhi(59.28m, 15.21m, new TimeSpan(1, 0, 0));
            var currentWeather = smhi.GetCurrentWeather();

            Console.WriteLine("Temperature is " + currentWeather.Temperature + " degrees Celcius.");
            Console.Read();
        }
    }
}
