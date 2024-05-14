namespace ProgrammingStation
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.timerAdmin = new System.Windows.Forms.Timer(this.components);
            this.btnCikis = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAyar = new System.Windows.Forms.Button();
            this.projectNameTxt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cardPicture = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbE945 = new System.Windows.Forms.RadioButton();
            this.rbE9 = new System.Windows.Forms.RadioButton();
            this.rbE10 = new System.Windows.Forms.RadioButton();
            this.rbE8 = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbConsole
            // 
            this.rtbConsole.BackColor = System.Drawing.SystemColors.Info;
            this.rtbConsole.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConsole.ForeColor = System.Drawing.Color.White;
            this.rtbConsole.Location = new System.Drawing.Point(747, 40);
            this.rtbConsole.Margin = new System.Windows.Forms.Padding(0);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.Size = new System.Drawing.Size(439, 719);
            this.rtbConsole.TabIndex = 0;
            this.rtbConsole.TabStop = false;
            this.rtbConsole.Text = "";
            this.rtbConsole.TextChanged += new System.EventHandler(this.rtbConsole_TextChanged);
            // 
            // tbState
            // 
            this.tbState.BackColor = System.Drawing.Color.DarkGray;
            this.tbState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbState.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbState.ForeColor = System.Drawing.Color.White;
            this.tbState.Location = new System.Drawing.Point(747, 7);
            this.tbState.Margin = new System.Windows.Forms.Padding(0);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(439, 33);
            this.tbState.TabIndex = 0;
            this.tbState.TabStop = false;
            this.tbState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerAdmin
            // 
            this.timerAdmin.Tick += new System.EventHandler(this.timerAdmin_Tick);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(441, 704);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(302, 55);
            this.btnCikis.TabIndex = 48;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 720);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 49;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btnAyar
            // 
            this.btnAyar.BackColor = System.Drawing.Color.Red;
            this.btnAyar.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyar.Location = new System.Drawing.Point(-1, 704);
            this.btnAyar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAyar.Name = "btnAyar";
            this.btnAyar.Size = new System.Drawing.Size(302, 55);
            this.btnAyar.TabIndex = 47;
            this.btnAyar.Text = "AYARLAR";
            this.btnAyar.UseVisualStyleBackColor = false;
            this.btnAyar.Click += new System.EventHandler(this.btnAyar_Click);
            // 
            // projectNameTxt
            // 
            this.projectNameTxt.BackColor = System.Drawing.Color.DarkGray;
            this.projectNameTxt.Enabled = false;
            this.projectNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projectNameTxt.Location = new System.Drawing.Point(7, 98);
            this.projectNameTxt.Name = "projectNameTxt";
            this.projectNameTxt.Size = new System.Drawing.Size(737, 44);
            this.projectNameTxt.TabIndex = 58;
            this.projectNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::ProgrammingStation.Properties.Resources.alpNEXT;
            this.pictureBox2.Image = global::ProgrammingStation.Properties.Resources.alpNEXT;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(10, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(734, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // cardPicture
            // 
            this.cardPicture.InitialImage = null;
            this.cardPicture.Location = new System.Drawing.Point(7, 149);
            this.cardPicture.Margin = new System.Windows.Forms.Padding(2);
            this.cardPicture.Name = "cardPicture";
            this.cardPicture.Size = new System.Drawing.Size(737, 400);
            this.cardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardPicture.TabIndex = 56;
            this.cardPicture.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbE945);
            this.groupBox1.Controls.Add(this.rbE9);
            this.groupBox1.Controls.Add(this.rbE10);
            this.groupBox1.Controls.Add(this.rbE8);
            this.groupBox1.Location = new System.Drawing.Point(7, 554);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 143);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbE945
            // 
            this.rbE945.AutoSize = true;
            this.rbE945.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbE945.Location = new System.Drawing.Point(607, 19);
            this.rbE945.Name = "rbE945";
            this.rbE945.Size = new System.Drawing.Size(92, 33);
            this.rbE945.TabIndex = 8;
            this.rbE945.Text = "E9-45";
            this.rbE945.UseVisualStyleBackColor = true;
            this.rbE945.CheckedChanged += new System.EventHandler(this.rbE945_CheckedChanged);
            // 
            // rbE9
            // 
            this.rbE9.AutoSize = true;
            this.rbE9.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbE9.Location = new System.Drawing.Point(16, 104);
            this.rbE9.Name = "rbE9";
            this.rbE9.Size = new System.Drawing.Size(57, 33);
            this.rbE9.TabIndex = 4;
            this.rbE9.Text = "E9";
            this.rbE9.UseVisualStyleBackColor = true;
            this.rbE9.CheckedChanged += new System.EventHandler(this.rbE9_CheckedChanged);
            // 
            // rbE10
            // 
            this.rbE10.AutoSize = true;
            this.rbE10.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbE10.Location = new System.Drawing.Point(607, 93);
            this.rbE10.Name = "rbE10";
            this.rbE10.Size = new System.Drawing.Size(70, 33);
            this.rbE10.TabIndex = 1;
            this.rbE10.Text = "E10";
            this.rbE10.UseVisualStyleBackColor = true;
            this.rbE10.CheckedChanged += new System.EventHandler(this.rbE10_CheckedChanged);
            // 
            // rbE8
            // 
            this.rbE8.AutoSize = true;
            this.rbE8.Checked = true;
            this.rbE8.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbE8.Location = new System.Drawing.Point(16, 19);
            this.rbE8.Name = "rbE8";
            this.rbE8.Size = new System.Drawing.Size(57, 33);
            this.rbE8.TabIndex = 0;
            this.rbE8.TabStop = true;
            this.rbE8.Text = "E8";
            this.rbE8.UseVisualStyleBackColor = true;
            this.rbE8.CheckedChanged += new System.EventHandler(this.rbE8_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(677, -1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 96);
            this.btnExit.TabIndex = 108;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1196, 769);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.projectNameTxt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cardPicture);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAyar);
            this.Controls.Add(this.rtbConsole);
            this.Controls.Add(this.tbState);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All E SeriesPrograming Station";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.Timer timerAdmin;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAyar;
        private System.Windows.Forms.PictureBox cardPicture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox projectNameTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbE10;
        private System.Windows.Forms.RadioButton rbE8;
        private System.Windows.Forms.RadioButton rbE945;
        private System.Windows.Forms.RadioButton rbE9;
        private System.Windows.Forms.Button btnExit;
    }
}

