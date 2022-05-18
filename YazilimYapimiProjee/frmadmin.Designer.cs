namespace YazilimYapimiProjee
{
    partial class frmadmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.yuvarlakButon1 = new ShapedButton.YuvarlakButon();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(700, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(209, 35);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(476, 38);
            this.label.TabIndex = 1;
            this.label.Text = "Soruları Kontrol Edin Ve Onaylayın";
            // 
            // yuvarlakButon1
            // 
            this.yuvarlakButon1.BackColor = System.Drawing.Color.White;
            this.yuvarlakButon1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yuvarlakButon1.Location = new System.Drawing.Point(13, 11);
            this.yuvarlakButon1.Name = "yuvarlakButon1";
            this.yuvarlakButon1.Size = new System.Drawing.Size(52, 29);
            this.yuvarlakButon1.TabIndex = 2;
            this.yuvarlakButon1.Text = "Geri";
            this.yuvarlakButon1.UseVisualStyleBackColor = false;
            this.yuvarlakButon1.Click += new System.EventHandler(this.yuvarlakButon1_Click);
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.yuvarlakButon1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmadmin";
            this.Text = "frmadmin";
            this.Load += new System.EventHandler(this.frmadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label;
        private ShapedButton.YuvarlakButon yuvarlakButon1;
    }
}