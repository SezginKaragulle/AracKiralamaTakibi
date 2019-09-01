<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="SozlesmeEkleGuncelle.aspx.cs" Inherits="Araç_Kiralama_Takibi.SozlesmeEkleGuncelle" ClassName="Classes.Customer_Operations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="Css/BtnStyle.css" rel="stylesheet" />
    <link href="Css/GrdStyle.css" rel="stylesheet" />
    <link href="Css/textStyle.css" rel="stylesheet" />
    <script type="text/javascript">
        function KeyPressed(e)
        {
            
            var code = (e.keyCode ? e.keyCode : e.which);
            if (code == 13) { //Enter keycode
             <%  
        Customer_Method(txtCustomerCode.Text);
         %>          
            }
        }
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 500px;
        }
        .auto-style2 {
            height: 20px;
        }
        .auto-style3 {
            height: 14px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <table align="center" cellpadding="2" class="auto-style1">
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;<asp:Label ID="Label1" runat="server" Text="Sözleşme No:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtContractNo" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Sözleşme Başlangıç:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtContractStart" runat="server" Width="162px" TextMode="Date" CssClass="css-input"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Sözleşme Bitiş:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtContractFinish" runat="server" Width="162px" CssClass="css-input" TextMode="Date"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Teslim:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtHanding" runat="server" Width="162px" CssClass="css-input" TextMode="Date"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Araç Plakası:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drpVehiclePlate" runat="server" Width="162px" CssClass="css-input" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td>
                <asp:CheckBox ID="chcVehicleUpdate" runat="server" Text="Güncelle" Visible="False" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Müşteri Kodu:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCustomerCode" runat="server" Width="162px" CssClass="css-input" onkeypress ="KeyPressed(event)" OnTextChanged="txtCustomerCode_TextChanged" AutoPostBack="True"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label7" runat="server" Text="Müşteri Adı:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtCustomerTitle" runat="server" Width="162px" CssClass="css-input" OnTextChanged="txtCustomerTitle_TextChanged"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label8" runat="server" Text="Müşteri Yetkilisi:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtCustomerAuthorized" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label9" runat="server" Text="Telefon No:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtTelephoneNo" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label10" runat="server" Text="E-Mail:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtEmail" runat="server" Width="162px" CssClass="css-input" TextMode="Email"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label11" runat="server" Text="Müşteri Temsilcisi:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtCustomerRepresentative" runat="server" Width="162px" CssClass="css-input"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label12" runat="server" Text="Tutar:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtContractAmount" runat="server" Width="162px" CssClass="css-input" TextMode="Number"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label13" runat="server" Text="Döviz:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="drpContractCurrency" runat="server" Width="162px" CssClass="css-input">
                    <asp:ListItem>TL</asp:ListItem>
                    <asp:ListItem>USD</asp:ListItem>
                    <asp:ListItem>EUR</asp:ListItem>
                    <asp:ListItem>GBP</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnContractAdded" runat="server" Text="Ekle" Width = "125px" CssClass="myButton" OnClick="btnContractAdded_Click"/>
            </td>
            <td>
                <asp:Button ID="btnContractExit" runat="server" Text="Çıkış" Width = "125px" CssClass="myButton" OnClick="btnContractExit_Click"/>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

    
</asp:Content>
