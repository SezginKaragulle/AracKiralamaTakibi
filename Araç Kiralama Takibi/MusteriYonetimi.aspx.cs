using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Araç_Kiralama_Takibi
{
    public partial class MusteriYonetimi : System.Web.UI.Page
    {
        Classes.Customer_Operations CustomerOperations = new Classes.Customer_Operations();
        private int Vr_Selected_Row;
        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerOperations.Customer_List(grdCustomerList);
           
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }


        protected void grdCustomerList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

      

        protected void grdCustomerList_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Vr_Selected_Row = grdCustomerList.SelectedIndex;
            GridViewRow row = grdCustomerList.Rows[Vr_Selected_Row];
            Session.Add("Vr_CustomerID", row.Cells[1].Text);
            Session.Add("Vr_CustomerTitle", row.Cells[2].Text);
            Session.Add("Vr_CustomerProvince", row.Cells[3].Text);
            Session.Add("Vr_CustomerDistrict", row.Cells[4].Text);
            Session.Add("Vr_CustomerAddress", row.Cells[5].Text);
            Session.Add("Vr_CustomerTaxAdministration", row.Cells[6].Text);
            Session.Add("Vr_CustomerTaxNumber", row.Cells[7].Text);
            Session.Add("Vr_CustomerTelephone", row.Cells[8].Text);
            Session.Add("Vr_CustomerEMail", row.Cells[9].Text);
        }

   

        protected void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            Session.Add("Vr_Data", "CustomerAdd");
            Response.Redirect("MusteriEkleGuncelle.aspx");
        }

        protected void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            Session.Add("Vr_Data", "CustomerUpdate");
            Response.Redirect("MusteriEkleGuncelle.aspx");
        }

        protected void btnCustomerDelete_Click(object sender, EventArgs e)
        {

            CustomerOperations.Customer_Delete(Session["Vr_CustomerID"].ToString(), this.Context);
            CustomerOperations.Customer_List(grdCustomerList);

        }

        protected void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            CustomerOperations.Customer_List_CustomerFilter(grdCustomerList, txtCustomerId.Text, txtCustomerName.Text, txtCustomerTaxNumber.Text);
            txtCustomerId.Text = "";
            txtCustomerName.Text = "";
            txtCustomerTaxNumber.Text = "";

        }
    }
}