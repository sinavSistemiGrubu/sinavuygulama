using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace YazilimYapimiProjee
{
    public partial class frmGirisYap : Form
    {
        public static SqlConnection connection = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS; Initial Catalog=kullanicilarr; Integrated Security=TRUE");
        public frmGirisYap()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            bool kontrol = false;
            if (radioButtonAdminGiris.Checked)
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from admin", connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    if(txtKullaniciAdi.Text == reader["adminKullaniciAd"].ToString().TrimEnd() && txtSifre.Text == reader["adminSifre"].ToString().TrimEnd())
                    {
                        kontrol = true;
                        if (kontrol)
                        {
                            MessageBox.Show("Giriş Başarılı 😉");
                            frmadmin frm = new frmadmin();
                            frm.Show();
                            this.Hide();
                        }
                    }
                    break;
                }
                connection.Close();
                if (kontrol == false)
                {
                    MessageBox.Show("Hatalı Giriş ! ! !");
                }
            }

            else if (radioButtonOgrenciGiris.Checked)
            {
                connection.Open();
                SqlCommand sqlCommand1 = new SqlCommand("Select * from ogrenci", connection);
                SqlDataReader reader1 = sqlCommand1.ExecuteReader();

                while (reader1.Read())
                {
                    if (txtKullaniciAdi.Text == reader1["ogrenciKullaniciAd"].ToString().TrimEnd() && txtSifre.Text == reader1["ogrenciSifre"].ToString().TrimEnd())
                    {
                        kontrol = true;
                        if (kontrol)
                        {
                            MessageBox.Show("Giriş Başarılı 😃");
                            frmOgrenciPanel frm = new frmOgrenciPanel();
                            frm.ogrID = Convert.ToInt32(reader1["ogrenciId"].ToString());
                            frm.Show();
                            this.Hide();
                        }
                        break;
                    }

                }

                connection.Close();
                if (kontrol == false)
                {
                    MessageBox.Show("Hatalı Giriş ! ! !");
                }
            }

            else if (radioButtonOgretmenGiris.Checked)
            {
                connection.Open();
                SqlCommand sqlCommand2 = new SqlCommand("Select * from sorumluu", connection);
                SqlDataReader reader2 = sqlCommand2.ExecuteReader();

                while (reader2.Read())
                {
                    if (txtKullaniciAdi.Text == reader2["sorumluKullaniciAd"].ToString().TrimEnd() && txtSifre.Text == reader2["sorumluSifre"].ToString().TrimEnd())
                    {
                        kontrol = true;
                        if (kontrol)
                        {
                            MessageBox.Show("Giriş Başarılı 😃");
                            frmsinavsorumlusu frmsorumlu = new frmsinavsorumlusu();
                            frmsorumlu.Show();
                            this.Hide();
                        }
                        break;
                    }
                }
                connection.Close();
                if (kontrol == false)
                {
                    MessageBox.Show("Hatalı Giriş ! ! !");
                }
            }

            else
            {
                MessageBox.Show("Hatalı Giriş ! ! ! 😴");
            }
        }

        private void linkLabelKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayitOl frmKayit = new frmKayitOl();
            frmKayit.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmsifreunut frm = new frmsifreunut();
            if (radioButtonAdminGiris.Checked|| radioButtonOgrenciGiris.Checked||radioButtonOgretmenGiris.Checked)
            {
                if (radioButtonAdminGiris.Checked)
                {
                    frm.tur = radioButtonAdminGiris.Text;
                }
                else if (radioButtonOgrenciGiris.Checked)
                {
                    frm.tur = radioButtonOgrenciGiris.Text;
                }
                else if (radioButtonOgretmenGiris.Checked)
                {
                    frm.tur = radioButtonOgretmenGiris.Text;
                }
                frm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("giriş türünü seç");
            }
          
      
        }


      

        
    }
}