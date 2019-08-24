using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Araç_Kiralama_Takibi
{
    public partial class AracEkleGuncelle : System.Web.UI.Page
    {
        Classes.Vehicle_Operations VehicleOperations = new Classes.Vehicle_Operations();
        private string vr_Gelen_Deger;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                vr_Gelen_Deger = Session["Vr_Data"].ToString();
                if (vr_Gelen_Deger == "VehicleAdd")
                {
                    txtVehiclePlate.Text = "";
                    txtVehicleTrademark.Text = "";
                    txtVehicleModel.Text = "";
                    txtVehicleType.Text = "";
                    txtVehicleYear.Text = "";
                    txtVehicleColor.Text = "";
                    drpVehicleGear.Text = "";
                    txtVehicleEnginePower.Text = "";
                    txtVehicleEngineVolume.Text = "";
                    drpVehicleFuelType.Text = "";
                    txtVehicleLicenseNo.Text = "";
                    drpVehicleStatus.Text = "";
                    btnVehicleAdded.Text = "Ekle";
                }
                else if (vr_Gelen_Deger == "VehicleUpdate")
                {
                    txtVehiclePlate.Text = Session["vr_VehiclePlate"].ToString();
                    txtVehicleTrademark.Text = Session["vr_VehicleTradeMark"].ToString();
                    txtVehicleModel.Text = Session["vr_VehicleModel"].ToString();
                    txtVehicleType.Text = Session["vr_VehicleType"].ToString();
                    txtVehicleYear.Text = Session["vr_VehicleYear"].ToString();
                    txtVehicleColor.Text = Session["vr_VehicleColor"].ToString();
                    drpVehicleGear.Items[0].Text = Session["vr_VehicleGear"].ToString();
                    txtVehicleEnginePower.Text = Session["vr_VehicleEnginePower"].ToString();
                    txtVehicleEngineVolume.Text = Session["vr_VehicleEngineVolume"].ToString();
                    drpVehicleFuelType.Items[0].Text = Session["vr_VehicleFuelType"].ToString();
                    txtVehicleLicenseNo.Text = Session["vr_VehicleLicenseNo"].ToString();
                    drpVehicleStatus.Items[0].Text = Session["vr_VehicleStatus"].ToString();
                    btnVehicleAdded.Text = "Güncelle";
                }
            }
        }

        protected void btnVehicleExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("AracYonetimi.aspx");
        }

        protected void btnVehicleAdded_Click(object sender, EventArgs e)
        {
            if (btnVehicleAdded.Text == "Ekle")
            {
                VehicleOperations.Vehicle_Add(txtVehiclePlate.Text, txtVehicleTrademark.Text, txtVehicleModel.Text, txtVehicleType.Text, txtVehicleYear.Text, txtVehicleColor.Text, drpVehicleGear.Text, txtVehicleEnginePower.Text, txtVehicleEngineVolume.Text, drpVehicleFuelType.Text, int.Parse(txtVehicleLicenseNo.Text), drpVehicleStatus.Text, this.Context);
                txtVehiclePlate.Text = "";
                txtVehicleTrademark.Text = "";
                txtVehicleModel.Text = "";
                txtVehicleType.Text = "";
                txtVehicleYear.Text = "";
                txtVehicleColor.Text = "";
                drpVehicleGear.Text = "";
                txtVehicleEnginePower.Text = "";
                txtVehicleEngineVolume.Text = "";
                drpVehicleFuelType.Text = "";
                txtVehicleLicenseNo.Text = "";
                drpVehicleStatus.Text = "";
            }
            else if (btnVehicleAdded.Text == "Güncelle")
            {
                VehicleOperations.Vehicle_Update(Session["Vr_VehicleID"].ToString(), txtVehiclePlate.Text, txtVehicleTrademark.Text, txtVehicleModel.Text, txtVehicleType.Text, txtVehicleYear.Text, txtVehicleColor.Text, drpVehicleGear.Text, txtVehicleEnginePower.Text, txtVehicleEngineVolume.Text, drpVehicleFuelType.Text, int.Parse(txtVehicleLicenseNo.Text), drpVehicleStatus.Text, this.Context);
            }
          
        }
    }
}