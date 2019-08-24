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
            if (!IsPostBack)
            {
                Session.Add("Vr_CustomerID", "");
                Session.Add("Vr_CustomerTitle", "");
                Session.Add("Vr_CustomerProvince", "");
                Session.Add("Vr_CustomerDistrict", "");
                Session.Add("Vr_CustomerAddress", "");
                Session.Add("Vr_CustomerTaxAdministration", "");
                Session.Add("Vr_CustomerTaxNumber", "");
                Session.Add("Vr_CustomerTelephone", "");
                Session.Add("Vr_CustomerEMail", "");
                CustomerOperations.Customer_List(grdCustomerList);
            }
            
           
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }


        protected void grdCustomerList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdCustomerList.PageIndex = e.NewPageIndex;
            CustomerOperations.Customer_List(grdCustomerList);

        }

      

        protected void grdCustomerList_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Vr_Selected_Row = grdCustomerList.SelectedIndex;
            GridViewRow row = grdCustomerList.Rows[Vr_Selected_Row];
            //Session.Add("Vr_CustomerID", row.Cells[1].Text);
            //Session.Add("Vr_CustomerTitle", row.Cells[2].Text);
            //Session.Add("Vr_CustomerProvince", row.Cells[3].Text);
            //Session.Add("Vr_CustomerDistrict", row.Cells[4].Text);
            //Session.Add("Vr_CustomerAddress", row.Cells[5].Text);
            //Session.Add("Vr_CustomerTaxAdministration", row.Cells[6].Text);
            //Session.Add("Vr_CustomerTaxNumber", row.Cells[7].Text);
            //Session.Add("Vr_CustomerTelephone", row.Cells[8].Text);
            //Session.Add("Vr_CustomerEMail", row.Cells[9].Text);
            Session["Vr_CustomerID"] = row.Cells[1].Text;
            Session["Vr_CustomerTitle"] = row.Cells[2].Text;
            Session["Vr_CustomerProvince"] = row.Cells[3].Text;
            Session["Vr_CustomerDistrict"] = row.Cells[4].Text;
            Session["Vr_CustomerAddress"] = row.Cells[5].Text;
            Session["Vr_CustomerTaxAdministration"] = row.Cells[6].Text;
            Session["Vr_CustomerTaxNumber"] = row.Cells[7].Text;
            Session["Vr_CustomerTelephone"] = row.Cells[8].Text;
            Session["Vr_CustomerEMail"] = row.Cells[9].Text;


        }

   

        protected void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            Session.Add("Vr_Data", "CustomerAdd");
            Response.Redirect("MusteriEkleGuncelle.aspx");
        }

        protected void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (Session["Vr_CustomerID"].ToString() == "")
            {
                Response.Write("<script lang='JavaScript'> alert ('Müşteri Seçmelisiniz.');</script>");
            }
            else
            {
                Session.Add("Vr_Data", "CustomerUpdate");
                Response.Redirect("MusteriEkleGuncelle.aspx");
            }
            
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