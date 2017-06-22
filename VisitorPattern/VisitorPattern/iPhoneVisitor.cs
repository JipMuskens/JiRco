using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public interface iPhoneVisitor
    {
        void Visit(Camera cam);
        void Visit(FingerprintScanner scanner);
        void Visit(Speaker speaker);
        void Visit(TouchScreen ts);
    }
}
