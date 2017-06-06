using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFactory
{
    public class e1LR_GUE : iCarEngine
    {
        public e1LR_GUE()
        { }

        ~e1LR_GUE()
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
            return "Toyota 1LR-GUE";
        }
        public override string ToString()
        {
            return EngineName();
        }
    }
}
