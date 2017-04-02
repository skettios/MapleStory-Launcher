using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using RestSharp;

namespace MSLauncher
{
    public class MapleStoryAuth
    {
        public static string GetAuthToken(string id, string pass, out string token, out int uid)
        {
            token = "";
            uid = -1;
            var restClient = new RestClient("https://api.nexon.net")
            {
                UserAgent =
                    "NexonLauncher node-webkit/0.14.6 (Windows NT 6.3; WOW64) WebKit/537.36 (@c26c0312e940221c424c2730ef72be2c69ac1b67) nexon_client"
            };
            var restRequest = new RestRequest("/auth/login", Method.POST);
            var credentials = Uri.EscapeDataString(id) + ":" + Uri.EscapeDataString(pass);
            var base64Credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials));
            restRequest.AddHeader("Accpt", "application/json, text/javascript, */*; q=0.01");
            restRequest.AddHeader("Accept-Language", "en-US;q=0.8");
            restRequest.AddHeader("Origin", "chrome-extension://dobbaijafcbikgimjpakclacfgeagffm");
            restRequest.AddHeader("Authorization", "Basic " + base64Credentials);
            restRequest.AddJsonBody(new
            {
                allow_unverified = true,
                user_id = id,
                user_pw = pass
            });
            var content = restClient.Execute(restRequest).Content;
            var contentDictionary =
                JsonConvert.DeserializeObject<Dictionary<string, object>>(content);
            if (contentDictionary.ContainsKey("error"))
            {
                return content;
            }

            if (contentDictionary.ContainsKey("refresh_token"))
            {
                token = contentDictionary["refresh_token"].ToString();
                uid = int.Parse(token.Split('_')[1]);
            }

            return content;
        }

        private static string _getMethod(string token, string method)
        {
            var restClient = new RestClient("http://api.nexon.net");
            var restRequest = new RestRequest(method, Method.GET);
            restRequest.AddParameter("access_token", token);
            return restClient.Execute(restRequest).Content;
        }

        public static string GetLoginString(string token)
        {
            var splitMethod1 = _getMethod(token, "/users/me/passport").Split('\"');
            var splitMethod2 = splitMethod1[7].Split(':')[1];
            var cookie = splitMethod1[7];
            var webClient = new WebClient();
            webClient.Headers.Add("Cookie", "NPPv2=" + cookie);
            webClient.Headers.Add("user-agent", "Python-urllib/2.7");
            var address = "http://" + splitMethod2 + ".nexon.net/ajax/default.aspx?_vb=UpdateSession";
            var stream = webClient.OpenRead(address);
            var streamReader = new StreamReader(stream);
            var input = streamReader.ReadToEnd();
            stream.Close();
            streamReader.Close();
            var match = Regex.Match(input,
                "NxamlLib\\.HandleResponse\\('<nxaml><number name=\"_cs\" value=\".*\"/><object name=\"_state\" type=\"State\">.*</object><number name=\"ErrorCode\" value=\"(.*)\"/><string name=\"ErrorMessage\" value=\"(.*)\"/><string name=\"NewPassport\" value=\"(.*)\"/><number name=\"UnreadNoteCount\" value=\".*\"/><number name=\"StatusFlag\" value=\".*\"/><number name=\"UpdateInterval\" value=\".*\"/></nxaml>'\\);");
            if (match.Success)
                return match.Groups[3].Value;

            return null;
        }
    }
}
