using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OptifineProxy {
    class HostsChange {
        public static void load(String ip) {
            unload();

            String path = @"C:\Windows\System32\drivers\etc\hosts";
            if (!File.Exists(path)) {
                var f = File.Create(path);
                f.Close();
            }
            StreamWriter writer = new StreamWriter(path, true);

            writer.WriteLine(ip + " s.optifine.net");
            writer.Close();
        }

        public static void unload() {
            String path = @"C:\Windows\System32\drivers\etc\hosts";
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            StreamReader reader = new StreamReader(stream);
            var lines = new List<String>();
            String line;
            while ((line = reader.ReadLine()) != null) {
                lines.Add(line);
            }
            reader.Close();
            stream.Close();

            //Czyszczenie pliku
            File.WriteAllText(path, String.Empty);

            //Zapisywanie starych hostów
            StreamWriter writer = new StreamWriter(path, true);
            for (int i = 0; i < lines.Count; i++) {
                String currentItem = lines.ElementAt(i);
                try {
                    if (currentItem.Split(' ')[1].Equals("s.optifine.net")) continue;
                } catch (Exception) { }
                writer.WriteLine(currentItem);
            }
            writer.Close();
        }

        private static string getLocalIPAddress() {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList) {
                if (ip.AddressFamily == AddressFamily.InterNetwork) {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}
