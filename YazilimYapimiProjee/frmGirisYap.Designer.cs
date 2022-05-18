namespace YazilimYapimiProjee
{
    partial class frmGirisYap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGirisYap));
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.linkLabelKayitOl = new System.Windows.Forms.LinkLabel();
            this.radioButtonOgrenciGiris = new System.Windows.Forms.RadioButton();
            this.radioButtonOgretmenGiris = new System.Windows.Forms.RadioButton();
            this.radioButtonAdminGiris = new System.Windows.Forms.RadioButton();
            this.lnksifreunut = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGirisYap.Location = new System.Drawing.Point(125, 122);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(190, 35);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // linkLabelKayitOl
            // 
            this.linkLabelKayitOl.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabelKayitOl.AutoSize = true;
            this.linkLabelKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linkLabelKayitOl.LinkColor = System.Drawing.Color.AliceBlue;
            this.linkLabelKayitOl.Location = new System.Drawing.Point(58, 166);
            this.linkLabelKayitOl.Name = "linkLabelKayitOl";
            this.linkLabelKayitOl.Size = new System.Drawing.Size(91, 20);
            this.linkLabelKayitOl.TabIndex = 6;
            this.linkLabelKayitOl.TabStop = true;
            this.linkLabelKayitOl.Text = "KAYIT OL";
            this.linkLabelKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelKayitOl_LinkClicked);
            // 
            // radioButtonOgrenciGiris
            // 
            this.radioButtonOgrenciGiris.AutoSize = true;
            this.radioButtonOgrenciGiris.BackColor = System.Drawing.Color.IndianRed;
            this.radioButtonOgrenciGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioButtonOgrenciGiris.ForeColor = System.Drawing.Color.Azure;
            this.radioButtonOgrenciGiris.Location = new System.Drawing.Point(6, 33);
            this.radioButtonOgrenciGiris.Name = "radioButtonOgrenciGiris";
            this.radioButtonOgrenciGiris.Size = new System.Drawing.Size(114, 24);
            this.radioButtonOgrenciGiris.TabIndex = 7;
            this.radioButtonOgrenciGiris.TabStop = true;
            this.radioButtonOgrenciGiris.Text = "ÖĞRENCİ";
            this.radioButtonOgrenciGiris.UseVisualStyleBackColor = false;
            // 
            // radioButtonOgretmenGiris
            // 
            this.radioButtonOgretmenGiris.AutoSize = true;
            this.radioButtonOgretmenGiris.BackColor = System.Drawing.Color.IndianRed;
            this.radioButtonOgretmenGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioButtonOgretmenGiris.ForeColor = System.Drawing.Color.White;
            this.radioButtonOgretmenGiris.Location = new System.Drawing.Point(159, 33);
            this.radioButtonOgretmenGiris.Name = "radioButtonOgretmenGiris";
            this.radioButtonOgretmenGiris.Size = new System.Drawing.Size(206, 24);
            this.radioButtonOgretmenGiris.TabIndex = 8;
            this.radioButtonOgretmenGiris.TabStop = true;
            this.radioButtonOgretmenGiris.Text = "SINAV SORUMLUSU";
            this.radioButtonOgretmenGiris.UseVisualStyleBackColor = false;
            // 
            // radioButtonAdminGiris
            // 
            this.radioButtonAdminGiris.AutoSize = true;
            this.radioButtonAdminGiris.BackColor = System.Drawing.Color.IndianRed;
            this.radioButtonAdminGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioButtonAdminGiris.ForeColor = System.Drawing.Color.White;
            this.radioButtonAdminGiris.Location = new System.Drawing.Point(402, 33);
            this.radioButtonAdminGiris.Name = "radioButtonAdminGiris";
            this.radioButtonAdminGiris.Size = new System.Drawing.Size(89, 24);
            this.radioButtonAdminGiris.TabIndex = 9;
            this.radioButtonAdminGiris.TabStop = true;
            this.radioButtonAdminGiris.Text = "ADMİN";
            this.radioButtonAdminGiris.UseVisualStyleBackColor = false;
            // 
            // lnksifreunut
            // 
            this.lnksifreunut.AutoSize = true;
            this.lnksifreunut.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lnksifreunut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lnksifreunut.ForeColor = System.Drawing.Color.Chocolate;
            this.lnksifreunut.LinkColor = System.Drawing.Color.White;
            this.lnksifreunut.Location = new System.Drawing.Point(259, 170);
            this.lnksifreunut.Name = "lnksifreunut";
            this.lnksifreunut.Size = new System.Drawing.Size(147, 16);
            this.lnksifreunut.TabIndex = 10;
            this.lnksifreunut.TabStop = true;
            this.lnksifreunut.Text = "ŞİFREMİ UNUTTUM";
            this.lnksifreunut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.lnksifreunut);
            this.groupBox1.Controls.Add(this.btnGirisYap);
            this.groupBox1.Controls.Add(this.linkLabelKayitOl);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(526, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 255);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistem Giriş";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.Crimson;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Snow;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(113, 42);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(211, 27);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Crimson;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtSifre.ForeColor = System.Drawing.Color.Snow;
            this.txtSifre.Location = new System.Drawing.Point(113, 75);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.PlaceholderText = "Şifre";
            this.txtSifre.Size = new System.Drawing.Size(211, 27);
            this.txtSifre.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonOgrenciGiris);
            this.groupBox2.Controls.Add(this.radioButtonOgretmenGiris);
            this.groupBox2.Controls.Add(this.radioButtonAdminGiris);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(526, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 90);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giriş Türü";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmGirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGirisYap";
            this.Text = "SINAV GİRİŞ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnGirisYap;
        private LinkLabel linkLabelKayitOl;
        private RadioButton radioButtonOgrenciGiris;
        private RadioButton radioButtonOgretmenGiris;
        private RadioButton radioButtonAdminGiris;
        private LinkLabel lnksifreunut;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
    }
}