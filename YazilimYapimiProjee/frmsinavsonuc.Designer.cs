namespace YazilimYapimiProjee
{
    partial class frmsinavsonuc
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
            this.cbxsinavid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsonuc = new System.Windows.Forms.Button();
            this.txtdogru = new System.Windows.Forms.TextBox();
            this.txtyanlis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxsinavid
            // 
            this.cbxsinavid.FormattingEnabled = true;
            this.cbxsinavid.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxsinavid.Location = new System.Drawing.Point(597, 33);
            this.cbxsinavid.Name = "cbxsinavid";
            this.cbxsinavid.Size = new System.Drawing.Size(151, 28);
            this.cbxsinavid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Görmek İstediğiniz Sinavı Seçiniz";
            // 
            // btnsonuc
            // 
            this.btnsonuc.Location = new System.Drawing.Point(616, 67);
            this.btnsonuc.Name = "btnsonuc";
            this.btnsonuc.Size = new System.Drawing.Size(94, 29);
            this.btnsonuc.TabIndex = 2;
            this.btnsonuc.Text = "Sonuçları Gör";
            this.btnsonuc.UseVisualStyleBackColor = true;
            this.btnsonuc.Click += new System.EventHandler(this.btnsonuc_Click);
            // 
            // txtdogru
            // 
            this.txtdogru.Location = new System.Drawing.Point(193, 26);
            this.txtdogru.Name = "txtdogru";
            this.txtdogru.Size = new System.Drawing.Size(125, 27);
            this.txtdogru.TabIndex = 3;
            // 
            // txtyanlis
            // 
            this.txtyanlis.Location = new System.Drawing.Point(193, 73);
            this.txtyanlis.Name = "txtyanlis";
            this.txtyanlis.Size = new System.Drawing.Size(125, 27);
            this.txtyanlis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doğru Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yanlış sayısı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdogru);
            this.groupBox1.Controls.Add(this.txtyanlis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(343, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 125);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sonuçlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(324, 372);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(604, 263);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sorular ve Cevapları";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmsinavsonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 704);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxsinavid);
            this.Name = "frmsinavsonuc";
            this.Text = "frmsinavsonuc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxsinavid;
        private Label label1;
        private Button btnsonuc;
        private TextBox txtdogru;
        private TextBox txtyanlis;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button1;
    }
}