using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    public class Coupe : iCarBody
    {
        public Coupe()
        { }

        ~Coupe()
        { }

        public bool CanFloatOnWater()
        {
            return false;
        }

        /*
         * Interior space in square cm
         */
        public double InteriorSpace()
        {
            return 500;
        }

        public bool IsEaroDynamic()
        {
            return true;
        }

        public int NumberOfWheels()
        {
            return 4;
        }

        public override string ToString()
        {
            string output = string.Format("Body type: Coupe, Floats on water: {0}, Interior space: {1} sq cm, Earodynamic: {2}, numbers of wheels: {3}",
                (CanFloatOnWater() ? "yes" : "no"),
                InteriorSpace(),
                (IsEaroDynamic() ? "yes" : "no"),
                NumberOfWheels());

            return output;
        }
    }
}
