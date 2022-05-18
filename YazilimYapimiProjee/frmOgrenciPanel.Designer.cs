namespace YazilimYapimiProjee
{
    partial class frmOgrenciPanel
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sınava Gir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sonuçlarımı Gör";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(535, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 57);
            this.button3.TabIndex = 1;
            this.button3.Text = "Sınav Analiz";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmOgrenciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 506);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmOgrenciPanel";
            this.Text = "frmOgrenciPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}