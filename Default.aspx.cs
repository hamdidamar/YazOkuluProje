using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YazOkulu.BusinessLogicLayer;
using YazOkulu.DataAccessLayer;
using YazOkulu.Entity;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    EntityOgrenci entityogrenci = new EntityOgrenci();
    protected void Btn_OgrenciEkle_Click(object sender, EventArgs e)
    {

        entityogrenci.OgrenciAd = TxtOgrenciAd.Text;
        entityogrenci.OgrenciSoyad = TxtOgrenciSoyad.Text;
        entityogrenci.OgrenciNumara = TxtOgrenciNumara.Text;
        entityogrenci.OgrenciMail = TxtOgrenciMail.Text;
        entityogrenci.OgrenciSifre = TxtOgrenciSifre.Text;
        entityogrenci.OgrenciFotograf = TxtOgrenciFotograf.Text;
        entityogrenci.OgrenciBakiye = double.Parse(TxtOgrenciBakiye.Text);
        BLLOgrenci.OgrenciEkle(entityogrenci);

    }
}
