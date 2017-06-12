using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class HondaCivic : iCar
    {
        public HondaCivic()
        { }
        public decimal cost()
        {
            return 34140.0m;
        }

        public string GetComponentNames()
        {
            return "Honda Civic Sport";
        }

        public override string ToString()
        {
            return GetComponentNames();
        }
    }
}
