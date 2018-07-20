using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmhiWeather
{
    /// <summary>
    /// Class representing a weather parameter contained in a ForecastTimeSerie returned from SMHI's weather service.
    /// </summary>
    /// <remarks>
    /// This class is an exact mirror of the JSON response from SMHI's web service.
    /// </remarks>
    public class ForecastParameter
    {
        /// <summary>
        /// Gets or sets the name of the parameter.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the level type.
        /// </summary>
        public string levelType { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        public int level { get; set; }

        // Gets or sets the unit.
        public string unit { get; set; }

        /// <summary>
        /// Gets or sets the values.
        /// </summary>
        public decimal[] values { get; set; }

        public override string ToString()
        {
            return name + ": " + values[0] + " " + unit;
        }
    }
}
