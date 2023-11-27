using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCB.stub
{
    internal static class Settings
    {
        internal static string Webhook { get; private set; }
        internal static bool Ping { get; private set; }
        internal static bool Antivm { get; private set; }
        internal static bool Screenshot { get; private set; }
        internal static bool Disinjection { get; private set; }
        internal static bool Melt { get; private set; }
        static Settings()
        {
            var webhook = "";
            var ping = true;
            var antivm = true;
            var screenshot = true;
            var disinjection = true;
            var melt = true;
            Webhook = webhook;
            Ping = ping;
            Antivm = antivm;
            Screenshot = screenshot;
            Disinjection = disinjection;
            Melt = melt;
        }
    }
}