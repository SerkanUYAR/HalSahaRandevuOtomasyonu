namespace HalıSahaOtomasyonu
{
    partial class Frm_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.TxtAdı = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.MskMaas = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbPozisyon = new System.Windows.Forms.ComboBox();
            this.MskSifre = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rANDEUİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(326, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 355);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personeller";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 327);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(147, 74);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(136, 29);
            this.TxtSoyad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon:";
            // 
            // MskTel
            // 
            this.MskTel.Location = new System.Drawing.Point(147, 117);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(136, 29);
            this.MskTel.TabIndex = 6;
            // 
            // BtnEkle
            // 
            this.BtnEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEkle.BackColor = System.Drawing.Color.Blue;
            this.BtnEkle.Location = new System.Drawing.Point(198, 338);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(85, 29);
            this.BtnEkle.TabIndex = 7;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGüncelle.Location = new System.Drawing.Point(107, 338);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(85, 29);
            this.BtnGüncelle.TabIndex = 8;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = false;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // TxtAdı
            // 
            this.TxtAdı.Location = new System.Drawing.Point(147, 31);
            this.TxtAdı.Name = "TxtAdı";
            this.TxtAdı.Size = new System.Drawing.Size(136, 29);
            this.TxtAdı.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Başlangıç Tarihi:";
            // 
            // DtpTarih
            // 
            this.DtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpTarih.Location = new System.Drawing.Point(147, 205);
            this.DtpTarih.Name = "DtpTarih";
            this.DtpTarih.Size = new System.Drawing.Size(136, 29);
            this.DtpTarih.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Maaş:";
            // 
            // MskMaas
            // 
            this.MskMaas.Location = new System.Drawing.Point(147, 248);
            this.MskMaas.Mask = "00000";
            this.MskMaas.Name = "MskMaas";
            this.MskMaas.Size = new System.Drawing.Size(136, 29);
            this.MskMaas.TabIndex = 13;
            this.MskMaas.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pozisyon:";
            // 
            // CmbPozisyon
            // 
            this.CmbPozisyon.FormattingEnabled = true;
            this.CmbPozisyon.Location = new System.Drawing.Point(147, 160);
            this.CmbPozisyon.Name = "CmbPozisyon";
            this.CmbPozisyon.Size = new System.Drawing.Size(136, 31);
            this.CmbPozisyon.TabIndex = 15;
            // 
            // MskSifre
            // 
            this.MskSifre.Location = new System.Drawing.Point(147, 291);
            this.MskSifre.Mask = "00000";
            this.MskSifre.Name = "MskSifre";
            this.MskSifre.Size = new System.Drawing.Size(136, 29);
            this.MskSifre.TabIndex = 17;
            this.MskSifre.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Şifre:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rANDEUİŞLEMLERİToolStripMenuItem,
            this.iToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 29);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rANDEUİŞLEMLERİToolStripMenuItem
            // 
            this.rANDEUİŞLEMLERİToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rANDEUİŞLEMLERİToolStripMenuItem.Name = "rANDEUİŞLEMLERİToolStripMenuItem";
            this.rANDEUİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(137, 25);
            this.rANDEUİŞLEMLERİToolStripMenuItem.Text = "RANDEU İŞLEMLERİ";
            this.rANDEUİŞLEMLERİToolStripMenuItem.Click += new System.EventHandler(this.rANDEUİŞLEMLERİToolStripMenuItem_Click);
            // 
            // iToolStripMenuItem
            // 
            this.iToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iToolStripMenuItem.Name = "iToolStripMenuItem";
            this.iToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.iToolStripMenuItem.Text = "İstatistik";
            this.iToolStripMenuItem.Click += new System.EventHandler(this.iToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(16, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MskSifre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbPozisyon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MskMaas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtpTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAdı);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.MskTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HALI SAHA RANDEVU OTOMASYONU";
            this.Load += new System.EventHandler(this.Frm_Admin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.TextBox TxtAdı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MskMaas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbPozisyon;
        private System.Windows.Forms.MaskedTextBox MskSifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rANDEUİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}