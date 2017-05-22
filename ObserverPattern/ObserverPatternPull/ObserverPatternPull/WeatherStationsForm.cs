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
    public partial class WeatherStationsForm : Form
    {
        private Weather geldropWeather;
        private Weather eindhovenWeather;
        private Weather amsterdamWeather;

        public WeatherStationsForm()
        {
            geldropWeather = new Weather("Geldrop");
            eindhovenWeather = new Weather("Eindhoven");
            amsterdamWeather = new Weather("Amsterdam");

            InitializeComponent();
        }

        private void btnGeldrop_Click(object sender, EventArgs e)
        {

        }

        private void btnEindhoven_Click(object sender, EventArgs e)
        {
            var eindhovenForm = new EindhovenWeatherStationForm();
            eindhovenForm.Show();

            eindhovenForm.AddWeather(eindhovenWeather);
        }
    }
}
