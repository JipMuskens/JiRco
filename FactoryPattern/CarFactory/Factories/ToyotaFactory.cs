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
            return new Cabrio();
        }

        public iCarEngine ManufactureEngine()
        {
            return new e1LR_GUE();
        }

        public override string ToString()
        {
            return "Toyota";
        }
    }
}
