namespace YazilimYapimiProjee
{
    partial class frmsınav
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
            this.cboxsinavid = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sınava başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboxsinavid
            // 
            this.cboxsinavid.FormattingEnabled = true;
            this.cboxsinavid.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboxsinavid.Location = new System.Drawing.Point(489, 33);
            this.cboxsinavid.Name = "cboxsinavid";
            this.cboxsinavid.Size = new System.Drawing.Size(151, 28);
            this.cboxsinavid.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 544);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cboxsinavid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1351, 103);
            this.panel2.TabIndex = 2;
            // 
            // frmsınav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmsınav";
            this.Text = "frmsınav";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private ComboBox cboxsinavid;
        private Panel panel1;
        private Panel panel2;
    }
}