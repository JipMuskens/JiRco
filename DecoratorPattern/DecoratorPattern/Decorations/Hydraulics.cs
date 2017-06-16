using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Hydraulics : TuningOptions
    {
        static public string Name { get { return "Hydraulics"; } }

        public Hydraulics(iCar car) : base(car)
        { }

        public override decimal cost()
        {
            return _car.cost() + 129.0m;
        }

        public override string GetComponentNames()
        {
            return _car.GetComponentNames() + ", hydraulics";
        }

        public override string ToString()
        {
            return GetComponentNames();
        }
    }
}
