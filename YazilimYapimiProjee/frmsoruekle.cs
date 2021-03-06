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
    public partial class frmsoruekle : Form
    {
        public frmsoruekle()
        {
            InitializeComponent();
        }
        SqlConnection connnection = frmGirisYap.connection;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS; Initial Catalog=kullanicilarr; Integrated Security=TRUE");
        string secenek;
        string dogrucevap;
        string yanliscevap1;
        string yanliscevap2;
        string yanliscevap3;
        private void btnEkle_Click(object sender, EventArgs e)
        {

           
            connnection.Open();
          

            SqlCommand cmd = new SqlCommand("insert into Sorular(SoruText,SoruResim,DersId,UniteId,DogruCevap,YanlisCevap1,YanlisCevap2,YanlisCevap3,DogruSecenek)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9) ", connnection);
           
            cmd.Parameters.AddWithValue("@p1", txtsoru.Text);
            cmd.Parameters.AddWithValue("@p2", txtYol.Text);
            cmd.Parameters.AddWithValue("@p3", DersId);
            cmd.Parameters.AddWithValue("@p4", UniteId);
            cmd.Parameters.AddWithValue("@p5", dogrucevap);
            cmd.Parameters.AddWithValue("@p6", yanliscevap1);
            cmd.Parameters.AddWithValue("@p7", yanliscevap2);
            cmd.Parameters.AddWithValue("@p8", yanliscevap3);
            cmd.Parameters.AddWithValue("@p9", secenek);
            cmd.ExecuteNonQuery();
            MessageBox.Show("yeni soru başarıyla eklendi");
            connnection.Close();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            dogrucevap = txtA.Text;
            yanliscevap1 = txtB.Text;
            yanliscevap2 = txtC.Text;
            yanliscevap3 = txtD.Text;
            secenek = btnA.Text;
            btnA.BackColor = Color.Red;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        

    }

        private void btnB_Click(object sender, EventArgs e)
        {
            dogrucevap = txtB.Text;
            yanliscevap1 = txtA.Text;
            yanliscevap2 = txtC.Text;
            yanliscevap3 = txtD.Text;
            secenek = btnB.Text;
            btnB.BackColor = Color.Red;
            btnA.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            dogrucevap = txtC.Text;
            yanliscevap1 = txtB.Text;
            yanliscevap2 = txtA.Text;
            yanliscevap3 = txtD.Text;
            secenek = btnC.Text;
            btnC.BackColor = Color.Red;
            btnB.Enabled = false;
            btnA.Enabled = false;
            btnD.Enabled = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            dogrucevap = txtD.Text;
            yanliscevap1 = txtB.Text;
            yanliscevap2 = txtC.Text;
            yanliscevap3 = txtA.Text;
            secenek = btnD.Text;
            btnD.BackColor = Color.Red;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnA.Enabled = false;
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureSoru.ImageLocation = openFileDialog1.FileName;
            txtYol.Text = openFileDialog1.FileName;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text ="";
            txtD.Text = "";
            txtsoru.Text = "";
            txtYol.Text = "";
            pictureSoru.ImageLocation = "";
            btnA.BackColor = Color.Lime;
            btnB.BackColor = Color.Lime;
            btnC.BackColor = Color.Lime;
            btnD.BackColor = Color.Lime;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnA.Enabled = true;
            btnD.Enabled = true;
            cmbxunite.Items.Clear();
            cmbxunite.Text = "";
            cmbxders.Text = "";

        }
        
        private void frmsoruekle_Load(object sender, EventArgs e)
        {
       
            connnection.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Dersler",connnection);
            SqlDataReader dr;
            dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
               cmbxders.Items.Add(dr["DersAdi"]);
            }
         
          
            connnection.Close();

        }
        int DersId;
        int UniteId;
        private void cmbxders_SelectedIndexChanged(object sender, EventArgs e)
        {

            connnection.Open();
            conn.Open();
            string tur;
           

            tur = cmbxders.Text;

            SqlCommand sqlCommand2 = new SqlCommand("Select * from Dersler", connnection);
           
            SqlDataReader dr = sqlCommand2.ExecuteReader();
           
            
            while (dr.Read())
            {
                
                if (tur == dr["DersAdi"].ToString() )
                {
                    DersId = Convert.ToInt32(dr["DersId"]);
                  
                }
            }
            SqlCommand sqlCommand3 = new SqlCommand("select UniteAd from tblunite where DersId=@p1", conn);
            sqlCommand3.Parameters.AddWithValue("@p1", DersId);
            SqlDataReader dr1 = sqlCommand3.ExecuteReader();
            while (dr1.Read())
            {

                cmbxunite.Items.Add(dr1["UniteAd"]);
            }
            

            connnection.Close();
            conn.Close();
            
        }

        private void cmbxunite_SelectedIndexChanged(object sender, EventArgs e)
        {
            connnection.Open();
           
            string tur;


            tur = cmbxunite.Text;

            SqlCommand sqlCommand2 = new SqlCommand("Select * from tblUnite", connnection);

            SqlDataReader dr = sqlCommand2.ExecuteReader();
            while (dr.Read())
            {

                if (tur == dr["UniteAd"].ToString())
                {
                    UniteId = Convert.ToInt32(dr["UniteId"]);

                }
            }
            connnection.Close();
        }

        private void yuvarlakButon1_Click(object sender, EventArgs e)
        {
            frmsinavsorumlusu frm = new frmsinavsorumlusu();
            frm.Show();
            this.Hide();
        }
    }
}
