using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternPull
{
    public class AmsterdamWeatherStation : iWeatherStation
    {
        private Weather _weather;
        private float _rainlevel;
        private bool _isclouded;

        public float rainlevel
        {
            get { return _rainlevel; }
        }

        public bool isclouded
        {
            get { return _isclouded; }
        }

        public AmsterdamWeatherStation(Weather weather)
        {
            if (weather == null)
            { throw new ArgumentNullException(); }

            _weather = weather;

            _weather.Attach(this);
        }

        ~AmsterdamWeatherStation()
        {
            _weather.Detach(this);
        }

        public void Update()
        {
            WeatherState state = _weather.GetState();
            _rainlevel = state.rain_in_mm;
            _isclouded = state.clouded;
        }
    }
}
