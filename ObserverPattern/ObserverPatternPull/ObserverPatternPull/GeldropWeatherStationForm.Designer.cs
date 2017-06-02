namespace ObserverPatternPull
{
    partial class GeldropWeatherStationForm
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
            this.components = new System.ComponentModel.Container();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.interfaceUpdater = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(136, 42);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(13, 17);
            this.lblTemperature.TabIndex = 11;
            this.lblTemperature.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Temperature:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(136, 15);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(13, 17);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Location:";
            // 
            // interfaceUpdater
            // 
            this.interfaceUpdater.Enabled = true;
            this.interfaceUpdater.Interval = 10;
            this.interfaceUpdater.Tick += new System.EventHandler(this.interfaceUpdater_Tick);
            // 
            // GeldropWeatherStationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 71);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "GeldropWeatherStationForm";
            this.Text = "GeldropWeatherStationForm";
            this.Load += new System.EventHandler(this.GeldropWeatherStationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer interfaceUpdater;
    }
}