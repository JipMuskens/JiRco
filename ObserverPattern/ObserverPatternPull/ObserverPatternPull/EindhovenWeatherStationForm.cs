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
    public partial class EindhovenWeatherStationForm : Form
    {
        private EindhovenWeatherStation eindhoven;
        public EindhovenWeatherStationForm()
        {
            eindhoven = null;
            InitializeComponent();
        }

        public void AddWeather(Weather weather)
        {
            eindhoven = new EindhovenWeatherStation(weather);
            //lblLocation.Text = weather;
        }

        private void interfaceUpdater_Tick(object sender, EventArgs e)
        {
            if(eindhoven != null)
            {
                lblTemperature.Text = eindhoven.temperature.ToString();
            }
            lblClouded.Text = (eindhoven.isclouded) ? "True" : "False";
        }
    }
}
