using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternPull
{
    public class EindhovenWeatherStation : iWeatherStation
    {
        private Weather _weather;
        private float _temperature;
        private bool _isclouded;

        public float temperature
        {
            get { return _temperature; }
        }

        public bool isclouded
        {
            get { return _isclouded; }
        }

        public EindhovenWeatherStation(Weather weather)
        {
            if (weather == null)
            { throw new ArgumentNullException(); }

            _weather = weather;
            _weather.Attach(this);

            Update();
        }

        ~EindhovenWeatherStation()
        {
            _weather.Detach(this);
        }

        public void Update()
        {
            WeatherState state = _weather.GetState();
            _temperature = state.temperature;
            _isclouded = state.clouded;
        }
    }
}
