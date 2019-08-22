<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="SistemYonetimi.aspx.cs" Inherits="Araç_Kiralama_Takibi.SistemYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!– DİL AYARLARI –>
<meta http-equiv=”Content-Language” content=”tr” />
<!–dilin türkçe old. belirten tag–>
<meta http-equiv=”Content-Type” content=”text/html; charset=UTF-8″ />
<!–charset=UTF-8 türkçe karakterlerin bulunduğu set–>
     <link href="Css/BtnStyle.css" rel="stylesheet" />
    <link href="Css/textStyle.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 1000px;
            
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
          <tr>
            <td>
                <asp:Button ID="btnUserAdd" runat="server" Text="Ekle" Width = "125px" CssClass="myButton" OnClick="btnUserAdd_Click" />
            </td>
              <td>
                
            </td>
            <td>
                <asp:Button ID="btnUserUpdate" runat="server" Text="Güncelle" Width = "125px" CssClass="myButton" OnClick="btnUserUpdate_Click"/>
            </td>
               <td>
                
            </td>
            <td>
                <asp:Button ID="btnUserDel" runat="server" Text="Sil" Width = "125px" CssClass="myButton" OnClick="btnUserDel_Click1"/>
            </td>
               <td>
                
            </td>
            <td>
               <asp:Button ID="btnUserSearch" runat="server" Text="Ara" Width = "125px" CssClass="myButton" OnClick="btnUserSearch_Click"/></td>
               <td>
                
            </td>
              
               <td>
                   <asp:TextBox ID="txtUserCode" placeholder="Kullanıcı Kodu" runat="server" class="css-input"></asp:TextBox> 
            </td>
               <td>
                
            </td>
             
               <td>
                   <asp:TextBox ID="txtUserNameSurName" placeholder="Ad-Soyad" runat="server" class="css-input"></asp:TextBox>
            </td>
        </tr>
    </table>
    <table  cellpadding="2" class="auto-style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="grdUsersList" runat="server" AllowPaging="True" OnPageIndexChanging="grdUsersList_PageIndexChanging" CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" SelectedRowStyle-CssClass="selectedrow" OnSelectedIndexChanged="grdUsersList_SelectedIndexChanged" Width="1000px" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                    <Columns>
                        <asp:ButtonField CommandName="Select" Text="Seç" ButtonType="Button" ControlStyle-CssClass="myButton">
<ControlStyle CssClass="myButton"></ControlStyle>

                        <ItemStyle BackColor="White" />
                        </asp:ButtonField>
                        <asp:BoundField DataField="UserId" HeaderText="Kullanıcı Numarası" />
                        <asp:BoundField DataField="UserCode" HeaderText="Kullanıcı Kodu" />
                        <asp:BoundField DataField="UserNameSurName" HeaderText="Adı Soyadı" />
                        <asp:BoundField DataField="UserDepartment" HeaderText="Departman" />
                        <asp:BoundField DataField="UserTelephone" HeaderText="Telefon Numarası" />
                        <asp:BoundField DataField="UserMail" HeaderText="E-Mail" />
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
<HeaderStyle CssClass="header" BackColor="#333333" Font-Bold="True" ForeColor="White"></HeaderStyle>

<PagerStyle CssClass="pager" BackColor="White" ForeColor="Black" HorizontalAlign="Right"></PagerStyle>

<SelectedRowStyle CssClass="selectedrow" BackColor="#CC3333" Font-Bold="True" ForeColor="White"></SelectedRowStyle>
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
