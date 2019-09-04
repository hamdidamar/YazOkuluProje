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
   public class DALOgrenci
    {
       
        public static int OgrenciEkle(EntityOgrenci ogrenci)
        {
            SqlCommand cmd = new SqlCommand("EXEC OgrenciEkle @p1 = @p1,@p2 = @p2,@p3 = @p3,@p4 = @p4,@p5 = @p5,@p6 = @p6,@p7 = @p7", DBHelper.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", ogrenci.OgrenciAd);
            cmd.Parameters.AddWithValue("@p2", ogrenci.OgrenciSoyad);
            cmd.Parameters.AddWithValue("@p3", ogrenci.OgrenciNumara);
            cmd.Parameters.AddWithValue("@p4", ogrenci.OgrenciMail);
            cmd.Parameters.AddWithValue("@p5", ogrenci.OgrenciSifre);
            cmd.Parameters.AddWithValue("@p6", ogrenci.OgrenciFotograf);
            cmd.Parameters.AddWithValue("@p7", ogrenci.OgrenciBakiye);
            return cmd.ExecuteNonQuery();
        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_OGRENCILER", DBHelper.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ogrenci = new EntityOgrenci();
                ogrenci.OgrenciId = Convert.ToInt32(dr["OgrenciID"].ToString());
                ogrenci.OgrenciAd = dr["OgrenciAd"].ToString();
                ogrenci.OgrenciSoyad = dr["OgrenciSoyad"].ToString();
                ogrenci.OgrenciNumara = dr["OgrenciNumara"].ToString();
                ogrenci.OgrenciMail = dr["OgrenciMail"].ToString();
                ogrenci.OgrenciSifre = dr["OgrenciSifre"].ToString();
                ogrenci.OgrenciFotograf = dr["OgrenciFotograf"].ToString();
                ogrenci.OgrenciBakiye = Convert.ToDouble(dr["OgrenciBakiye"].ToString());

                degerler.Add(ogrenci);
            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciSil(int OgrenciID)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM TBL_OGRENCILER WHERE OgrenciID = @p1", DBHelper.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", OgrenciID);
            return cmd.ExecuteNonQuery() > 0;

        }
    }
}
