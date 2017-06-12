namespace DecoratorPattern
{
    partial class TuningShopForm
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
            this.lbUntunedCars = new System.Windows.Forms.ListBox();
            this.lblUntunedCarsInShop = new System.Windows.Forms.Label();
            this.lbTunedCars = new System.Windows.Forms.ListBox();
            this.lblTunedCarsInShop = new System.Windows.Forms.Label();
            this.tbLabelCars = new System.Windows.Forms.TextBox();
            this.btTune = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTuneOptions = new System.Windows.Forms.ListBox();
            this.btTuneEverything = new System.Windows.Forms.Button();
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUntunedCars
            // 
            this.lbUntunedCars.FormattingEnabled = true;
            this.lbUntunedCars.ItemHeight = 16;
            this.lbUntunedCars.Location = new System.Drawing.Point(16, 33);
            this.lbUntunedCars.Name = "lbUntunedCars";
            this.lbUntunedCars.Size = new System.Drawing.Size(147, 100);
            this.lbUntunedCars.TabIndex = 0;
            this.lbUntunedCars.SelectedIndexChanged += new System.EventHandler(this.lbUntunedCars_SelectedIndexChanged);
            // 
            // lblUntunedCarsInShop
            // 
            this.lblUntunedCarsInShop.AutoSize = true;
            this.lblUntunedCarsInShop.Location = new System.Drawing.Point(13, 13);
            this.lblUntunedCarsInShop.Name = "lblUntunedCarsInShop";
            this.lblUntunedCarsInShop.Size = new System.Drawing.Size(147, 17);
            this.lblUntunedCarsInShop.TabIndex = 1;
            this.lblUntunedCarsInShop.Text = "Untuned cars in shop:";
            // 
            // lbTunedCars
            // 
            this.lbTunedCars.FormattingEnabled = true;
            this.lbTunedCars.HorizontalScrollbar = true;
            this.lbTunedCars.ItemHeight = 16;
            this.lbTunedCars.Location = new System.Drawing.Point(409, 33);
            this.lbTunedCars.Name = "lbTunedCars";
            this.lbTunedCars.Size = new System.Drawing.Size(288, 100);
            this.lbTunedCars.TabIndex = 2;
            this.lbTunedCars.SelectedIndexChanged += new System.EventHandler(this.lbTunedCars_SelectedIndexChanged);
            // 
            // lblTunedCarsInShop
            // 
            this.lblTunedCarsInShop.AutoSize = true;
            this.lblTunedCarsInShop.Location = new System.Drawing.Point(406, 13);
            this.lblTunedCarsInShop.Name = "lblTunedCarsInShop";
            this.lblTunedCarsInShop.Size = new System.Drawing.Size(134, 17);
            this.lblTunedCarsInShop.TabIndex = 3;
            this.lblTunedCarsInShop.Text = "Tuned cars in shop:";
            // 
            // tbLabelCars
            // 
            this.tbLabelCars.BackColor = System.Drawing.SystemColors.Menu;
            this.tbLabelCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLabelCars.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbLabelCars.Location = new System.Drawing.Point(16, 139);
            this.tbLabelCars.Name = "tbLabelCars";
            this.tbLabelCars.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLabelCars.Size = new System.Drawing.Size(681, 15);
            this.tbLabelCars.TabIndex = 4;
            // 
            // btTune
            // 
            this.btTune.Location = new System.Drawing.Point(317, 110);
            this.btTune.Name = "btTune";
            this.btTune.Size = new System.Drawing.Size(75, 23);
            this.btTune.TabIndex = 5;
            this.btTune.Text = "Tune";
            this.btTune.UseVisualStyleBackColor = true;
            this.btTune.Click += new System.EventHandler(this.btTune_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tune options/decorations:";
            // 
            // lbTuneOptions
            // 
            this.lbTuneOptions.FormattingEnabled = true;
            this.lbTuneOptions.ItemHeight = 16;
            this.lbTuneOptions.Location = new System.Drawing.Point(186, 49);
            this.lbTuneOptions.Name = "lbTuneOptions";
            this.lbTuneOptions.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbTuneOptions.Size = new System.Drawing.Size(120, 84);
            this.lbTuneOptions.TabIndex = 7;
            // 
            // btTuneEverything
            // 
            this.btTuneEverything.Location = new System.Drawing.Point(317, 49);
            this.btTuneEverything.Name = "btTuneEverything";
            this.btTuneEverything.Size = new System.Drawing.Size(75, 23);
            this.btTuneEverything.TabIndex = 8;
            this.btTuneEverything.Text = "All";
            this.btTuneEverything.UseVisualStyleBackColor = true;
            this.btTuneEverything.Click += new System.EventHandler(this.btTuneEverything_Click);
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.Location = new System.Drawing.Point(317, 78);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(75, 23);
            this.btnClearSelection.TabIndex = 9;
            this.btnClearSelection.Text = "Clear";
            this.btnClearSelection.UseVisualStyleBackColor = true;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
            // 
            // TuningShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 171);
            this.Controls.Add(this.btnClearSelection);
            this.Controls.Add(this.btTuneEverything);
            this.Controls.Add(this.lbTuneOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTune);
            this.Controls.Add(this.tbLabelCars);
            this.Controls.Add(this.lblTunedCarsInShop);
            this.Controls.Add(this.lbTunedCars);
            this.Controls.Add(this.lblUntunedCarsInShop);
            this.Controls.Add(this.lbUntunedCars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TuningShopForm";
            this.Text = "Tuning shop";
            this.Load += new System.EventHandler(this.TuningShopForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUntunedCars;
        private System.Windows.Forms.Label lblUntunedCarsInShop;
        private System.Windows.Forms.ListBox lbTunedCars;
        private System.Windows.Forms.Label lblTunedCarsInShop;
        private System.Windows.Forms.TextBox tbLabelCars;
        private System.Windows.Forms.Button btTune;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbTuneOptions;
        private System.Windows.Forms.Button btTuneEverything;
        private System.Windows.Forms.Button btnClearSelection;
    }
}

