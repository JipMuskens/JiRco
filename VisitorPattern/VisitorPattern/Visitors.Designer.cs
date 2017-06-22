namespace VisitorPattern
{
    partial class Visitors
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
            this.lbVisitors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbElements = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVisit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVisitors
            // 
            this.lbVisitors.FormattingEnabled = true;
            this.lbVisitors.ItemHeight = 16;
            this.lbVisitors.Location = new System.Drawing.Point(13, 27);
            this.lbVisitors.Name = "lbVisitors";
            this.lbVisitors.Size = new System.Drawing.Size(168, 84);
            this.lbVisitors.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visitors/Operators";
            // 
            // lbElements
            // 
            this.lbElements.FormattingEnabled = true;
            this.lbElements.ItemHeight = 16;
            this.lbElements.Location = new System.Drawing.Point(196, 28);
            this.lbElements.Name = "lbElements";
            this.lbElements.Size = new System.Drawing.Size(139, 84);
            this.lbElements.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Component/Elements";
            // 
            // btnVisit
            // 
            this.btnVisit.Location = new System.Drawing.Point(362, 44);
            this.btnVisit.Name = "btnVisit";
            this.btnVisit.Size = new System.Drawing.Size(80, 31);
            this.btnVisit.TabIndex = 4;
            this.btnVisit.Text = "Visit";
            this.btnVisit.UseVisualStyleBackColor = true;
            this.btnVisit.Click += new System.EventHandler(this.btnVisit_Click);
            // 
            // Visitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 147);
            this.Controls.Add(this.btnVisit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbElements);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbVisitors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Visitors";
            this.Text = "Phone";
            this.Load += new System.EventHandler(this.Visitors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbVisitors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbElements;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVisit;
    }
}

