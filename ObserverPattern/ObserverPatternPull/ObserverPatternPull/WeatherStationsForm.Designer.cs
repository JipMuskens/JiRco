namespace ObserverPatternPull
{
    partial class WeatherStationsForm
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
            this.btnAmsterdam = new System.Windows.Forms.Button();
            this.btnGeldrop = new System.Windows.Forms.Button();
            this.btnEindhoven = new System.Windows.Forms.Button();
            this.btnNational = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAmsterdam
            // 
            this.btnAmsterdam.Location = new System.Drawing.Point(121, 12);
            this.btnAmsterdam.Name = "btnAmsterdam";
            this.btnAmsterdam.Size = new System.Drawing.Size(104, 23);
            this.btnAmsterdam.TabIndex = 0;
            this.btnAmsterdam.Text = "Open Amsterdam";
            this.btnAmsterdam.UseVisualStyleBackColor = true;
            // 
            // btnGeldrop
            // 
            this.btnGeldrop.Location = new System.Drawing.Point(121, 41);
            this.btnGeldrop.Name = "btnGeldrop";
            this.btnGeldrop.Size = new System.Drawing.Size(104, 23);
            this.btnGeldrop.TabIndex = 1;
            this.btnGeldrop.Text = "Open Geldrop";
            this.btnGeldrop.UseVisualStyleBackColor = true;
            this.btnGeldrop.Click += new System.EventHandler(this.btnGeldrop_Click);
            // 
            // btnEindhoven
            // 
            this.btnEindhoven.Location = new System.Drawing.Point(12, 41);
            this.btnEindhoven.Name = "btnEindhoven";
            this.btnEindhoven.Size = new System.Drawing.Size(103, 23);
            this.btnEindhoven.TabIndex = 2;
            this.btnEindhoven.Text = "Open Eindhoven";
            this.btnEindhoven.UseVisualStyleBackColor = true;
            this.btnEindhoven.Click += new System.EventHandler(this.btnEindhoven_Click);
            // 
            // btnNational
            // 
            this.btnNational.Location = new System.Drawing.Point(12, 12);
            this.btnNational.Name = "btnNational";
            this.btnNational.Size = new System.Drawing.Size(103, 23);
            this.btnNational.TabIndex = 3;
            this.btnNational.Text = "Open National";
            this.btnNational.UseVisualStyleBackColor = true;
            // 
            // WeatherStationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 76);
            this.Controls.Add(this.btnNational);
            this.Controls.Add(this.btnEindhoven);
            this.Controls.Add(this.btnGeldrop);
            this.Controls.Add(this.btnAmsterdam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WeatherStationsForm";
            this.Text = "Weather Stations";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAmsterdam;
        private System.Windows.Forms.Button btnGeldrop;
        private System.Windows.Forms.Button btnEindhoven;
        private System.Windows.Forms.Button btnNational;
    }
}

