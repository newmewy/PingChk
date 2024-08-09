using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingChk
{
    public partial class Main : Form
    {
        private List<long> LatencyData60 { get; set; } = new List<long>();
        private List<long> LatencyData15 { get; set; } = new List<long>();

        public Main()
        {
            InitializeComponent();
        }

        private async void tmrLatencyChecker_Tick(object sender, EventArgs e)
        {
            // Request for latency data
            var latency = await Latency.GetServerLatencyAsync(txtServer.Text);
            // Add latency value to data array
            LatencyData60.Add(latency);
            // If latency data is exceeded ...
            if (LatencyData60.Count > 60)
            {
                // Then remove the last one
                LatencyData60.RemoveAt(0);
            }
            // Add latency value to data array
            LatencyData15.Add(latency);
            // If latency data is exceeded ...
            if (LatencyData15.Count > 15)
            {
                // Then remove the last one
                LatencyData15.RemoveAt(0);
            }
            // Push data into bar controller
            bcMain.PushData(Convert.ToInt32(latency));
            // Update statistics labels
            lbCurrentLatency.Text = $"(Now: {latency}ms)";
            lbAverageLatency.Text = $"AVG60S: {Convert.ToInt32(LatencyData60.Average())}ms | AVG15S: {Convert.ToInt32(LatencyData15.Average())}ms";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Define tag value
            var clickToStartTag = "to:start";
            var clickToStopTag = "to:stop";
            var clickToStartText = "Start";
            var clickToStopText = "Stop";
            // Tag check
            if (btnStart.Tag.ToString() == clickToStartTag)
            {
                // Then start the timer
                tmrLatencyChecker.Start();
                // Update button's tag
                btnStart.Tag = clickToStopTag;
                // Update button's text
                btnStart.Text = clickToStopText;
                // Disable server text box
                txtServer.Enabled = false;
                // Update statistics labels
                lbAverageLatency.Text = "";
                lbCurrentLatency.Text = "{Starting...)";
            }
            else
            {
                // Then stop the timer
                tmrLatencyChecker.Stop();
                // Update button's tag
                btnStart.Tag = clickToStartTag;
                // Update button's text
                btnStart.Text = clickToStartText;
                // Enable server text box
                txtServer.Enabled = true;
                // Update statistics labels
                lbAverageLatency.Text = "Paused, please press [Start] again";
                lbCurrentLatency.Text = "";
            }
        }
    }
}
