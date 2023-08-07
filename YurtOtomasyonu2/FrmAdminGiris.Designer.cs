namespace YurtOtomasyonu2
{
    partial class FrmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            this.TxtKullanici = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtSifre = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtCikisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtKullanici
            // 
            this.TxtKullanici.AutoSize = true;
            this.TxtKullanici.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullanici.Location = new System.Drawing.Point(40, 59);
            this.TxtKullanici.Name = "TxtKullanici";
            this.TxtKullanici.Size = new System.Drawing.Size(124, 28);
            this.TxtKullanici.TabIndex = 0;
            this.TxtKullanici.Text = "Kullanıcı Adı:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(170, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 34);
            this.textBox1.TabIndex = 1;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLogin.Location = new System.Drawing.Point(83, 201);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(143, 38);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Giriş";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtSifre
            // 
            this.TxtSifre.AutoSize = true;
            this.TxtSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(97, 133);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(55, 28);
            this.TxtSifre.TabIndex = 3;
            this.TxtSifre.Text = "Şifre:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(170, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 34);
            this.textBox2.TabIndex = 2;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // TxtCikisYap
            // 
            this.TxtCikisYap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCikisYap.Location = new System.Drawing.Point(312, 201);
            this.TxtCikisYap.Name = "TxtCikisYap";
            this.TxtCikisYap.Size = new System.Drawing.Size(143, 38);
            this.TxtCikisYap.TabIndex = 4;
            this.TxtCikisYap.Text = "Çıkış Yap";
            this.TxtCikisYap.UseVisualStyleBackColor = true;
            this.TxtCikisYap.Click += new System.EventHandler(this.TxtCikisYap_Click);
            // 
            // FrmAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(509, 295);
            this.Controls.Add(this.TxtCikisYap);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TxtKullanici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminGiris";
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.FrmAdminGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtKullanici;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label TxtSifre;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button TxtCikisYap;
    }
}