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
        public static async Task<long> GetServerLatencyAsync(string serverAddress, int timeout = 500, int fallbackLatency = 500)
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

        public static long GetServerLatency(string serverAddress, int timeout = 500, int fallbackLatency = 500)
        {
            using (var ping = new Ping())
            {
                try
                {
                    // Send ping to specific server
                    var reply = ping.Send(serverAddress, timeout);
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
    }
}
