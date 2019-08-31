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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                VehiclePlate_Method("Uygun");
            }
        }

        protected void btnContractExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("SozlesmeYonetimi.aspx");
        }

        

    }
}