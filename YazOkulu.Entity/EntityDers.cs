using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazOkulu.Entity
{
   public class EntityDers
    {
        private int dersId;
        private string dersAd;
        private int dersMinKontenjan;
        private int dersMaxKontenjan;

        public int DersId
        {
            get
            {
                return dersId;
            }

            set
            {
                dersId = value;
            }
        }
        public string DersAd
        {
            get
            {
                return dersAd;
            }

            set
            {
                dersAd = value;
            }
        }

        public int DersMinKontenjan
        {
            get
            {
                return dersMinKontenjan;
            }

            set
            {
                dersMinKontenjan = value;
            }
        }

        public int DersMaxKontenjan
        {
            get
            {
                return dersMaxKontenjan;
            }

            set
            {
                dersMaxKontenjan = value;
            }
        }

        
    }
}
