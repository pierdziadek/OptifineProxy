using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptifineProxy {
    public partial class Form1 : MaterialSkin.Controls.MaterialForm {
        public Form1() {
            InitializeComponent();
            
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue700, Accent.LightBlue400,
                TextShade.WHITE
            );

            tbResourcesDirectory.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Capes Resources";

            for (int i = 0; i < tbNicknameColumn.Length; i++) {
                tbNicknameColumn[i] = new MaterialSingleLineTextField();
                tbNicknameColumn[i].BackColor = SystemColors.Control;
                tbNicknameColumn[i].Depth = 0;
                tbNicknameColumn[i].Dock = DockStyle.Fill;
                tbNicknameColumn[i].Hint = "";
                tbNicknameColumn[i].Location = new Point(276, 50);
                tbNicknameColumn[i].MouseState = MouseState.HOVER;
                tbNicknameColumn[i].Name = "tbNicknameColumn" + i;
                tbNicknameColumn[i].PasswordChar = '\0';
                tbNicknameColumn[i].SelectedText = "";
                tbNicknameColumn[i].SelectionLength = 0;
                tbNicknameColumn[i].SelectionStart = 0;
                tbNicknameColumn[i].Size = new Size(50, 23);
                tbNicknameColumn[i].TabIndex = 6;
                tbNicknameColumn[i].Text = "";
                tbNicknameColumn[i].UseSystemPasswordChar = false;

                tbCapeColumn[i] = new MaterialSingleLineTextField();
                tbCapeColumn[i].BackColor = SystemColors.Control;
                tbCapeColumn[i].Depth = 0;
                tbCapeColumn[i].Dock = DockStyle.Fill;
                tbCapeColumn[i].Hint = "";
                tbCapeColumn[i].Location = new Point(276, 50);
                tbCapeColumn[i].MouseState = MouseState.HOVER;
                tbCapeColumn[i].Name = "tbCapeColumn" + i;
                tbCapeColumn[i].PasswordChar = '\0';
                tbCapeColumn[i].SelectedText = "";
                tbCapeColumn[i].SelectionLength = 0;
                tbCapeColumn[i].SelectionStart = 0;
                tbCapeColumn[i].Size = new Size(50, 23);
                tbCapeColumn[i].TabIndex = 6;
                tbCapeColumn[i].Text = "";
                tbCapeColumn[i].UseSystemPasswordChar = false;

                cbEnabledColumn[i] = new MaterialCheckBox();
                cbEnabledColumn[i].AutoSize = true;
                cbEnabledColumn[i].Depth = 0;
                cbEnabledColumn[i].Font = new Font("Roboto", 10F);
                cbEnabledColumn[i].Location = new Point(113, 130);
                cbEnabledColumn[i].Margin = new Padding(0);
                cbEnabledColumn[i].MouseLocation = new Point(-1, -1);
                cbEnabledColumn[i].MouseState = MouseState.HOVER;
                cbEnabledColumn[i].Name = "cbEnabledColumn" + i;
                cbEnabledColumn[i].Ripple = true;
                cbEnabledColumn[i].Size = new Size(150, 30);
                cbEnabledColumn[i].TabIndex = 6;
                cbEnabledColumn[i].Text = "";
                cbEnabledColumn[i].UseVisualStyleBackColor = true;

                tableCapes.Controls.Add(cbEnabledColumn[i], 0, i+1);
                tableCapes.Controls.Add(tbNicknameColumn[i], 1, i+1);
                tableCapes.Controls.Add(tbCapeColumn[i], 2, i+1);
            }

            cbEnabledColumn[0].Checked = true;
            tbNicknameColumn[0].Text = "pierdziadek";
            tbCapeColumn[0].Text = "2016";
            cbStartup.Checked = Startup.isStartupItem();
            if (Program.args.Length > 0 && Program.args[0] == "-minimized") {
                Hide();
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
            }
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e) {
              tbServerIP.Visible = ((MaterialRadioButton)sender).Checked;
        }

        private void materialFlatButton3_Click(object sender, EventArgs e) {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                tbResourcesDirectory.Text = folderBrowserDialog1.SelectedPath;
            } else if (result == DialogResult.Cancel) {
                return;
            }
        }

        public void materialFlatButton2_Click(object sender, EventArgs e) {
            lblStatus.Text = "Status: ENABLED";
            lblStatus.ForeColor = Color.Green;
            if (rbServerLocal.Checked) HostsChange.load("127.0.0.1");
            else {
                HostsChange.load(tbServerIP.Text);
                return;
            }
            HttpServer.running = true;
            Task.Run(() => HttpServer.start());
        }

        private void materialFlatButton1_Click(object sender, EventArgs e) {
            lblStatus.Text = "Status: DISABLED";
            lblStatus.ForeColor = Color.Red;
            HttpServer.stop();
        }

        private void btnDestruct_Click(object sender, EventArgs e) {
            HostsChange.unload();
            btnDisable.PerformClick();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                Configuration.save();
            } catch (Exception) { }
        }

        private void Form1_Load(object sender, EventArgs e) {
            try {
                Configuration.load();
            } catch (Exception) { }
            Logs.WriteLine("Application started!");
        }

        private void Form1_Resize(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
            ShowInTaskbar = true;
        }

        private void cbStartup_CheckedChanged(object sender, EventArgs e) {
            MaterialCheckBox cb = (MaterialCheckBox)sender;
            if (cb.Checked) Startup.add();
            else Startup.remove();
        }
    }
}
