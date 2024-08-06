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
            this.barController1 = new PingChk.BarController();
            ((System.ComponentModel.ISupportInitialize)(this.numAverage)).BeginInit();
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
            // barController1
            // 
            this.barController1.Location = new System.Drawing.Point(7, 75);
            this.barController1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barController1.Name = "barController1";
            this.barController1.Size = new System.Drawing.Size(324, 91);
            this.barController1.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(344, 179);
            this.Controls.Add(this.barController1);
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
        private BarController barController1;
    }
}

