namespace YurtOtomasyonu2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.MskOgrTc = new System.Windows.Forms.MaskedTextBox();
            this.MskOgrTel = new System.Windows.Forms.MaskedTextBox();
            this.MskOgrDogum = new System.Windows.Forms.MaskedTextBox();
            this.CmbBolum = new System.Windows.Forms.ComboBox();
            this.OgrMail = new System.Windows.Forms.TextBox();
            this.CmbOdaNo = new System.Windows.Forms.ComboBox();
            this.TxtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MskVeliTelNo = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.OgrAdres = new System.Windows.Forms.RichTextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(337, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(633, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci T.C Kimlik No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon Numarası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(337, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(633, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Okuduğu Bölüm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Öğrenci Mail Adresi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(337, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Oda Numarası";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(633, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "Veli Adı Soyadı";
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtOgrAd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrAd.Location = new System.Drawing.Point(17, 76);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(216, 27);
            this.TxtOgrAd.TabIndex = 9;
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtOgrSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrSoyad.Location = new System.Drawing.Point(342, 76);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(216, 27);
            this.TxtOgrSoyad.TabIndex = 10;
            // 
            // MskOgrTc
            // 
            this.MskOgrTc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MskOgrTc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOgrTc.Location = new System.Drawing.Point(638, 76);
            this.MskOgrTc.Mask = "00000000000";
            this.MskOgrTc.Name = "MskOgrTc";
            this.MskOgrTc.Size = new System.Drawing.Size(198, 27);
            this.MskOgrTc.TabIndex = 11;
            this.MskOgrTc.ValidatingType = typeof(int);
            // 
            // MskOgrTel
            // 
            this.MskOgrTel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MskOgrTel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOgrTel.Location = new System.Drawing.Point(17, 183);
            this.MskOgrTel.Mask = "(999) 000-0000";
            this.MskOgrTel.Name = "MskOgrTel";
            this.MskOgrTel.Size = new System.Drawing.Size(198, 27);
            this.MskOgrTel.TabIndex = 12;
            // 
            // MskOgrDogum
            // 
            this.MskOgrDogum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MskOgrDogum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOgrDogum.Location = new System.Drawing.Point(342, 183);
            this.MskOgrDogum.Mask = "00/00/0000";
            this.MskOgrDogum.Name = "MskOgrDogum";
            this.MskOgrDogum.Size = new System.Drawing.Size(198, 27);
            this.MskOgrDogum.TabIndex = 13;
            this.MskOgrDogum.ValidatingType = typeof(System.DateTime);
            // 
            // CmbBolum
            // 
            this.CmbBolum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CmbBolum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbBolum.FormattingEnabled = true;
            this.CmbBolum.Location = new System.Drawing.Point(638, 183);
            this.CmbBolum.Name = "CmbBolum";
            this.CmbBolum.Size = new System.Drawing.Size(198, 28);
            this.CmbBolum.TabIndex = 14;
            this.CmbBolum.SelectedIndexChanged += new System.EventHandler(this.CmbBolum_SelectedIndexChanged);
            // 
            // OgrMail
            // 
            this.OgrMail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OgrMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrMail.Location = new System.Drawing.Point(17, 312);
            this.OgrMail.Name = "OgrMail";
            this.OgrMail.Size = new System.Drawing.Size(216, 27);
            this.OgrMail.TabIndex = 15;
            // 
            // CmbOdaNo
            // 
            this.CmbOdaNo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CmbOdaNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOdaNo.FormattingEnabled = true;
            this.CmbOdaNo.Location = new System.Drawing.Point(326, 312);
            this.CmbOdaNo.Name = "CmbOdaNo";
            this.CmbOdaNo.Size = new System.Drawing.Size(198, 28);
            this.CmbOdaNo.TabIndex = 16;
            // 
            // TxtVeliAdSoyad
            // 
            this.TxtVeliAdSoyad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtVeliAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVeliAdSoyad.Location = new System.Drawing.Point(638, 313);
            this.TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            this.TxtVeliAdSoyad.Size = new System.Drawing.Size(216, 27);
            this.TxtVeliAdSoyad.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(633, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 28);
            this.label10.TabIndex = 18;
            this.label10.Text = "Veli Telefon Numarası";
            // 
            // MskVeliTelNo
            // 
            this.MskVeliTelNo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MskVeliTelNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskVeliTelNo.Location = new System.Drawing.Point(638, 421);
            this.MskVeliTelNo.Mask = "(999) 000-0000";
            this.MskVeliTelNo.Name = "MskVeliTelNo";
            this.MskVeliTelNo.Size = new System.Drawing.Size(198, 27);
            this.MskVeliTelNo.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(12, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 28);
            this.label11.TabIndex = 20;
            this.label11.Text = "Adres";
            // 
            // OgrAdres
            // 
            this.OgrAdres.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OgrAdres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrAdres.Location = new System.Drawing.Point(12, 401);
            this.OgrAdres.Name = "OgrAdres";
            this.OgrAdres.Size = new System.Drawing.Size(512, 65);
            this.OgrAdres.TabIndex = 21;
            this.OgrAdres.Text = "";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(365, 495);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(141, 50);
            this.BtnKaydet.TabIndex = 22;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(626, 495);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(868, 571);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.OgrAdres);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MskVeliTelNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtVeliAdSoyad);
            this.Controls.Add(this.CmbOdaNo);
            this.Controls.Add(this.OgrMail);
            this.Controls.Add(this.CmbBolum);
            this.Controls.Add(this.MskOgrDogum);
            this.Controls.Add(this.MskOgrTel);
            this.Controls.Add(this.MskOgrTc);
            this.Controls.Add(this.TxtOgrSoyad);
            this.Controls.Add(this.TxtOgrAd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Öğrenci Kaydı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.TextBox TxtOgrSoyad;
        private System.Windows.Forms.MaskedTextBox MskOgrTc;
        private System.Windows.Forms.MaskedTextBox MskOgrTel;
        private System.Windows.Forms.MaskedTextBox MskOgrDogum;
        private System.Windows.Forms.ComboBox CmbBolum;
        private System.Windows.Forms.TextBox OgrMail;
        private System.Windows.Forms.ComboBox CmbOdaNo;
        private System.Windows.Forms.TextBox TxtVeliAdSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox MskVeliTelNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox OgrAdres;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label12;
    }
}

