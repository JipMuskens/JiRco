using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPatternPull
{
    public partial class AmsterdamWeatherStationForm : Form
    {
        private AmsterdamWeatherStation amsterdam;

        public AmsterdamWeatherStationForm()
        {
            InitializeComponent();
        } 

        public void AddWeather(Weather weather)
        {
            if (weather == null)
            { throw new ArgumentNullException(); }

            amsterdam = new AmsterdamWeatherStation(weather);
            lblLocation.Text = weather.GetState().location;
            updateWeatherStation();
        }

        private void interfaceUpdater_Tick(object sender, EventArgs e)
        {
            updateWeatherStation();
        }

        private void updateWeatherStation()
        {
            if (amsterdam != null)
            {
                lblRainLevel.Text = amsterdam.rainlevel.ToString();
                lblClouded.Text = (amsterdam.isclouded) ? "True" : "False";
            }
        }


        private void AmsterdamWeatherStation_Load(object sender, EventArgs e)
        {

        }
    }
}
