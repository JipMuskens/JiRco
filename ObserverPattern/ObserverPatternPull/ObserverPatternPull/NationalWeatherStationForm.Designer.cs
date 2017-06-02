namespace ObserverPatternPull
{
    partial class NationalWeatherStationForm
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
            this.lblClouded = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblrainlevel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWeathers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRainLevelAverage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTemperatureAverage = new System.Windows.Forms.Label();
            this.lblCloudedPercentage = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.interfaceUpdater = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(265, 18);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(13, 17);
            this.lblTemperature.TabIndex = 11;
            this.lblTemperature.Text = "-";
            // 
            // lblClouded
            // 
            this.lblClouded.AutoSize = true;
            this.lblClouded.Location = new System.Drawing.Point(265, 45);
            this.lblClouded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClouded.Name = "lblClouded";
            this.lblClouded.Size = new System.Drawing.Size(13, 17);
            this.lblClouded.TabIndex = 10;
            this.lblClouded.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Clouded:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Temperature in ° :";
            // 
            // lblrainlevel
            // 
            this.lblrainlevel.AutoSize = true;
            this.lblrainlevel.Location = new System.Drawing.Point(265, 74);
            this.lblrainlevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrainlevel.Name = "lblrainlevel";
            this.lblrainlevel.Size = new System.Drawing.Size(13, 17);
            this.lblrainlevel.TabIndex = 13;
            this.lblrainlevel.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rain in mm:";
            // 
            // lbWeathers
            // 
            this.lbWeathers.FormattingEnabled = true;
            this.lbWeathers.ItemHeight = 16;
            this.lbWeathers.Location = new System.Drawing.Point(12, 12);
            this.lbWeathers.Name = "lbWeathers";
            this.lbWeathers.Size = new System.Drawing.Size(120, 84);
            this.lbWeathers.TabIndex = 14;
            this.lbWeathers.SelectedIndexChanged += new System.EventHandler(this.lbWeathers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 1);
            this.label1.TabIndex = 15;
            // 
            // lblRainLevelAverage
            // 
            this.lblRainLevelAverage.AutoSize = true;
            this.lblRainLevelAverage.Location = new System.Drawing.Point(174, 195);
            this.lblRainLevelAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRainLevelAverage.Name = "lblRainLevelAverage";
            this.lblRainLevelAverage.Size = new System.Drawing.Size(13, 17);
            this.lblRainLevelAverage.TabIndex = 21;
            this.lblRainLevelAverage.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Rain in mm:";
            // 
            // lblTemperatureAverage
            // 
            this.lblTemperatureAverage.AutoSize = true;
            this.lblTemperatureAverage.Location = new System.Drawing.Point(174, 139);
            this.lblTemperatureAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperatureAverage.Name = "lblTemperatureAverage";
            this.lblTemperatureAverage.Size = new System.Drawing.Size(13, 17);
            this.lblTemperatureAverage.TabIndex = 19;
            this.lblTemperatureAverage.Text = "-";
            // 
            // lblCloudedPercentage
            // 
            this.lblCloudedPercentage.AutoSize = true;
            this.lblCloudedPercentage.Location = new System.Drawing.Point(174, 166);
            this.lblCloudedPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCloudedPercentage.Name = "lblCloudedPercentage";
            this.lblCloudedPercentage.Size = new System.Drawing.Size(13, 17);
            this.lblCloudedPercentage.TabIndex = 18;
            this.lblCloudedPercentage.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 166);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Clouded in %:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 139);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Temperature in ° :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Average:";
            // 
            // interfaceUpdater
            // 
            this.interfaceUpdater.Enabled = true;
            this.interfaceUpdater.Interval = 10;
            this.interfaceUpdater.Tick += new System.EventHandler(this.interfaceUpdater_Tick);
            // 
            // NationalWeatherStationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 221);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblRainLevelAverage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTemperatureAverage);
            this.Controls.Add(this.lblCloudedPercentage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbWeathers);
            this.Controls.Add(this.lblrainlevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblClouded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "NationalWeatherStationForm";
            this.Text = "NationalWeatherStationForm";
            this.Load += new System.EventHandler(this.NationalWeatherStationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblClouded;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblrainlevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbWeathers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRainLevelAverage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTemperatureAverage;
        private System.Windows.Forms.Label lblCloudedPercentage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer interfaceUpdater;
    }
}