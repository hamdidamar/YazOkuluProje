using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YazOkulu.BusinessLogicLayer;
using YazOkulu.DataAccessLayer;
using YazOkulu.Entity;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int OgrenciId = Convert.ToInt32(Request.QueryString["OgrenciID"].ToString());
        TxtOgrenciId.Text = OgrenciId.ToString();
        TxtOgrenciId.Enabled = false;

        if (Page.IsPostBack == false)
        {
            List<EntityOgrenci> ogrencidetay = BLLOgrenci.OgrenciDetay(OgrenciId);

            TxtOgrenciAd.Text = ogrencidetay[0].OgrenciAd.ToString();
            TxtOgrenciSoyad.Text = ogrencidetay[0].OgrenciSoyad.ToString();
            TxtOgrenciNumara.Text = ogrencidetay[0].OgrenciNumara.ToString();
            TxtOgrenciMail.Text = ogrencidetay[0].OgrenciMail.ToString();
            TxtOgrenciSifre.Text = ogrencidetay[0].OgrenciSifre.ToString();
            TxtOgrenciFotograf.Text = ogrencidetay[0].OgrenciFotograf.ToString();
            TxtOgrenciBakiye.Text = ogrencidetay[0].OgrenciBakiye.ToString();
        }
    }

    protected void Btn_OgrenciGuncelle_Click(object sender, EventArgs e)
    {
        EntityOgrenci ogrenci = new EntityOgrenci();
        ogrenci.OgrenciAd = TxtOgrenciAd.Text;
        ogrenci.OgrenciSoyad = TxtOgrenciSoyad.Text;
        ogrenci.OgrenciNumara = TxtOgrenciNumara.Text;
        ogrenci.OgrenciMail = TxtOgrenciMail.Text;
        ogrenci.OgrenciSifre = TxtOgrenciSifre.Text;
        ogrenci.OgrenciFotograf = TxtOgrenciFotograf.Text;
        ogrenci.OgrenciBakiye = double.Parse(TxtOgrenciBakiye.Text);
        ogrenci.OgrenciId = int.Parse(TxtOgrenciId.Text);

        BLLOgrenci.OgrenciGuncelle(ogrenci);
        Response.Redirect("OgrenciListe.aspx");
    }
}