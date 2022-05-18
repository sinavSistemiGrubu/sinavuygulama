using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazilimYapimiProjee
{
    public partial class frmsinavolustur : Form
    {
        public frmsinavolustur()
        {
            InitializeComponent();
        }
        SqlConnection conn = frmGirisYap.connection;
        private void frmsinavolustur_Load(object sender, EventArgs e)
        {
           
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT S.SoruId,S.SoruText,S.SoruResim,S.DogruCevap,S.yanliscevap1,S.YanlisCevap2,S.yanliscevap3,D.DersAdi,U.UniteAd FROM Sorular AS S INNER JOIN Dersler AS D ON S.DersId = D.DersId INNER JOIN tblunite AS U On S.UniteId=U.uniteId;",conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            
            int soruId;
            int SinavId;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;     
            soruId = Convert.ToInt32( dataGridView1.Rows[secilen].Cells[0].Value);
            SinavId = Convert.ToInt32(cboxSınavId.Text);
            SqlCommand cmd = new SqlCommand("Insert INTO tblSinav (SinavID,SoruID) values (@p1,@p2)",conn);
            cmd.Parameters.AddWithValue("@p1", SinavId);
            cmd.Parameters.AddWithValue("@p2",soruId);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

       
    }
}
