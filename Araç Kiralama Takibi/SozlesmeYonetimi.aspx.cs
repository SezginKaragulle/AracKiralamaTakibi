using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Araç_Kiralama_Takibi
{
    public partial class SozlesmeYonetimi : System.Web.UI.Page
    {
        Classes.Contract_Operations Contact_Operations = new Classes.Contract_Operations();
        protected void Page_Load(object sender, EventArgs e)
        {
            Contact_Operations.Contract_List(grdContractsList);
        }

        protected void btnContractAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("SozlesmeEkleGuncelle.aspx");
        }

        protected void grdContractsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}