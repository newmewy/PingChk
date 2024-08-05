namespace PingChk
{
    partial class Main
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
            this.lbServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lbAverage = new System.Windows.Forms.Label();
            this.numAverage = new System.Windows.Forms.NumericUpDown();
            this.lbMillis = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnBars = new System.Windows.Forms.Panel();
            this.pnBar14 = new System.Windows.Forms.Panel();
            this.pnBar13 = new System.Windows.Forms.Panel();
            this.pnBar12 = new System.Windows.Forms.Panel();
            this.pnBar11 = new System.Windows.Forms.Panel();
            this.pnBar10 = new System.Windows.Forms.Panel();
            this.pnBar9 = new System.Windows.Forms.Panel();
            this.pnBar8 = new System.Windows.Forms.Panel();
            this.pnBar7 = new System.Windows.Forms.Panel();
            this.pnBar6 = new System.Windows.Forms.Panel();
            this.pnBar = new System.Windows.Forms.Panel();
            this.pnBar4 = new System.Windows.Forms.Panel();
            this.pnBar3 = new System.Windows.Forms.Panel();
            this.pnBar2 = new System.Windows.Forms.Panel();
            this.pnBar1 = new System.Windows.Forms.Panel();
            this.pnBar0 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numAverage)).BeginInit();
            this.pnBars.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbServer
            // 
            this.lbServer.Location = new System.Drawing.Point(19, 12);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(56, 22);
            this.lbServer.TabIndex = 0;
            this.lbServer.Text = "Server:";
            this.lbServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(81, 9);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(145, 25);
            this.txtServer.TabIndex = 1;
            this.txtServer.TabStop = false;
            this.txtServer.Text = "8.8.8.8";
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbAverage
            // 
            this.lbAverage.Location = new System.Drawing.Point(12, 40);
            this.lbAverage.Name = "lbAverage";
            this.lbAverage.Size = new System.Drawing.Size(63, 22);
            this.lbAverage.TabIndex = 2;
            this.lbAverage.Text = "Average:";
            this.lbAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numAverage
            // 
            this.numAverage.Location = new System.Drawing.Point(81, 41);
            this.numAverage.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numAverage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAverage.Name = "numAverage";
            this.numAverage.Size = new System.Drawing.Size(93, 25);
            this.numAverage.TabIndex = 3;
            this.numAverage.TabStop = false;
            this.numAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAverage.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lbMillis
            // 
            this.lbMillis.Location = new System.Drawing.Point(180, 40);
            this.lbMillis.Name = "lbMillis";
            this.lbMillis.Size = new System.Drawing.Size(46, 22);
            this.lbMillis.TabIndex = 4;
            this.lbMillis.Text = "millis.";
            this.lbMillis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(235, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 57);
            this.btnStart.TabIndex = 5;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // pnBars
            // 
            this.pnBars.BackColor = System.Drawing.Color.Gainsboro;
            this.pnBars.Controls.Add(this.pnBar0);
            this.pnBars.Controls.Add(this.pnBar1);
            this.pnBars.Controls.Add(this.pnBar2);
            this.pnBars.Controls.Add(this.pnBar3);
            this.pnBars.Controls.Add(this.pnBar4);
            this.pnBars.Controls.Add(this.pnBar);
            this.pnBars.Controls.Add(this.pnBar6);
            this.pnBars.Controls.Add(this.pnBar7);
            this.pnBars.Controls.Add(this.pnBar8);
            this.pnBars.Controls.Add(this.pnBar9);
            this.pnBars.Controls.Add(this.pnBar10);
            this.pnBars.Controls.Add(this.pnBar11);
            this.pnBars.Controls.Add(this.pnBar12);
            this.pnBars.Controls.Add(this.pnBar13);
            this.pnBars.Controls.Add(this.pnBar14);
            this.pnBars.Location = new System.Drawing.Point(12, 81);
            this.pnBars.Name = "pnBars";
            this.pnBars.Size = new System.Drawing.Size(317, 85);
            this.pnBars.TabIndex = 6;
            // 
            // pnBar14
            // 
            this.pnBar14.BackColor = System.Drawing.Color.LimeGreen;
            this.pnBar14.Location = new System.Drawing.Point(4, 25);
            this.pnBar14.Name = "pnBar14";
            this.pnBar14.Size = new System.Drawing.Size(15, 60);
            this.pnBar14.TabIndex = 0;
            // 
            // pnBar13
            // 
            this.pnBar13.BackColor = System.Drawing.Color.LimeGreen;
            this.pnBar13.Location = new System.Drawing.Point(25, 43);
            this.pnBar13.Name = "pnBar13";
            this.pnBar13.Size = new System.Drawing.Size(15, 42);
            this.pnBar13.TabIndex = 1;
            // 
            // pnBar12
            // 
            this.pnBar12.BackColor = System.Drawing.Color.LimeGreen;
            this.pnBar12.Location = new System.Drawing.Point(46, 25);
            this.pnBar12.Name = "pnBar12";
            this.pnBar12.Size = new System.Drawing.Size(15, 60);
            this.pnBar12.TabIndex = 2;
            // 
            // pnBar11
            // 
            this.pnBar11.BackColor = System.Drawing.Color.LimeGreen;
            this.pnBar11.Location = new System.Drawing.Point(67, 25);
            this.pnBar11.Name = "pnBar11";
            this.pnBar11.Size = new System.Drawing.Size(15, 60);
            this.pnBar11.TabIndex = 3;
            // 
            // pnBar10
            // 
            this.pnBar10.BackColor = System.Drawing.Color.LimeGreen;
            this.pnBar10.Location = new System.Drawing.Point(88, 25);
            this.pnBar10.Name = "pnBar10";
            this.pnBar10.Size = new System.Drawing.Size(15, 60);
            this.pnBar10.TabIndex = 4;
            // 
            // pnBar9
            // 
            this.pnBar9.BackColor = System.Drawing.Color.LimeGreen;
            this.pnBar9.Location = new System.Drawing.Point(109, 25);
            this.pnBar9.Name = "pnBar9";
            this.pnBar9.Size = new System.Drawing.Size(15, 60);
            this.pnBar9.TabIndex = 5;
            // 
            // pnBar8
            // 
            this.pnBar8.BackColor = System.Drawing.Color.LimeGreen;
            this.pnBar8.Location = new System.Drawing.Point(130, 25);
            this.pnBar8.Name = "pnBar8";
            this.pnBar8.Size = new System.Drawing.Size(15, 60);
            this.pnBar8.TabIndex = 6;
            // 
            // pnBar7
            // 
            this.pnBar7.BackColor = System.Drawing.Color.LimeGreen;
            this.pnBar7.Location = new System.Drawing.Point(151, 25);
            this.pnBar7.Name = "pnBar7";
            this.pnBar7.Size = new System.Drawing.Size(15, 60);
            this.pnBar7.TabIndex = 7;
            // 
            // pnBar6
            // 
            this.pnBar6.BackColor = System.Drawing.Color.LimeGreen;
            this.pnBar6.Location = new System.Drawing.Point(172, 25);
            this.pnBar6.Name = "pnBar6";
            this.pnBar6.Size = new System.Drawing.Size(15, 60);
            this.pnBar6.TabIndex = 8;
            // 
            // pnBar
            // 
            this.pnBar.BackColor = System.Drawing.Color.LimeGreen;
            this.pnBar.Location = new System.Drawing.Point(193, 25);
            this.pnBar.Name = "pnBar";
            this.pnBar.Size = new System.Drawing.Size(15, 60);
            this.pnBar.TabIndex = 9;
            // 
            // pnBar4
            // 
            this.pnBar4.BackColor = System.Drawing.Color.LimeGreen;
            this.pnBar4.Location = new System.Drawing.Point(214, 25);
            this.pnBar4.Name = "pnBar4";
            this.pnBar4.Size = new System.Drawing.Size(15, 60);
            this.pnBar4.TabIndex = 10;
            // 
            // pnBar3
            // 
            this.pnBar3.BackColor = System.Drawing.Color.LimeGreen;
            this.pnBar3.Location = new System.Drawing.Point(235, 25);
            this.pnBar3.Name = "pnBar3";
            this.pnBar3.Size = new System.Drawing.Size(15, 60);
            this.pnBar3.TabIndex = 11;
            // 
            // pnBar2
            // 
            this.pnBar2.BackColor = System.Drawing.Color.LimeGreen;
            this.pnBar2.Location = new System.Drawing.Point(256, 25);
            this.pnBar2.Name = "pnBar2";
            this.pnBar2.Size = new System.Drawing.Size(15, 60);
            this.pnBar2.TabIndex = 12;
            // 
            // pnBar1
            // 
            this.pnBar1.BackColor = System.Drawing.Color.LimeGreen;
            this.pnBar1.Location = new System.Drawing.Point(277, 25);
            this.pnBar1.Name = "pnBar1";
            this.pnBar1.Size = new System.Drawing.Size(15, 60);
            this.pnBar1.TabIndex = 13;
            // 
            // pnBar0
            // 
            this.pnBar0.BackColor = System.Drawing.Color.LimeGreen;
            this.pnBar0.Location = new System.Drawing.Point(298, 25);
            this.pnBar0.Name = "pnBar0";
            this.pnBar0.Size = new System.Drawing.Size(15, 60);
            this.pnBar0.TabIndex = 14;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(344, 179);
            this.Controls.Add(this.pnBars);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbMillis);
            this.Controls.Add(this.numAverage);
            this.Controls.Add(this.lbAverage);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lbServer);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "PingChk - Simple Network Monitoring Tool";
            ((System.ComponentModel.ISupportInitialize)(this.numAverage)).EndInit();
            this.pnBars.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lbAverage;
        private System.Windows.Forms.NumericUpDown numAverage;
        private System.Windows.Forms.Label lbMillis;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnBars;
        private System.Windows.Forms.Panel pnBar13;
        private System.Windows.Forms.Panel pnBar14;
        private System.Windows.Forms.Panel pnBar0;
        private System.Windows.Forms.Panel pnBar1;
        private System.Windows.Forms.Panel pnBar2;
        private System.Windows.Forms.Panel pnBar3;
        private System.Windows.Forms.Panel pnBar4;
        private System.Windows.Forms.Panel pnBar;
        private System.Windows.Forms.Panel pnBar6;
        private System.Windows.Forms.Panel pnBar7;
        private System.Windows.Forms.Panel pnBar8;
        private System.Windows.Forms.Panel pnBar9;
        private System.Windows.Forms.Panel pnBar10;
        private System.Windows.Forms.Panel pnBar11;
        private System.Windows.Forms.Panel pnBar12;
    }
}

