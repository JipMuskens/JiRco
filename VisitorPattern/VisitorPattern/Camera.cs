using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public enum picture_channel_type
    {
        red,
        blue,
        green,
        alpha
    }
    public struct Picture
    {
        readonly static double noise = 10.0;//90% is simulated data, 10% is noise
        /*  Pre:
         *  Returns the coverage in channel in random percentage
         */
        public double Coverage(picture_channel_type channel)
        {
            return new Random().NextDouble() * (100.0 - noise) + noise;
        }
    };

    public class Camera : iPhoneElement
    {
        public void Accept(iPhoneVisitor visitor)
        { if (visitor != null) visitor.Visit(this); }

        public Picture TakePicture()
        { return new Picture(); }

        public override string ToString()
        {
            return "Camera";
        }
    }
}
