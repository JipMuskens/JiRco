using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorPattern
{
    public partial class TuningShopForm : Form
    {
        public TuningShopForm()
        {
            InitializeComponent();
        }

        private void TuningShopForm_Load(object sender, EventArgs e)
        {
            lbUntunedCars.Items.Add(new HondaCivic());
            lbUntunedCars.Items.Add(new TeslaModelS());
            lbUntunedCars.Items.Add(new ToyotaAuris());
            lbUntunedCars.Items.Add(new TeslaModelS());
            lbUntunedCars.Items.Add(new ToyotaAuris());

            lbTuneOptions.Items.Add(PaintJob.Name);
            lbTuneOptions.Items.Add(Hydraulics.Name);
            lbTuneOptions.Items.Add(VinylSticker.Name);
            lbTuneOptions.Items.Add(Airco.Name);
        }

        private void btTune_Click(object sender, EventArgs e)
        {
            if (lbTuneOptions.Items.Count <= 0)
            {
                MessageBox.Show("Must select tuning options");
                return;
            }

            iCar car = (iCar)lbUntunedCars.SelectedItem;
            if(car == null)
            {
                car = (iCar)lbTunedCars.SelectedItem;
                if (car == null)
                {
                    MessageBox.Show("Must select a Car");
                    return;
                }
                else { lbTunedCars.Items.RemoveAt(lbTunedCars.SelectedIndex); }

            }
            else { lbUntunedCars.Items.RemoveAt(lbUntunedCars.SelectedIndex); }

            // this copy is only done for naming purposes. 
            // since from this point forward the iCar object is no longer a car (component) but a tuning option (decoration)
            iCar tuning_options = car;

            foreach(var option in lbTuneOptions.SelectedItems)
            {
                string optionName = option.ToString();
                if (optionName == PaintJob.Name)
                {
                    tuning_options = new PaintJob(tuning_options);
                }
                else if(optionName == Hydraulics.Name)
                {
                    tuning_options = new Hydraulics(tuning_options);
                }
                else if(optionName == VinylSticker.Name)
                {
                    tuning_options = new VinylSticker(tuning_options);
                }
                else if(optionName == Airco.Name)
                {
                    Airco airco = new Airco(tuning_options);
                    //To show you can have different funtionality for each decorator we will test the airco:
                    airco.TurnOn();
                    airco.TurnOff();
                    tuning_options = airco;
                }
            }
            tbLabelCars.Text = "";
            lbTunedCars.Items.Add(tuning_options);
        }

        private void btTuneEverything_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lbTuneOptions.Items.Count; i++)
            { lbTuneOptions.SetSelected(i, true); }
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbTuneOptions.Items.Count; i++)
            { lbTuneOptions.SetSelected(i, false); }
        }

        private void lbTunedCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            iCar car = (iCar)lbTunedCars.SelectedItem;

            if(car == null)
            { return; }

            lbUntunedCars.ClearSelected();

            tbLabelCars.Text = "Costs: \u20AC " + car.cost() + " " + car.ToString();
        }

        private void lbUntunedCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTunedCars.ClearSelected();
        }
    }
}
