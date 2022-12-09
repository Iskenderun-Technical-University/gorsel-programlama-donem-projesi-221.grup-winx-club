namespace PansiyonOtomasyonKayit
{
    partial class FrmYeniMusteri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.MskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.TxtTCKimlikNo = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtSoyadi = new System.Windows.Forms.TextBox();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.TxtOdaNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnOda9 = new System.Windows.Forms.Button();
            this.BtnOda8 = new System.Windows.Forms.Button();
            this.BtnOda7 = new System.Windows.Forms.Button();
            this.BtnOda6 = new System.Windows.Forms.Button();
            this.BtnOda5 = new System.Windows.Forms.Button();
            this.BtnOda4 = new System.Windows.Forms.Button();
            this.BtnOda3 = new System.Windows.Forms.Button();
            this.BtnOda2 = new System.Windows.Forms.Button();
            this.BtnOda1 = new System.Windows.Forms.Button();
            this.BtnBosOda = new System.Windows.Forms.Button();
            this.BtnDoluOda = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.MskTxtTelefon);
            this.groupBox1.Controls.Add(this.DtpCikisTarihi);
            this.groupBox1.Controls.Add(this.DtpGirisTarihi);
            this.groupBox1.Controls.Add(this.TxtUcret);
            this.groupBox1.Controls.Add(this.TxtTCKimlikNo);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.TxtSoyadi);
            this.groupBox1.Controls.Add(this.TxtAdi);
            this.groupBox1.Controls.Add(this.TxtOdaNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 439);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.Location = new System.Drawing.Point(302, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "0";
            this.label10.Visible = false;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnKaydet.Location = new System.Drawing.Point(121, 367);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(153, 38);
            this.BtnKaydet.TabIndex = 37;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // MskTxtTelefon
            // 
            this.MskTxtTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MskTxtTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MskTxtTelefon.Location = new System.Drawing.Point(159, 139);
            this.MskTxtTelefon.Mask = "(999) 000-0000";
            this.MskTxtTelefon.Name = "MskTxtTelefon";
            this.MskTxtTelefon.Size = new System.Drawing.Size(200, 28);
            this.MskTxtTelefon.TabIndex = 36;
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.Location = new System.Drawing.Point(159, 301);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(200, 20);
            this.DtpCikisTarihi.TabIndex = 35;
            this.DtpCikisTarihi.ValueChanged += new System.EventHandler(this.DtpCikisTarihi_ValueChanged);
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.Location = new System.Drawing.Point(159, 275);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(200, 20);
            this.DtpGirisTarihi.TabIndex = 34;
            // 
            // TxtUcret
            // 
            this.TxtUcret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtUcret.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtUcret.Location = new System.Drawing.Point(159, 333);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(200, 28);
            this.TxtUcret.TabIndex = 33;
            // 
            // TxtTCKimlikNo
            // 
            this.TxtTCKimlikNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtTCKimlikNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtTCKimlikNo.Location = new System.Drawing.Point(159, 207);
            this.TxtTCKimlikNo.MaxLength = 11;
            this.TxtTCKimlikNo.Name = "TxtTCKimlikNo";
            this.TxtTCKimlikNo.Size = new System.Drawing.Size(200, 28);
            this.TxtTCKimlikNo.TabIndex = 32;
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtMail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtMail.Location = new System.Drawing.Point(159, 173);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(200, 28);
            this.TxtMail.TabIndex = 31;
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtSoyadi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtSoyadi.Location = new System.Drawing.Point(159, 71);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(200, 28);
            this.TxtSoyadi.TabIndex = 30;
            // 
            // TxtAdi
            // 
            this.TxtAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtAdi.Location = new System.Drawing.Point(159, 36);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(200, 28);
            this.TxtAdi.TabIndex = 29;
            // 
            // TxtOdaNo
            // 
            this.TxtOdaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtOdaNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtOdaNo.Location = new System.Drawing.Point(159, 241);
            this.TxtOdaNo.Name = "TxtOdaNo";
            this.TxtOdaNo.Size = new System.Drawing.Size(200, 28);
            this.TxtOdaNo.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(27, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ücret:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(25, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Çıkış Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(25, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Giriş Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(25, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Oda Numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(25, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(27, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(23, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnOda9);
            this.groupBox2.Controls.Add(this.BtnOda8);
            this.groupBox2.Controls.Add(this.BtnOda7);
            this.groupBox2.Controls.Add(this.BtnOda6);
            this.groupBox2.Controls.Add(this.BtnOda5);
            this.groupBox2.Controls.Add(this.BtnOda4);
            this.groupBox2.Controls.Add(this.BtnOda3);
            this.groupBox2.Controls.Add(this.BtnOda2);
            this.groupBox2.Controls.Add(this.BtnOda1);
            this.groupBox2.Location = new System.Drawing.Point(436, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 269);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            // 
            // BtnOda9
            // 
            this.BtnOda9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(39)))));
            this.BtnOda9.Location = new System.Drawing.Point(221, 201);
            this.BtnOda9.Name = "BtnOda9";
            this.BtnOda9.Size = new System.Drawing.Size(45, 32);
            this.BtnOda9.TabIndex = 8;
            this.BtnOda9.Text = "9";
            this.BtnOda9.UseVisualStyleBackColor = false;
            this.BtnOda9.Click += new System.EventHandler(this.BtnOda9_Click);
            // 
            // BtnOda8
            // 
            this.BtnOda8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(39)))));
            this.BtnOda8.Location = new System.Drawing.Point(119, 201);
            this.BtnOda8.Name = "BtnOda8";
            this.BtnOda8.Size = new System.Drawing.Size(45, 32);
            this.BtnOda8.TabIndex = 7;
            this.BtnOda8.Text = "8";
            this.BtnOda8.UseVisualStyleBackColor = false;
            this.BtnOda8.Click += new System.EventHandler(this.BtnOda8_Click);
            // 
            // BtnOda7
            // 
            this.BtnOda7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(39)))));
            this.BtnOda7.Location = new System.Drawing.Point(23, 203);
            this.BtnOda7.Name = "BtnOda7";
            this.BtnOda7.Size = new System.Drawing.Size(45, 32);
            this.BtnOda7.TabIndex = 6;
            this.BtnOda7.Text = "7";
            this.BtnOda7.UseVisualStyleBackColor = false;
            this.BtnOda7.Click += new System.EventHandler(this.BtnOda7_Click);
            // 
            // BtnOda6
            // 
            this.BtnOda6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(39)))));
            this.BtnOda6.Location = new System.Drawing.Point(221, 109);
            this.BtnOda6.Name = "BtnOda6";
            this.BtnOda6.Size = new System.Drawing.Size(45, 32);
            this.BtnOda6.TabIndex = 5;
            this.BtnOda6.Text = "6";
            this.BtnOda6.UseVisualStyleBackColor = false;
            this.BtnOda6.Click += new System.EventHandler(this.BtnOda6_Click);
            // 
            // BtnOda5
            // 
            this.BtnOda5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(39)))));
            this.BtnOda5.Location = new System.Drawing.Point(119, 109);
            this.BtnOda5.Name = "BtnOda5";
            this.BtnOda5.Size = new System.Drawing.Size(45, 32);
            this.BtnOda5.TabIndex = 4;
            this.BtnOda5.Text = "5";
            this.BtnOda5.UseVisualStyleBackColor = false;
            this.BtnOda5.Click += new System.EventHandler(this.BtnOda5_Click);
            // 
            // BtnOda4
            // 
            this.BtnOda4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(39)))));
            this.BtnOda4.Location = new System.Drawing.Point(23, 109);
            this.BtnOda4.Name = "BtnOda4";
            this.BtnOda4.Size = new System.Drawing.Size(45, 32);
            this.BtnOda4.TabIndex = 3;
            this.BtnOda4.Text = "4";
            this.BtnOda4.UseVisualStyleBackColor = false;
            this.BtnOda4.Click += new System.EventHandler(this.BtnOda4_Click);
            // 
            // BtnOda3
            // 
            this.BtnOda3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(39)))));
            this.BtnOda3.Location = new System.Drawing.Point(221, 28);
            this.BtnOda3.Name = "BtnOda3";
            this.BtnOda3.Size = new System.Drawing.Size(45, 32);
            this.BtnOda3.TabIndex = 2;
            this.BtnOda3.Text = "3";
            this.BtnOda3.UseVisualStyleBackColor = false;
            this.BtnOda3.Click += new System.EventHandler(this.BtnOda3_Click);
            // 
            // BtnOda2
            // 
            this.BtnOda2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(39)))));
            this.BtnOda2.Location = new System.Drawing.Point(119, 28);
            this.BtnOda2.Name = "BtnOda2";
            this.BtnOda2.Size = new System.Drawing.Size(45, 32);
            this.BtnOda2.TabIndex = 1;
            this.BtnOda2.Text = "2";
            this.BtnOda2.UseVisualStyleBackColor = false;
            this.BtnOda2.Click += new System.EventHandler(this.BtnOda2_Click);
            // 
            // BtnOda1
            // 
            this.BtnOda1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(39)))));
            this.BtnOda1.Location = new System.Drawing.Point(23, 28);
            this.BtnOda1.Name = "BtnOda1";
            this.BtnOda1.Size = new System.Drawing.Size(45, 32);
            this.BtnOda1.TabIndex = 0;
            this.BtnOda1.Text = "1";
            this.BtnOda1.UseVisualStyleBackColor = false;
            this.BtnOda1.Click += new System.EventHandler(this.BtnOda1_Click);
            // 
            // BtnBosOda
            // 
            this.BtnBosOda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(179)))), ((int)(((byte)(39)))));
            this.BtnBosOda.Location = new System.Drawing.Point(619, 313);
            this.BtnBosOda.Name = "BtnBosOda";
            this.BtnBosOda.Size = new System.Drawing.Size(83, 32);
            this.BtnBosOda.TabIndex = 21;
            this.BtnBosOda.Text = "Boş";
            this.BtnBosOda.UseVisualStyleBackColor = false;
            this.BtnBosOda.Click += new System.EventHandler(this.BtnBosOda_Click);
            // 
            // BtnDoluOda
            // 
            this.BtnDoluOda.BackColor = System.Drawing.Color.Red;
            this.BtnDoluOda.Location = new System.Drawing.Point(619, 370);
            this.BtnDoluOda.Name = "BtnDoluOda";
            this.BtnDoluOda.Size = new System.Drawing.Size(83, 32);
            this.BtnDoluOda.TabIndex = 22;
            this.BtnDoluOda.Text = "Dolu";
            this.BtnDoluOda.UseVisualStyleBackColor = false;
            this.BtnDoluOda.Click += new System.EventHandler(this.BtnDoluOda_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label11.Location = new System.Drawing.Point(27, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Cinsiyet:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.comboBox1.Location = new System.Drawing.Point(159, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // FrmYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(744, 474);
            this.Controls.Add(this.BtnDoluOda);
            this.Controls.Add(this.BtnBosOda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmYeniMusteri";
            this.Text = "Yeni Müşteri Kaydı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.MaskedTextBox MskTxtTelefon;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.TextBox TxtTCKimlikNo;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtSoyadi;
        private System.Windows.Forms.TextBox TxtAdi;
        private System.Windows.Forms.TextBox TxtOdaNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnOda9;
        private System.Windows.Forms.Button BtnOda8;
        private System.Windows.Forms.Button BtnOda7;
        private System.Windows.Forms.Button BtnOda6;
        private System.Windows.Forms.Button BtnOda5;
        private System.Windows.Forms.Button BtnOda4;
        private System.Windows.Forms.Button BtnOda3;
        private System.Windows.Forms.Button BtnOda2;
        private System.Windows.Forms.Button BtnOda1;
        private System.Windows.Forms.Button BtnBosOda;
        private System.Windows.Forms.Button BtnDoluOda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
    }
}