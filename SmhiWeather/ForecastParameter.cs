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
        public string name { get; set; }
        public string levelType { get; set; }
        public int level { get; set; }
        public string unit { get; set; }
        public decimal[] values { get; set; }

        public override string ToString()
        {
            return name + ": " + values[0];
        }
    }
}
