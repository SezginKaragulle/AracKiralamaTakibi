<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="MusteriYonetimi.aspx.cs" Inherits="Araç_Kiralama_Takibi.MusteriYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/BtnStyle.css" rel="stylesheet" />
    <link href="Css/GrdStyle.css" rel="stylesheet" />
    <link href="Css/textStyle.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 500px;
            
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
          <tr>
            <td>
                <asp:Button ID="btnCustomerAdd" runat="server" Text="Ekle" Width = "125px" CssClass="myButton" OnClick="btnCustomerAdd_Click" />
            </td>
              <td>
                
            </td>
            <td>
                <asp:Button ID="btnCustomerUpdate" runat="server" Text="Güncelle" Width = "125px" CssClass="myButton" OnClick="btnCustomerUpdate_Click" style="height: 42px"/>
            </td>
               <td>
                
            </td>
            <td>
                <asp:Button ID="btnCustomerDelete" runat="server" Text="Sil" Width = "125px" CssClass="myButton" OnClick="btnCustomerDelete_Click" />
            </td>
               <td>
                
            </td>
            <td>
               <asp:Button ID="btnCustomerSearch" runat="server" Text="Ara" Width = "125px" CssClass="myButton" OnClick="btnCustomerSearch_Click" /></td>
               <td>
                
            </td>
              
               <td>
                   <asp:TextBox ID="txtCustomerId" placeholder="Müşteri Kodu" runat="server" class="css-input"></asp:TextBox> 
            </td>
               <td>
                
            </td>
             
               <td>
                   <asp:TextBox ID="txtCustomerName" placeholder="Müşteri Adı" runat="server" class="css-input"></asp:TextBox>
            </td>

                <td>
                
            </td>
             
               <td>
                   <asp:TextBox ID="txtCustomerTaxNumber" placeholder="Müşteri Vergi No" runat="server" class="css-input"></asp:TextBox>
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
                <asp:GridView ID="grdCustomerList" runat="server" AllowPaging="True"  CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" SelectedRowStyle-CssClass="selectedrow"  Width="1000px" OnSelectedIndexChanged="grdCustomerList_SelectedIndexChanged1" OnPageIndexChanging="grdCustomerList_PageIndexChanging">
                    <Columns>
                        <asp:ButtonField CommandName="Select" Text="Seç" ButtonType="Button" ControlStyle-CssClass="myButton">
<ControlStyle CssClass="myButton"></ControlStyle>

                        <ItemStyle BackColor="White" />
                        </asp:ButtonField>
                    </Columns>
<HeaderStyle CssClass="header"></HeaderStyle>

<PagerStyle CssClass="pager"></PagerStyle>

<SelectedRowStyle CssClass="selectedrow"></SelectedRowStyle>
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
