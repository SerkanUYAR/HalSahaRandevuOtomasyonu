namespace HalıSahaOtomasyonu
{
    partial class Frm_Ist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ist));
            this.label1 = new System.Windows.Forms.Label();
            this.LblGunKasa = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblTopKasa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LnlOrtalamaMaas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblPerSay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Günluk Kasa:";
            // 
            // LblGunKasa
            // 
            this.LblGunKasa.AutoSize = true;
            this.LblGunKasa.Location = new System.Drawing.Point(170, 56);
            this.LblGunKasa.Name = "LblGunKasa";
            this.LblGunKasa.Size = new System.Drawing.Size(45, 20);
            this.LblGunKasa.TabIndex = 1;
            this.LblGunKasa.Text = "label2";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 26);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // LblTopKasa
            // 
            this.LblTopKasa.AutoSize = true;
            this.LblTopKasa.Location = new System.Drawing.Point(170, 107);
            this.LblTopKasa.Name = "LblTopKasa";
            this.LblTopKasa.Size = new System.Drawing.Size(45, 20);
            this.LblTopKasa.TabIndex = 4;
            this.LblTopKasa.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Toplam Kasa:";
            // 
            // LnlOrtalamaMaas
            // 
            this.LnlOrtalamaMaas.AutoSize = true;
            this.LnlOrtalamaMaas.Location = new System.Drawing.Point(164, 158);
            this.LnlOrtalamaMaas.Name = "LnlOrtalamaMaas";
            this.LnlOrtalamaMaas.Size = new System.Drawing.Size(51, 20);
            this.LnlOrtalamaMaas.TabIndex = 14;
            this.LnlOrtalamaMaas.Text = "0000TL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ortalama Maaş:";
            // 
            // LblPerSay
            // 
            this.LblPerSay.AutoSize = true;
            this.LblPerSay.Location = new System.Drawing.Point(164, 209);
            this.LblPerSay.Name = "LblPerSay";
            this.LblPerSay.Size = new System.Drawing.Size(45, 20);
            this.LblPerSay.TabIndex = 16;
            this.LblPerSay.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Personel Sayısı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HalıSahaOtomasyonu.Properties.Resources._4_icon_icons_com_68889;
            this.pictureBox1.Location = new System.Drawing.Point(255, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Ist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(485, 281);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblPerSay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LnlOrtalamaMaas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblTopKasa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LblGunKasa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Ist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HALI SAHA RANDEVU OTOMASYONU";
            this.Load += new System.EventHandler(this.Frm_Istat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblGunKasa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LblTopKasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LnlOrtalamaMaas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblPerSay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}