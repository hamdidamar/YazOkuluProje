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
            Console.WriteLine(ogrenci.OgrenciAd);
            cmd.Parameters.AddWithValue("@p1", ogrenci.OgrenciAd);
            cmd.Parameters.AddWithValue("@p2", ogrenci.OgrenciSoyad);
            cmd.Parameters.AddWithValue("@p3", ogrenci.OgrenciNumara);
            cmd.Parameters.AddWithValue("@p4", ogrenci.OgrenciMail);
            cmd.Parameters.AddWithValue("@p5", ogrenci.OgrenciSifre);
            cmd.Parameters.AddWithValue("@p6", ogrenci.OgrenciFotograf);
            cmd.Parameters.AddWithValue("@p7", ogrenci.OgrenciBakiye);
            return cmd.ExecuteNonQuery();
        }
    }
}
