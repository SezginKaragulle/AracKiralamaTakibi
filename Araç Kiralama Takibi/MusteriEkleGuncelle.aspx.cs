using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Araç_Kiralama_Takibi
{
    public partial class MusteriEkleGuncelle : System.Web.UI.Page
    {
        Classes.Customer_Operations CustomerOperations = new Classes.Customer_Operations();
        private string vr_Gelen_Deger;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                vr_Gelen_Deger = Session["Vr_Data"].ToString();
                if (vr_Gelen_Deger == "CustomerAdd")
                {
                    txtCustomerTitle.Text = "";
                    txtCustomerProvince.Text = "";
                    txtCustomerDistrict.Text = "";
                    txtCustomerAddress.Text = "";
                    txtCustomerTaxAdministration.Text = "";
                    txtCustomerTaxNumber.Text = "";
                    txtCustomerTelephone.Text = "";
                    txtCustomerEMail.Text = "";
                    btnCustomerAdded.Text = "Ekle";
                }
                else if (vr_Gelen_Deger == "CustomerUpdate")
                {
                    txtCustomerTitle.Text = Session["Vr_CustomerTitle"].ToString();
                    txtCustomerProvince.Text = Session["Vr_CustomerProvince"].ToString();
                    txtCustomerDistrict.Text = Session["Vr_CustomerDistrict"].ToString();
                    txtCustomerAddress.Text = Session["Vr_CustomerAddress"].ToString();
                    txtCustomerTaxAdministration.Text = Session["Vr_CustomerTaxAdministration"].ToString();
                    txtCustomerTaxNumber.Text = Session["Vr_CustomerTaxNumber"].ToString();
                    txtCustomerTelephone.Text = Session["Vr_CustomerTelephone"].ToString();
                    txtCustomerEMail.Text = Session["Vr_CustomerEMail"].ToString();
                    btnCustomerAdded.Text = "Güncelle";
                }
            }

        }

        protected void btnCustomerExit_Click(object sender, EventArgs e)
        {
            txtCustomerTitle.Text = "";
            txtCustomerProvince.Text = "";
            txtCustomerDistrict.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerTaxAdministration.Text = "";
            txtCustomerTaxNumber.Text = "";
            txtCustomerTelephone.Text = "";
            txtCustomerEMail.Text = "";
            Response.Redirect("MusteriYonetimi.aspx");
        }

        protected void btnCustomerAdded_Click(object sender, EventArgs e)
        {
            CustomerOperations.P_Customer_Title = txtCustomerTitle.Text;
            CustomerOperations.P_Customer_Province = txtCustomerProvince.Text;
            CustomerOperations.P_Customer_District = txtCustomerDistrict.Text;
            CustomerOperations.P_Customer_Address = txtCustomerAddress.Text;
            CustomerOperations.P_Customer_TaxAdministration = txtCustomerTaxAdministration.Text;
            CustomerOperations.P_Customer_TaxNumber = int.Parse(txtCustomerTaxNumber.Text);
            CustomerOperations.P_Customer_Telephone = txtCustomerTelephone.Text;
            CustomerOperations.P_Customer_EMail = txtCustomerEMail.Text;

            if (btnCustomerAdded.Text == "Ekle")
            {
                
                CustomerOperations.Customer_Add(CustomerOperations.P_Customer_Title, CustomerOperations.P_Customer_Province, CustomerOperations.P_Customer_District, CustomerOperations.P_Customer_Address, CustomerOperations.P_Customer_TaxAdministration, CustomerOperations.P_Customer_TaxNumber, CustomerOperations.P_Customer_Telephone, CustomerOperations.P_Customer_EMail, this.Context);
                txtCustomerTitle.Text = "";
                txtCustomerProvince.Text = "";
                txtCustomerDistrict.Text = "";
                txtCustomerAddress.Text = "";
                txtCustomerTaxAdministration.Text = "";
                txtCustomerTaxNumber.Text = "";
                txtCustomerTelephone.Text = "";
                txtCustomerEMail.Text = "";
            }
            else if (btnCustomerAdded.Text == "Güncelle")
            {
                CustomerOperations.Customer_Update(Session["Vr_CustomerID"].ToString(), CustomerOperations.P_Customer_Title, CustomerOperations.P_Customer_Province, CustomerOperations.P_Customer_District, CustomerOperations.P_Customer_Address, CustomerOperations.P_Customer_TaxAdministration, CustomerOperations.P_Customer_TaxNumber, CustomerOperations.P_Customer_Telephone, CustomerOperations.P_Customer_EMail, this.Context);
            }
        }
    }
}