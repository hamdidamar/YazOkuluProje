using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YazOkulu.BusinessLogicLayer;
using YazOkulu.DataAccessLayer;
using YazOkulu.Entity;

public partial class OgrenciSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int OgrenciID = Convert.ToInt32(Request.QueryString["OgrenciID"]);
        Response.Write(OgrenciID);
        EntityOgrenci ogrenci = new EntityOgrenci();
        ogrenci.OgrenciId = OgrenciID;
        BLLOgrenci.OgrenciSil(ogrenci.OgrenciId);
        Response.Redirect("OgrenciListe.aspx");
    }
}