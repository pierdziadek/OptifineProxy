using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptifineProxy {
    class Startup {
        private static string appName = "OptifineProxy";
        public static void add() {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (!isStartupItem())
                rkApp.SetValue(appName, Application.ExecutablePath.ToString() + " -minimized");
        }
        public static void remove() {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isStartupItem())
                rkApp.DeleteValue(appName, false);
        }
        public static bool isStartupItem() {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (rkApp.GetValue(appName) == null)
                return false;
            else
                return true;
        }
    }
}
