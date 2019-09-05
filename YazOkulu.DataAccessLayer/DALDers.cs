using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using YazOkulu.Entity;

namespace YazOkulu.DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_DERSLER", DBHelper.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ders = new EntityDers();
                ders.DersId = Convert.ToInt32(dr["DersID"].ToString());
                ders.DersAd = dr["DersAd"].ToString();
                ders.DersMinKontenjan = int.Parse(dr["DersMinKontenjan"].ToString());
                ders.DersMaxKontenjan = int.Parse(dr["DersMaxKontenjan"].ToString());

                degerler.Add(ders);
            }
            dr.Close();
            return degerler;
        }

        public static int DersTalepEkle(EntityBasvuru basvuru)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_BASVURULAR(OgrenciID,DersID) VALUES (@p1,@p2)", DBHelper.bgl);
            cmd.Parameters.AddWithValue("@p1", basvuru.BasvuruOgrenciId);
            cmd.Parameters.AddWithValue("@p2", basvuru.BasvuruDersId);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            return cmd.ExecuteNonQuery();
        }
    }
}
