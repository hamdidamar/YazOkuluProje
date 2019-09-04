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
        
        entityogrenci.OgrenciAd = "Hasan";
        entityogrenci.OgrenciSoyad = "Kulmaz";
        entityogrenci.OgrenciNumara = "968574123";
        entityogrenci.OgrenciMail = "hasan.kulmaz@hotmail.com";
        entityogrenci.OgrenciSifre = "456987";
        entityogrenci.OgrenciFotograf = "FotoYol";
        entityogrenci.OgrenciBakiye = 150;
        BLLOgrenci.OgrenciEkle(entityogrenci);

    }
}