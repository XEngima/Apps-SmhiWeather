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
        /// <summary>
        /// Gets or sets the univeral time for when the forecast was calculated (the start time for the forecast).
        /// </summary>
        public DateTime referenceTime { get; set; }

        /// <summary>
        /// Gets the local time for when the forecast was calculated (the start time for the forecast).
        /// </summary>
        public DateTime ReferenceTimeLocal
        {
            get
            {
                return referenceTime.ToLocalTime();
            }
        }

        /// <summary>
        /// Gets or sets the time series that descript the weather forecast for each time period. Hourly at first, then with greater and greater time interval.
        /// </summary>
        public ForecastTimeSerie[] timeseries { get; set; }

        public override string ToString()
        {
            return ReferenceTimeLocal.ToString("yyyy-MM-dd HH:mm");
        }
    }
}
