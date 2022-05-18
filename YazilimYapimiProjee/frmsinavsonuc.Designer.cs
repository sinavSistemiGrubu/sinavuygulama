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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.cbxsinavid.Location = new System.Drawing.Point(548, 41);
            this.cbxsinavid.Name = "cbxsinavid";
            this.cbxsinavid.Size = new System.Drawing.Size(151, 28);
            this.cbxsinavid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Görmek İstediğiniz Sinavı Seçiniz:";
            // 
            // btnsonuc
            // 
            this.btnsonuc.BackColor = System.Drawing.Color.Red;
            this.btnsonuc.Location = new System.Drawing.Point(526, 86);
            this.btnsonuc.Name = "btnsonuc";
            this.btnsonuc.Size = new System.Drawing.Size(190, 47);
            this.btnsonuc.TabIndex = 2;
            this.btnsonuc.Text = "Sonuçları Gör";
            this.btnsonuc.UseVisualStyleBackColor = false;
            this.btnsonuc.Click += new System.EventHandler(this.btnsonuc_Click);
            // 
            // txtdogru
            // 
            this.txtdogru.Location = new System.Drawing.Point(193, 33);
            this.txtdogru.Name = "txtdogru";
            this.txtdogru.Size = new System.Drawing.Size(180, 34);
            this.txtdogru.TabIndex = 3;
            // 
            // txtyanlis
            // 
            this.txtyanlis.Location = new System.Drawing.Point(193, 73);
            this.txtyanlis.Name = "txtyanlis";
            this.txtyanlis.Size = new System.Drawing.Size(180, 34);
            this.txtyanlis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doğru Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yanlış sayısı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdogru);
            this.groupBox1.Controls.Add(this.txtyanlis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(349, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 125);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sonuçlar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sorular ve Cevapları";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(87, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1086, 354);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CEVAPLANAN SORULAR";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(1080, 328);
            this.dataGridView2.TabIndex = 8;
            // 
            // frmsinavsonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1359, 704);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxsinavid);
            this.Name = "frmsinavsonuc";
            this.Text = "frmsinavsonuc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private Button button1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
    }
}