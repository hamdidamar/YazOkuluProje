<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form id ="Form1" runat ="server">
        <asp:Button ID ="Btn_OgrenciEkle"  runat="server" text="Öğrenci Ekle" OnClick="Btn_OgrenciEkle_Click" />
    </form>
</asp:Content>

