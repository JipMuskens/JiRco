using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Factories
{
    public class SubaruFactory : iVehicleFactory
    {
        public iCarBody ManufactureBody()
        {
            return new Coupe();
        }

        public iCarEngine ManufactureEngine()
        {
            return new EK21();
        }
        public override string ToString()
        {
            return "Subaru";
        }
    }
}
