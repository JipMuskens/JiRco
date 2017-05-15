using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StrategyPattern;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        private DiskRequestScheduler _scheduler;

        public Form1()
        {
            _scheduler = new DiskRequestScheduler(new FIFOSchedulingAlgorithm());
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            btnAddRequest.Enabled = false;
            nudRequestValue.ReadOnly = true;
            lbProcessedRequests.Items.Clear();

            _scheduler.AddRequests(lbRequests.Items.OfType<int>().ToList());
            _scheduler.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _scheduler.Stop();

            btnStop.Enabled = false;
            btnStart.Enabled = true;
            btnAddRequest.Enabled = true;
            nudRequestValue.ReadOnly = false;
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            int value = Decimal.ToInt32(nudRequestValue.Value);

            bool itemAlreadyAdded = false;
            foreach (var item in lbRequests.Items)
            {
                int v = Convert.ToInt32(item);

                if (v == value)
                {
                    itemAlreadyAdded = true;
                    break;
                }
            }

            if (!itemAlreadyAdded)
            { lbRequests.Items.Add(value); }
        }
    }
}
