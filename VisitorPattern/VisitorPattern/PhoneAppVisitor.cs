﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitorPattern
{
    public struct PersonIdentity
    {
        public int identity;
        public string name;
    }

    /* Pre:
     * PhoneAppVisitor simulates some functions possibly found in mobile phone applications
     */
    public class PhoneAppVisitor : iPhoneVisitor
    {
        private PersonIdentity[] PersonIdentities;
        public PhoneAppVisitor()
        {
            PersonIdentities = new PersonIdentity[]
            {
                new PersonIdentity{ identity = 10000, name = "Jip Musketier" },
                new PersonIdentity{ identity = 10005, name = "Marco shrek" },
                new PersonIdentity{ identity = 10010, name = "Wouter Whatsitsname" },
                new PersonIdentity{ identity = 10015, name = "Andre Wazig" },
                new PersonIdentity{ identity = 10020, name = "Maarten Glutenboii" },
                new PersonIdentity{ identity = 10025, name = "Evert Cozmo" },
                new PersonIdentity{ identity = 10030, name = "Freddy Wrong" },
            };
        }

        /* Pre:
         * Expects a photo of a person's head that is tinted red
         */
        public void Visit(Camera cam)
        {
            Picture p = cam.TakePicture();

            double redness = p.Coverage(picture_channel_type.red);

            if (redness < 50)
            {
                MessageBox.Show("Expected to see a red-ish face");
            }
            else
            {
                MessageBox.Show("Detected red-ish face!");
            }
        }

        /*  Pre:
         *  Expects a fingerprint for person recognition
         */
        public void Visit(FingerprintScanner scanner)
        {
            int id = scanner.ScanFinger();
            PersonIdentity recognisedPerson = new PersonIdentity { identity = 0, name = "" };

            for(int i = 0; i < PersonIdentities.Length; i++)
            {
                if(PersonIdentities[i].identity == id)
                {
                    recognisedPerson = PersonIdentities[i];
                    break;
                }
            }

            if(recognisedPerson.identity == 0)
            {
                MessageBox.Show("The fingerprint is not recognised");
            }
            else
            {
                MessageBox.Show("Welcome home, " + recognisedPerson.name);
            }
        }

        /* Pre:
         * Simulate producing music; just two frequencies that represent a song
         */
        public void Visit(Speaker speaker)
        {
            speaker.ProduceFrequency(5000);
            speaker.ProduceFrequency(100);
        }

        /* Pre:
         * Simulation : process touch screen for interacting with interface of app
         */
        public void Visit(TouchScreen ts)
        {
            TouchPoint[] points = ts.GetTouches();

            int index = points.Length;

            TouchPoint average = new TouchPoint { x = 0, y = 0 };

            while(--index > 0)
            {
                average.x += points[index].x;
                average.y += points[index].y;
            }

            average.x /= points.Length;
            average.y /= points.Length;

            MessageBox.Show("Average point position: { x = " + average.x + ", y = " + average.y + " }");
        }
    }
}
