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
        public int ogrId;
        public int a = 0;
        int[] SinavSoruId = new int[10];
        public int id;
        
        int sayac = 0;
        string DogruSecenek = ""; string OgrenciSecenek = "";
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS; Initial Catalog=kullanicilarr; Integrated Security=TRUE");

       
        private void frmsinavbasla_Load(object sender, EventArgs e)
        {
            connection.Open();
           SqlCommand cmd = new SqlCommand("SELECT * FROM tblSinav where SinavID=@p1",connection);
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SinavSoruId[a] = Convert.ToInt32(dr[1]);
                a++;
            }
            connection.Close();
            SoruCek();

        }
        public void SoruCek()
        {
            if (sayac < 10) 
            {
                connection.Open();
                SqlCommand cmd3 = new SqlCommand("Select * from Sorular  where soruID=@p2", connection);
                cmd3.Parameters.AddWithValue("@p2", SinavSoruId[sayac]);
                SqlDataReader dr2 = cmd3.ExecuteReader();
                if (dr2.Read())
                {

                    lblsoru.Text = Convert.ToString(dr2[1]);
                    pictureBox1.ImageLocation = dr2[2].ToString();
                    radioButtonSecenekA.Text = Convert.ToString(dr2[5]);
                    radioButtonSecenekB.Text = Convert.ToString(dr2[6]);
                    radioButtonSecenekC.Text = Convert.ToString(dr2[7]);
                    radioButtonSecenekD.Text = Convert.ToString(dr2[8]);
                    DogruSecenek = Convert.ToString(dr2[9]);
                }
                connection.Close();
                sayac++;
            }
            else
            {
                MessageBox.Show("sinav bitmiştir");
            }
           

        }
        public void kontrol()
        {
            connection.Open();
          
            if (radioButtonSecenekA.Checked) OgrenciSecenek = "A";
            if (radioButtonSecenekB.Checked) OgrenciSecenek = "B";
            if (radioButtonSecenekC.Checked) OgrenciSecenek = "C";
            if (radioButtonSecenekD.Checked) OgrenciSecenek = "D";

            if (OgrenciSecenek == DogruSecenek)
            {
                MessageBox.Show("Dogru");
              
                CevapKontol(ogrId, id, SinavSoruId[sayac-1], true);


            }
            else
            {
                MessageBox.Show("yanlış");
                CevapKontol(ogrId, id, SinavSoruId[sayac-1], false);
              
            }
            connection.Close();
        }
       
        private void btnsonraki_Click(object sender, EventArgs e)
        {
            kontrol();
            SoruCek();
            radioButtonSecenekA.Checked = false;
            radioButtonSecenekB.Checked = false;
            radioButtonSecenekC.Checked = false;
            radioButtonSecenekD.Checked = false;


        }

        public void CevapKontol(int a ,int b ,int c,bool d)
        {
            
          
            SqlCommand cmd = new SqlCommand("insert INTO  OgrenciSinavDurum (OgrenciID,SinavID,SoruID,CevapDurum) values (@p1,@p2,@p3,@p4) ", connection);
            cmd.Parameters.AddWithValue("@p1", a);
            cmd.Parameters.AddWithValue("@p2", b);
            cmd.Parameters.AddWithValue("p3", c);
            cmd.Parameters.AddWithValue("@p4", d);
            cmd.ExecuteNonQuery();
          
        
          


        }


    }
}
