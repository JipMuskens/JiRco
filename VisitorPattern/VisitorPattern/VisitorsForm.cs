using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitorPattern
{
    public partial class VisitorsForm : Form
    {
        public VisitorsForm()
        {
            InitializeComponent();
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            iPhoneElement element = (iPhoneElement)lbElements.SelectedItem;
            iPhoneVisitor visitor = (iPhoneVisitor)lbVisitors.SelectedItem;
            if(visitor == null || element == null)
            {
                MessageBox.Show("please select a visitor and element");
                return;
            }
            element.Accept(visitor);
        }

        private void Visitors_Load(object sender, EventArgs e)
        {
            var identities = new PersonIdentity[]
            {
                new PersonIdentity{ identity = 10000, name = "Jip Musketier" },
                new PersonIdentity{ identity = 10005, name = "Marco shrek" },
                new PersonIdentity{ identity = 10010, name = "Wouter Whatsitsname" },
                new PersonIdentity{ identity = 10015, name = "Andre Hazig" },
                new PersonIdentity{ identity = 10020, name = "Maarten Glutenboii" },
                new PersonIdentity{ identity = 10025, name = "Evert Cozmo" },
                new PersonIdentity{ identity = 10030, name = "Freddy Wrong" },
                new PersonIdentity{ identity = 10035, name = "Hong Konghon" },
            };

            lbVisitors.Items.Add(new PhoneDiagnosticsVisitor());
            lbVisitors.Items.Add(new PhoneAppVisitor(identities));

            lbElements.Items.Add(new Camera());
            lbElements.Items.Add(new Speaker());
            lbElements.Items.Add(new Touchscreen());
            lbElements.Items.Add(new FingerprintScanner());
        }
    }
}
