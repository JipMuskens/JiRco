namespace StrategyPattern
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbAlgorithms = new System.Windows.Forms.ListBox();
            this.lblAlgorithms = new System.Windows.Forms.Label();
            this.lbRequests = new System.Windows.Forms.ListBox();
            this.lblRequests = new System.Windows.Forms.Label();
            this.nudRequestValue = new System.Windows.Forms.NumericUpDown();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.lbProcessedRequests = new System.Windows.Forms.ListBox();
            this.lblProcessedRequests = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRequestValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 127);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(53, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(79, 127);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(53, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbAlgorithms
            // 
            this.lbAlgorithms.FormattingEnabled = true;
            this.lbAlgorithms.Location = new System.Drawing.Point(12, 26);
            this.lbAlgorithms.Name = "lbAlgorithms";
            this.lbAlgorithms.Size = new System.Drawing.Size(120, 95);
            this.lbAlgorithms.TabIndex = 2;
            // 
            // lblAlgorithms
            // 
            this.lblAlgorithms.AutoSize = true;
            this.lblAlgorithms.Location = new System.Drawing.Point(9, 10);
            this.lblAlgorithms.Name = "lblAlgorithms";
            this.lblAlgorithms.Size = new System.Drawing.Size(113, 13);
            this.lblAlgorithms.TabIndex = 3;
            this.lblAlgorithms.Text = "Scheduling algorithms:";
            // 
            // lbRequests
            // 
            this.lbRequests.FormattingEnabled = true;
            this.lbRequests.Location = new System.Drawing.Point(151, 26);
            this.lbRequests.Name = "lbRequests";
            this.lbRequests.Size = new System.Drawing.Size(109, 95);
            this.lbRequests.TabIndex = 4;
            // 
            // lblRequests
            // 
            this.lblRequests.AutoSize = true;
            this.lblRequests.Location = new System.Drawing.Point(148, 10);
            this.lblRequests.Name = "lblRequests";
            this.lblRequests.Size = new System.Drawing.Size(55, 13);
            this.lblRequests.TabIndex = 5;
            this.lblRequests.Text = "Requests:";
            // 
            // nudRequestValue
            // 
            this.nudRequestValue.Location = new System.Drawing.Point(151, 132);
            this.nudRequestValue.Name = "nudRequestValue";
            this.nudRequestValue.Size = new System.Drawing.Size(109, 20);
            this.nudRequestValue.TabIndex = 6;
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Location = new System.Drawing.Point(278, 130);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(109, 20);
            this.btnAddRequest.TabIndex = 7;
            this.btnAddRequest.Text = "add Request";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // lbProcessedRequests
            // 
            this.lbProcessedRequests.FormattingEnabled = true;
            this.lbProcessedRequests.Location = new System.Drawing.Point(278, 26);
            this.lbProcessedRequests.Name = "lbProcessedRequests";
            this.lbProcessedRequests.Size = new System.Drawing.Size(109, 95);
            this.lbProcessedRequests.TabIndex = 8;
            // 
            // lblProcessedRequests
            // 
            this.lblProcessedRequests.AutoSize = true;
            this.lblProcessedRequests.Location = new System.Drawing.Point(275, 9);
            this.lblProcessedRequests.Name = "lblProcessedRequests";
            this.lblProcessedRequests.Size = new System.Drawing.Size(103, 13);
            this.lblProcessedRequests.TabIndex = 9;
            this.lblProcessedRequests.Text = "Processed requests:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 160);
            this.Controls.Add(this.lblProcessedRequests);
            this.Controls.Add(this.lbProcessedRequests);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.nudRequestValue);
            this.Controls.Add(this.lblRequests);
            this.Controls.Add(this.lbRequests);
            this.Controls.Add(this.lblAlgorithms);
            this.Controls.Add(this.lbAlgorithms);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "DiskScheduler";
            ((System.ComponentModel.ISupportInitialize)(this.nudRequestValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox lbAlgorithms;
        private System.Windows.Forms.Label lblAlgorithms;
        private System.Windows.Forms.ListBox lbRequests;
        private System.Windows.Forms.Label lblRequests;
        private System.Windows.Forms.NumericUpDown nudRequestValue;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.ListBox lbProcessedRequests;
        private System.Windows.Forms.Label lblProcessedRequests;
    }
}

