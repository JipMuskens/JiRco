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
    public partial class DiskSimulationForm : Form
    {
        private DiskRequestScheduler _scheduler;

        public DiskSimulationForm()
        {
            _scheduler = new DiskRequestScheduler(new FIFOSchedulingAlgorithm());
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start();
        }
        private void start()
        {
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            formupdatetimer.Enabled = true;
            lbProcessedRequests.Items.Clear();

            _scheduler.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void stop()
        {
            _scheduler.Stop();

            btnStop.Enabled = false;
            btnStart.Enabled = true;
            formupdatetimer.Enabled = false;
        }

        private void AddRequest(int value)
        {
            if (value > 0)
            {
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
                {
                    lbRequests.Items.Add(value);
                    _scheduler.AddRequest(value);
                }
            }
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            int value = Decimal.ToInt32(nudRequestValue.Value);

            AddRequest(value);

            nudRequestValue.Value = value + 1;
        }

        private void formupdatetimer_Tick(object sender, EventArgs e)
        {     
            var processed_requests = _scheduler.GetProcessedRequests();

            int request_in_process = _scheduler.RequestInProcess;

            if(request_in_process != -1)
            {
                var result = lbRequests.Items.IndexOf(request_in_process);

                if(result >= 0)
                { lbRequests.SelectedIndex = result; }
            }

            if(processed_requests != null)
            {
                foreach (var value in processed_requests)
                {
                    lbProcessedRequests.Items.Add(value);
                    lbRequests.Items.Remove(value);
                }
            }

            if(!_scheduler.IsWorking)
            { stop(); }
        }

        private void lbAlgorithms_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbAlgorithms.SelectedIndex)
            {
                case 0:
                {
                    _scheduler.SetScheduler(new FIFOSchedulingAlgorithm());
                    break;
                }
                case 1:
                {
                    _scheduler.SetScheduler(new SSTFSchedulingAlgorithm());
                    break;
                }
                case 2:
                {
                   _scheduler.SetScheduler(new SCANSchedulingAlgorithm());
                   break;
                }
                default:
                {
                   MessageBox.Show("Please select a scheduling algorithm");
                   break;
                }
            }
        }

        private void DiskSimulationForm_Load(object sender, EventArgs e)
        {
            lbAlgorithms.SelectedIndex = 0;

            // load requests with default values
            AddRequest(25);
            AddRequest(30);
            AddRequest(5);
            AddRequest(6);
            AddRequest(8);
            AddRequest(1);
            AddRequest(20);
            AddRequest(19);
            AddRequest(18);
            AddRequest(17);
            AddRequest(3);
            AddRequest(16);
        }
    }
}
