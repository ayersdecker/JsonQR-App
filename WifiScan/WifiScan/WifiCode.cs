using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiScan
{
    internal class WifiCode
    {
        // UID for AlertBoss User
        public string UID { get; set; }

        // Wifi AP Name
        public string WifiName { get; set; }

        // Wifi AP Password
        public string WifiPW { get; set; }

        // Parameterized Constructor
        public WifiCode(string uID, string wifiName, string wifiPW)
        {
            UID = uID;
            WifiName = wifiName;
            WifiPW = wifiPW;
        }
    }
}
