using System;
using System.Collections.Generic;
using System.Text;

namespace SmhiWeather
{
    public interface IShmi
    {
        decimal CoordLat { get; }

        decimal CoordLon { get; }

        Forecast GetForecast();

        ForecastTimeSerie GetCurrentWeather();
    }
}
