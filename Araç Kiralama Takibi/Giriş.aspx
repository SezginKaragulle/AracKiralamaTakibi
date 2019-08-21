<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giriş.aspx.cs" Inherits="Araç_Kiralama_Takibi.Giriş" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Css/textStyle.css" rel="stylesheet" />
    <link href="Css/BtnStyle.css" rel="stylesheet" />
    <link href="Css/GrdStyle.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap-theme.min.css" integrity="sha384-6pzBo3FDv/PJ8r2KRkGHifhEocL+1X2rVCTTkUfGk7/0pbek5mMa1upzvWbrUbOZ" crossorigin="anonymous">
    <style type="text/css">
        .auto-style1 {
            width: 500px;
        }
        .auto-style2 {
            height: 33px;
        }
        .auto-style3 {
            height: 2px;
        }
    </style>
    
</head>
<body>
    <form id="FrmGiris" runat="server">
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <div>
            <table align="center" cellspacing="1" class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Kullanıcı Adı:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtKullaniciAdi" runat="server" Width="210px" class="css-input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Şifre:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSifre" runat="server" Width="210px" TextMode="Password" class="css-input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnGiris" runat="server" Text="Giriş" Class="myButton" Width="106px" OnClick="btnGiris_Click"  />
                        
                       </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
