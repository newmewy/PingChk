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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.bcMain = new PingChk.BarController();
            this.tmrLatencyChecker = new System.Windows.Forms.Timer(this.components);
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.ledAverageLatency = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbAverageLatency = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbCurrentLatency = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusMain.SuspendLayout();
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
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(235, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 28);
            this.btnStart.TabIndex = 5;
            this.btnStart.TabStop = false;
            this.btnStart.Tag = "to:start";
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // bcMain
            // 
            this.bcMain.Location = new System.Drawing.Point(12, 43);
            this.bcMain.Margin = new System.Windows.Forms.Padding(4);
            this.bcMain.Name = "bcMain";
            this.bcMain.Size = new System.Drawing.Size(324, 91);
            this.bcMain.TabIndex = 6;
            // 
            // tmrLatencyChecker
            // 
            this.tmrLatencyChecker.Interval = 1000;
            this.tmrLatencyChecker.Tick += new System.EventHandler(this.tmrLatencyChecker_Tick);
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ledAverageLatency,
            this.lbAverageLatency,
            this.lbCurrentLatency,
            this.lbSpring,
            this.btnSettings});
            this.statusMain.Location = new System.Drawing.Point(0, 143);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(344, 22);
            this.statusMain.SizingGrip = false;
            this.statusMain.TabIndex = 7;
            this.statusMain.Text = "statusStrip1";
            // 
            // ledAverageLatency
            // 
            this.ledAverageLatency.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.ledAverageLatency.ForeColor = System.Drawing.Color.Silver;
            this.ledAverageLatency.Name = "ledAverageLatency";
            this.ledAverageLatency.Size = new System.Drawing.Size(17, 17);
            this.ledAverageLatency.Text = "●";
            // 
            // lbAverageLatency
            // 
            this.lbAverageLatency.Name = "lbAverageLatency";
            this.lbAverageLatency.Size = new System.Drawing.Size(69, 17);
            this.lbAverageLatency.Text = "Press [Start]";
            // 
            // lbCurrentLatency
            // 
            this.lbCurrentLatency.Name = "lbCurrentLatency";
            this.lbCurrentLatency.Size = new System.Drawing.Size(0, 17);
            // 
            // lbSpring
            // 
            this.lbSpring.Name = "lbSpring";
            this.lbSpring.Size = new System.Drawing.Size(168, 17);
            this.lbSpring.Spring = true;
            // 
            // btnSettings
            // 
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(29, 20);
            this.btnSettings.Text = "toolStripDropDownButton1";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(344, 165);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.bcMain);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lbServer);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "PingChk - Simple Network Monitoring Tool";
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnStart;
        private BarController bcMain;
        private System.Windows.Forms.Timer tmrLatencyChecker;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel ledAverageLatency;
        private System.Windows.Forms.ToolStripStatusLabel lbAverageLatency;
        private System.Windows.Forms.ToolStripStatusLabel lbSpring;
        private System.Windows.Forms.ToolStripStatusLabel lbCurrentLatency;
        private System.Windows.Forms.ToolStripDropDownButton btnSettings;
    }
}

