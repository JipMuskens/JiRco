using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class FingerprintScanner : iPhoneElement
    {
        readonly static int scanIdentityFloorBase = 10000;
        readonly static int scanIdentityRange = 30;

        public void Accept(iPhoneVisitor visitor)
        { visitor.Visit(this); }

        public int ScanFinger()
        {
            return (new Random().Next() % scanIdentityRange + scanIdentityFloorBase);
        }

        public override string ToString()
        {
            return "Fingerprint scanner";
        }
    }
}
