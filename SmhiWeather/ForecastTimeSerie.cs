using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmhiWeather
{
    /// <summary>
    /// Class representing a time serie interval with a valid weather forecast. The current weather is the forecasted
    /// weather in a time serie where the valid time applies to now.
    /// </summary>
    /// <remarks>
    /// This class is an exact mirror of the JSON response from SMHI's web service.
    /// </remarks>
    public class ForecastTimeSerie
    {
        /// <summary>
        /// Gets or sets the time (in universal time) when this time serie is valid (when the weather will occur).
        /// </summary>
        public DateTime validTime { get; set; }

        /// <summary>
        /// Gets or sets the time in local time when this time serie is valid (when the weather will occur).
        /// </summary>
        public DateTime ValidLocalTime
        {
            get
            {
                return validTime.ToLocalTime();
            }
        }

        /// <summary>
        /// Gets or sets the time serie's parameters.
        /// </summary>
        public ForecastParameter[] parameters { get; set; }

        /// <summary>
        /// Gets the air pressure in hPa (value range: decimal number, one decimal). Shorthand for parameter "msl".
        /// </summary>
        public decimal AirPressure
        {
            get
            {
                ForecastParameter parameter = parameters.FirstOrDefault(p => p.name == "t");
                if (parameter != null)
                {
                    return parameter.values[0];
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets the horizontal visibility in kilometers (value range: decimal number, one decimal). Shorthand for parameter "vis".
        /// </summary>
        public decimal Visibility
        {
            get
            {
                ForecastParameter parameter = parameters.FirstOrDefault(p => p.name == "t");
                if (parameter != null)
                {
                    return parameter.values[0];
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets the wind direction in degrees (value range: integer). Shorthand for parameter "wd".
        /// </summary>
        public int WindDirection
        {
            get
            {
                ForecastParameter parameter = parameters.FirstOrDefault(p => p.name == "wd");
                if (parameter != null)
                {
                    return Convert.ToInt32(parameter.values[0]);
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets the wind speed in meters per second (value range: decimal number, one decimal). Shorthand for parameter "ws".
        /// </summary>
        public decimal WindSpeed
        {
            get
            {
                ForecastParameter parameter = parameters.FirstOrDefault(p => p.name == "ws");
                if (parameter != null)
                {
                    return parameter.values[0];
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets the air temperature in degrees Celcius (value range: decimal number, one decimal). Shorthand for parameter "t".
        /// </summary>
        public decimal Temperature
        {
            get
            {
                ForecastParameter parameter = parameters.FirstOrDefault(p => p.name == "t");
                if (parameter != null)
                {
                    return parameter.values[0];
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets the thunder probability in percent (value range: integer, 0-100). Shorthand for parameter "tstm".
        /// </summary>
        public int ThunderProbability
        {
            get
            {
                ForecastParameter parameter = parameters.FirstOrDefault(p => p.name == "tstm");
                if (parameter != null)
                {
                    return Convert.ToInt32(parameter.values[0]);
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets the mean value of total cloud cover in octas (value range: integer, 0-8). Shorthand for parameter "tcc_mean".
        /// </summary>
        public int CloudCoverTotal
        {
            get
            {
                ForecastParameter parameter = parameters.FirstOrDefault(p => p.name == "tcc_mean");
                if (parameter != null)
                {
                    return Convert.ToInt32(parameter.values[0]);
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets the mean value of low level cloud cover in octas (value range: integer, 0-8). Shorthand for parameter "lcc_mean".
        /// </summary>
        public int CloudCoverLow
        {
            get
            {
                ForecastParameter parameter = parameters.FirstOrDefault(p => p.name == "lcc_mean");
                if (parameter != null)
                {
                    return Convert.ToInt32(parameter.values[0]);
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets the mean value of medium level cloud cover in octas (value range: integer, 0-8). Shorthand for parameter "mcc_mean".
        /// </summary>
        public int CloudCoverMedium
        {
            get
            {
                ForecastParameter parameter = parameters.FirstOrDefault(p => p.name == "mcc_mean");
                if (parameter != null)
                {
                    return Convert.ToInt32(parameter.values[0]);
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets the mean value of high level cloud cover in octas (value range: integer, 0-8). Shorthand for parameter "hcc_mean".
        /// </summary>
        public int CloudCoverHigh
        {
            get
            {
                ForecastParameter parameter = parameters.FirstOrDefault(p => p.name == "hcc_mean");
                if (parameter != null)
                {
                    return Convert.ToInt32(parameter.values[0]);
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets the wind gust speed in meters per second (value range: decimal number, one decimal). Shorthand for parameter "gust".
        /// </summary>
        public int WindGustSpeed
        {
            get
            {
                ForecastParameter parameter = parameters.FirstOrDefault(p => p.name == "gust");
                if (parameter != null)
                {
                    return Convert.ToInt32(parameter.values[0]);
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets the minimum precipitation intensity in millimeters per hour (value range: decimal number, one decimal). Shorthand for parameter "pmin".
        /// </summary>
        public int PrecipitationMin
        {
            get
            {
                ForecastParameter parameter = parameters.FirstOrDefault(p => p.name == "pmin");
                if (parameter != null)
                {
                    return Convert.ToInt32(parameter.values[0]);
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets the maximum precipitation intensity in millimeters per hour (value range: decimal number, one decimal). Shorthand for parameter "pmax".
        /// </summary>
        public int PrecipitationMax
        {
            get
            {
                ForecastParameter parameter = parameters.FirstOrDefault(p => p.name == "pmax");
                if (parameter != null)
                {
                    return Convert.ToInt32(parameter.values[0]);
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets the relative humidity in percent (value range: integer, 0-100). Shorthand for parameter "r".
        /// </summary>
        public int Humidity
        {
            get
            {
                ForecastParameter parameter = parameters.FirstOrDefault(p => p.name == "r");
                if (parameter != null)
                {
                    return Convert.ToInt32(parameter.values[0]);
                }

                return 0;
            }
        }

        public override string ToString()
        {
            return validTime.ToString("yyyy-MM-dd HH:mm") + ", Temp=" + Temperature + ", Humidity=" + Humidity;
        }
    }
}
