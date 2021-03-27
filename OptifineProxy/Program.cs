using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptifineProxy {
    static class Program {
        public static string currentVersion = "v1.1*";
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main() {
            string s = downloadInfo();
            if(getInformations(s, "tag_name") != currentVersion)
                MessageBox.Show("New version available! Download it from:\n" +
                    getInformations(s, "html_url"), "OptifineProxy");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static string downloadInfo() {
            string s = null;
            try {
                WebClient client = new WebClient();
                client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.105 Safari/537.36");
                string url = "https://api.github.com/repos/pierdziadek/OptifineProxy/releases/latest";
                StreamReader reader = new StreamReader(client.OpenRead(url));
                s = reader.ReadToEnd();
            } catch(Exception) {
                return null;
            }
            return s;
        }
        
        private static string getInformations(string s, string key) {
            try {
                JObject o = JObject.Parse(s);
                string response = o.SelectToken(key).Value<string>();
                return response;
            } catch (Exception) {
                return null;
            }
        }
    }
}
