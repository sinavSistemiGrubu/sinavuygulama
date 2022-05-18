using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace YazilimYapimiProjee
{

    public class ListeyeEkle
    {
        SqlConnection con;
        SqlCommand cmd;

        public ListeyeEkle() //Kurucu metotta bağlantı yolumuzu belirledik.
        {
            con = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS; Initial Catalog=kullanicilarr; Integrated Security=TRUE");
           
        }
        public void Listekle(int id)
        {
       List<int> sinavListe = new List<int>();
            string sql = "SELECT * FROM tblSinav where SinavID=@p1 ";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sinavListe.Add(Convert.ToInt32(dr["SoruId"].ToString()));
            }
            

            con.Close();
            
            
        }
        

    }
}
