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
            this.btnAmsterdam.Location = new System.Drawing.Point(161, 15);
            this.btnAmsterdam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAmsterdam.Name = "btnAmsterdam";
            this.btnAmsterdam.Size = new System.Drawing.Size(139, 28);
            this.btnAmsterdam.TabIndex = 0;
            this.btnAmsterdam.Text = "Open Amsterdam";
            this.btnAmsterdam.UseVisualStyleBackColor = true;
            this.btnAmsterdam.Click += new System.EventHandler(this.btnAmsterdam_Click);
            // 
            // btnGeldrop
            // 
            this.btnGeldrop.Location = new System.Drawing.Point(161, 50);
            this.btnGeldrop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGeldrop.Name = "btnGeldrop";
            this.btnGeldrop.Size = new System.Drawing.Size(139, 28);
            this.btnGeldrop.TabIndex = 1;
            this.btnGeldrop.Text = "Open Geldrop";
            this.btnGeldrop.UseVisualStyleBackColor = true;
            this.btnGeldrop.Click += new System.EventHandler(this.btnGeldrop_Click);
            // 
            // btnEindhoven
            // 
            this.btnEindhoven.Location = new System.Drawing.Point(16, 50);
            this.btnEindhoven.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEindhoven.Name = "btnEindhoven";
            this.btnEindhoven.Size = new System.Drawing.Size(137, 28);
            this.btnEindhoven.TabIndex = 2;
            this.btnEindhoven.Text = "Open Eindhoven";
            this.btnEindhoven.UseVisualStyleBackColor = true;
            this.btnEindhoven.Click += new System.EventHandler(this.btnEindhoven_Click);
            // 
            // btnNational
            // 
            this.btnNational.Location = new System.Drawing.Point(16, 15);
            this.btnNational.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNational.Name = "btnNational";
            this.btnNational.Size = new System.Drawing.Size(137, 28);
            this.btnNational.TabIndex = 3;
            this.btnNational.Text = "Open National";
            this.btnNational.UseVisualStyleBackColor = true;
            this.btnNational.Click += new System.EventHandler(this.btnNational_Click);
            // 
            // WeatherStationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 94);
            this.Controls.Add(this.btnNational);
            this.Controls.Add(this.btnEindhoven);
            this.Controls.Add(this.btnGeldrop);
            this.Controls.Add(this.btnAmsterdam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WeatherStationsForm";
            this.Text = "Weather Stations";
            this.Load += new System.EventHandler(this.WeatherStationsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAmsterdam;
        private System.Windows.Forms.Button btnGeldrop;
        private System.Windows.Forms.Button btnEindhoven;
        private System.Windows.Forms.Button btnNational;
    }
}

