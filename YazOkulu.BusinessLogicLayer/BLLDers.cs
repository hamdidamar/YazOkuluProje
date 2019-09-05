using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazOkulu.DataAccessLayer;
using YazOkulu.Entity;

namespace YazOkulu.BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> DersListesi()
        {
            return DALDers.DersListesi();
        }
        public static int DersTalepEkle(EntityBasvuru basvuru)
        {
            if (basvuru.BasvuruOgrenciId >= 0 && basvuru.BasvuruDersId >= 0)
            {
                return DALDers.DersTalepEkle(basvuru);
            }
            else
            {
                return -1;
            }
        }
    }
}
