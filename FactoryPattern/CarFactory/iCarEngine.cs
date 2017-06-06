using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    public interface iCarEngine
    {
        void Start();
        void Stop();
        void Accelerate();
        void Decelerate();

        string EngineName();
    }
}
