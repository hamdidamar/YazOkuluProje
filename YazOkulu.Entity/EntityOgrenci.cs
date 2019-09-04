using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazOkulu.Entity
{
    public class EntityOgrenci
    {
        private int ogrenciId;
        private string ogrenciAd;
        private string ogrenciSoyad;
        private string ogrenciNumara;
        private string ogrenciMail;
        private string ogrenciSifre;
        private string ogrenciFotograf;
        private double ogrenciBakiye;

        public int OgrenciId
        {
            get
            {
                return ogrenciId;
            }

            set
            {
                ogrenciId = value;
            }
        }

        public string OgrenciAd
        {
            get
            {
                return ogrenciAd;
            }

            set
            {
                ogrenciAd = value;
            }
        }

        public string OgrenciSoyad
        {
            get
            {
                return ogrenciSoyad;
            }

            set
            {
                ogrenciSoyad = value;
            }
        }

        public string OgrenciNumara
        {
            get
            {
                return ogrenciNumara;
            }

            set
            {
                ogrenciNumara = value;
            }
        }
        public string OgrenciMail
        {
            get
            {
                return ogrenciMail;
            }

            set
            {
                ogrenciMail = value;
            }
        }

        public string OgrenciSifre
        {
            get
            {
                return ogrenciSifre;
            }

            set
            {
                ogrenciSifre = value;
            }
        }

        public string OgrenciFotograf
        {
            get
            {
                return ogrenciFotograf;
            }

            set
            {
                ogrenciFotograf = value;
            }
        }

        public double OgrenciBakiye
        {
            get
            {
                return ogrenciBakiye;
            }

            set
            {
                ogrenciBakiye = value;
            }
        }

        
    }
}
