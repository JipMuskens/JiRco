using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ObserverPatternPull
{
    public class Weather : iWeather
    {
        private List<iWeatherStation> _stations;
        private WeatherState current_weather;
        private const int weather_change_rate = 10;
        private int weather_clouded_current_iteration = 0;
        private Timer _timer;

        private Random _random;

        public Weather(string location, int seed)
        {
            _stations = new List<iWeatherStation>();

            //TODO: error check on location object null, and empty check, if so, exception
            current_weather.location = location;
            current_weather.temperature = (float)Math.Round((new Random().NextDouble() * 10.0) + 5.0);

            _random = new Random(seed);

            _timer = new Timer();

            _timer.Elapsed += (sender, e) => WeatherUpdate(sender, e, this);

            _timer.Interval = 1000;
            _timer.Enabled = true;

            weatherUpdate();
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

        private static void WeatherUpdate(object sender, ElapsedEventArgs e, Weather weather)
        { weather.weatherUpdate(); }

        private void weatherUpdate()
        {
            

            current_weather.temperature += (float)Math.Round(_random.NextDouble()*5.0 - 2.5f, 1);

            if(current_weather.temperature < -30.0f)
            { current_weather.temperature = -30.0f; }

            if(current_weather.temperature > 55.0f)
            { current_weather.temperature = 55.0f; }

            if (++weather_clouded_current_iteration > weather_change_rate)
            {
                weather_clouded_current_iteration = 0;

                current_weather.clouded = (_random.Next() % 4 != 1);

                if (current_weather.clouded)
                {
                    current_weather.rain_in_mm = (float)((_random.Next() % 100 < 70) ? (Math.Round(_random.NextDouble() * 2.5, 1) + 0.2) : 0.0);
                }
                else
                {
                    current_weather.rain_in_mm = (float)((_random.Next() % 100 < 40) ? (Math.Round(_random.NextDouble() * 1.0, 1) + 0.1) : 0.0);
                }
            }

            Notify();
        }
    }
}
