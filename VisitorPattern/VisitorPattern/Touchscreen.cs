﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public struct TouchPoint
    {
        public double x;
        public double y;
    };
    public class TouchScreen : iPhoneElement
    {
        public void Accept(iPhoneVisitor visitor)
        { visitor.Visit(this); }

        public TouchPoint[] GetTouches()
        {
            int number_of_touches = (new Random().Next() % 10);

            TouchPoint[] touches = null;

            if (number_of_touches > 0)
            {
                touches = new TouchPoint[number_of_touches];

                Random randomPosition = new Random();

                while(--number_of_touches > 0)
                {
                    touches[number_of_touches] = new TouchPoint{
                        x = randomPosition.NextDouble(),
                        y = randomPosition.NextDouble()
                    };
                }
            }

            return touches;
        }
    }
}
