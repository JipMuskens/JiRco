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
    public partial class Visitors : Form
    {
        public Visitors()
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
            lbVisitors.Items.Add(new PhoneDiagnosticsVisitor());
            lbVisitors.Items.Add(new PhoneAppVisitor());

            lbElements.Items.Add(new Camera());
            lbElements.Items.Add(new Speaker());
            lbElements.Items.Add(new Touchscreen());
            lbElements.Items.Add(new FingerprintScanner());
        }
    }
}
