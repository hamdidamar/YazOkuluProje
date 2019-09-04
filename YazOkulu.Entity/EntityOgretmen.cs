using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazOkulu.Entity
{
   public class EntityOgretmen
    {
        private int ogretmenId;
        private string ogretmenAdSoyad;
        private string ogretmenBrans;

        public int OgretmenId
        {
            get
            {
                return ogretmenId;
            }

            set
            {
                ogretmenId = value;
            }
        }

        public string OgretmenAdSoyad
        {
            get
            {
                return ogretmenAdSoyad;
            }

            set
            {
                ogretmenAdSoyad = value;
            }
        }

        public string OgretmenBrans
        {
            get
            {
                return ogretmenBrans;
            }

            set
            {
                ogretmenBrans = value;
            }
        }
    }
}
