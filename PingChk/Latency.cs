using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PingChk
{
    public static class Latency
    {
        public static async Task<double> GetServerLatencyAsync(string serverAddress, int timeout = 500, int fallbackLatency = 500)
        {
            using (var ping = new Ping())
            {
                try
                {
                    // Send ping to specific server
                    var reply = await ping.SendPingAsync(serverAddress, timeout);
                    // If there is success ...
                    if (reply.Status == IPStatus.Success)
                    {
                        // Return latency value in milliseconds
                        return reply.RoundtripTime;
                    }
                    else
                    {
                        // Otherwise, return fallback value instead
                        return fallbackLatency;
                    }
                }
                catch
                {
                    // If there is error, return fallback as well
                    return fallbackLatency;
                }
            }
        }

        public static Color GetColorByLatency(long latency, int greenWhenBelow = 30, int yellowWhenBelow = 100, int orangeWhenBelow = 200)
        {
            // In case of error then return Silver
            if (latency < 0) return Color.Silver;
            // Otherwise, return color depends on latency data
            else if (latency <= greenWhenBelow) return Color.LimeGreen;
            else if (latency <= yellowWhenBelow) return Color.Yellow;
            else if (latency <= orangeWhenBelow) return Color.Orange;
            // If latency is higher than orange zone then return red color (Higher or timedout will be the same)
            else return Color.Red;
        }
    }
}
