using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class ToyotaAuris : iCar
    {
        public ToyotaAuris()
        { }

        public decimal cost()
        {
            return 20000.0m;
        }

        public string GetComponentNames()
        {
            return "Toyota Auris";
        }

        public override string ToString()
        {
            return GetComponentNames();
        }
    }
}
