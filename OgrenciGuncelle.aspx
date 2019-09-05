<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciGuncelle.aspx.cs" Inherits="OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form id ="Form1" runat ="server">
        <div class ="form-group">
           
             <div>
                <asp:Label for="TxtOgrenciId" runat="server" Text="Öğrenci ID" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtOgrenciId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtOgrenciAd" runat="server" Text="Öğrenci Adı" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtOgrenciAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtOgrenciSoyad" runat="server" Text="Öğrenci Soyadı" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtOgrenciSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtOgrenciNumara" runat="server" Text="Öğrenci Numara" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtOgrenciNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtOgrenciMail" runat="server" Text="Öğrenci Mail Adresi" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtOgrenciMail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtOgrenciSifre" runat="server" Text="Öğrenci Şifre" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtOgrenciSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtOgrenciFotograf" runat="server" Text="Öğrenci Fotoğraf Yolu" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtOgrenciFotograf" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtOgrenciBakiye" runat="server" Text="Öğrenci Bakiye" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtOgrenciBakiye" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
        </div>
        <asp:Button ID ="Btn_OgrenciGuncelle"  runat="server" text="Öğrenci Güncelle"  CssClass ="btn btn-warning" OnClick="Btn_OgrenciGuncelle_Click" />
    </form>
</asp:Content>
