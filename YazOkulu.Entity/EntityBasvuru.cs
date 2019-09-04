using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazOkulu.Entity
{
    public class EntityBasvuru
    {
        private int basvuruId;
        private int basvuruOgrenciId;
        private int basvuruDersId;

        public int BasvuruId
        {
            get
            {
                return basvuruId;
            }

            set
            {
                basvuruId = value;
            }
        }

        public int BasvuruOgrenciId
        {
            get
            {
                return basvuruOgrenciId;
            }

            set
            {
                basvuruOgrenciId = value;
            }
        }

        public int BasvuruDersId
        {
            get
            {
                return basvuruDersId;
            }

            set
            {
                basvuruDersId = value;
            }
        }
    }
}
