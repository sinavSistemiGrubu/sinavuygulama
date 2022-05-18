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
    public partial class frmOgrenciPanel : Form
    {
        public frmOgrenciPanel()
        {
            InitializeComponent();
        }
        public int ogrID;

        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS; Initial Catalog=kullanicilarr; Integrated Security=TRUE");
        private void button1_Click(object sender, EventArgs e)
        {
            frmsınav frm=new frmsınav();
            frm.ogrId = ogrID;
            frm.Show();

        }

        private void frmOgrenciPanel_Load(object sender, EventArgs e)
        {
           connection.Open();
            SqlCommand cmd = new SqlCommand("select * from ogrenci where ogrenciID=@p1",connection);
            cmd.Parameters.AddWithValue("@p1", ogrID);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                label1.Text = dr["ogrenciAd"].ToString() +" "+ dr["ogrenciSoyad"].ToString();

            }
            connection.Close();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmsinavsonuc frm1 = new frmsinavsonuc();
            frm1.ogrId = ogrID;
            frm1.Show();
        }
    }
}
