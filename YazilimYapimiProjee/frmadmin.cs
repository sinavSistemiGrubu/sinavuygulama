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
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS; Initial Catalog=kullanicilarr; Integrated Security=TRUE");
        private void frmadmin_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT S.SoruId,S.Onay,S.SoruText,S.SoruResim,S.DogruCevap,S.yanliscevap1,S.YanlisCevap2,S.yanliscevap3,D.DersAdi,U.UniteAd FROM Sorular AS S INNER JOIN Dersler AS D ON S.DersId = D.DersId INNER JOIN tblunite AS U On S.UniteId=U.uniteId;", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            conn.Open();
            int soruID;

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            soruID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
            SqlCommand cmd = new SqlCommand("update Sorular  set onay=@p1 where soruID=@p2", conn);
            cmd.Parameters.AddWithValue("@p1", true);
            cmd.Parameters.AddWithValue("@p2", soruID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void yuvarlakButon1_Click(object sender, EventArgs e)
        {
            frmGirisYap frm  = new frmGirisYap();
            frm.Show();
            this.Hide();

        }
    }
}
