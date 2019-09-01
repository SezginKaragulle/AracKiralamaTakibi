using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Araç_Kiralama_Takibi
{
    public partial class SozlesmeEkleGuncelle : System.Web.UI.Page
    {
        Classes.Contract_Operations Contract_Operations = new Classes.Contract_Operations();
   [WebMethod]
      public void Customer_Method(string vr_CustomerCode)
        {
            Contract_Operations.Db_Connection.Open();
            Contract_Operations.Db_Query.Connection = Contract_Operations.Db_Connection;
            Contract_Operations.Db_Query.CommandText = "Select * From CustomersList Where CustomerID ='" + vr_CustomerCode + "'";
            Contract_Operations.Db_DataReader = Contract_Operations.Db_Query.ExecuteReader();
            while (Contract_Operations.Db_DataReader.Read())
            {
                txtCustomerTitle.Text = Contract_Operations.Db_DataReader[1].ToString();
            }
            Contract_Operations.Db_Connection.Close();
            Contract_Operations.Db_DataReader.Close();
        }

        public void VehiclePlate_Method(string vr_VehicleStatus)
        {
            Contract_Operations.Db_Connection.Open();
            Contract_Operations.Db_Query.Connection = Contract_Operations.Db_Connection;
            Contract_Operations.Db_Query.CommandText = "Select * From VehicleList Where VehicleStatus='" + vr_VehicleStatus + "'";
            Contract_Operations.Db_DataReader = Contract_Operations.Db_Query.ExecuteReader();
            drpVehiclePlate.DataSource = Contract_Operations.Db_DataReader;
            drpVehiclePlate.DataValueField = "VehicleCode";
            drpVehiclePlate.DataTextField = "VehiclePlate";
            drpVehiclePlate.DataBind();
            Contract_Operations.Db_Connection.Close();
            Contract_Operations.Db_DataReader.Close();


        }
        private string vr_Vehicle_Plate;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                if (Session["Vr_Data"].ToString() == "ContractAdd")
                {
                    VehiclePlate_Method("Uygun");
                    txtContractNo.Text = "";
                    txtContractStart.Text = "";
                    txtContractFinish.Text = "";
                    txtHanding.Text = "";
                    drpVehiclePlate.Text = "";
                    txtCustomerCode.Text = "";
                    txtCustomerTitle.Text = "";
                    txtCustomerAuthorized.Text = "";
                    txtTelephoneNo.Text = "";
                    txtEmail.Text = "";
                    txtCustomerRepresentative.Text = "";
                    btnContractAdded.Text = "Ekle";
                }
                else if (Session["Vr_Data"].ToString() == "ContractUpdate")
                {
                    VehiclePlate_Method("Uygun");
                    DateTime dt = Convert.ToDateTime(Session["Vr_ContractStart"]);
                    txtContractNo.Text = Session["Vr_ContractNo"].ToString();
                    txtContractStart.Text = dt.ToString("yyyy-MM-dd");
                    dt = Convert.ToDateTime(Session["Vr_ContractFinish"]);
                    txtContractFinish.Text = dt.ToString("yyyy-MM-dd");
                    dt = Convert.ToDateTime(Session["Vr_HandingDate"]);
                    txtHanding.Text = dt.ToString("yyyy-MM-dd");
                    //drpVehiclePlate.SelectedItem.Text = Session["Vr_VehiclePlate"].ToString();
                    txtCustomerCode.Text = Session["Vr_CustomerCode"].ToString();
                    txtCustomerTitle.Text = Session["Vr_CustomerTitle"].ToString();
                    txtCustomerAuthorized.Text = Session["Vr_CustomerAuthorized"].ToString();
                    txtTelephoneNo.Text = Session["Vr_TelephoneNo"].ToString();
                    txtEmail.Text = Session["Vr_EMail"].ToString();
                    txtCustomerRepresentative.Text = Session["Vr_CustomerRepresentative"].ToString();
                    txtContractAmount.Text = Session["Vr_ContractAmount"].ToString();
                    drpContractCurrency.SelectedItem.Text = Session["Vr_ContractCurrency"].ToString();
                    chcVehicleUpdate.Visible = true;
                    btnContractAdded.Text = "Güncelle";
                    
                }
            }
        }

        protected void btnContractExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("SozlesmeYonetimi.aspx");
        }

        protected void btnContractAdded_Click(object sender, EventArgs e)
        {
            vr_Vehicle_Plate = drpVehiclePlate.Text;
            Contract_Operations.P_ContractNo = txtContractNo.Text;
            Contract_Operations.P_ContractStart = txtContractStart.Text;
            Contract_Operations.P_ContractFinish = txtContractFinish.Text;
            Contract_Operations.P_HandingDate = txtHanding.Text;
            Contract_Operations.P_VehiclePlate = drpVehiclePlate.SelectedItem.Text;
            Contract_Operations.P_CustomerCode = int.Parse(txtCustomerCode.Text);
            Contract_Operations.P_CustomerTitle = txtCustomerTitle.Text;
            Contract_Operations.P_CustomerAuthorized = txtCustomerAuthorized.Text;
            Contract_Operations.P_TelephoneNo = txtTelephoneNo.Text;
            Contract_Operations.P_EMail = txtEmail.Text;
            Contract_Operations.P_CustomerRepresentative = txtCustomerRepresentative.Text;
            Contract_Operations.P_ContractAmount = int.Parse(txtContractAmount.Text);
            Contract_Operations.P_ContractCurrency = drpContractCurrency.SelectedItem.Text;
            if (btnContractAdded.Text == "Ekle")
            {
                Contract_Operations.Query_Send("UPDATE VehicleList SET VehicleStatus = 'Kiralık' Where VehiclePlate='"+drpVehiclePlate.SelectedItem.Text+"'");
                Contract_Operations.Contract_Add(Contract_Operations.P_ContractNo, Contract_Operations.P_ContractStart, Contract_Operations.P_ContractFinish, Contract_Operations.P_HandingDate, Contract_Operations.P_VehiclePlate, Contract_Operations.P_CustomerCode, Contract_Operations.P_CustomerTitle, Contract_Operations.P_CustomerAuthorized, Contract_Operations.P_TelephoneNo, Contract_Operations.P_EMail, Contract_Operations.P_CustomerRepresentative,"H", "Aktif", Contract_Operations.P_ContractAmount, Contract_Operations.P_ContractCurrency, this.Context);
                //Response.Redirect("SozlesmeYonetimi.aspx");
                //Response.Write("<script lang='JavaScript'> alert ('Sözleşme Eklendi.');</script>");
                Response.Redirect("SozlesmeEkleGuncelle.aspx");
            }
            else if (btnContractAdded.Text == "Güncelle")
            {
                if (chcVehicleUpdate.Checked == true)
                {
                    Contract_Operations.Query_Send("UPDATE VehicleList SET VehicleStatus = 'Uygun' Where VehiclePlate='" + Session["Vr_VehiclePlate"].ToString() + "'");
                    Contract_Operations.Query_Send("UPDATE VehicleList SET VehicleStatus = 'Kiralık' Where VehiclePlate='" + drpVehiclePlate.SelectedItem.Text + "'");
                    Contract_Operations.Contract_Update(Session["Vr_ContractID"].ToString(), Contract_Operations.P_ContractNo, Contract_Operations.P_ContractStart, Contract_Operations.P_ContractFinish, Contract_Operations.P_HandingDate, Contract_Operations.P_VehiclePlate, Contract_Operations.P_CustomerCode, Contract_Operations.P_CustomerTitle, Contract_Operations.P_CustomerAuthorized, Contract_Operations.P_TelephoneNo, Contract_Operations.P_EMail, Contract_Operations.P_CustomerRepresentative, Contract_Operations.P_ContractAmount, Contract_Operations.P_ContractCurrency, this.Context);
                    Response.Redirect("SozlesmeYonetimi.aspx");

                }
                else if (chcVehicleUpdate.Checked == false)
                {
                    Contract_Operations.Contract_Update(Session["Vr_ContractID"].ToString(), Contract_Operations.P_ContractNo, Contract_Operations.P_ContractStart, Contract_Operations.P_ContractFinish, Contract_Operations.P_HandingDate, Session["Vr_VehiclePlate"].ToString(), Contract_Operations.P_CustomerCode, Contract_Operations.P_CustomerTitle, Contract_Operations.P_CustomerAuthorized, Contract_Operations.P_TelephoneNo, Contract_Operations.P_EMail, Contract_Operations.P_CustomerRepresentative, Contract_Operations.P_ContractAmount, Contract_Operations.P_ContractCurrency, this.Context);
                    Response.Redirect("SozlesmeYonetimi.aspx");
                }
               

            }
        }

        protected void txtCustomerCode_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void txtCustomerTitle_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}