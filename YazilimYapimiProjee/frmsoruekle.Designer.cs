namespace YazilimYapimiProjee
{
    partial class frmsoruekle
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtsoru = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.pictureSoru = new System.Windows.Forms.PictureBox();
            this.btnA = new ShapedButton.YuvarlakButon();
            this.btnC = new ShapedButton.YuvarlakButon();
            this.btnB = new ShapedButton.YuvarlakButon();
            this.btnD = new ShapedButton.YuvarlakButon();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.txtYol = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSoru)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(786, 327);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(152, 41);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Soruyu Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtsoru
            // 
            this.txtsoru.Location = new System.Drawing.Point(12, 28);
            this.txtsoru.Multiline = true;
            this.txtsoru.Name = "txtsoru";
            this.txtsoru.Size = new System.Drawing.Size(524, 269);
            this.txtsoru.TabIndex = 4;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(62, 327);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(125, 27);
            this.txtA.TabIndex = 5;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(62, 375);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(125, 27);
            this.txtC.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(281, 327);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(139, 27);
            this.txtB.TabIndex = 5;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(281, 375);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(139, 27);
            this.txtD.TabIndex = 5;
            // 
            // pictureSoru
            // 
            this.pictureSoru.Location = new System.Drawing.Point(848, 41);
            this.pictureSoru.Name = "pictureSoru";
            this.pictureSoru.Size = new System.Drawing.Size(204, 187);
            this.pictureSoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSoru.TabIndex = 6;
            this.pictureSoru.TabStop = false;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.Lime;
            this.btnA.Location = new System.Drawing.Point(12, 319);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(44, 42);
            this.btnA.TabIndex = 8;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Lime;
            this.btnC.Location = new System.Drawing.Point(12, 367);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(44, 42);
            this.btnC.TabIndex = 8;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.Lime;
            this.btnB.Location = new System.Drawing.Point(222, 319);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(44, 42);
            this.btnB.TabIndex = 8;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.Chartreuse;
            this.btnD.Location = new System.Drawing.Point(222, 367);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(44, 42);
            this.btnD.TabIndex = 8;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Location = new System.Drawing.Point(582, 118);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(101, 29);
            this.btnResimEkle.TabIndex = 9;
            this.btnResimEkle.Text = "ResimEkle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // txtYol
            // 
            this.txtYol.Location = new System.Drawing.Point(707, 120);
            this.txtYol.Name = "txtYol";
            this.txtYol.Size = new System.Drawing.Size(135, 27);
            this.txtYol.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sayfayı Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmsoruekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 637);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtYol);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.pictureSoru);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtsoru);
            this.Controls.Add(this.btnEkle);
            this.Name = "frmsoruekle";
            this.Text = "frmsoruekle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureSoru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEkle;
        private TextBox txtsoru;
        private TextBox txtA;
        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtD;
        private PictureBox pictureSoru;
        private ShapedButton.YuvarlakButon btnA;
        private ShapedButton.YuvarlakButon btnC;
        private ShapedButton.YuvarlakButon btnB;
        private ShapedButton.YuvarlakButon btnD;
        private OpenFileDialog openFileDialog1;
        private Button btnResimEkle;
        private TextBox txtYol;
        private Button button1;
    }
}