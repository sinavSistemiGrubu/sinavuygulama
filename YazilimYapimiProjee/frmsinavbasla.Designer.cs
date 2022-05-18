namespace YazilimYapimiProjee
{
    partial class frmsinavbasla
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
            this.components = new System.ComponentModel.Container();
            this.btnsonraki = new System.Windows.Forms.Button();
            this.lblsoru = new System.Windows.Forms.Label();
            this.radioButtonSecenekA = new System.Windows.Forms.RadioButton();
            this.radioButtonSecenekB = new System.Windows.Forms.RadioButton();
            this.radioButtonSecenekC = new System.Windows.Forms.RadioButton();
            this.radioButtonSecenekD = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbldk = new System.Windows.Forms.Label();
            this.lblsn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsonraki
            // 
            this.btnsonraki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsonraki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsonraki.Location = new System.Drawing.Point(869, 498);
            this.btnsonraki.Name = "btnsonraki";
            this.btnsonraki.Size = new System.Drawing.Size(186, 51);
            this.btnsonraki.TabIndex = 0;
            this.btnsonraki.Text = "Sonraki Soru";
            this.btnsonraki.UseVisualStyleBackColor = false;
            this.btnsonraki.Click += new System.EventHandler(this.btnsonraki_Click);
            // 
            // lblsoru
            // 
            this.lblsoru.AutoSize = true;
            this.lblsoru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblsoru.Location = new System.Drawing.Point(22, 85);
            this.lblsoru.Name = "lblsoru";
            this.lblsoru.Size = new System.Drawing.Size(20, 28);
            this.lblsoru.TabIndex = 1;
            this.lblsoru.Text = "-";
            // 
            // radioButtonSecenekA
            // 
            this.radioButtonSecenekA.AutoSize = true;
            this.radioButtonSecenekA.Location = new System.Drawing.Point(37, 49);
            this.radioButtonSecenekA.Name = "radioButtonSecenekA";
            this.radioButtonSecenekA.Size = new System.Drawing.Size(36, 24);
            this.radioButtonSecenekA.TabIndex = 3;
            this.radioButtonSecenekA.TabStop = true;
            this.radioButtonSecenekA.Text = "-";
            this.radioButtonSecenekA.UseVisualStyleBackColor = true;
            // 
            // radioButtonSecenekB
            // 
            this.radioButtonSecenekB.AutoSize = true;
            this.radioButtonSecenekB.Location = new System.Drawing.Point(37, 93);
            this.radioButtonSecenekB.Name = "radioButtonSecenekB";
            this.radioButtonSecenekB.Size = new System.Drawing.Size(36, 24);
            this.radioButtonSecenekB.TabIndex = 4;
            this.radioButtonSecenekB.TabStop = true;
            this.radioButtonSecenekB.Text = "-";
            this.radioButtonSecenekB.UseVisualStyleBackColor = true;
            // 
            // radioButtonSecenekC
            // 
            this.radioButtonSecenekC.AutoSize = true;
            this.radioButtonSecenekC.Location = new System.Drawing.Point(37, 143);
            this.radioButtonSecenekC.Name = "radioButtonSecenekC";
            this.radioButtonSecenekC.Size = new System.Drawing.Size(36, 24);
            this.radioButtonSecenekC.TabIndex = 5;
            this.radioButtonSecenekC.TabStop = true;
            this.radioButtonSecenekC.Text = "-";
            this.radioButtonSecenekC.UseVisualStyleBackColor = true;
            // 
            // radioButtonSecenekD
            // 
            this.radioButtonSecenekD.AutoSize = true;
            this.radioButtonSecenekD.Location = new System.Drawing.Point(37, 188);
            this.radioButtonSecenekD.Name = "radioButtonSecenekD";
            this.radioButtonSecenekD.Size = new System.Drawing.Size(36, 24);
            this.radioButtonSecenekD.TabIndex = 6;
            this.radioButtonSecenekD.TabStop = true;
            this.radioButtonSecenekD.Text = "-";
            this.radioButtonSecenekD.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSecenekA);
            this.groupBox1.Controls.Add(this.radioButtonSecenekB);
            this.groupBox1.Controls.Add(this.radioButtonSecenekD);
            this.groupBox1.Controls.Add(this.radioButtonSecenekC);
            this.groupBox1.Location = new System.Drawing.Point(72, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 278);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEÇENEKLER";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblsoru);
            this.groupBox2.Location = new System.Drawing.Point(57, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 271);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SORU";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(869, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(471, 271);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbldk
            // 
            this.lbldk.AutoSize = true;
            this.lbldk.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldk.Location = new System.Drawing.Point(1025, 66);
            this.lbldk.Name = "lbldk";
            this.lbldk.Size = new System.Drawing.Size(40, 31);
            this.lbldk.TabIndex = 11;
            this.lbldk.Text = "00";
            // 
            // lblsn
            // 
            this.lblsn.AutoSize = true;
            this.lblsn.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsn.Location = new System.Drawing.Point(1094, 66);
            this.lblsn.Name = "lblsn";
            this.lblsn.Size = new System.Drawing.Size(40, 31);
            this.lblsn.TabIndex = 12;
            this.lblsn.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1071, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(905, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kalan Süre:";
            // 
            // frmsinavbasla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1402, 736);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblsn);
            this.Controls.Add(this.lbldk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsonraki);
            this.Name = "frmsinavbasla";
            this.Text = "frmsinavbasla";
            this.Load += new System.EventHandler(this.frmsinavbasla_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnsonraki;
        private Label lblsoru;
        private RadioButton radioButtonSecenekA;
        private RadioButton radioButtonSecenekB;
        private RadioButton radioButtonSecenekC;
        private RadioButton radioButtonSecenekD;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private Label lbldk;
        private Label lblsn;
        private Label label1;
        private Label label2;
    }
}