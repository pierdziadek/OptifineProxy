using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptifineProxy {
    class HttpServer {
        public static Boolean running = false;
        private static HttpListener listener = new HttpListener();
        public static void start() {
            listener.Prefixes.Add("http://s.optifine.net/");
            listener.Start();
            Logs.WriteLine("HTTP server started!");
            while (running) {
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;

                if (request.RawUrl == "/users/") continue;
                String regex = @"\/(?<requesttype>(.+))/(?<nickname>(.+)).(?<filetype>(...))";
                string nickname = Regex.Replace(request.RawUrl, regex, "${nickname}");
                string requesttype = Regex.Replace(request.RawUrl, regex, "${requesttype}");
                string filetype = Regex.Replace(request.RawUrl, regex, "${filetype}");
                Console.WriteLine(request.RawUrl + " " + nickname + " " + requesttype);
                Logs.WriteLine("Request for " + requesttype +  " " + nickname);

                HttpListenerResponse response = context.Response;
                byte[] buffer = responseCape(nickname);
                if(UTF8Encoding.UTF8.GetString(buffer).Equals("Not found")) {
                    response.StatusCode = 404;
                    response.AddHeader("Content-Type", "text/html");
                }
                response.ContentLength64 = buffer.Length;
                Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                output.Close();
            }
            listener.Stop();
        }
        public static void stop() {
            running = false;
        }
        private static byte[] responseCape(String nickname) {
            byte[] output;
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            for (int i = 0; i < form1.tbNicknameColumn.Length; i++) {
                if(form1.tbNicknameColumn[i].Text.Equals(nickname)) {
                    string capeName = form1.tbCapeColumn[i].Text;
                    string path = form1.tbResourcesDirectory.Text + @"\" + capeName + @".png";
                    output = File.ReadAllBytes(path);
                    return output;
                }
            }

            var webClient = new WebClient();
            try {
                output = webClient.DownloadData("http://optifine.net/capes/" + nickname + ".png");
            } catch (WebException) {
                return UTF8Encoding.UTF8.GetBytes("Not found");
            }
            return output;
        }
    }
}
