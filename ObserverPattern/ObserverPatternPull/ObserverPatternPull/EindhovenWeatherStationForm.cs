﻿using System;
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
            if(weather == null)
            { throw new ArgumentNullException(); }

            eindhoven = new EindhovenWeatherStation(weather);
            lblLocation.Text = weather.GetState().location;

            updateWeatherStation();
        }

        private void interfaceUpdater_Tick(object sender, EventArgs e)
        {
            updateWeatherStation();
        }

        private void updateWeatherStation()
        {
            if (eindhoven != null)
            {
                lblTemperature.Text = eindhoven.temperature.ToString();
                lblClouded.Text = (eindhoven.isclouded) ? "True" : "False";
            } 
        }

        private void EindhovenWeatherStationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
