using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using  System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using Araç_Kiralama_Takibi.Classes;

namespace Araç_Kiralama_Takibi
{
    public partial class Giriş : System.Web.UI.Page
    {
        Classes.User_Operations User_Operations = new User_Operations();
        
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            User_Operations.P_User_Code = txtKullaniciAdi.Text.Trim();
            User_Operations.P_User_Password = txtSifre.Text.Trim();
            User_Operations.User_Login(User_Operations.P_User_Code, User_Operations.P_User_Password, this.Context);
            
        }
    }
}