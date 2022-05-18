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
    public partial class frmsinavsonuc : Form
    {
        public frmsinavsonuc()
        {
            InitializeComponent();
        }
        public int ogrId;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS; Initial Catalog=kullanicilarr; Integrated Security=TRUE");
        private void btnsonuc_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("exec sp_sorular @p1,@p2,@p3 ",conn);// procedure kullanarak öğrencinin sınavdan doğru yanlis yapma durumu
            cmd.Parameters.AddWithValue("@p1",Convert.ToInt32( cbxsinavid.Text));
            cmd.Parameters.AddWithValue("@p2",1);
            cmd.Parameters.AddWithValue("@p3", ogrId);


            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                txtdogru.Text=dr[0].ToString();
            }
            conn.Close();

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("exec sp_sorular @p1,@p2,@p3 ", conn);// procedure kullanarak öğrencinin sınavdan doğru yanlis yapma durumu
            cmd1.Parameters.AddWithValue("@p1", Convert.ToInt32(cbxsinavid.Text));
            cmd1.Parameters.AddWithValue("@p2", 0);
            cmd1.Parameters.AddWithValue("@p3", ogrId);

            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                txtyanlis.Text = dr1[0].ToString();
            }
            conn.Close();
        }
    }
}
