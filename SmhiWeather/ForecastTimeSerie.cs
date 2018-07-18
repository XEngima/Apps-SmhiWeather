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
        public DateTime validTime { get; set; }

        public ForecastParameter[] parameters { get; set; }

        ///// <summary>
        ///// Hämtar eller sätter temperaturen i grader Celcius.
        ///// </summary>
        public decimal t
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

        ///// <summary>
        ///// Hämtar eller sätter total molnighet. Heltal mellan 0 - 9.
        ///// </summary>
        //public int tcc { get; set; }

        ///// <summary>
        ///// Hämtar eller sätter låg molnighet. Heltal mellan 0-8 (osäkert, varför inte 0-9 so för tcc?).
        ///// </summary>
        //public int lcc { get; set; }

        ///// <summary>
        ///// Hämtar eller sätter medium molnighet. Heltal mellan 0-8 (osäkert, varför inte 0-9 so för tcc?).
        ///// </summary>
        //public int mcc { get; set; }

        ///// <summary>
        ///// Hämtar eller sätter hög molnighet. Heltal mellan 0-8 (osäkert, varför inte 0-9 so för tcc?).
        ///// </summary>
        //public int hcc { get; set; }

        ///// <summary>
        ///// Hämter eller sätter relativ luftfuktighet i procent.
        ///// </summary>
        public int r
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

        ///// <summary>
        ///// Hämter eller sätter sannolikhet för åska i procent.
        ///// </summary>
        //public int tstm { get; set; }

        ///// <summary>
        ///// Hämtar och sätter sikt i km.
        ///// </summary>
        //public decimal vis { get; set; }

        ///// <summary>
        ///// Hämtar eller sätter byvind i m/s.
        ///// </summary>
        //public decimal gust { get; set; }

        ///// <summary>
        ///// Hämtar eller sätter nederbördsintensitet, total - förmodligen i mm/h.
        ///// </summary>
        public decimal pit
        {
            get
            {
                ForecastParameter parameter = parameters.FirstOrDefault(p => p.name == "pit");
                if (parameter != null)
                {
                    return parameter.values[0];
                }

                return 0;
            }
        }

        ///// <summary>
        ///// Hämtar eller sätter nederbördsintensitet, snö - förmodligen i mm/h.
        ///// </summary>
        //public decimal pis { get; set; }

        ///// <summary>
        ///// Hämtar eller sätter nederbördstyp. 0 = ingen, 1 = snö, 2 = snöblandat regn, 3 = regn, 4 = duggregn, 5 = underkylt regn, 6 = underkylt duggregn.
        ///// </summary>
        public int pcat
        {
            get
            {
                ForecastParameter parameter = parameters.FirstOrDefault(p => p.name == "pcat");
                if (parameter != null)
                {
                    return Convert.ToInt32(parameter.values[0]);
                }

                return 0;
            }
        }

        ///// <summary>
        ///// Hämtar eller sätter lufttryck vid vid havsnivån i hPa.
        ///// </summary>
        //public decimal msl { get; set; }

        ///// <summary>
        ///// Hämtar eller sätter vindriktning i grader (0-360).
        ///// </summary>
        //public int wd { get; set; }

        ///// <summary>
        ///// Hämtar eller sätter vindhastighet i m/s.
        ///// </summary>
        //public decimal ws { get; set; }

        public override string ToString()
        {
            return validTime.ToString("yyyy-MM-dd HH:mm") + ", Temp=" + t + ", Humidity=" + r;
        }
    }
}
