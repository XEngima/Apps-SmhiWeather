using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmhiWeather
{
    /// <summary>
    /// Class representing forecasted weather. It basically contains a list of time series with forecasted
    /// weather for different times in the future.
    /// </summary>
    /// <remarks>
    /// This class is an exact mirror of the JSON response from SMHI's web service.
    /// </remarks>
    public class Forecast
    {
        public DateTime referenceTime { get; set; }

        public ForecastTimeSerie[] timeseries { get; set; }
    }
}
