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
        private NationalWeatherStation[] stations;

        public NationalWeatherStationForm()
        {
            InitializeComponent();
        }

        public void AddWeather(Weather[] weather)
        {
            if (weather == null || weather.Length == 0)
            { throw new ArgumentNullException(); }

            stations = new NationalWeatherStation[weather.Length];
            
            for(int i = 0; i < weather.Length; i++)
            {
                lbWeathers.Items.Add(new NationalWeatherStation(weather[i]));
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
                var station = (NationalWeatherStation)lbWeathers.Items[lbWeathers.SelectedIndex];

                lblTemperature.Text = ((float)Math.Round(station.temperature, 1)).ToString();
                lblClouded.Text = station.isclouded ? "Yes" : "No";
                lblrainlevel.Text = ((float)Math.Round(station.rainlevel, 1)).ToString();
            }

            float avtTemp = 0.0f;
            float avRain = 0.0f;
            int avNumCloudedLocations = 0;

            foreach (var station_obj in lbWeathers.Items)
            {
                var station = (NationalWeatherStation)station_obj;
                avtTemp += station.temperature;
                avRain += station.rainlevel;

                if (station.isclouded)
                { avNumCloudedLocations++; }
            }

            avtTemp /= stations.Length;
            avRain /= stations.Length;
            avNumCloudedLocations = (avNumCloudedLocations * 100) / stations.Length;

            lblTemperatureAverage.Text = ((float)Math.Round(avtTemp, 1)).ToString();
            lblRainLevelAverage.Text = ((float)Math.Round(avRain, 1)).ToString();
            lblCloudedPercentage.Text = avNumCloudedLocations.ToString();
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
