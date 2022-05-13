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
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.linkLabelKayitOl = new System.Windows.Forms.LinkLabel();
            this.radioButtonOgrenciGiris = new System.Windows.Forms.RadioButton();
            this.radioButtonOgretmenGiris = new System.Windows.Forms.RadioButton();
            this.radioButtonAdminGiris = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Crimson;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(498, 208);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(143, 22);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "KULLANICI ADI";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSifre.ForeColor = System.Drawing.Color.Crimson;
            this.lblSifre.Location = new System.Drawing.Point(577, 252);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(64, 22);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "ŞİFRE";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.Crimson;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Snow;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(698, 206);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(211, 21);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Crimson;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtSifre.ForeColor = System.Drawing.Color.Snow;
            this.txtSifre.Location = new System.Drawing.Point(698, 253);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(211, 21);
            this.txtSifre.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGirisYap.Location = new System.Drawing.Point(927, 400);
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
            this.linkLabelKayitOl.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabelKayitOl.Location = new System.Drawing.Point(738, 448);
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
            this.radioButtonOgrenciGiris.BackColor = System.Drawing.Color.Silver;
            this.radioButtonOgrenciGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioButtonOgrenciGiris.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonOgrenciGiris.Location = new System.Drawing.Point(474, 313);
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
            this.radioButtonOgretmenGiris.BackColor = System.Drawing.Color.Silver;
            this.radioButtonOgretmenGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioButtonOgretmenGiris.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonOgretmenGiris.Location = new System.Drawing.Point(698, 313);
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
            this.radioButtonAdminGiris.BackColor = System.Drawing.Color.Silver;
            this.radioButtonAdminGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioButtonAdminGiris.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonAdminGiris.Location = new System.Drawing.Point(1028, 313);
            this.radioButtonAdminGiris.Name = "radioButtonAdminGiris";
            this.radioButtonAdminGiris.Size = new System.Drawing.Size(89, 24);
            this.radioButtonAdminGiris.TabIndex = 9;
            this.radioButtonAdminGiris.TabStop = true;
            this.radioButtonAdminGiris.Text = "ADMİN";
            this.radioButtonAdminGiris.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.SeaGreen;
            this.linkLabel1.Location = new System.Drawing.Point(486, 407);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(177, 20);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ŞİFREMİ UNUTTUM";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YazilimYapimiProjee.Properties.Resources.indir;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1285, 545);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.radioButtonAdminGiris);
            this.Controls.Add(this.radioButtonOgretmenGiris);
            this.Controls.Add(this.radioButtonOgrenciGiris);
            this.Controls.Add(this.linkLabelKayitOl);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Name = "Form1";
            this.Text = "SINAV GİRİŞ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKullaniciAdi;
        private Label lblSifre;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGirisYap;
        private LinkLabel linkLabelKayitOl;
        private RadioButton radioButtonOgrenciGiris;
        private RadioButton radioButtonOgretmenGiris;
        private RadioButton radioButtonAdminGiris;
        private LinkLabel linkLabel1;
    }
}