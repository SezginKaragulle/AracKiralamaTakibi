<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="MusteriEkleGuncelle.aspx.cs" Inherits="Araç_Kiralama_Takibi.MusteriEkleGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
     <table align="center" cellpadding="2" class="auto-style1">
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>
                &nbsp;<asp:Label ID="Label1" runat="server" Text="Müşteri Adı:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCustomerTitle" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;<asp:Label ID="Label2" runat="server" Text="İl:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCustomerProvince" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="İlçe:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCustomerDistrict" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Adres:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCustomerAddress" runat="server" Width="163px" CssClass="css-input" Height="47px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Vergi Dairesi:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCustomerTaxAdministration" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Vergi No:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCustomerTaxNumber" runat="server" Width="162px" CssClass="css-input" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Telefon No:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCustomerTelephone" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="E-Mail:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCustomerEMail" runat="server" Width="162px" CssClass="css-input" TextMode="Email"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnCustomerAdded" runat="server" Text="Ekle" Width = "125px" CssClass="myButton" OnClick="btnCustomerAdded_Click"/>
            </td>
            <td>
                <asp:Button ID="btnCustomerExit" runat="server" Text="Çıkış" Width = "125px" CssClass="myButton" OnClick="btnCustomerExit_Click"/>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
