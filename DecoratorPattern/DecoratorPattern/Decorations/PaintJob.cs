using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class PaintJob : TuningOptions
    {
        public PaintJob(iCar car) : base(car)
        { }

        public override decimal cost()
        {
            return _car.cost() + 18.50m;
        }

        public override string GetComponentNames()
        {
            return _car.GetComponentNames() + ", paint job";
        }

        public override string ToString()
        {
            return GetComponentNames();
        }
    }
}
