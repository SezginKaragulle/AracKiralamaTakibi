<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="AracEkleGuncelle.aspx.cs" Inherits="Araç_Kiralama_Takibi.AracEkleGuncelle" %>
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
                &nbsp;<asp:Label ID="Label1" runat="server" Text="Plaka:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtVehiclePlate" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;<asp:Label ID="Label2" runat="server" Text="Marka:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtVehicleTrademark" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Model:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtVehicleModel" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Tipi:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtVehicleType" runat="server" Width="163px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Yıl:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtVehicleYear" runat="server" Width="162px" CssClass="css-input" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Renk:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtVehicleColor" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Vites:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drpVehicleGear" runat="server" Width="162px" CssClass="css-input">
                    <asp:ListItem>Manuel</asp:ListItem>
                    <asp:ListItem>Otomatik</asp:ListItem>
                    <asp:ListItem>Yarı Otomatik</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Motor Gücü:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtVehicleEnginePower" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Motor Hacmi:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtVehicleEngineVolume" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Yakıt Tipi:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drpVehicleFuelType" runat="server" Width="162px" CssClass="css-input">
                    <asp:ListItem>Benzinli</asp:ListItem>
                    <asp:ListItem>Dizel</asp:ListItem>
                    <asp:ListItem>Elektrikli</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Ruhsat No:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtVehicleLicenseNo" runat="server" Width="162px" CssClass="css-input" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Durumu:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drpVehicleStatus" runat="server" Width="162px" CssClass="css-input">
                    <asp:ListItem>Uygun</asp:ListItem>
                    <asp:ListItem>Kiralandı</asp:ListItem>
                    <asp:ListItem>Satıldı</asp:ListItem>
                    <asp:ListItem>Bakımda</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnVehicleAdded" runat="server" Text="Ekle" Width = "125px" CssClass="myButton" OnClick="btnVehicleAdded_Click"/>
            </td>
            <td>
                <asp:Button ID="btnVehicleExit" runat="server" Text="Çıkış" Width = "125px" CssClass="myButton" OnClick="btnVehicleExit_Click"/>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
