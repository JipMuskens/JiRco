namespace ObserverPatternPull
{
    partial class AmsterdamWeatherStationForm
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
            this.lblRainLevel = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.interfaceUpdater = new System.Windows.Forms.Timer(this.components);
            this.lblClouded = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRainLevel
            // 
            this.lblRainLevel.AutoSize = true;
            this.lblRainLevel.Location = new System.Drawing.Point(136, 36);
            this.lblRainLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRainLevel.Name = "lblRainLevel";
            this.lblRainLevel.Size = new System.Drawing.Size(13, 17);
            this.lblRainLevel.TabIndex = 15;
            this.lblRainLevel.Text = "-";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(13, 36);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(82, 17);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Rain in mm:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(136, 9);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(13, 17);
            this.lblLocation.TabIndex = 13;
            this.lblLocation.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Location:";
            // 
            // interfaceUpdater
            // 
            this.interfaceUpdater.Enabled = true;
            this.interfaceUpdater.Interval = 10;
            this.interfaceUpdater.Tick += new System.EventHandler(this.interfaceUpdater_Tick);
            // 
            // lblClouded
            // 
            this.lblClouded.AutoSize = true;
            this.lblClouded.Location = new System.Drawing.Point(136, 59);
            this.lblClouded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClouded.Name = "lblClouded";
            this.lblClouded.Size = new System.Drawing.Size(13, 17);
            this.lblClouded.TabIndex = 17;
            this.lblClouded.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Clouded:";
            // 
            // AmsterdamWeatherStationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 84);
            this.Controls.Add(this.lblClouded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRainLevel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AmsterdamWeatherStationForm";
            this.Text = "AmsterdamWeatherStation";
            this.Load += new System.EventHandler(this.AmsterdamWeatherStation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRainLevel;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer interfaceUpdater;
        private System.Windows.Forms.Label lblClouded;
        private System.Windows.Forms.Label label4;
    }
}