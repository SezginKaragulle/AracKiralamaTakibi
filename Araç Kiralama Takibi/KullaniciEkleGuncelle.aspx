<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="KullaniciEkleGuncelle.aspx.cs" Inherits="Araç_Kiralama_Takibi.KullaniciEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!– DİL AYARLARI –>
<meta http-equiv=”Content-Language” content=”tr” />
<!–dilin türkçe old. belirten tag–>
<meta http-equiv=”Content-Type” content=”text/html; charset=UTF-8″ />
<!–charset=UTF-8 türkçe karakterlerin bulunduğu set–>
    <link href="Css/BtnStyle.css" rel="stylesheet" />
    <link href="Css/GrdStyle.css" rel="stylesheet" />
    <link href="Css/textStyle.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 500px;
        }
        .auto-style2 {
            height: 20px;
        }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" /> 

    <table align="center" cellpadding="2" class="auto-style1">
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>
                &nbsp;<asp:Label ID="Label1" runat="server" Text="Kullanıcı Kodu:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUserCode" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;<asp:Label ID="Label2" runat="server" Text="Şifre:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUserPassword" runat="server" Width="162px" TextMode="Password" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Ad / Soyad:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUserNameSurname" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Departman:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUserDepartment" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Telefon:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUserTelephone" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="E-Mail:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUserMail" runat="server" Width="162px" CssClass="css-input" TextMode="Email"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnUserAdded" runat="server" Text="Ekle" Width = "125px" CssClass="myButton" OnClick="btnUserAdded_Click"/>
            </td>
            <td>
                <asp:Button ID="btnUserExit" runat="server" Text="Çıkış" Width = "125px" CssClass="myButton" OnClick="btnUserExit_Click"/>
            </td>
        </tr>
    </table>

    

</asp:Content>
