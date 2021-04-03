using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptifineProxy {
    class Logs {
        public static void WriteLine(String s) {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            DateTime localDate = DateTime.Now;
            CultureInfo culture = new CultureInfo("pl-PL");
            String date = localDate.ToString(culture);
            s = "[" + date + "] " + s + Environment.NewLine;

            try {
                form1.tbLogs.Invoke((MethodInvoker)(() => form1.tbLogs.AppendText(s)));
            } catch (Exception) { }
        }
    }
}
