using System;
using System.Collections.Generic;
using System.Text;

namespace SmhiWeather
{
    public interface ISmhi
    {
        decimal CoordLat { get; }

        decimal CoordLon { get; }

        Forecast GetForecast();

        ForecastTimeSerie GetCurrentWeather();
    }
}
