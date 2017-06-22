using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitorPattern
{
    /* Pre:
     * Simulates a diagnostics program that checks the components by its interfaces
     */
    public class PhoneDiagnosticsVisitor : iPhoneVisitor
    {
        /*  Pre:
         *  Camera is required to be implemented due to its interface.
         *  This class does not support operating on Camera.
         *  (This shows that you must implement all objects of the interface even if not in use OR require a new interface).
         */
        public void Visit(Camera cam)
        {
            //Picture p = cam.TakePicture();
            MessageBox.Show("Diagnostics: Does nothing here..");
        }

        /* Pre:
         * Shows the scanner's result
         */
        public void Visit(FingerprintScanner scanner)
        {
            int id = scanner.ScanFinger();
            MessageBox.Show("Diagnostics: received identity from scanner: " + id);
        }

        /* Pre:
         * Produce a frequency to see if the speaker works
         */
        public void Visit(Speaker speaker)
        {
            speaker.ProduceFrequency(1000);
        }

        /* Pre:
         *  Checks if points are detected.
         */
        public void Visit(Touchscreen ts)
        {
            TouchPoint[] points = ts.GetTouches();

            if(points.Length == 0)
            {
                MessageBox.Show("Diagnostics: Couldn't find any points from touch screen!");
            }
            else
            {
                MessageBox.Show("Diagnostics: Could find points: " + points.Length);
            }
        }

        public override string ToString()
        {
            return "Operator : Diagnostics";
        }
    }
}
