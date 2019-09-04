using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazOkulu.DataAccessLayer;
using YazOkulu.Entity;

namespace YazOkulu.BusinessLogicLayer
{
   public class BLLOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci ogrenci)
        {
            if (ogrenci.OgrenciAd != null && ogrenci.OgrenciSoyad != null && ogrenci.OgrenciNumara != null && ogrenci.OgrenciMail != null && ogrenci.OgrenciSifre != null && ogrenci.OgrenciFotograf != null && ogrenci.OgrenciBakiye != null)
            {
                return DALOgrenci.OgrenciEkle(ogrenci);
            }
            return -1;
        }
    }
}
