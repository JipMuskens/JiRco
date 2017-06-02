namespace ObserverPatternPull
{
    partial class EindhovenWeatherStationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClouded = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.interfaceUpdater = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(139, 11);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(13, 17);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperature:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clouded:";
            // 
            // lblClouded
            // 
            this.lblClouded.AutoSize = true;
            this.lblClouded.Location = new System.Drawing.Point(139, 65);
            this.lblClouded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClouded.Name = "lblClouded";
            this.lblClouded.Size = new System.Drawing.Size(13, 17);
            this.lblClouded.TabIndex = 4;
            this.lblClouded.Text = "-";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(139, 38);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(13, 17);
            this.lblTemperature.TabIndex = 5;
            this.lblTemperature.Text = "-";
            // 
            // interfaceUpdater
            // 
            this.interfaceUpdater.Enabled = true;
            this.interfaceUpdater.Interval = 10;
            this.interfaceUpdater.Tick += new System.EventHandler(this.interfaceUpdater_Tick);
            // 
            // EindhovenWeatherStationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 98);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblClouded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EindhovenWeatherStationForm";
            this.Text = "EindhovenWeatherStationForm";
            this.Load += new System.EventHandler(this.EindhovenWeatherStationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClouded;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Timer interfaceUpdater;
    }
}