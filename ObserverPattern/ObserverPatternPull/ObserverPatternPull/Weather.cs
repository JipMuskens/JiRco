using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternPull
{
    public class Weather : iWeather
    {
        private List<iWeatherStation> _stations;
        private WeatherState current_weather;

        public Weather(string location)
        {
            _stations = new List<iWeatherStation>();

            //TODO: error check on location object null, and empty check, if so, exception
            current_weather.location = location;
        }

        public void Attach(iWeatherStation station)
        {
            if (station != null)
            {
                if (!_stations.Contains(station))
                { _stations.Add(station); }
            }
        }

        public void Detach(iWeatherStation station)
        {
            _stations.Remove(station);
        }

        public void Notify()
        {
            foreach (var station in _stations)
            {
                station.Update();
            }
        }

        public WeatherState GetState()
        {
            return current_weather;
        }
    }
}
