using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingChk
{
    public static class LedController
    {
        public static void ChangeColor(this ToolStripStatusLabel label, Color color)
        {
            // Adjust ForeColor of label
            label.ForeColor = color;
        }

        public static void TurnGreen(this ToolStripStatusLabel label)
        {
            // Invoke change color method
            ChangeColor(label, Color.LimeGreen);
        }

        public static void TurnYellow(this ToolStripStatusLabel label)
        {
            // Invoke change color method
            ChangeColor(label, Color.Gold);
        }

        public static void TurnOrange(this ToolStripStatusLabel label)
        {
            // Invoke change color method
            ChangeColor(label, Color.DarkOrange);
        }

        public static void TurnRed(this ToolStripStatusLabel label)
        {
            // Invoke change color method
            ChangeColor(label, Color.Red);
        }

        public static void TurnSilver(this ToolStripStatusLabel label)
        {
            // Invoke change color method
            ChangeColor(label, Color.Silver);
        }
    }
}
