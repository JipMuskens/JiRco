using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarFactory.Factories;

namespace CarFactory
{
    /*
     * Struct is used mainly for serialisation. (Composition of ToString)
     */
    struct BodyAndCar
    {
        public iCarBody body;
        public iCarEngine engine;
        public iVehicleFactory producer_factory;

        public override string ToString()
        {
            return body.ToString() + ", engine: " + engine.ToString() + ", produced by: " + producer_factory.ToString();
        }
    }

    public partial class CarFactoryForms : Form
    {
        public CarFactoryForms()
        {
            InitializeComponent();
        }

        private void btnManufacture_Click(object sender, EventArgs e)
        {
            foreach (var obj in lbFactories.SelectedItems)
            {
                iVehicleFactory factory = (iVehicleFactory)obj;

                if(factory == null)
                { throw new InvalidCastException("Cannot manufacture car from non-factory object in listbox"); }

                BodyAndCar assembly;
                assembly.body = factory.ManufactureBody();
                assembly.engine = factory.ManufactureEngine();
                assembly.producer_factory = factory;

                lbProducedCars.Items.Add(assembly);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbProducedCars.SelectedItems.Count > 0)
            {
                object[] objs = new object[lbProducedCars.SelectedItems.Count];

                lbProducedCars.SelectedItems.CopyTo(objs, 0);

                foreach (var obj in objs)
                { lbProducedCars.Items.Remove(obj); }
            }
        }

        private void CarFactoryForms_Load(object sender, EventArgs e)
        {
            lbFactories.Items.Add(new RollsRoyceFactory());
            lbFactories.Items.Add(new ToyotaFactory());
            lbFactories.Items.Add(new SubaruFactory());
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            foreach(var obj in lbProducedCars.SelectedItems)
            {
                var assembly = (BodyAndCar)obj;

                if(assembly.body != null && assembly.engine != null)
                {
                    assembly.engine.Start();
                    assembly.engine.Accelerate();
                }
            }
        }

        private void btnStopCar_Click(object sender, EventArgs e)
        {
            foreach (var obj in lbProducedCars.SelectedItems)
            {
                var assembly = (BodyAndCar)obj;

                if (assembly.body != null && assembly.engine != null)
                {
                    assembly.engine.Decelerate();
                    assembly.engine.Stop();
                }
            }
        }
    }
}
