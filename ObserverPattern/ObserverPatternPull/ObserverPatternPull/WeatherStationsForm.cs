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
            geldropWeather = new Weather("Geldrop", 100);
            eindhovenWeather = new Weather("Eindhoven", 200);
            amsterdamWeather = new Weather("Amsterdam", 300);

            InitializeComponent();
        }

        private void btnGeldrop_Click(object sender, EventArgs e)
        {
            var geldropForm = new GeldropWeatherStationForm();
            geldropForm.AddWeather(geldropWeather);

            geldropForm.Show();
        }

        private void btnEindhoven_Click(object sender, EventArgs e)
        {
            var eindhovenForm = new EindhovenWeatherStationForm();
            eindhovenForm.AddWeather(eindhovenWeather);

            eindhovenForm.Show();
        }

        private void btnAmsterdam_Click(object sender, EventArgs e)
        {
            var amsterdamForm = new AmsterdamWeatherStationForm();
            amsterdamForm.AddWeather(amsterdamWeather);

            amsterdamForm.Show();
        }

        private void WeatherStationsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNational_Click(object sender, EventArgs e)
        {
            var nationalForm = new NationalWeatherStationForm();
            nationalForm.AddWeather(new Weather[] { geldropWeather, eindhovenWeather, amsterdamWeather });

            nationalForm.Show();
        }
    }
}
