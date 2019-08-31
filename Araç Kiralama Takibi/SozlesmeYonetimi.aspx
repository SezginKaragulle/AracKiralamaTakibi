<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="SozlesmeYonetimi.aspx.cs" Inherits="Araç_Kiralama_Takibi.SozlesmeYonetimi" %>
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
                <asp:Button ID="btnContractAdd" runat="server" Text="Ekle" Width = "125px" CssClass="myButton" OnClick="btnContractAdd_Click" />
            </td>
              <td>
                
            </td>
            <td>
                <asp:Button ID="btnContractUpdate" runat="server" Text="Güncelle" Width = "125px" CssClass="myButton"/>
            </td>
               <td>
                
            </td>
            <td>
                <asp:Button ID="btnContractDel" runat="server" Text="Sil" Width = "125px" CssClass="myButton"/>
            </td>
               <td>
                
            </td>
            <td>
               <asp:Button ID="btnContractSearch" runat="server" Text="Ara" Width = "125px" CssClass="myButton"/></td>
               <td>
                
            </td>
               <td>
                <asp:Button ID="btnVoucherSend" runat="server" Text="Mahsup" Width = "125px" CssClass="myButton"/></td>
            </td>
               <td>
                
            </td>
               <td>
                   <asp:TextBox ID="txtContractCode" placeholder="Sözleşme Kodu" runat="server" class="css-input"></asp:TextBox> 
            </td>
               <td>
                
            </td>
             
               <td>
                   <asp:TextBox ID="txtContractNo" placeholder="Sözleşme Numarası" runat="server" class="css-input"></asp:TextBox>
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
                <asp:GridView ID="grdContractsList" runat="server" AllowPaging="True" PageSize="10" CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" SelectedRowStyle-CssClass="selectedrow" Width="1000px" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="grdContractsList_SelectedIndexChanged">
                    <Columns>
                        <asp:ButtonField CommandName="Select" Text="Seç" ButtonType="Button" ControlStyle-CssClass="myButton">
<ControlStyle CssClass="myButton"></ControlStyle>

                        <ItemStyle BackColor="White" />
                        </asp:ButtonField>
                        <asp:BoundField DataField="ContractID" HeaderText="Sözleşme ID" />
                        <asp:BoundField DataField="ContractNo" HeaderText="Sözleşme No" />
                        <asp:BoundField DataField="ContractStart" HeaderText="Sözleşme Başlangıç" />
                        <asp:BoundField DataField="ContractFinish" HeaderText="Sözleşme Bitiş" />
                        <asp:BoundField DataField="HandingDate" HeaderText="Teslim" />
                        <asp:BoundField DataField="VehiclePlate" HeaderText="Araç Plakası" />
                        <asp:BoundField DataField="CustomerCode" HeaderText="Müşteri Kodu" />
                        <asp:BoundField DataField="CustomerTitle" HeaderText="Müşteri Adı" />
                        <asp:BoundField DataField="CustomerAuthorized" HeaderText="Müşteri Yetkili" />
                        <asp:BoundField DataField="TelephoneNo" HeaderText="Telefon No" />
                        <asp:BoundField DataField="EMail" HeaderText="E-Mail" />
                        <asp:BoundField DataField="CustomerRepresentative" HeaderText="Müşteri Temsilcisi" />
                        <asp:BoundField DataField="AccountingStatus" HeaderText="Muhasebe Durumu" />
                        <asp:BoundField DataField="VoucherNo" HeaderText="Fiş No" />
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
