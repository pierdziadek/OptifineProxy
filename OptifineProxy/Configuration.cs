using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptifineProxy {
    class Configuration {
        public static string configDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\OptifineProxy";
        public static string configFile = configDirectory + @"\config.json";
        private static void fileExists() {
            if (!Directory.Exists(configDirectory)) Directory.CreateDirectory(configDirectory);
            if (File.Exists(configFile)) return;
            var f = File.Create(configFile);
            f.Close();
            JObject newJson = new JObject(
            new JProperty("configVersion", Program.configVersion));
            Program.json = newJson;

            saveToFile();
            save();
        }
        private static void saveToFile() {
            File.WriteAllText(configFile, String.Empty);
            StreamWriter writer = new StreamWriter(configFile, true);
            writer.WriteLine(Program.json.ToString());
            writer.Close();
        }
        private static void loadFromFile() {
            StreamReader reader = new StreamReader(configFile, true);
            String response = reader.ReadToEnd();
            Program.json = JObject.Parse(response);
            reader.Close();
        }
        public static void save() {
            fileExists();
            JObject newJson = new JObject(
            new JProperty("configVersion", Program.configVersion));
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            for (int i = 0; i < 11; i++) {
                newJson.Add("cbEnabledColumn" + i, form1.cbEnabledColumn[i].Checked);
                newJson.Add("tbNicknameColumn" + i, form1.tbNicknameColumn[i].Text);
                newJson.Add("tbCapeColumn" + i, form1.tbCapeColumn[i].Text);
            }
            newJson.Add("rbServerLocal", form1.rbServerLocal.Checked);
            newJson.Add("rbServerRemote", form1.rbServerRemote.Checked);
            newJson.Add("tbServerIP", form1.tbServerIP.Text);
            newJson.Add("tbResourcesDirectory", form1.tbResourcesDirectory.Text);
            newJson.Add("enabled", HttpServer.running);
            Program.json = newJson;
            saveToFile();
        }
        public static void load() {
            fileExists();
            loadFromFile();
            JObject json = Program.json;
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            for(int i = 0; i < 11; i++) {
                form1.cbEnabledColumn[i].Checked = (bool)json["cbEnabledColumn" + i];
                form1.tbNicknameColumn[i].Text = (string)json["tbNicknameColumn" + i];
                form1.tbCapeColumn[i].Text = (string)json["tbCapeColumn" + i];
            }
            form1.rbServerLocal.Checked = (bool)json["rbServerLocal"];
            form1.rbServerRemote.Checked = (bool)json["rbServerRemote"];
            form1.tbServerIP.Text = (string)json["tbServerIP"];
            form1.tbResourcesDirectory.Text = (string)json["tbResourcesDirectory"];
            if ((bool)json["enabled"]) form1.materialFlatButton2_Click(null, null);
            
        }
    }
}
