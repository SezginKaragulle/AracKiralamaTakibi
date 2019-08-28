<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="GelirGiderYonetimi.aspx.cs" Inherits="Araç_Kiralama_Takibi.GelirGiderYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                <asp:Button ID="btnRevenuesExpensesAdd" runat="server" Text="Ekle" Width = "125px" CssClass="myButton" OnClick="btnRevenuesExpensesAdd_Click" />
            </td>
              <td>
                
            </td>
            <td>
                <asp:Button ID="btnRevenuesExpensesUpdate" runat="server" Text="Güncelle" Width = "125px" CssClass="myButton" OnClick="btnRevenuesExpensesUpdate_Click"/>
            </td>
               <td>
                
            </td>
            <td>
                <asp:Button ID="btnRevenuesExpensesDel" runat="server" Text="Sil" Width = "125px" CssClass="myButton" OnClick="btnRevenuesExpensesDel_Click"/>
            </td>
               <td>
                
            </td>
            <td>
               <asp:Button ID="btnRevenuesExpensesSearch" runat="server" Text="Ara" Width = "125px" CssClass="myButton"/></td>
               <td>
                
            </td>
              
               <td>
                   <asp:TextBox ID="txtVoucherNumber" placeholder="Kullanıcı Kodu" runat="server" class="css-input"></asp:TextBox> 
            </td>
               <td>
                
            </td>
             
               <td>
                   <asp:TextBox ID="txtVoucherExplanation" placeholder="Ad-Soyad" runat="server" class="css-input"></asp:TextBox>
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
                <asp:GridView ID="grdRevenuesExpensesList" runat="server" AllowPaging="True" PageSize="10" OnPageIndexChanging="grdRevenuesExpensesList_PageIndexChanging" CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" SelectedRowStyle-CssClass="selectedrow" OnSelectedIndexChanged="grdRevenuesExpensesList_SelectedIndexChanged" Width="1000px" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                    <Columns>
                        <asp:ButtonField CommandName="Select" Text="Seç" ButtonType="Button" ControlStyle-CssClass="myButton">
<ControlStyle CssClass="myButton"></ControlStyle>

                        <ItemStyle BackColor="White" />
                        </asp:ButtonField>
                        <asp:BoundField DataField="VoucherNumber" HeaderText="Fiş Numarası" />
                        <asp:BoundField DataField="VoucherDate" HeaderText="Fiş Tarihi" />
                        <asp:BoundField DataField="VoucherExplanation" HeaderText="Fiş Açıklaması" />
                        <asp:BoundField DataField="VoucherAmount" HeaderText="Fiş Tutarı" />
                        <asp:BoundField DataField="VoucherCurrency" HeaderText="Fiş Dövizi" />
                        <asp:BoundField DataField="VoucherCreditDebt" HeaderText="Alacak/Borç" />
                        <asp:BoundField DataField="VoucherPositionCode" HeaderText="Uygulama Kodu" />
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
<HeaderStyle CssClass="header" BackColor="#333333" Font-Bold="True" ForeColor="White"></HeaderStyle>

<PagerStyle CssClass="pager" BackColor="White" ForeColor="Black" HorizontalAlign="Right"></PagerStyle>

<SelectedRowStyle CssClass="selectedrow" BackColor="#ff6e00" Font-Bold="True" ForeColor="White"></SelectedRowStyle>
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
