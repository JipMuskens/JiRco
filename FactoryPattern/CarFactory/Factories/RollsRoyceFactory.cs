using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Factories
{
    public class RollsRoyceFactory : iVehicleFactory
    {
        public iCarBody ManufactureBody()
        {
            return new Sedan();
        }

        public iCarEngine ManufactureEngine()
        {
            return new Trend7000();
        }

        public override string ToString()
        {
            return "Rolls Royce";
        }
    }
}
