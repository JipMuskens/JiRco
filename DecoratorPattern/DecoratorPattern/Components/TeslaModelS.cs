using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class TeslaModelS : iCar
    {
        public TeslaModelS()
        { }
        public decimal cost()
        {
            return 82500.0m;
        }

        public string GetComponentNames()
        {
            return "Tesla Model S75";
        }

        public override string ToString()
        {
            return GetComponentNames();
        }
    }
}
