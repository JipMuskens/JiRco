using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFactory
{
    public class Trend7000 : iCarEngine
    {
        public Trend7000()
        { }

        ~Trend7000()
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
            MessageBox.Show(EngineName() + " taken off");
        }

        public void Stop()
        {
            MessageBox.Show(EngineName() + " landed");
        }

        public string EngineName()
        {
            return "Rolls Royce Trend 7000";
        }

        public override string ToString()
        {
            return EngineName();
        }
    }
}
