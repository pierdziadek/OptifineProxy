
using MaterialSkin.Controls;

namespace OptifineProxy {
    partial class Form1 {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableCapes = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTableNickname = new MaterialSkin.Controls.MaterialLabel();
            this.lblTableCape = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDestruct = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblResources = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.tbResourcesDirectory = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnResourcesDirectory = new MaterialSkin.Controls.MaterialFlatButton();
            this.tbServerIP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rbServerRemote = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbServerLocal = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnEnable = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDisable = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableCapes.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(-1, 89);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(551, 363);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tableCapes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(543, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Capes";
            // 
            // tableCapes
            // 
            this.tableCapes.ColumnCount = 3;
            this.tableCapes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableCapes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.91775F));
            this.tableCapes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.08225F));
            this.tableCapes.Controls.Add(this.materialLabel4, 0, 0);
            this.tableCapes.Controls.Add(this.lblTableNickname, 1, 0);
            this.tableCapes.Controls.Add(this.lblTableCape, 2, 0);
            this.tableCapes.Location = new System.Drawing.Point(9, 15);
            this.tableCapes.Name = "tableCapes";
            this.tableCapes.RowCount = 12;
            this.tableCapes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableCapes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCapes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCapes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCapes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCapes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCapes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCapes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCapes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCapes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCapes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCapes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableCapes.Size = new System.Drawing.Size(528, 322);
            this.tableCapes.TabIndex = 10;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(23, 47);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableNickname
            // 
            this.lblTableNickname.AutoSize = true;
            this.lblTableNickname.Depth = 0;
            this.lblTableNickname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableNickname.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTableNickname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTableNickname.Location = new System.Drawing.Point(32, 0);
            this.lblTableNickname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTableNickname.Name = "lblTableNickname";
            this.lblTableNickname.Size = new System.Drawing.Size(238, 47);
            this.lblTableNickname.TabIndex = 11;
            this.lblTableNickname.Text = "Nickname";
            this.lblTableNickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableCape
            // 
            this.lblTableCape.AutoSize = true;
            this.lblTableCape.Depth = 0;
            this.lblTableCape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTableCape.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTableCape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTableCape.Location = new System.Drawing.Point(276, 0);
            this.lblTableCape.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTableCape.Name = "lblTableCape";
            this.lblTableCape.Size = new System.Drawing.Size(249, 47);
            this.lblTableCape.TabIndex = 12;
            this.lblTableCape.Text = "Cape";
            this.lblTableCape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btnDestruct);
            this.tabPage2.Controls.Add(this.lblResources);
            this.tabPage2.Controls.Add(this.lblServer);
            this.tabPage2.Controls.Add(this.tbResourcesDirectory);
            this.tabPage2.Controls.Add(this.btnResourcesDirectory);
            this.tabPage2.Controls.Add(this.tbServerIP);
            this.tabPage2.Controls.Add(this.rbServerRemote);
            this.tabPage2.Controls.Add(this.rbServerLocal);
            this.tabPage2.Controls.Add(this.btnEnable);
            this.tabPage2.Controls.Add(this.btnDisable);
            this.tabPage2.Controls.Add(this.lblStatus);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(543, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            // 
            // btnDestruct
            // 
            this.btnDestruct.AutoSize = true;
            this.btnDestruct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDestruct.BackColor = System.Drawing.SystemColors.Control;
            this.btnDestruct.Depth = 0;
            this.btnDestruct.Location = new System.Drawing.Point(298, 314);
            this.btnDestruct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDestruct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDestruct.Name = "btnDestruct";
            this.btnDestruct.Primary = false;
            this.btnDestruct.Size = new System.Drawing.Size(80, 36);
            this.btnDestruct.TabIndex = 14;
            this.btnDestruct.Text = "Destruct";
            this.btnDestruct.UseVisualStyleBackColor = false;
            this.btnDestruct.Click += new System.EventHandler(this.btnDestruct_Click);
            // 
            // lblResources
            // 
            this.lblResources.AutoSize = true;
            this.lblResources.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResources.ForeColor = System.Drawing.Color.Black;
            this.lblResources.Location = new System.Drawing.Point(177, 141);
            this.lblResources.Name = "lblResources";
            this.lblResources.Size = new System.Drawing.Size(184, 23);
            this.lblResources.TabIndex = 13;
            this.lblResources.Text = "Resources Directory";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblServer.ForeColor = System.Drawing.Color.Black;
            this.lblServer.Location = new System.Drawing.Point(230, 24);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(66, 23);
            this.lblServer.TabIndex = 12;
            this.lblServer.Text = "Server";
            // 
            // tbResourcesDirectory
            // 
            this.tbResourcesDirectory.Depth = 0;
            this.tbResourcesDirectory.Hint = "";
            this.tbResourcesDirectory.Location = new System.Drawing.Point(8, 167);
            this.tbResourcesDirectory.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbResourcesDirectory.Name = "tbResourcesDirectory";
            this.tbResourcesDirectory.PasswordChar = '\0';
            this.tbResourcesDirectory.SelectedText = "";
            this.tbResourcesDirectory.SelectionLength = 0;
            this.tbResourcesDirectory.SelectionStart = 0;
            this.tbResourcesDirectory.Size = new System.Drawing.Size(456, 23);
            this.tbResourcesDirectory.TabIndex = 10;
            this.tbResourcesDirectory.Text = "C:\\Users\\%USERNAME%\\Desktop\\Capes Resources";
            this.tbResourcesDirectory.UseSystemPasswordChar = false;
            // 
            // btnResourcesDirectory
            // 
            this.btnResourcesDirectory.AutoSize = true;
            this.btnResourcesDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResourcesDirectory.Depth = 0;
            this.btnResourcesDirectory.Location = new System.Drawing.Point(469, 161);
            this.btnResourcesDirectory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnResourcesDirectory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnResourcesDirectory.Name = "btnResourcesDirectory";
            this.btnResourcesDirectory.Primary = false;
            this.btnResourcesDirectory.Size = new System.Drawing.Size(67, 36);
            this.btnResourcesDirectory.TabIndex = 7;
            this.btnResourcesDirectory.Text = "Change";
            this.btnResourcesDirectory.UseVisualStyleBackColor = true;
            this.btnResourcesDirectory.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // tbServerIP
            // 
            this.tbServerIP.BackColor = System.Drawing.SystemColors.Control;
            this.tbServerIP.Depth = 0;
            this.tbServerIP.Hint = "";
            this.tbServerIP.Location = new System.Drawing.Point(151, 80);
            this.tbServerIP.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.PasswordChar = '\0';
            this.tbServerIP.SelectedText = "";
            this.tbServerIP.SelectionLength = 0;
            this.tbServerIP.SelectionStart = 0;
            this.tbServerIP.Size = new System.Drawing.Size(229, 23);
            this.tbServerIP.TabIndex = 6;
            this.tbServerIP.Text = "127.0.0.1";
            this.tbServerIP.UseSystemPasswordChar = false;
            this.tbServerIP.Visible = false;
            // 
            // rbServerRemote
            // 
            this.rbServerRemote.AutoSize = true;
            this.rbServerRemote.Depth = 0;
            this.rbServerRemote.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbServerRemote.Location = new System.Drawing.Point(262, 47);
            this.rbServerRemote.Margin = new System.Windows.Forms.Padding(0);
            this.rbServerRemote.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbServerRemote.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbServerRemote.Name = "rbServerRemote";
            this.rbServerRemote.Ripple = true;
            this.rbServerRemote.Size = new System.Drawing.Size(118, 30);
            this.rbServerRemote.TabIndex = 1;
            this.rbServerRemote.Text = "Remote server";
            this.rbServerRemote.UseVisualStyleBackColor = true;
            this.rbServerRemote.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // rbServerLocal
            // 
            this.rbServerLocal.AutoSize = true;
            this.rbServerLocal.Checked = true;
            this.rbServerLocal.Depth = 0;
            this.rbServerLocal.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbServerLocal.Location = new System.Drawing.Point(145, 47);
            this.rbServerLocal.Margin = new System.Windows.Forms.Padding(0);
            this.rbServerLocal.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbServerLocal.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbServerLocal.Name = "rbServerLocal";
            this.rbServerLocal.Ripple = true;
            this.rbServerLocal.Size = new System.Drawing.Size(104, 30);
            this.rbServerLocal.TabIndex = 0;
            this.rbServerLocal.TabStop = true;
            this.rbServerLocal.Text = "Local server";
            this.rbServerLocal.UseVisualStyleBackColor = true;
            // 
            // btnEnable
            // 
            this.btnEnable.AutoSize = true;
            this.btnEnable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnable.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnable.Depth = 0;
            this.btnEnable.Location = new System.Drawing.Point(171, 314);
            this.btnEnable.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEnable.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Primary = false;
            this.btnEnable.Size = new System.Drawing.Size(62, 36);
            this.btnEnable.TabIndex = 7;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = false;
            this.btnEnable.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.AutoSize = true;
            this.btnDisable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDisable.BackColor = System.Drawing.SystemColors.Control;
            this.btnDisable.Depth = 0;
            this.btnDisable.Location = new System.Drawing.Point(232, 314);
            this.btnDisable.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDisable.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Primary = false;
            this.btnDisable.Size = new System.Drawing.Size(66, 36);
            this.btnDisable.TabIndex = 1;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = false;
            this.btnDisable.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(194, 291);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(163, 23);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status: DISABLED";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(543, 337);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Credits";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(66, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pan Pierdziadek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Author:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(163, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Special credits to:\r\n";
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(32, 50);
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(0, 0);
            this.materialSingleLineTextField3.TabIndex = 15;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(276, 50);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(0, 0);
            this.materialSingleLineTextField1.TabIndex = 16;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // tabSelector
            // 
            this.tabSelector.BaseTabControl = this.tabControl;
            this.tabSelector.Depth = 0;
            this.tabSelector.Location = new System.Drawing.Point(-1, 63);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(544, 42);
            this.tabSelector.TabIndex = 5;
            this.tabSelector.Text = "materialTabSelector1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.tabSelector);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Optifine Proxy Menu";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableCapes.ResumeLayout(false);
            this.tableCapes.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        public MaterialSingleLineTextField[] tbNicknameColumn = new MaterialSingleLineTextField[12];
        public MaterialSingleLineTextField[] tbCapeColumn = new MaterialSingleLineTextField[12];
        public MaterialCheckBox[] cbEnabledColumn = new MaterialCheckBox[12];
        private MaterialSkin.Controls.MaterialSingleLineTextField tbServerIP;
        private MaterialSkin.Controls.MaterialRadioButton rbServerRemote;
        private MaterialSkin.Controls.MaterialRadioButton rbServerLocal;
        private MaterialSkin.Controls.MaterialFlatButton btnResourcesDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel tableCapes;
        private MaterialSkin.Controls.MaterialLabel lblTableNickname;
        private MaterialSkin.Controls.MaterialLabel lblTableCape;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialFlatButton btnEnable;
        private MaterialSkin.Controls.MaterialFlatButton btnDisable;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResources;
        private System.Windows.Forms.Label lblServer;
        private MaterialFlatButton btnDestruct;
        public MaterialSingleLineTextField tbResourcesDirectory;
    }
}

