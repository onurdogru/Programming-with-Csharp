// Decompiled with JetBrains decompiler
// Type: EsdTurnikesi.AyarForm
// Assembly: EsdTurnikesi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C8099926-BBEB-495E-ADF6-36B4F5F75BE8
// Assembly location: C:\Users\serkan.baki\Desktop\esd-rar\ESD\Release\EsdTurnikesi.exe

using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text;

namespace ProgrammingStation
{
    public class ProgAyarForm : Form
    {
        public FormMain MainFrm;
        private IContainer components;
        private GroupBox groupBox7;
        private Label label27;
        private Label label26;

        private Button btnKaydet;
        private TextBox txtKaliteSifre;
        private TextBox txtAdminSifre;
        private TextBox txtTimerAdmin;
        private Label label25;
        private Label label24;
        private Label label12;
        private TextBox txtBatchDosya;
        private Button btnLogsec;
        private TextBox projectName;
        private Label label29;
        private Button btnIDsec;
        private TextBox txtINIdosya;
        private Label label220;
        private Button btnOkuIni;
        private Button btnKaydetIni;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnE8PNGsec;
        private TextBox txtE8PNGdosya;
        private Label label36;
        private CheckBox chBoxSuccess;
        private CheckBox chBoxError1;
        private CheckBox chBoxError2;
        private CheckBox chBoxError3;
        private GroupBox groupBox4;
        private TextBox txtError3Batch;
        private TextBox txtError2Batch;
        private TextBox txtError1Batch;
        private TextBox txtSuccessBatch;
        private Button btnE945PNGsec;
        private TextBox txtE945PNGdosya;
        private Label label2;
        private Button btnE9PNGsec;
        private TextBox txtE9PNGdosya;
        private Label label1;
        private Button btnE10PNGsec;
        private TextBox txtE10PNGdosya;
        private Label label3;
        private CheckBox checkBox2;

        public ProgAyarForm()
        {
            this.InitializeComponent();
        }

        public class INIKaydet
        {
            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

            public INIKaydet(string dosyaYolu)
            {
                DOSYAYOLU = dosyaYolu;
            }
            private string DOSYAYOLU = String.Empty;
            public string Varsayilan { get; set; }
            public string Oku(string bolum, string ayaradi)
            {
                Varsayilan = Varsayilan ?? string.Empty;
                StringBuilder StrBuild = new StringBuilder(256);
                GetPrivateProfileString(bolum, ayaradi, Varsayilan, StrBuild, 255, DOSYAYOLU);
                return StrBuild.ToString();
            }
            public long Yaz(string bolum, string ayaradi, string deger)
            {
                return WritePrivateProfileString(bolum, ayaradi, deger, DOSYAYOLU);
            }
        }

        private void AyarForm_Load(object sender, EventArgs e)
        {
            this.txtINIdosya.Text = Prog_Ayarlar.Default.iniDosyaYolu;
            this.projectName.Text = Prog_Ayarlar.Default.projectName;
            this.txtBatchDosya.Text = Prog_Ayarlar.Default.Logdosyayolu;
            this.txtE8PNGdosya.Text = Prog_Ayarlar.Default.E8PNGdosyayolu;
            this.txtE9PNGdosya.Text = Prog_Ayarlar.Default.E9PNGdosyayolu;
            this.txtE945PNGdosya.Text = Prog_Ayarlar.Default.E945PNGdosyayolu;
            this.txtE10PNGdosya.Text = Prog_Ayarlar.Default.E10PNGdosyayolu;
            this.txtAdminSifre.Text = Prog_Ayarlar.Default.adminSifre.ToString();
            this.txtKaliteSifre.Text = Prog_Ayarlar.Default.kaliteSifre.ToString();
            this.txtTimerAdmin.Text = Prog_Ayarlar.Default.timerAdmin.ToString();

            this.chBoxSuccess.Checked = Prog_Ayarlar.Default.chBoxSuccess;
            if (chBoxSuccess.Checked == true)
                txtSuccessBatch.Enabled = true;
            else
                txtSuccessBatch.Enabled = false;

            this.chBoxError1.Checked = Prog_Ayarlar.Default.chBoxError1;
            if (chBoxError1.Checked == true)
                txtError1Batch.Enabled = true;
            else
                txtError1Batch.Enabled = false;

            this.chBoxError2.Checked = Prog_Ayarlar.Default.chBoxError2;
            if (chBoxError2.Checked == true)
                txtError2Batch.Enabled = true;
            else
                txtError2Batch.Enabled = false;

            this.chBoxError3.Checked = Prog_Ayarlar.Default.chBoxError3;
            if (chBoxError3.Checked == true)
                txtError3Batch.Enabled = true;
            else
                txtError3Batch.Enabled = false;

            this.txtSuccessBatch.Text = Prog_Ayarlar.Default.successBatch;
            this.txtError1Batch.Text = Prog_Ayarlar.Default.error1Batch;
            this.txtError2Batch.Text = Prog_Ayarlar.Default.error2Batch;
            this.txtError3Batch.Text = Prog_Ayarlar.Default.error3Batch;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Prog_Ayarlar.Default.iniDosyaYolu = this.txtINIdosya.Text;
                Prog_Ayarlar.Default.projectName = this.projectName.Text;
                Prog_Ayarlar.Default.Logdosyayolu = this.txtBatchDosya.Text;
                Prog_Ayarlar.Default.E8PNGdosyayolu = this.txtE8PNGdosya.Text;
                Prog_Ayarlar.Default.E9PNGdosyayolu = this.txtE9PNGdosya.Text;
                Prog_Ayarlar.Default.E945PNGdosyayolu = this.txtE945PNGdosya.Text;
                Prog_Ayarlar.Default.E10PNGdosyayolu = this.txtE10PNGdosya.Text;

                Prog_Ayarlar.Default.adminSifre = this.txtAdminSifre.Text;
                Prog_Ayarlar.Default.kaliteSifre = this.txtKaliteSifre.Text;

                Prog_Ayarlar.Default.timerAdmin = Convert.ToInt32(this.txtTimerAdmin.Text);

                Prog_Ayarlar.Default.chBoxSuccess = this.chBoxSuccess.Checked;
                Prog_Ayarlar.Default.chBoxError1 = this.chBoxError1.Checked;
                Prog_Ayarlar.Default.chBoxError2 = this.chBoxError2.Checked;
                Prog_Ayarlar.Default.chBoxError3 = this.chBoxError3.Checked;
                Prog_Ayarlar.Default.successBatch = this.txtSuccessBatch.Text;
                Prog_Ayarlar.Default.error1Batch = this.txtError1Batch.Text;
                Prog_Ayarlar.Default.error2Batch = this.txtError2Batch.Text;
                Prog_Ayarlar.Default.error3Batch = this.txtError3Batch.Text;
                Prog_Ayarlar.Default.Save();

                int num1 = (int)MessageBox.Show("Bütün Ayarlar Başarıyla Kaydedildi.");
                this.Close();

                Application.Restart();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Ayarlar Kayıt Hatası: " + ex.ToString());
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.txtAdminSifre.Enabled = true;
                this.txtKaliteSifre.Enabled = true;
                this.txtAdminSifre.PasswordChar = char.MinValue;
                this.txtKaliteSifre.PasswordChar = char.MinValue;
            }
            else
            {
                this.txtAdminSifre.Enabled = false;
                this.txtKaliteSifre.Enabled = false;
                this.txtAdminSifre.PasswordChar = '*';
                this.txtKaliteSifre.PasswordChar = '*';
            }
        }

        private void btnKaydetIni_Click(object sender, EventArgs e)
        {
            if (txtINIdosya.Text != "")
            {
                INIKaydet ini = new INIKaydet(txtINIdosya.Text);  // @"\Ayarlar.ini"
                ini.Yaz("batchDosya", "Metin Kutusu", Convert.ToString(txtBatchDosya.Text));
                ini.Yaz("projectName", "Metin Kutusu", Convert.ToString(projectName.Text));
                ini.Yaz("projectE8PNG", "Metin Kutusu", Convert.ToString(txtE8PNGdosya.Text));
                ini.Yaz("projectE9PNG", "Metin Kutusu", Convert.ToString(txtE9PNGdosya.Text));
                ini.Yaz("projectE945PNG", "Metin Kutusu", Convert.ToString(txtE945PNGdosya.Text));
                ini.Yaz("projectE10PNG", "Metin Kutusu", Convert.ToString(txtE10PNGdosya.Text));
                ini.Yaz("successChecked", "Metin Kutusu", Convert.ToString(chBoxSuccess.Checked));
                ini.Yaz("error1Checked", "Metin Kutusu", Convert.ToString(chBoxError1.Checked));
                ini.Yaz("error2Checked", "Metin Kutusu", Convert.ToString(chBoxError2.Checked));
                ini.Yaz("error3Checked", "Metin Kutusu", Convert.ToString(chBoxError3.Checked));
                ini.Yaz("successBatch", "Metin Kutusu", Convert.ToString(txtSuccessBatch.Text));
                ini.Yaz("error1Batch", "Metin Kutusu", Convert.ToString(txtError1Batch.Text));
                ini.Yaz("error2Batch", "Metin Kutusu", Convert.ToString(txtError2Batch.Text));
                ini.Yaz("error3Batch", "Metin Kutusu", Convert.ToString(txtError3Batch.Text));
            }
            else
            {
                CustomMessageBox.ShowMessage("Dosya Yolu Boş Kalamaz", Prog_Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Red);
            }
        }

        private void btnOkuIni_Click(object sender, EventArgs e)
        {
            if (txtINIdosya.Text != "")
            {
                try
                {
                    if (File.Exists(txtINIdosya.Text))
                    {
                        INIKaydet ini = new INIKaydet(txtINIdosya.Text);
                        txtBatchDosya.Text = ini.Oku("batchDosya", "Metin Kutusu");
                        projectName.Text = ini.Oku("projectName", "Metin Kutusu");
                        txtE8PNGdosya.Text = ini.Oku("projectE8PNG", "Metin Kutusu");
                        txtE9PNGdosya.Text = ini.Oku("projectE9PNG", "Metin Kutusu");
                        txtE945PNGdosya.Text = ini.Oku("projectE945PNG", "Metin Kutusu");
                        txtE10PNGdosya.Text = ini.Oku("projectE10PNG", "Metin Kutusu");

                        if (ini.Oku("successChecked", "Metin Kutusu") == "True")
                            chBoxSuccess.Checked = true;
                        else if (ini.Oku("successChecked", "Metin Kutusu") == "False")
                            chBoxSuccess.Checked = false;

                        if (ini.Oku("error1Checked", "Metin Kutusu") == "True")
                            chBoxError1.Checked = true;
                        else if (ini.Oku("error1Checked", "Metin Kutusu") == "False")
                            chBoxError1.Checked = false;

                        if (ini.Oku("error2Checked", "Metin Kutusu") == "True")
                            chBoxError2.Checked = true;
                        else if (ini.Oku("error2Checked", "Metin Kutusu") == "False")
                            chBoxError2.Checked = false;

                        if (ini.Oku("error3Checked", "Metin Kutusu") == "True")
                            chBoxError3.Checked = true;
                        else if (ini.Oku("error3Checked", "Metin Kutusu") == "False")
                            chBoxError3.Checked = false;

                        txtSuccessBatch.Text = ini.Oku("successBatch", "Metin Kutusu");
                        txtError1Batch.Text = ini.Oku("error1Batch", "Metin Kutusu");
                        txtError2Batch.Text = ini.Oku("error2Batch", "Metin Kutusu");
                        txtError3Batch.Text = ini.Oku("error3Batch", "Metin Kutusu");
                    }
                }
                catch (Exception)
                {
                    CustomMessageBox.ShowMessage("ini Dosyası Hasarlı", Prog_Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Red);
                }
            }
            else
            {
                CustomMessageBox.ShowMessage("Dosya Yolu Boş Kalamaz", Prog_Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Red);
            }
        }

        private void btnIDsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.ini";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.txtINIdosya.Text = openFileDialog.FileName;
        }

        private void btnLogsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Database Dosyaları|*.bat|Tüm Dosyalar|*.*";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.txtBatchDosya.Text = openFileDialog.FileName;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgAyarForm));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtKaliteSifre = new System.Windows.Forms.TextBox();
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtTimerAdmin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBatchDosya = new System.Windows.Forms.TextBox();
            this.btnLogsec = new System.Windows.Forms.Button();
            this.projectName = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btnIDsec = new System.Windows.Forms.Button();
            this.txtINIdosya = new System.Windows.Forms.TextBox();
            this.label220 = new System.Windows.Forms.Label();
            this.btnOkuIni = new System.Windows.Forms.Button();
            this.btnKaydetIni = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnE10PNGsec = new System.Windows.Forms.Button();
            this.txtE10PNGdosya = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnE945PNGsec = new System.Windows.Forms.Button();
            this.txtE945PNGdosya = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnE9PNGsec = new System.Windows.Forms.Button();
            this.txtE9PNGdosya = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnE8PNGsec = new System.Windows.Forms.Button();
            this.txtE8PNGdosya = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.chBoxSuccess = new System.Windows.Forms.CheckBox();
            this.chBoxError1 = new System.Windows.Forms.CheckBox();
            this.chBoxError2 = new System.Windows.Forms.CheckBox();
            this.chBoxError3 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtError3Batch = new System.Windows.Forms.TextBox();
            this.txtError2Batch = new System.Windows.Forms.TextBox();
            this.txtError1Batch = new System.Windows.Forms.TextBox();
            this.txtSuccessBatch = new System.Windows.Forms.TextBox();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Aqua;
            this.btnKaydet.Font = new System.Drawing.Font("Calibri", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(397, 160);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(175, 309);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Ayarları Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 21);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 21);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Şifre Değiştir";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // txtKaliteSifre
            // 
            this.txtKaliteSifre.Enabled = false;
            this.txtKaliteSifre.Location = new System.Drawing.Point(75, 84);
            this.txtKaliteSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKaliteSifre.Name = "txtKaliteSifre";
            this.txtKaliteSifre.PasswordChar = '*';
            this.txtKaliteSifre.Size = new System.Drawing.Size(89, 24);
            this.txtKaliteSifre.TabIndex = 0;
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.Enabled = false;
            this.txtAdminSifre.Location = new System.Drawing.Point(75, 52);
            this.txtAdminSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.PasswordChar = '*';
            this.txtAdminSifre.Size = new System.Drawing.Size(89, 24);
            this.txtAdminSifre.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(-3, 87);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(72, 17);
            this.label27.TabIndex = 1;
            this.label27.Text = "Kalite Şifre:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(-1, 55);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 17);
            this.label26.TabIndex = 1;
            this.label26.Text = "Adm. Şifre:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox2);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.txtAdminSifre);
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Controls.Add(this.txtKaliteSifre);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.txtTimerAdmin);
            this.groupBox7.Location = new System.Drawing.Point(397, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(175, 143);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Şifre Ayarları:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(-1, 122);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 17);
            this.label24.TabIndex = 23;
            this.label24.Text = "T. Admin:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(144, 120);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(25, 17);
            this.label25.TabIndex = 24;
            this.label25.Text = "mS";
            // 
            // txtTimerAdmin
            // 
            this.txtTimerAdmin.Location = new System.Drawing.Point(75, 117);
            this.txtTimerAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimerAdmin.Name = "txtTimerAdmin";
            this.txtTimerAdmin.Size = new System.Drawing.Size(68, 24);
            this.txtTimerAdmin.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Batch Dosya Yolu:";
            // 
            // txtBatchDosya
            // 
            this.txtBatchDosya.Location = new System.Drawing.Point(140, 22);
            this.txtBatchDosya.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBatchDosya.Name = "txtBatchDosya";
            this.txtBatchDosya.Size = new System.Drawing.Size(167, 24);
            this.txtBatchDosya.TabIndex = 1;
            // 
            // btnLogsec
            // 
            this.btnLogsec.BackColor = System.Drawing.Color.Aqua;
            this.btnLogsec.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogsec.Location = new System.Drawing.Point(315, 22);
            this.btnLogsec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogsec.Name = "btnLogsec";
            this.btnLogsec.Size = new System.Drawing.Size(65, 24);
            this.btnLogsec.TabIndex = 2;
            this.btnLogsec.Text = "Seç";
            this.btnLogsec.UseVisualStyleBackColor = false;
            this.btnLogsec.Click += new System.EventHandler(this.btnLogsec_Click);
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(140, 204);
            this.projectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(167, 24);
            this.projectName.TabIndex = 62;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(7, 207);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(89, 17);
            this.label29.TabIndex = 61;
            this.label29.Text = "Project Name:";
            // 
            // btnIDsec
            // 
            this.btnIDsec.BackColor = System.Drawing.Color.Aqua;
            this.btnIDsec.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIDsec.Location = new System.Drawing.Point(306, 23);
            this.btnIDsec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIDsec.Name = "btnIDsec";
            this.btnIDsec.Size = new System.Drawing.Size(65, 24);
            this.btnIDsec.TabIndex = 587;
            this.btnIDsec.Text = "Seç";
            this.btnIDsec.UseVisualStyleBackColor = false;
            this.btnIDsec.Click += new System.EventHandler(this.btnIDsec_Click);
            // 
            // txtINIdosya
            // 
            this.txtINIdosya.Location = new System.Drawing.Point(131, 22);
            this.txtINIdosya.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtINIdosya.Name = "txtINIdosya";
            this.txtINIdosya.Size = new System.Drawing.Size(167, 24);
            this.txtINIdosya.TabIndex = 586;
            // 
            // label220
            // 
            this.label220.AutoSize = true;
            this.label220.Location = new System.Drawing.Point(9, 22);
            this.label220.Name = "label220";
            this.label220.Size = new System.Drawing.Size(116, 17);
            this.label220.TabIndex = 585;
            this.label220.Text = "Ayarlar Dosya Yolu:";
            // 
            // btnOkuIni
            // 
            this.btnOkuIni.BackColor = System.Drawing.Color.Aqua;
            this.btnOkuIni.Location = new System.Drawing.Point(217, 55);
            this.btnOkuIni.Name = "btnOkuIni";
            this.btnOkuIni.Size = new System.Drawing.Size(80, 30);
            this.btnOkuIni.TabIndex = 584;
            this.btnOkuIni.Text = "Oku";
            this.btnOkuIni.UseVisualStyleBackColor = false;
            this.btnOkuIni.Click += new System.EventHandler(this.btnOkuIni_Click);
            // 
            // btnKaydetIni
            // 
            this.btnKaydetIni.BackColor = System.Drawing.Color.Aqua;
            this.btnKaydetIni.Location = new System.Drawing.Point(131, 55);
            this.btnKaydetIni.Name = "btnKaydetIni";
            this.btnKaydetIni.Size = new System.Drawing.Size(80, 30);
            this.btnKaydetIni.TabIndex = 583;
            this.btnKaydetIni.Text = "Kaydet";
            this.btnKaydetIni.UseVisualStyleBackColor = false;
            this.btnKaydetIni.Click += new System.EventHandler(this.btnKaydetIni_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label220);
            this.groupBox2.Controls.Add(this.btnOkuIni);
            this.groupBox2.Controls.Add(this.btnIDsec);
            this.groupBox2.Controls.Add(this.btnKaydetIni);
            this.groupBox2.Controls.Add(this.txtINIdosya);
            this.groupBox2.Location = new System.Drawing.Point(3, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 92);
            this.groupBox2.TabIndex = 588;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ini Dosyası Ayarları:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnE10PNGsec);
            this.groupBox3.Controls.Add(this.txtE10PNGdosya);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnE945PNGsec);
            this.groupBox3.Controls.Add(this.txtE945PNGdosya);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnE9PNGsec);
            this.groupBox3.Controls.Add(this.txtE9PNGdosya);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnE8PNGsec);
            this.groupBox3.Controls.Add(this.txtE8PNGdosya);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtBatchDosya);
            this.groupBox3.Controls.Add(this.btnLogsec);
            this.groupBox3.Controls.Add(this.projectName);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Location = new System.Drawing.Point(3, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 233);
            this.groupBox3.TabIndex = 589;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proje Ayarları:";
            // 
            // btnE10PNGsec
            // 
            this.btnE10PNGsec.BackColor = System.Drawing.Color.Aqua;
            this.btnE10PNGsec.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnE10PNGsec.Location = new System.Drawing.Point(314, 165);
            this.btnE10PNGsec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnE10PNGsec.Name = "btnE10PNGsec";
            this.btnE10PNGsec.Size = new System.Drawing.Size(65, 24);
            this.btnE10PNGsec.TabIndex = 74;
            this.btnE10PNGsec.Text = "Seç";
            this.btnE10PNGsec.UseVisualStyleBackColor = false;
            this.btnE10PNGsec.Click += new System.EventHandler(this.btnE10PNGsec_Click);
            // 
            // txtE10PNGdosya
            // 
            this.txtE10PNGdosya.Location = new System.Drawing.Point(139, 167);
            this.txtE10PNGdosya.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtE10PNGdosya.Name = "txtE10PNGdosya";
            this.txtE10PNGdosya.Size = new System.Drawing.Size(167, 24);
            this.txtE10PNGdosya.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "E10 Resim Dosya Yolu:";
            // 
            // btnE945PNGsec
            // 
            this.btnE945PNGsec.BackColor = System.Drawing.Color.Aqua;
            this.btnE945PNGsec.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnE945PNGsec.Location = new System.Drawing.Point(315, 128);
            this.btnE945PNGsec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnE945PNGsec.Name = "btnE945PNGsec";
            this.btnE945PNGsec.Size = new System.Drawing.Size(65, 24);
            this.btnE945PNGsec.TabIndex = 71;
            this.btnE945PNGsec.Text = "Seç";
            this.btnE945PNGsec.UseVisualStyleBackColor = false;
            this.btnE945PNGsec.Click += new System.EventHandler(this.btnE945PNGsec_Click);
            // 
            // txtE945PNGdosya
            // 
            this.txtE945PNGdosya.Location = new System.Drawing.Point(140, 130);
            this.txtE945PNGdosya.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtE945PNGdosya.Name = "txtE945PNGdosya";
            this.txtE945PNGdosya.Size = new System.Drawing.Size(167, 24);
            this.txtE945PNGdosya.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "E9-45 Rsm Dosya Yolu:";
            // 
            // btnE9PNGsec
            // 
            this.btnE9PNGsec.BackColor = System.Drawing.Color.Aqua;
            this.btnE9PNGsec.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnE9PNGsec.Location = new System.Drawing.Point(315, 92);
            this.btnE9PNGsec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnE9PNGsec.Name = "btnE9PNGsec";
            this.btnE9PNGsec.Size = new System.Drawing.Size(65, 24);
            this.btnE9PNGsec.TabIndex = 68;
            this.btnE9PNGsec.Text = "Seç";
            this.btnE9PNGsec.UseVisualStyleBackColor = false;
            this.btnE9PNGsec.Click += new System.EventHandler(this.btnE9PNGsec_Click);
            // 
            // txtE9PNGdosya
            // 
            this.txtE9PNGdosya.Location = new System.Drawing.Point(140, 94);
            this.txtE9PNGdosya.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtE9PNGdosya.Name = "txtE9PNGdosya";
            this.txtE9PNGdosya.Size = new System.Drawing.Size(167, 24);
            this.txtE9PNGdosya.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "E9 Resim Dosya Yolu:";
            // 
            // btnE8PNGsec
            // 
            this.btnE8PNGsec.BackColor = System.Drawing.Color.Aqua;
            this.btnE8PNGsec.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnE8PNGsec.Location = new System.Drawing.Point(315, 56);
            this.btnE8PNGsec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnE8PNGsec.Name = "btnE8PNGsec";
            this.btnE8PNGsec.Size = new System.Drawing.Size(65, 24);
            this.btnE8PNGsec.TabIndex = 65;
            this.btnE8PNGsec.Text = "Seç";
            this.btnE8PNGsec.UseVisualStyleBackColor = false;
            this.btnE8PNGsec.Click += new System.EventHandler(this.btnE8PNGsec_Click);
            // 
            // txtE8PNGdosya
            // 
            this.txtE8PNGdosya.Location = new System.Drawing.Point(140, 58);
            this.txtE8PNGdosya.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtE8PNGdosya.Name = "txtE8PNGdosya";
            this.txtE8PNGdosya.Size = new System.Drawing.Size(167, 24);
            this.txtE8PNGdosya.TabIndex = 64;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(7, 61);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(126, 17);
            this.label36.TabIndex = 63;
            this.label36.Text = "E8 Resim Dosya Yolu:";
            // 
            // chBoxSuccess
            // 
            this.chBoxSuccess.AutoSize = true;
            this.chBoxSuccess.Location = new System.Drawing.Point(10, 18);
            this.chBoxSuccess.Name = "chBoxSuccess";
            this.chBoxSuccess.Size = new System.Drawing.Size(69, 21);
            this.chBoxSuccess.TabIndex = 673;
            this.chBoxSuccess.Text = "Success";
            this.chBoxSuccess.UseVisualStyleBackColor = true;
            this.chBoxSuccess.CheckedChanged += new System.EventHandler(this.chBoxSuccess_CheckedChanged);
            // 
            // chBoxError1
            // 
            this.chBoxError1.AutoSize = true;
            this.chBoxError1.Location = new System.Drawing.Point(10, 43);
            this.chBoxError1.Name = "chBoxError1";
            this.chBoxError1.Size = new System.Drawing.Size(63, 21);
            this.chBoxError1.TabIndex = 674;
            this.chBoxError1.Text = "Error1";
            this.chBoxError1.UseVisualStyleBackColor = true;
            this.chBoxError1.CheckedChanged += new System.EventHandler(this.chBoxError1_CheckedChanged);
            // 
            // chBoxError2
            // 
            this.chBoxError2.AutoSize = true;
            this.chBoxError2.Location = new System.Drawing.Point(10, 68);
            this.chBoxError2.Name = "chBoxError2";
            this.chBoxError2.Size = new System.Drawing.Size(63, 21);
            this.chBoxError2.TabIndex = 675;
            this.chBoxError2.Text = "Error2";
            this.chBoxError2.UseVisualStyleBackColor = true;
            this.chBoxError2.CheckedChanged += new System.EventHandler(this.chBoxError2_CheckedChanged);
            // 
            // chBoxError3
            // 
            this.chBoxError3.AutoSize = true;
            this.chBoxError3.Location = new System.Drawing.Point(10, 93);
            this.chBoxError3.Name = "chBoxError3";
            this.chBoxError3.Size = new System.Drawing.Size(63, 21);
            this.chBoxError3.TabIndex = 676;
            this.chBoxError3.Text = "Error3";
            this.chBoxError3.UseVisualStyleBackColor = true;
            this.chBoxError3.CheckedChanged += new System.EventHandler(this.chBoxError3_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtError3Batch);
            this.groupBox4.Controls.Add(this.txtError2Batch);
            this.groupBox4.Controls.Add(this.txtError1Batch);
            this.groupBox4.Controls.Add(this.txtSuccessBatch);
            this.groupBox4.Controls.Add(this.chBoxError3);
            this.groupBox4.Controls.Add(this.chBoxSuccess);
            this.groupBox4.Controls.Add(this.chBoxError2);
            this.groupBox4.Controls.Add(this.chBoxError1);
            this.groupBox4.Location = new System.Drawing.Point(3, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 120);
            this.groupBox4.TabIndex = 677;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Batch Error Name";
            // 
            // txtError3Batch
            // 
            this.txtError3Batch.Location = new System.Drawing.Point(85, 90);
            this.txtError3Batch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtError3Batch.Name = "txtError3Batch";
            this.txtError3Batch.Size = new System.Drawing.Size(283, 24);
            this.txtError3Batch.TabIndex = 680;
            // 
            // txtError2Batch
            // 
            this.txtError2Batch.Location = new System.Drawing.Point(85, 65);
            this.txtError2Batch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtError2Batch.Name = "txtError2Batch";
            this.txtError2Batch.Size = new System.Drawing.Size(283, 24);
            this.txtError2Batch.TabIndex = 679;
            // 
            // txtError1Batch
            // 
            this.txtError1Batch.Location = new System.Drawing.Point(85, 40);
            this.txtError1Batch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtError1Batch.Name = "txtError1Batch";
            this.txtError1Batch.Size = new System.Drawing.Size(283, 24);
            this.txtError1Batch.TabIndex = 678;
            // 
            // txtSuccessBatch
            // 
            this.txtSuccessBatch.Location = new System.Drawing.Point(85, 15);
            this.txtSuccessBatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSuccessBatch.Name = "txtSuccessBatch";
            this.txtSuccessBatch.Size = new System.Drawing.Size(283, 24);
            this.txtSuccessBatch.TabIndex = 677;
            // 
            // ProgAyarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 467);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox7);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProgAyarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.AyarForm_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        private void chBoxSuccess_CheckedChanged(object sender, EventArgs e)
        {
            txtSuccessBatch.Enabled = chBoxSuccess.Checked;
        }

        private void chBoxError1_CheckedChanged(object sender, EventArgs e)
        {
            txtError1Batch.Enabled = chBoxError1.Checked;
        }

        private void chBoxError2_CheckedChanged(object sender, EventArgs e)
        {
            txtError2Batch.Enabled = chBoxError2.Checked;
        }

        private void chBoxError3_CheckedChanged(object sender, EventArgs e)
        {
            txtError3Batch.Enabled = chBoxError3.Checked;
        }

        private void btnE8PNGsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.png||*.jpg|Tüm Dosyalar|*.*";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.txtE8PNGdosya.Text = openFileDialog.FileName;
        }

        private void btnE9PNGsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.png||*.jpg|Tüm Dosyalar|*.*";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.txtE9PNGdosya.Text = openFileDialog.FileName;
        }

        private void btnE945PNGsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.png||*.jpg|Tüm Dosyalar|*.*";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.txtE945PNGdosya.Text = openFileDialog.FileName;
        }

        private void btnE10PNGsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.png||*.jpg|Tüm Dosyalar|*.*";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.txtE10PNGdosya.Text = openFileDialog.FileName;
        }

    }
}
