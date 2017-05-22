using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternPull
{
    public struct WeatherState
    {
        public float temperature;
        public float rain_in_mm;
        public bool clouded;
        public string location;
    }
}
