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
        public Main()
        {
            InitializeComponent();
        }

        private async void tmrLatencyChecker_Tick(object sender, EventArgs e)
        {
            // Request for latency data
            var latency = await Latency.GetServerLatencyAsync(txtServer.Text);
            // Just push data into bar controller
            bcMain.PushData(Convert.ToInt32(latency));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Define tag values
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
            }
            else
            {
                // Then stop the timer
                tmrLatencyChecker.Stop();
                // Update button's tag
                btnStart.Tag = clickToStartTag;
                // Update button's text
                btnStart.Text = clickToStartText;
            }
        }
    }
}
