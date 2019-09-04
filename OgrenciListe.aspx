<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciListe.aspx.cs" Inherits="OgrenciListe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci ID</th>
            <th>Öğrenci Ad</th>
            <th>Öğrenci Soyad</th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Mail</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Öğrenci Bakiye</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
            <tr>
                <td><%#Eval("OgrenciID")%></td>
                <td><%#Eval("OgrenciAd")%></td>
                <td><%#Eval("OgrenciSoyad")%></td>
                <td><%#Eval("OgrenciNumara")%></td>
                <td><%#Eval("OgrenciMail")%></td>
                <td><%#Eval("OgrenciSifre")%></td>
                <td><%#Eval("OgrenciFotograf")%></td>
                <td><%#Eval("OgrenciBakiye")%></td>
                <td>
                    <asp:HyperLink NavigateUrl=<%# "~/OgrenciSil.aspx?OgrenciID=" +Eval("OgrenciID") %> ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                    <asp:HyperLink NavigateUrl=<%# "~/OgrenciGuncelle.aspx?OgrenciID=" +Eval("OgrenciID") %> ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                </td>
            </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

