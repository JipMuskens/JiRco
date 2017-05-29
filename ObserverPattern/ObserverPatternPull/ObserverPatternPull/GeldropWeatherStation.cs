using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternPull
{
    public class GeldropWeatherStation : iWeatherStation
    {
        private Weather _weather;
        private float _temperature;

        public float temperature
        {
            get { return _temperature; }
        }

        public GeldropWeatherStation(Weather weather)
        {
            if (weather == null)
            { throw new ArgumentNullException(); }

            _weather = weather;

            _weather.Attach(this);
        }

        ~GeldropWeatherStation()
        {
            _weather.Detach(this);
        }

        public void Update()
        {
            WeatherState state = _weather.GetState();
            _temperature = state.temperature;
        }
    }
}
