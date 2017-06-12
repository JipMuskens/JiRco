using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class TuningOptions : iCar
    {
        protected iCar _car;
        public TuningOptions(iCar car)
        {
            if(car == null)
            { throw new ArgumentNullException("car is null"); }

            _car = car;
        }

        abstract public decimal cost();
        abstract public string GetComponentNames();
    }
}
