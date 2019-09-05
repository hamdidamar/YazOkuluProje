using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YazOkulu.BusinessLogicLayer;
using YazOkulu.DataAccessLayer;
using YazOkulu.Entity;

public partial class Dersler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            List<EntityDers> ders = BLLDers.DersListesi();
            DersListe.DataSource = BLLDers.DersListesi();
            DersListe.DataTextField = "DersAd";
            DersListe.DataValueField = "DersID";
            DersListe.DataBind();
        }
       
    }

    protected void BtnDersTalepOlustur_Click(object sender, EventArgs e)
    {
        
        EntityBasvuru basvuru = new EntityBasvuru();
        basvuru.BasvuruOgrenciId = int.Parse(TxtOgrenciId.Text);
        basvuru.BasvuruDersId = int.Parse(DersListe.SelectedValue.ToString());
        BLLDers.DersTalepEkle(basvuru);
    }
}