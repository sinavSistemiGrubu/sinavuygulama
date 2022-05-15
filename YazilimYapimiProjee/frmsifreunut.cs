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

    public partial class frmsifreunut : Form
    {

        public frmsifreunut()
        {
            InitializeComponent();
        }


        SqlConnection conn = frmGirisYap.connection;
        SqlConnection conn1 = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\QLEXPRESS; Initial Catalog=kullanicilarr; Integrated Security=TRUE");
        public string tur;
        private void frmsifreunut_Load(object sender, EventArgs e)
        {
            lbltur.Text = tur;
        }



        private void btnupdate_Click(object sender, EventArgs e)
        {


            bool kontrol = false;

            SqlCommand sqlCommand = new SqlCommand("Select * from admin", conn);
            SqlCommand sqlCommand1 = new SqlCommand("Select * from ogrenci", conn);
            SqlCommand sqlCommand2 = new SqlCommand("Select * from sorumluu", conn);




            if (lbltur.Text == "ADMİN")
            {
                conn.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    if (txtkullaniciadi.Text == reader["adminKullaniciAd"].ToString() && txtmail.Text == reader["adminEmail"].ToString())
                    {
                        kontrol = true;

                        SqlCommand upd = new SqlCommand("Update admin set adminSifre=@a1 where adminKullaniciAd=@a2 and adminEmail=@a3", conn1);
                        conn1.Open();
                        upd.Parameters.AddWithValue("@a1", txtsifre.Text);
                        upd.Parameters.AddWithValue("@a2", txtkullaniciadi.Text);
                        upd.Parameters.AddWithValue("@a3", txtmail.Text);
                        upd.ExecuteNonQuery();
                        MessageBox.Show("yeni şifre başarıyla oluşturuldu");
                        conn1.Close();

                    }

                    break;

                }
                conn.Close();

                if (kontrol == false)
                {
                    MessageBox.Show("Hatalı bilgiler girdiniz! ! !");
                }

            }

            else if (lbltur.Text == "ÖĞRENCİ")
            {
                conn.Open();
                SqlDataReader reader1 = sqlCommand1.ExecuteReader();

                while (reader1.Read())
                {


                    if (txtkullaniciadi.Text == reader1["ogrenciKullaniciAd"].ToString() && txtmail.Text == reader1["ogrenciEmail"].ToString())

                    {
                        kontrol = true;

                        SqlCommand upd1 = new SqlCommand("Update ogrenci set ogrenciSifre=@a1 where ogrenciKullaniciAd=@a2 and ogrenciEmail=@a3", conn1);
                        conn1.Open();
                        upd1.Parameters.AddWithValue("@a1", txtsifre.Text);
                        upd1.Parameters.AddWithValue("@a2", txtkullaniciadi.Text);
                        upd1.Parameters.AddWithValue("@a3", txtmail.Text);

                        upd1.ExecuteNonQuery();

                        MessageBox.Show("yeni şifre başarıyla oluşturuldu");

                        conn1.Close();
                    }
                }
                conn.Close();

                if (kontrol == false)
                {
                    MessageBox.Show("Hatalı bilgiler girdiniz! ! !");
                }

            }

            else if (lbltur.Text == "SINAV SORUMLUSU")
            {
                conn.Open();
                SqlDataReader reader2 = sqlCommand2.ExecuteReader();

                while (reader2.Read())
                {

                    if (txtkullaniciadi.Text == reader2["sorumluKullaniciAd"].ToString() && txtmail.Text == reader2["sorumluEmail"].ToString())

                    {
                        kontrol = true;
                        SqlCommand upd2 = new SqlCommand("Update sorumluu set ogrenciSifre=@a1 where ogrenciKullaniciAd=@a2 and ogrenciEmail=@a3", conn1);
                        conn1.Open();
                        upd2.Parameters.AddWithValue("@a1", txtsifre.Text);
                        upd2.Parameters.AddWithValue("@a2", txtkullaniciadi.Text);
                        upd2.Parameters.AddWithValue("@a3", txtmail.Text);
                        upd2.ExecuteNonQuery();
                        MessageBox.Show("yeni şifre başarıyla oluşturuldu");
                        conn1.Close();

                    }
                }
                conn.Close();

                if (kontrol == false)
                {
                    MessageBox.Show("Hatalı bilgiler girdiniz! ! !");
                }
            }
        }
    }
}