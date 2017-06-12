using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Factories
{
    public class ToyotaFactory : iVehicleFactory
    {
        public iCarBody ManufactureBody()
        {
            return new CabrioBody();
        }

        public iCarEngine ManufactureEngine()
        {
            return new e1LR_GUEEngine();
        }

        public override string ToString()
        {
            return "Toyota";
        }
    }
}
