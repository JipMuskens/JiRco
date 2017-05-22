using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternPull
{
    public interface iWeather
    {
        void Attach(iWeatherStation station);
        void Detach(iWeatherStation station);
        void Notify();
    }
}
