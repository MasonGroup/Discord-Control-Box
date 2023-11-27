using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace DCB
{
    internal class API
    {
        private static string _DT;
        private static string _WH;
        private static HttpClient _httpClient = new HttpClient();
        private static HttpClient _httpClient2 = new HttpClient();
        public static string SetToken
        {
            get { return _DT; }
            set { _DT = value; }
        }
        public static string SetWebhook
        {
            get { return _WH; }
            set { _WH = value; }
        }
        public string getservers()
        {
            try
            {
                HttpResponseMessage response = _httpClient.GetAsync("https://discord.com/api/v8/users/@me/guilds").Result;
                response.EnsureSuccessStatusCode();

                dynamic data = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);

                List<string> serverNameHasAdmin = new List<string>();
                List<string> serverName = new List<string>();

                foreach (var server in data)
                {
                    if (server.permissions == "4398046511103")
                    {
                        serverNameHasAdmin.Add(server.name);
                    }

                    serverName.Add(server.name);
                }

                string serverHaveAdmin = string.Join("\n", serverNameHasAdmin);
                return $@"Server info :
───
servers : {serverName.Count}
servers has admin : {serverHaveAdmin}
───
";
            }
            catch (Exception ex)
            {
                return $"\nError getting servers: {ex.Message}\n";
            }
        }

        public string getfriends()
        {
            try
            {
                HttpResponseMessage response = _httpClient.GetAsync("https://discord.com/api/v8/users/@me/relationships").Result;
                response.EnsureSuccessStatusCode(); // Throws if not a success status code

                dynamic data = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);

                List<string> friendsList = new List<string>();

                foreach (var friend in data)
                {
                    friendsList.Add($"{friend.user.username}#{friend.user.discriminator}");
                }

                return $@"Friends info : 
───
friends : {friendsList.Count}
───
";
            }
            catch (Exception ex)
            {
                return $"Error getting friends: {ex.Message}";
            }
        }

        public string TokenInfo()
        {
            try
            {
                HttpResponseMessage response = _httpClient.GetAsync("https://discord.com/api/v8/users/@me").Result;
                response.EnsureSuccessStatusCode(); // Throws if not a success status code

                dynamic userInfo = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);

                string bd = "";
                int flags = userInfo.flags;
                bool nitro = false;

                // Flags
                if ((flags & 1) != 0) bd += "Staff, ";
                if ((flags & 2) != 0) bd += "Partner, ";
                if ((flags & 4) != 0) bd += "Hypesquad Event, ";
                if ((flags & 8) != 0) bd += "Green Bughunter, ";
                if ((flags & 64) != 0) bd += "Hypesquad Bravery, ";
                if ((flags & 128) != 0) bd += "HypeSquad Brilliance, ";
                if ((flags & 256) != 0) bd += "HypeSquad Balance, ";
                if ((flags & 512) != 0) bd += "Early Supporter, ";
                if ((flags & 16384) != 0) bd += "Gold BugHunter, ";
                if ((flags & 131072) != 0) bd += "Verified Bot Developer, ";

                HttpResponseMessage nitroResponse = _httpClient.GetAsync("https://discordapp.com/api/v9/users/@me/billing/subscriptions").Result;
                nitroResponse.EnsureSuccessStatusCode();

                dynamic nitroData = JsonConvert.DeserializeObject(nitroResponse.Content.ReadAsStringAsync().Result);

                nitro = nitroData.Count > 0;

                string avatarId = userInfo.avatar;
                string avatarUrl = $"https://cdn.discordapp.com/avatars/{userInfo.id}/{avatarId}.webp";
                DateTime creationDate = DateTimeOffset.FromUnixTimeMilliseconds(((long)userInfo.id >> 22) + 1420070400000).UtcDateTime;

                string result = $@"──────────────────────────── TOKEN INFO ────────────────────────────
Basic info :
───
Username : {userInfo.username}#{userInfo.discriminator}
Account age : {creationDate:dd-MM-yyyy HH:mm:ss UTC}
Language : {userInfo.locale}
Badges : {bd}
Avatar : {(string.IsNullOrEmpty(avatarId) ? "" : avatarUrl)}
token : {_DT}
phone : {userInfo.phone}
email : {userInfo.email}
MFA enabled ? (2FA) : {userInfo.mfa_enabled}
───

Nitro info : 
───
has nitro ? : {nitro}";

                if (nitro)
                {
                    DateTime currentPeriodEnd = nitroData[0].current_period_end;
                    DateTime currentPeriodStart = nitroData[0].current_period_start;
                    int daysRemaining = (currentPeriodEnd - currentPeriodStart).Days;

                    result += $@"exp. date : {daysRemaining} day(s)
───";
                }
                else
                {
                    result += "exp. date : N/A\n";
                }

                result += $@"{getservers()}

{getfriends()}
────────────────────────────────────────────────────────────────────";
                string filename = Path.Combine($"{Guid.NewGuid()}-DTB.txt");
                File.WriteAllText(filename, result);
                MessageBox.Show($"saved in {filename}");
                return result;
            }
            catch (Exception ex)
            {
                return $"Error getting token info: {ex.Message}";
            }
        }

        public bool checktoken()
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(_DT);
                HttpResponseMessage response = _httpClient.GetAsync("https://discord.com/api/v10/users/@me").Result;
                return response.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool checkwebhook()
        {
            HttpResponseMessage response = _httpClient2.GetAsync(_WH).Result;
            return response.IsSuccessStatusCode;
        }
        public bool deletewebhook()
        {
            HttpResponseMessage response = _httpClient2.DeleteAsync(_WH).Result;
            return response.IsSuccessStatusCode;
        }
        public string extract_webhook_info()
        {
            HttpResponseMessage response = _httpClient2.GetAsync(_WH).Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                return $"Error: {response.StatusCode} - {response.ReasonPhrase}";
            }
        }
        public bool sendmessage(string content, string avatarurl = null, string username = null)
        {
            try
            {
                var payload = new { content, username, avatar_url = avatarurl };
                string jsonpayload = Newtonsoft.Json.JsonConvert.SerializeObject(payload);
                var contentstring = new StringContent(jsonpayload, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _httpClient.PostAsync(_WH, contentstring).Result;
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
                
        }

    }
}
