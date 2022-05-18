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
            this.btnsonraki = new System.Windows.Forms.Button();
            this.lblsoru = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsonraki
            // 
            this.btnsonraki.Location = new System.Drawing.Point(952, 413);
            this.btnsonraki.Name = "btnsonraki";
            this.btnsonraki.Size = new System.Drawing.Size(175, 41);
            this.btnsonraki.TabIndex = 0;
            this.btnsonraki.Text = "Sonraki Soru";
            this.btnsonraki.UseVisualStyleBackColor = true;
            this.btnsonraki.Click += new System.EventHandler(this.btnsonraki_Click);
            // 
            // lblsoru
            // 
            this.lblsoru.AutoSize = true;
            this.lblsoru.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblsoru.Location = new System.Drawing.Point(211, 92);
            this.lblsoru.Name = "lblsoru";
            this.lblsoru.Size = new System.Drawing.Size(28, 38);
            this.lblsoru.TabIndex = 1;
            this.lblsoru.Text = "-";
            this.lblsoru.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(80, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(365, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(80, 128);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(117, 24);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(365, 128);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(117, 24);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1008, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 163);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(61, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 159);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(774, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "btnbasla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmsinavbasla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 535);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblsoru);
            this.Controls.Add(this.btnsonraki);
            this.Name = "frmsinavbasla";
            this.Text = "frmsinavbasla";
            this.Load += new System.EventHandler(this.frmsinavbasla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnsonraki;
        private Label lblsoru;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button button2;
    }
}