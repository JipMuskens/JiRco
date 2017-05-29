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
    public partial class GeldropWeatherStationForm : Form
    {
        private GeldropWeatherStation geldrop;

        public GeldropWeatherStationForm()
        {
            InitializeComponent();
        }

        public void AddWeather(Weather weather)
        {
            if (weather == null)
            { throw new ArgumentNullException(); }

            geldrop = new GeldropWeatherStation(weather);
            lblLocation.Text = weather.GetState().location;
            updateWeatherStation();
        }

        private void interfaceUpdater_Tick(object sender, EventArgs e)
        {
            updateWeatherStation();
        }

        private void updateWeatherStation()
        {
            if (geldrop != null)
            {
                lblTemperature.Text = geldrop.temperature.ToString();
            }
        }

        private void GeldropWeatherStationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
