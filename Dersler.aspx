<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Dersler.aspx.cs" Inherits="Dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form runat ="server">

    <div>
        <asp:Label ID="LblDersSecim" runat="server" Text="Ders Seçim"></asp:Label>
        <asp:DropDownList ID="DersListe" runat="server" CssClass="form-control"></asp:DropDownList>
    </div>
        <br />
    <div>
        <asp:Label ID="LblOgrenciId" runat="server" Text="Öğrenci ID"></asp:Label>
        <asp:TextBox ID="TxtOgrenciId" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
        <br />
        <asp:Button ID="BtnDersTalepOlustur" runat="server" Text="Ders Talep Oluştur" CssClass="btn btn-warning" OnClick="BtnDersTalepOlustur_Click" />
    </form>

</asp:Content>

