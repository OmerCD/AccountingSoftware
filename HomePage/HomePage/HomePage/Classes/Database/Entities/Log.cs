using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace HomePage.Classes.Database.Entities
{
    class Log : DbObject
    {
        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        public Log(string actionText, string baseName)
        {
            ActionText = actionText;
            ComputerName = Environment.MachineName;
            IPAddress = GetLocalIPAddress();
            User = MainPage.CurrentUser;
            MACAddress = GetMAC;
            LogBaseName = baseName;
        }

        public Log()
        {
            ComputerName = Environment.MachineName;
            IPAddress = GetLocalIPAddress();
            User = MainPage.CurrentUser;
            MACAddress = GetMAC;
        }

        private string GetMAC => NetworkInterface.GetAllNetworkInterfaces().Where(nic => nic.OperationalStatus == OperationalStatus.Up).Select(nic => nic.GetPhysicalAddress().ToString()).FirstOrDefault();
        public string ComputerName { get; set; }
        public string IPAddress { get; set; }
        public User User { get; set; }
        public string MACAddress { get; set; }
        public string ActionText { get; set; }
        public string LogBaseName { get; set; }
    }
}
