using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFactory
{
    public class EK21Engine : iCarEngine
    {
        public EK21Engine()
        { }

        ~EK21Engine()
        { }

        public void Accelerate()
        {
            MessageBox.Show(EngineName() + " accelerated");
        }

        public void Decelerate()
        {
            MessageBox.Show(EngineName() + " decelerated");
        }

        public void Start()
        {
            MessageBox.Show(EngineName() + " started");
        }

        public void Stop()
        {
            MessageBox.Show(EngineName() + " stopped");
        }

        public string EngineName()
        {
            return "Subaru EK21";
        }
        public override string ToString()
        {
            return EngineName();
        }
    }
}
