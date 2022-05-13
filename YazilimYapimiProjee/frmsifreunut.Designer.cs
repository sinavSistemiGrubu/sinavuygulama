namespace YazilimYapimiProjee
{
    partial class frmsifreunut
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
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(278, 82);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(186, 27);
            this.txtkullaniciadi.TabIndex = 0;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(278, 131);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(186, 27);
            this.txtmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "kullanici adi giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "e-posta adresi";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(322, 218);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(119, 29);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Şifre Değiştir";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(277, 173);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(187, 27);
            this.txtsifre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "yeni sifreyi gir";
            // 
            // lbltur
            // 
            this.lbltur.AutoSize = true;
            this.lbltur.Location = new System.Drawing.Point(629, 35);
            this.lbltur.Name = "lbltur";
            this.lbltur.Size = new System.Drawing.Size(15, 20);
            this.lbltur.TabIndex = 4;
            this.lbltur.Text = "-";
            // 
            // frmsifreunut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltur);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtkullaniciadi);
            this.Name = "frmsifreunut";
            this.Text = "ŞİFREMİ UNUTTUM";
            this.Load += new System.EventHandler(this.frmsifreunut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtkullaniciadi;
        private TextBox txtmail;
        private Label label1;
        private Label label2;
        private Button btnupdate;
        private TextBox txtsifre;
        private Label label3;
        private Label lbltur;
    }
}