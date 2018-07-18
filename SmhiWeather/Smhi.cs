using System;
using System.Linq;
using System.Net;
using System.IO;
using Newtonsoft.Json;

/// <summary>
/// A class representing the SMHI service that can be asked for the weather forecast.
/// For SMHI's own documentation on weather parameters, see https://opendata.smhi.se/apidocs/metfcst/parameters.html.
/// </summary>
namespace SmhiWeather
{
    public class Smhi
    {
        private readonly decimal _coordLat = 0;
        private readonly decimal _coordLon = 0;
        private readonly TimeSpan _refreshInterval = new TimeSpan(1, 0, 0);
        private Forecast _cachedForecast = null;
        private DateTime _lastRequestUtcTime = DateTime.MinValue;

        public Smhi(decimal lat, decimal lon, TimeSpan refreshInterval)
        {
            _coordLat = lat;
            _coordLon = lon;
            _refreshInterval = refreshInterval;
        }

        public Forecast GetForecast()
        {
            if (_cachedForecast == null || _lastRequestUtcTime + _refreshInterval < DateTime.UtcNow)
            {
                string lat = _coordLat.ToString("0.00").Replace(",", ".");
                string lon = _coordLon.ToString("0.00").Replace(",", ".");
                string uri = $"http://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/{lon}/lat/{lat}/data.json";
                HttpWebRequest webRequest = WebRequest.CreateHttp(uri);

                using (var webResponse = (HttpWebResponse)webRequest.GetResponse())
                using (var reader = new StreamReader(webResponse.GetResponseStream()))
                {
                    //JavaScriptSerializer js = new JavaScriptSerializer();
                    string sJson = reader.ReadToEnd();
                    //var forecast = (Forecast)js.Deserialize(sJson, typeof(Forecast));

                    Forecast forecast = JsonConvert.DeserializeObject<Forecast>(sJson);

                    _lastRequestUtcTime = DateTime.UtcNow;
                    _cachedForecast = forecast;
                    return forecast;
                }
            }
            else
            {
                return _cachedForecast;
            }
        }

        public ForecastTimeSerie GetCurrentWeather()
        {
            DateTime utcNow = DateTime.UtcNow;
            Forecast forecast = GetForecast();

            foreach (var timeSerie in forecast.timeseries.OrderBy(ts => ts.validTime))
            {
                var universalTime = timeSerie.validTime.ToUniversalTime();
                var localTime = timeSerie.validTime.ToLocalTime();

                if (universalTime.AddMinutes(30) > utcNow)
                {
                    return timeSerie;
                }
            }

            return null;
        }
    }
}
