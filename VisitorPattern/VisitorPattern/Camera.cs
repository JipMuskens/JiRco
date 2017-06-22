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
        /*  Returns the coverage in channel in random percentage
         */
        public double Coverage(picture_channel_type channel)
        {
            return new Random().NextDouble() % 100.0;
        }
    };

    public class Camera : iPhoneElement
    {
        public void Accept(iPhoneVisitor visitor)
        { visitor.Visit(this); }

        public Picture TakePicture()
        { return new Picture(); }
    }
}
