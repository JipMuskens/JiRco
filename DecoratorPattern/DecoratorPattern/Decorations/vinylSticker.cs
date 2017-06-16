using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class VinylSticker : TuningOptions
    {
        static public readonly string Name = "VinylSticker";

        public VinylSticker(iCar car) : base(car)
        { }

        public override decimal cost()
        {
            return _car.cost() + 10.0m;
        }

        public override string GetComponentNames()
        {
            return _car.GetComponentNames() + ", vinyl sticker";
        }

        public override string ToString()
        {
            return GetComponentNames();
        }
    }
}
