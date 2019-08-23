<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="AracYonetimi.aspx.cs" Inherits="Araç_Kiralama_Takibi.AracYonetimi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/BtnStyle.css" rel="stylesheet" />
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
                <asp:Button ID="btnVehicleAdd" runat="server" Text="Ekle" Width = "125px" CssClass="myButton"  />
            </td>
              <td>
                
            </td>
            <td>
                <asp:Button ID="btnVehicleUpdate" runat="server" Text="Güncelle" Width = "125px" CssClass="myButton" />
            </td>
               <td>
                
            </td>
            <td>
                <asp:Button ID="btnVehicleDelete" runat="server" Text="Sil" Width = "125px" CssClass="myButton" />
            </td>
               <td>
                
            </td>
            <td>
               <asp:Button ID="btnVehicleSearch" runat="server" Text="Ara" Width = "125px" CssClass="myButton" /></td>
               <td>
                
            </td>
              
               <td>
                   <asp:TextBox ID="txtVehicleId" placeholder="Araç Kodu" runat="server" class="css-input"></asp:TextBox> 
            </td>
               <td>
                
            </td>
             
               <td>
                   <asp:TextBox ID="txtVehiclePlate" placeholder="Araç Plakası" runat="server" class="css-input"></asp:TextBox>
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
                <asp:GridView ID="grdVehicleList" runat="server" AllowPaging="True"  CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" SelectedRowStyle-CssClass="selectedrow"  Width="1000px"  AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="grdVehicleList_SelectedIndexChanged" OnPageIndexChanging="grdVehicleList_PageIndexChanging">
                    <Columns>
                        <asp:ButtonField CommandName="Select" Text="Seç" ButtonType="Button" ControlStyle-CssClass="myButton">
<ControlStyle CssClass="myButton"></ControlStyle>

                        <ItemStyle BackColor="White" />
                        </asp:ButtonField>
                        <asp:BoundField DataField="VehicleCode" HeaderText="Araç Kodu" />
                        <asp:BoundField DataField="VehiclePlate" HeaderText="Araç Plakası" />
                        <asp:BoundField DataField="VehicleTradeMark" HeaderText="Araç Markası" />
                        <asp:BoundField DataField="VehicleModel" HeaderText="Araç Modeli" />
                        <asp:BoundField DataField="VehicleType" HeaderText="Araç Tipi" />
                        <asp:BoundField DataField="VehicleYear" HeaderText="Araç Yılı" />
                        <asp:BoundField DataField="VehicleColor" HeaderText="Araç Rengi" />
                        <asp:BoundField DataField="VehicleGear" HeaderText="Araç Vites" />
                        <asp:BoundField DataField="VehicleEnginePower" HeaderText="Araç Motor Gücü" />
                        <asp:BoundField DataField="VehicleEngineVolume" HeaderText="Araç Motor Hacmi" />
                        <asp:BoundField DataField="VehicleFuelType" HeaderText="Araç Yakıt Tipi" />
                        <asp:BoundField DataField="VehicleLicenseNo" HeaderText="Araç Ruhsat Numarası" />
                        <asp:BoundField DataField="VehicleStatus" HeaderText="Araç Durumu" />
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
