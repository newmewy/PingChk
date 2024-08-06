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
    public partial class BarController : UserControl
    {
        private Size BarDefaultSize { get; set; }
        private Point Bar0DefaultLocation { get; set; }
        private int BarOffsetX { get; set; }
        private int BarOffsetY { get; set; }
        private int BarMinY { get; set; }
        private int BarMaxY { get; set; }

        public int MinLatency { get; private set; }
        public int MaxLatency { get; private set; }

        private List<int> LatencyData { get; set; } = new List<int>();
        private List<Panel> Bars { get; set; }

        public BarController()
        {
            InitializeComponent();
            // Add bars to array
            Bars = new List<Panel>
            {
                // Was fixed to 15 bars ... (Bar0 is on the right most)
                pnBar0,
                pnBar1,
                pnBar2,
                pnBar3,
                pnBar4,
                pnBar5,
                pnBar6,
                pnBar7,
                pnBar8,
                pnBar9,
                pnBar10,
                pnBar11,
                pnBar12,
                pnBar13,
                pnBar14,
            };
            // Add zeroes to array
            for (int i = 0; i < Bars.Count; i++)
            {
                LatencyData.Add(0);
            }
            // Assign default settings
            InitialConfig();
            // Initial bar visualization
            InitialBars();
        }

        private int Map(int value, int fromLow, int fromHigh, int toLow, int toHigh)
        {
            // Assign bound values when value is exceed the threshold
            if (value <= fromLow) return fromLow;
            if (value >= fromHigh) return fromHigh;
            // Normalize the value
            var normalized = Convert.ToDouble(value - fromLow) / (fromHigh - fromLow);
            // Map the normalized value to the new range
            var result = toLow + (normalized * (toHigh - toLow));
            // Return result as integer
            return Convert.ToInt32(result);
        }

        private void InitialConfig()
        {
            // Apply default configurations to properties
            BarMinY = 20;
            BarMaxY = 100;
            BarDefaultSize = new Size(15, 0);
            Bar0DefaultLocation = new Point(298, BarMaxY - BarDefaultSize.Height); // Bars[0]
            BarOffsetX = -21;
            BarOffsetY = 0;
            MinLatency = 0;
            MaxLatency = 300;
        }

        private void InitialBars()
        {
            // Loop for each bars ...
            for (int i = 0; i < Bars.Count; i++)
            {
                // Adjust size of bar to default
                Bars[i].Size = BarDefaultSize;
                // Only for first iteration ...
                if (i == 0)
                {
                    // Assign location of first bar to their default values
                    Bars[0].Location = new Point(Bar0DefaultLocation.X, Bar0DefaultLocation.Y);
                }
                else
                {
                    // Otherwise, adjust their location based on first bar with fixed offset on Y-axis
                    Bars[i].Location = new Point(Bars[i - 1].Location.X + BarOffsetX, Bars[i - 1].Location.Y + BarOffsetY);
                }
            }
        }

        public void UpdateBar(int index, int value)
        {
            // Adjust bar height by mapping latency values into maximum height of the bar
            Bars[index].Height = Map(value, MinLatency, MaxLatency, BarMinY, BarMaxY);
            // Move the bar into calculated location based on their height
            Bars[index].Location = new Point(Bars[index].Location.X, BarMaxY - Bars[index].Height);
        }

        public void UpdateBars()
        {
            // For each bars ...
            for (int i = 0; i < Bars.Count; i++)
            {
                // Invoke update bar function
                UpdateBar(i, LatencyData[i]);
            }
        }

        public void PushData(int latency, bool invokeUpdateBar = true)
        {
            // Insert recent data into the first bar (Right most)
            LatencyData.Insert(0, latency);
            // Remove the oldest one (Left most)
            LatencyData.RemoveAt(Bars.Count);
            // If flag specified ...
            if (invokeUpdateBar)
            {
                // Then update all bars
                UpdateBars();
            }
        }

        public Size GetBarSize(int index)
        {
            // Return size of specific bar
            return Bars[index].Size;
        }

        public Point GetBarLocation(int index)
        {
            // Return location of specific bar
            return Bars[index].Location;
        }

        public void SetLatency(int minLatency, int maxLatency)
        {
            // Assign latency values to properties
            MinLatency = minLatency;
            MaxLatency = maxLatency;
        }
    }
}
