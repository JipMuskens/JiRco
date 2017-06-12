using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public interface iCar
    {
        /*
         * Is a assembled list of component names.
         */
        string GetComponentNames();

        /*
         *  Cost in euros
         */
        Decimal cost();
    }
}
