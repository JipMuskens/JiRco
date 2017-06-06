namespace CarFactory
{
    partial class CarFactoryForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFactories = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManufacture = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbProducedCars = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnStopCar = new System.Windows.Forms.Button();
            this.lblTestCar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFactories
            // 
            this.lbFactories.FormattingEnabled = true;
            this.lbFactories.ItemHeight = 16;
            this.lbFactories.Location = new System.Drawing.Point(12, 29);
            this.lbFactories.Name = "lbFactories";
            this.lbFactories.Size = new System.Drawing.Size(120, 212);
            this.lbFactories.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car manufacturer:";
            // 
            // btnManufacture
            // 
            this.btnManufacture.Location = new System.Drawing.Point(155, 41);
            this.btnManufacture.Name = "btnManufacture";
            this.btnManufacture.Size = new System.Drawing.Size(180, 58);
            this.btnManufacture.TabIndex = 2;
            this.btnManufacture.Text = "Manufacture";
            this.btnManufacture.UseVisualStyleBackColor = true;
            this.btnManufacture.Click += new System.EventHandler(this.btnManufacture_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(155, 105);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 60);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Put up for sale [delete]";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbProducedCars
            // 
            this.lbProducedCars.HorizontalScrollbar = true;
            this.lbProducedCars.ItemHeight = 16;
            this.lbProducedCars.Location = new System.Drawing.Point(355, 29);
            this.lbProducedCars.Name = "lbProducedCars";
            this.lbProducedCars.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbProducedCars.Size = new System.Drawing.Size(397, 212);
            this.lbProducedCars.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produced cars";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(176, 200);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(54, 31);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnStopCar
            // 
            this.btnStopCar.Location = new System.Drawing.Point(248, 200);
            this.btnStopCar.Name = "btnStopCar";
            this.btnStopCar.Size = new System.Drawing.Size(54, 31);
            this.btnStopCar.TabIndex = 7;
            this.btnStopCar.Text = "Stop";
            this.btnStopCar.UseVisualStyleBackColor = true;
            this.btnStopCar.Click += new System.EventHandler(this.btnStopCar_Click);
            // 
            // lblTestCar
            // 
            this.lblTestCar.AutoSize = true;
            this.lblTestCar.Location = new System.Drawing.Point(199, 178);
            this.lblTestCar.Name = "lblTestCar";
            this.lblTestCar.Size = new System.Drawing.Size(84, 17);
            this.lblTestCar.TabIndex = 8;
            this.lblTestCar.Text = "Test vehicle";
            // 
            // CarFactoryForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 254);
            this.Controls.Add(this.lblTestCar);
            this.Controls.Add(this.btnStopCar);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbProducedCars);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnManufacture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFactories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CarFactoryForms";
            this.Text = "Car factories";
            this.Load += new System.EventHandler(this.CarFactoryForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFactories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManufacture;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbProducedCars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnStopCar;
        private System.Windows.Forms.Label lblTestCar;
    }
}

