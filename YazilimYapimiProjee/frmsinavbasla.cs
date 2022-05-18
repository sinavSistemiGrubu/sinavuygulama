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
    public partial class frmsinavbasla : Form
    {
        public frmsinavbasla()
        {
            InitializeComponent();
        }
        List<int> sinavListe = new List<int>();
        public int a = 0;
        int[] SinavSoruId = new int[10];
        public int id;
        SqlConnection conn = frmGirisYap.connection;
        SqlConnection conn2 = frmGirisYap.connection;
        int sayac = 0;
        string DogruSecenek = ""; string OgrenciSecenek = "";
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS; Initial Catalog=kullanicilarr; Integrated Security=TRUE");

       
        private void frmsinavbasla_Load(object sender, EventArgs e)
        {
            conn.Open();
           SqlCommand cmd = new SqlCommand("SELECT * FROM tblSinav where SinavID=@p1",conn);
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SinavSoruId[a] = Convert.ToInt32(dr[1]);
                a++;
            }
            conn.Close();
            SoruCek();

        }
        public void SoruCek()
        {
            conn.Open();
            SqlCommand cmd3 = new SqlCommand("Select * from Sorular  where soruID=@p2", conn);
            cmd3.Parameters.AddWithValue("@p2", SinavSoruId[sayac]);
            SqlDataReader dr2 = cmd3.ExecuteReader();
            if(dr2.Read())
            {
                lblsoru.Text=Convert.ToString(dr2[1]);
                radioButton1.Text = Convert.ToString(dr2[5]);
                radioButton2.Text = Convert.ToString(dr2[6]);
                radioButton3.Text = Convert.ToString(dr2[7]);
                radioButton4.Text = Convert.ToString(dr2[8]);
                DogruSecenek= Convert.ToString(dr2[9]);
            }
            conn.Close();
            sayac++;
        }
        public void kontrol()
        {
            if (radioButton1.Checked) OgrenciSecenek = "A";
            if (radioButton2.Checked) OgrenciSecenek = "B";
            if (radioButton3.Checked) OgrenciSecenek = "C";
            if (radioButton4.Checked) OgrenciSecenek = "D";

            if (OgrenciSecenek == DogruSecenek) MessageBox.Show("Dogru");
            else MessageBox.Show("yanlış");
        }
        bool Saykon = false;
        private void btnsonraki_Click(object sender, EventArgs e)
        {
            kontrol();
            SoruCek();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            lblsoru.Visible = true;
        }
        
        
    }
}
