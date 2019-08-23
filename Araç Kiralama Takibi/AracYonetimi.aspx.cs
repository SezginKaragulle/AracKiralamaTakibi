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
        protected void Page_Load(object sender, EventArgs e)
        {
            VehicleOperations.Vehicle_List(grdVehicleList);
        }

        protected void grdVehicleList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}