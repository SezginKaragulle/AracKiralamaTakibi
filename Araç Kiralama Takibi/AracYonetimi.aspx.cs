using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Araç_Kiralama_Takibi
{
    public partial class AracYonetimi : System.Web.UI.Page
    {
        Classes.Vehicle_Operations VehicleOperations = new Classes.Vehicle_Operations();
        private int Vr_Selected_Row;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Add("Vr_VehicleID", "");
                Session.Add("vr_VehiclePlate", "");
                Session.Add("vr_VehicleTradeMark", "");
                Session.Add("vr_VehicleModel", "");
                Session.Add("vr_VehicleType", "");
                Session.Add("vr_VehicleYear", "");
                Session.Add("vr_VehicleColor", "");
                Session.Add("vr_VehicleGear", "");
                Session.Add("vr_VehicleEnginePower", "");
                Session.Add("vr_VehicleEngineVolume", "");
                Session.Add("vr_VehicleFuelType", "");
                Session.Add("vr_VehicleLicenseNo", "");
                Session.Add("vr_VehicleStatus", "");
                VehicleOperations.Vehicle_List(grdVehicleList);

            }
         
        }

        protected void grdVehicleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vr_Selected_Row = grdVehicleList.SelectedIndex;
            GridViewRow row = grdVehicleList.Rows[Vr_Selected_Row];
            //Session.Add("Vr_VehicleID", row.Cells[1].Text);
            //Session.Add("vr_VehiclePlate", row.Cells[2].Text);
            //Session.Add("vr_VehicleTradeMark", row.Cells[3].Text);
            //Session.Add("vr_VehicleModel", row.Cells[4].Text);
            //Session.Add("vr_VehicleType", row.Cells[5].Text);
            //Session.Add("vr_VehicleYear", row.Cells[6].Text);
            //Session.Add("vr_VehicleColor", row.Cells[7].Text);
            //Session.Add("vr_VehicleGear", row.Cells[8].Text);
            //Session.Add("vr_VehicleEnginePower", row.Cells[9].Text);
            //Session.Add("vr_VehicleEngineVolume", row.Cells[10].Text);
            //Session.Add("vr_VehicleFuelType", row.Cells[11].Text);
            //Session.Add("vr_VehicleLicenseNo", row.Cells[12].Text);
            //Session.Add("vr_VehicleStatus", row.Cells[13].Text);
            Session["Vr_VehicleID"] = row.Cells[1].Text;
            Session["vr_VehiclePlate"] = row.Cells[2].Text;
            Session["vr_VehicleTradeMark"] = row.Cells[3].Text;
            Session["vr_VehicleModel"] = row.Cells[4].Text;
            Session["vr_VehicleType"] = row.Cells[5].Text;
            Session["vr_VehicleYear"] = row.Cells[6].Text;
            Session["vr_VehicleColor"] = row.Cells[7].Text;
            Session["vr_VehicleGear"] = row.Cells[8].Text;
            Session["vr_VehicleEnginePower"] = row.Cells[9].Text;
            Session["vr_VehicleEngineVolume"] = row.Cells[10].Text;
            Session["vr_VehicleFuelType"] = row.Cells[11].Text;
            Session["vr_VehicleLicenseNo"] = row.Cells[12].Text;
            Session["vr_VehicleStatus"] = row.Cells[13].Text;

        }

        protected void grdVehicleList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdVehicleList.PageIndex = e.NewPageIndex;
            VehicleOperations.Vehicle_List(grdVehicleList);
        }

        protected void btnVehicleAdd_Click(object sender, EventArgs e)
        {
            Session.Add("Vr_Data", "VehicleAdd");
            Response.Redirect("AracEkleGuncelle.aspx");
        }

        protected void btnVehicleUpdate_Click(object sender, EventArgs e)
        {
            if (Session["Vr_VehicleID"].ToString() == "")
            {
                Response.Write("<script lang='JavaScript'> alert ('Araç Seçmelisiniz.');</script>");
            }
            else
            {
                Session.Add("Vr_Data", "VehicleUpdate");
                Response.Redirect("AracEkleGuncelle.aspx");

            }
            
        }

        protected void btnVehicleDelete_Click(object sender, EventArgs e)
        {
            if (Session["Vr_VehicleID"].ToString() == "")
            {
                Response.Write("<script lang='JavaScript'> alert ('Araç Seçmelisiniz.');</script>");
            }
            else
            {
                VehicleOperations.Vehicle_Delete(Session["Vr_VehicleID"].ToString(), this.Context);
                VehicleOperations.Vehicle_List(grdVehicleList);
            }
            
        }

        protected void btnVehicleSearch_Click(object sender, EventArgs e)
        {
            VehicleOperations.Vehicle_List_VehicleFilter(grdVehicleList,txtVehicleId.Text, txtVehiclePlate.Text);
            txtVehicleId.Text = "";
            txtVehiclePlate.Text = "";
        }
    }
}