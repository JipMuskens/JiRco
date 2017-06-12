using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DecoratorPattern
{
    public class Airco : TuningOptions
    {
        public Airco(iCar car) : base(car)
        { }

        public void TurnOn()
        { MessageBox.Show("Turning on airco!"); }
        public void TurnOff()
        { MessageBox.Show("Turning off airco!"); }

        public override decimal cost()
        {
            return _car.cost() + 150.0m;
        }

        public override string GetComponentNames()
        {
            return _car.GetComponentNames() + ", airco";
        }

        public override string ToString()
        {
            return GetComponentNames();
        }
    }
}
