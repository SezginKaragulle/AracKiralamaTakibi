<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="GelirGiderEkleGuncelle.aspx.cs" Inherits="Araç_Kiralama_Takibi.GelirGiderEkleGuncelle" %>
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
        .auto-style3 {
            height: 13px;
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
                &nbsp;<asp:Label ID="Label1" runat="server" Text="Fiş Numarası:" Enabled="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtVoucherNumber" runat="server" Width="162px" CssClass="css-input" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;<asp:Label ID="Label2" runat="server" Text="Fiş Tarihi:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtVoucherDate" runat="server" Width="162px" TextMode="Date" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Fiş Açıklaması:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtVoucherExplanation" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Fiş Tutarı:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtVoucherAmount" runat="server" Width="162px" CssClass="css-input" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label5" runat="server" Text="Fiş Dövizi"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="drpVoucherCurrency" runat="server" Width="162px" CssClass="css-input">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>TL</asp:ListItem>
                    <asp:ListItem>USD</asp:ListItem>
                    <asp:ListItem>EUR</asp:ListItem>
                    <asp:ListItem>GBP</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Alacak/Borç:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drpVoucherCreditDebt" runat="server" Width="162px" CssClass="css-input">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Alacak</asp:ListItem>
                    <asp:ListItem>Borç</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnRevenuesExpensesAdded" runat="server" Text="Ekle" Width = "125px" CssClass="myButton" OnClick="btnRevenuesExpensesAdded_Click"/>
            </td>
            <td>
                <asp:Button ID="btnRevenuesExpensesExit" runat="server" Text="Çıkış" Width = "125px" CssClass="myButton" OnClick="btnRevenuesExpensesExit_Click"/>
            </td>
        </tr>
    </table>

</asp:Content>
