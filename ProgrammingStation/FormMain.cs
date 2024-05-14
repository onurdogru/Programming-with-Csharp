using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProgrammingStation
{
    public partial class FormMain : Form
    {
        public ProgAyarForm ProgAyarFrm;
        public Sifre SifreFrm;
        private IntPtr ShellHwnd;

        string customMessageBoxTitle;
        string[] batchFileFeedback = new string[4];
        private bool isProgrammingStarted = false;

        string computerBatchFileAdress;
        string batchName;

        int adminTimerCounter = 0;
        public int yetki;

        public FormMain()
        {
            this.ProgAyarFrm = new ProgAyarForm();
            this.ProgAyarFrm.MainFrm = this;
            this.SifreFrm = new Sifre();
            this.SifreFrm.MainFrm = this;
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern byte ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string ClassName, string WindowName);

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.ShellHwnd = FormMain.FindWindow("Shell TrayWnd", (string)null);
            IntPtr shellHwnd = this.ShellHwnd;
            int num1 = (int)FormMain.ShowWindow(this.ShellHwnd, 0);
            /*
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Control.CheckForIllegalCrossThreadCalls = false;
            */

            this.customMessageBoxTitle = Prog_Ayarlar.Default.projectName;
            this.projectNameTxt.Text = customMessageBoxTitle;
            this.Text = customMessageBoxTitle;

            computerBatchFileAdress = Prog_Ayarlar.Default.Logdosyayolu;
            batchName = "E8";

            this.cardPicture.ImageLocation = Prog_Ayarlar.Default.E8PNGdosyayolu;

            this.timerAdmin.Interval = Prog_Ayarlar.Default.timerAdmin;

            batchFileFeedback[0] = Prog_Ayarlar.Default.successBatch;
            batchFileFeedback[1] = Prog_Ayarlar.Default.error1Batch;
            batchFileFeedback[2] = Prog_Ayarlar.Default.error2Batch;
            batchFileFeedback[3] = Prog_Ayarlar.Default.error3Batch;

            this.yetki = 0;
            this.yetkidegistir();
        }

        #region Events
        /* Program Kapatılmak İstendiğinde*/
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isProgrammingStarted)
            {
                // Show message box
                if (CustomMessageBox.ShowMessage("Programı kapatmak istediğinizden emin misiniz?", customMessageBoxTitle, MessageBoxButtons.YesNo, CustomMessageBoxIcon.Question, Color.Yellow) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                CustomMessageBox.ShowMessage("Programlama işlemi bitmeden programı kapatamazsınız.", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Warning, Color.Yellow);
                e.Cancel = true;
            }
        }

        /* Barkod "ProgramThreadFunction" gönderilir*/

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.Space)
                return false;
            if (isProgrammingStarted == false)
            {
                tbState.Invoke(new Action(delegate ()
                {
                    tbState.BackColor = Color.DarkGray;
                    tbState.Text = " ";
                }));
                Thread programThread = new Thread(ProgramThreadFunction);
                programThread.Start();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
        /* Tüm Ana İşlemlerin Yönlendirilmesi*/
        private void ProgramThreadFunction()
        {
            bool result = false;

            // Clean console
            ConsoleClean();

            // Show message box
            // set ProgrammingStarted flag
            isProgrammingStarted = true;

            ConsoleAppendLine(batchName + " ürününün programlama işlemi yapılıyor...", Color.Yellow);

            if (ProgramProduct())
            {
                ConsoleNewLine();
                ConsoleAppendLine(batchName + " ürününün programlama işlemi başarıyla tamamlanmıştır.", Color.Green);
                ConsoleNewLine();
                result = true;
            }
            else
            {
                ConsoleNewLine();
                ConsoleAppendLine(batchName + " ürününün programlama işlemi sırasında bir hata oluşmuştur!", Color.Red);
                ConsoleNewLine();
                result = false;
            }

            // Update status bar
            if (result)
            {
                tbState.Invoke(new Action(delegate ()
                {
                    tbState.BackColor = Color.Green;
                    tbState.Text = "PROGRAMLAMA BAŞARILI";
                }));

                // Show message box
                DialogResult dialog_result = DialogResult.None;
                this.Invoke(new Action(delegate ()
                {
                    dialog_result = CustomMessageBox.ShowMessage("PROGRAMLAMA BAŞARILI", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Pass, Color.Green);
                }));
                if (dialog_result == DialogResult.OK)
                {
                    // do nothing only information.
                }
            }
            else
            {
                tbState.Invoke(new Action(delegate ()
                {
                    tbState.BackColor = Color.Red;
                    tbState.Text = "PROGRAMLAMA BAŞARISIZ";
                }));

                // Show message box
                DialogResult dialog_result = DialogResult.None;
                this.Invoke(new Action(delegate ()
                {
                    dialog_result = CustomMessageBox.ShowMessage("PROGRAMLAMA BAŞARISIZ", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Fail, Color.Red);
                }));
                if (dialog_result == DialogResult.OK)
                {
                    // do nothing only information.
                }
            }

            // set ProgrammingStarted flag
            isProgrammingStarted = false;
        }

        /*ürün için .bat Seçilir*/
        private bool ProgramProduct()
        {
            bool result = false;
            String batchPath = String.Empty;

            batchPath = computerBatchFileAdress + batchName + "/" + batchName + ".bat";    // C:\Users\serkan.baki\Desktop\MIND-BATCH-FILES\
            result = RunBatch(batchPath, customMessageBoxTitle);
            if (result == false) return result;

            return result;
        }

        /*Seçilen .bat Çalıştırılır- Kontrol Edilir ve Kapatılır*/
        private bool RunBatch(string batch_path, string batch_name)
        {
            bool result = false;

            Process processBatch = new Process();
            processBatch.StartInfo.UseShellExecute = false;
            processBatch.StartInfo.RedirectStandardOutput = true;
            processBatch.StartInfo.CreateNoWindow = true;
            processBatch.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processBatch.StartInfo.FileName = batch_path;
            //processBatch.StartInfo.Arguments = string.Format("");
            processBatch.Start();

            StreamReader strmReader = processBatch.StandardOutput;
            string batchTempRow = string.Empty;
            // get all lines of batch
            while ((batchTempRow = strmReader.ReadLine()) != null)
            {
                // Write batch operation to the console
                ConsoleAppendLine(batchTempRow, Color.Black);

                // check programming is successful.
                // if succesfully finished.
                if (Prog_Ayarlar.Default.chBoxSuccess && ((batchTempRow.IndexOf("pause", StringComparison.OrdinalIgnoreCase) >= 0) || (batchTempRow.IndexOf(batchFileFeedback[0], StringComparison.OrdinalIgnoreCase) >= 0)))  // color ae
                {
                    ConsoleNewLine();
                    ConsoleAppendLine(batch_name + " Programlama İşlemi Başarıyla Tamamlanmıştır!", Color.Green);
                    result = true;
                    break;
                }
                else if (Prog_Ayarlar.Default.chBoxError1 && ((batchTempRow.IndexOf("pause", StringComparison.OrdinalIgnoreCase) >= 0) || (batchTempRow.IndexOf(batchFileFeedback[1], StringComparison.OrdinalIgnoreCase) >= 0))) //Could not start CPU core.
                {
                    ConsoleNewLine();
                    ConsoleAppendLine(batch_name + " Programlama İşlemi Başarısız1.", Color.Red);  // Programlama Soketi Düzgün Takılı Değil!
                    result = false;
                    break;
                }
                else if (Prog_Ayarlar.Default.chBoxError2 && ((batchTempRow.IndexOf("pause", StringComparison.OrdinalIgnoreCase) >= 0) || (batchTempRow.IndexOf(batchFileFeedback[2], StringComparison.OrdinalIgnoreCase) >= 0)))  // Cannot connect to target.
                {
                    ConsoleNewLine();
                    ConsoleAppendLine(batch_name + " Programlama İşlemi Başarısız2.", Color.Red); // Programlama Soketi Takılı Değil!
                    result = false;
                    break;
                }
                else if (Prog_Ayarlar.Default.chBoxError3 && ((batchTempRow.IndexOf("pause", StringComparison.OrdinalIgnoreCase) >= 0) || (batchTempRow.IndexOf(batchFileFeedback[3], StringComparison.OrdinalIgnoreCase) >= 0))) //FAILED
                {
                    ConsoleNewLine();
                    ConsoleAppendLine(batch_name + " Programlama İşlemi Başarısız3.", Color.Red);  //  USB Takılı Değil!
                    result = false;
                    break;
                }
            }

            // if batch didn't closed kill it.
            if (!processBatch.HasExited)
            {
                processBatch.Kill();
            }

            return result;
        }

        private void rtbConsole_TextChanged(object sender, EventArgs e)
        {
            RichTextBox rtb = sender as RichTextBox;
            rtb.SelectionStart = rtb.Text.Length;
            rtb.ScrollToCaret();
        }

        /*Kullanıcı Arayüzüne Temizlenir*/
        private void ConsoleClean()
        {
            if (rtbConsole.InvokeRequired)
            {
                rtbConsole.Invoke(new Action(delegate ()
                {
                    rtbConsole.Text = "";
                    rtbConsole.Select(rtbConsole.TextLength, 0);
                    rtbConsole.SelectionColor = Color.White;
                }));
            }
            else
            {
                rtbConsole.Text = "";
                rtbConsole.Select(rtbConsole.TextLength, 0);
                rtbConsole.SelectionColor = Color.White;
            }
        }

        /*Kullanıcı Arayüzüne Yazı Yazılır*/
        private void ConsoleAppendLine(string text, Color color)
        {
            if (rtbConsole.InvokeRequired)
            {
                rtbConsole.Invoke(new Action(delegate ()
                {
                    rtbConsole.Select(rtbConsole.TextLength, 0);
                    rtbConsole.SelectionColor = color;
                    rtbConsole.AppendText(text + Environment.NewLine);
                    rtbConsole.Select(rtbConsole.TextLength, 0);
                    rtbConsole.SelectionColor = Color.White;
                }));
            }
            else
            {
                rtbConsole.Select(rtbConsole.TextLength, 0);
                rtbConsole.SelectionColor = color;
                rtbConsole.AppendText(text + Environment.NewLine);
                rtbConsole.Select(rtbConsole.TextLength, 0);
                rtbConsole.SelectionColor = Color.White;
            }
        }

        /*Kullanıcı Arayüzünde Bir Satır Boşluk Bırakılır*/
        private void ConsoleNewLine()
        {
            if (rtbConsole.InvokeRequired)
            {
                rtbConsole.Invoke(new Action(delegate () { rtbConsole.AppendText(Environment.NewLine); }));
            }
            else
            {
                rtbConsole.AppendText(Environment.NewLine);
            }
        }

        public void yetkidegistir()
        {
            if (this.yetki == 0)
            {
                this.btnCikis.Enabled = false;
                this.btnAyar.Enabled = false;
                btnCikis.BackColor = Color.Gray;
                btnAyar.BackColor = Color.Gray;
            }
            if (this.yetki == 1)
            {
                this.btnCikis.Enabled = true;
                this.btnAyar.Enabled = true;
                btnCikis.BackColor = Color.Red;
                btnAyar.BackColor = Color.Red;
                timerAdmin.Start();
            }
            if (this.yetki == 2)
            {
                this.btnCikis.Enabled = true;
                btnCikis.BackColor = Color.Red;
                timerAdmin.Start();
            }
        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
            int num = (int)this.ProgAyarFrm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.L)
                return;
            if (this.yetki != 0)
            {
                timerAdmin.Stop();
                this.yetki = 0;
                this.yetkidegistir();
            }
            else
            {
                int num = (int)this.SifreFrm.ShowDialog();
                textBox1.Clear();
            }
        }
        /*
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.L)
                return false;
            if (this.yetki != 0)
            {
                timerAdmin.Stop();
                this.yetki = 0;
                this.yetkidegistir();
            }
            else
            {
                try { int num = (int)this.SifreFrm.ShowDialog(); }
                catch (Exception) { }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }*/

        private void timerAdmin_Tick(object sender, EventArgs e)
        {
            adminTimerCounter++;
            if (adminTimerCounter == 1)
            {
                adminTimerCounter = 0;
                timerAdmin.Stop();
                this.yetki = 0;
                this.yetkidegistir();
            }
        }

        private void rbE8_CheckedChanged(object sender, EventArgs e)
        {
            this.cardPicture.ImageLocation = Prog_Ayarlar.Default.E8PNGdosyayolu;
            batchName = "E8";
        }

        private void rbE9_CheckedChanged(object sender, EventArgs e)
        {
            this.cardPicture.ImageLocation = Prog_Ayarlar.Default.E9PNGdosyayolu;
            batchName = "E9";
        }

        private void rbE945_CheckedChanged(object sender, EventArgs e)
        {
            this.cardPicture.ImageLocation = Prog_Ayarlar.Default.E945PNGdosyayolu;
            batchName = "E945";
        }

        private void rbE10_CheckedChanged(object sender, EventArgs e)
        {
            this.cardPicture.ImageLocation = Prog_Ayarlar.Default.E10PNGdosyayolu;
            batchName = "E10";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
