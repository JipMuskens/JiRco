using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitorPattern
{
    public class Speaker : iPhoneElement
    {
        public void Accept(iPhoneVisitor visitor)
        { if (visitor != null) visitor.Visit(this); }

        public void ProduceFrequency(int frequency)
        { MessageBox.Show("Speakers are now producing a frequency of " + frequency + " Hz"); }

        public override string ToString()
        {
            return "Speaker";
        }
    }
}
