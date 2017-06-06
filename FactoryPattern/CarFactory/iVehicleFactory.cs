﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    public interface iVehicleFactory
    {
        iCarEngine ManufactureEngine();
        iCarBody ManufactureBody();
    }
}
