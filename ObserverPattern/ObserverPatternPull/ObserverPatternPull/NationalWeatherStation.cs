using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternPull
{
    public class NationalWeatherStation : iWeatherStation
    {
        private Weather _weather;
        private float _rainlevel;
        private float _temperature;
        private bool _isclouded;

        public float rainlevel
        {
            get { return _rainlevel; }
        }
    
        public float temperature
        {
            get { return _temperature; }
        }

        public bool isclouded
        {
            get { return _isclouded; }
        }

        public NationalWeatherStation(Weather weather)
        {
            if (weather == null)
            { throw new ArgumentNullException(); }

            _weather = weather;
            _weather.Attach(this);

            Update();
        }

        ~NationalWeatherStation()
        { _weather.Detach(this); }

        public void Update()
        {
            WeatherState state = _weather.GetState();
            _rainlevel = state.rain_in_mm;
            _isclouded = state.clouded;
            _temperature = state.temperature;
        }

        public override string ToString()
        {
            return _weather.GetState().location;
        }
    }
}
