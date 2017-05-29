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
    public partial class NationalWeatherStationForm : Form
    {
        private GeldropWeatherStation[] geldrop;

        public NationalWeatherStationForm()
        {
            InitializeComponent();
        }

        public void AddWeather(Weather[] weather)
        {
            if (weather == null || weather.Length == 0)
            { throw new ArgumentNullException(); }

            geldrop = new GeldropWeatherStation[weather.Length];
            
            for(int i = 0; i < weather.Length; i++)
            {
                geldrop[i] = new GeldropWeatherStation(weather[i]);
                lbWeathers.Items.Add(weather[i].GetState().location);
            }

            lbWeathers.SelectedIndex = 0;
            updateWeatherStation();
        }

        private void interfaceUpdater_Tick(object sender, EventArgs e)
        {
            updateWeatherStation();
        }

        private void updateWeatherStation()
        {
            if (lbWeathers.SelectedIndex >= 0)
            {
                lblTemperature.Text = geldrop[lbWeathers.SelectedIndex].temperature.ToString();
            }

            float avtTemp = 0.0f;

            foreach(var station in geldrop)
            {
                avtTemp += station.temperature;
            }

            avtTemp /= geldrop.Length;

            lblTemperatureAverage.Text = ((float)Math.Round(avtTemp, 1)).ToString();
        }

        private void NationalWeatherStationForm_Load(object sender, EventArgs e)
        {

        }

        private void lbWeathers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbWeathers.SelectedIndex < 0)
            {
                lbWeathers.SelectedIndex = 0;
                return;
            }

            updateWeatherStation();
        }
    }
}
