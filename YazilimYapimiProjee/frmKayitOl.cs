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
    public partial class frmKayitOl : Form
    {
        SqlConnection connnection = frmGirisYap.connection;
        public frmKayitOl()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            connnection.Open();
            
            if (radioButtonOgrenci.Checked && txtAd.Text.Length >= 3 && txtSoyad.Text!="" && txtKullaniciAd.Text!="" && txtEmail.Text.Length>=13 && txtSifre.Text!="")
            {
                SqlCommand cmd = new SqlCommand
                (
                "Insert into ogrenci " +
                "(ogrenciAd,ogrenciSoyad,ogrenciKullaniciAd,ogrenciEmail,ogrenciSifre) values " +
                "('" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtKullaniciAd.Text + "','" + txtEmail.Text + "','" + txtSifre.Text + "')"
                , connnection);

                cmd.ExecuteNonQuery();
                 DialogResult giris = MessageBox.Show("Kayıt Başarılı. Giriş yapmak ister misiniz ?");
                
                
                if (giris==DialogResult.OK)
                {
                    frmGirisYap frm = new frmGirisYap();
                    frm.Show();
                    this.Hide();
                }
                connnection.Close();
            }
            else if (radioButtonSinavSorumlusu.Checked && txtAd.Text.Length >= 3 && txtSoyad.Text != "" && txtKullaniciAd.Text != "" && txtEmail.Text.Length >= 13 && txtSifre.Text != "")
            {
                SqlCommand cmd = new SqlCommand
                (
                "Insert into sorumluu " +
                "(sorumluAd,sorumluSoyad,sorumluKullaniciAd,sorumluEmail,sorumluSifre) values " +
                "('" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtKullaniciAd.Text + "','" + txtEmail.Text + "','" + txtSifre.Text + "')"
                , connnection);

                cmd.ExecuteNonQuery();
               DialogResult giris = MessageBox.Show("Kayıt Başarılı. Giriş yapmak ister misiniz ?");
                
                
                if (giris==DialogResult.OK)
                {
                    frmGirisYap frm = new frmGirisYap();
                    frm.Show();
                    this.Hide();
                }
                connnection.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgiler Girdiniz");
                connnection.Close();
            }
        }

        
    }
}
