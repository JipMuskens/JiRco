using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class FingerprintScanner : iPhoneElement
    {
        public void Accept(iPhoneVisitor visitor)
        { visitor.Visit(this); }

        public int ScanFinger()
        {
            return (new Random().Next() % 30 + 10000);
        }
    }
}
