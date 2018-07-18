using SmhiWeather;
using System;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Smhi smhi = new Smhi(59.29m, 15.22m, new TimeSpan(1, 0, 0));
            var currentWeather = smhi.GetCurrentWeather();

            Console.WriteLine("Temperature is " + currentWeather.t + " degrees Celcius.");
            Console.Read();
        }
    }
}
