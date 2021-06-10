
namespace HalıSahaOtomasyonu
{
    partial class Frm_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Giris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.MskSifre = new System.Windows.Forms.MaskedTextBox();
            this.CmbKullanıcıAd = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(223, 219);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(130, 30);
            this.BtnGiris.TabIndex = 3;
            this.BtnGiris.Text = "Giriş";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // MskSifre
            // 
            this.MskSifre.Location = new System.Drawing.Point(182, 184);
            this.MskSifre.Name = "MskSifre";
            this.MskSifre.PasswordChar = '*';
            this.MskSifre.Size = new System.Drawing.Size(171, 29);
            this.MskSifre.TabIndex = 2;
            // 
            // CmbKullanıcıAd
            // 
            this.CmbKullanıcıAd.FormattingEnabled = true;
            this.CmbKullanıcıAd.Location = new System.Drawing.Point(182, 135);
            this.CmbKullanıcıAd.Name = "CmbKullanıcıAd";
            this.CmbKullanıcıAd.Size = new System.Drawing.Size(171, 31);
            this.CmbKullanıcıAd.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HalıSahaOtomasyonu.Properties.Resources.indir;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Giris
            // 
            this.AcceptButton = this.BtnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 289);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CmbKullanıcıAd);
            this.Controls.Add(this.MskSifre);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HALI SAHA RANDEVU OTOMASYONU ";
            this.Load += new System.EventHandler(this.Frm_Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.MaskedTextBox MskSifre;
        private System.Windows.Forms.ComboBox CmbKullanıcıAd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}