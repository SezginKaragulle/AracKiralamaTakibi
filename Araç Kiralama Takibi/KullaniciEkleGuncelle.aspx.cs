using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Araç_Kiralama_Takibi
{
    public partial class KullaniciEkle : System.Web.UI.Page
    {
        Classes.User_Operations UserOperations = new Classes.User_Operations();
        private string vr_Gelen_Deger;
        //private int vr_UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                vr_Gelen_Deger = Session["Vr_Data"].ToString();
                if (vr_Gelen_Deger == "UserAdd")
                {
                    txtUserCode.Text = "";
                    txtUserPassword.Text = "";
                    txtUserNameSurname.Text = "";
                    txtUserDepartment.Text = "";
                    txtUserTelephone.Text = "";
                    txtUserMail.Text = "";
                    btnUserAdded.Text = "Ekle";
                }
                else if (vr_Gelen_Deger == "UserUpdate")
                {
                    btnUserAdded.Text = "Güncelle";
                    //vr_UserID = int.Parse(Session["Vr_UserID"].ToString());
                    txtUserCode.Text = Session["Vr_UserCode"].ToString();
                    txtUserNameSurname.Text = Session["Vr_UserNameSurName"].ToString();
                    txtUserDepartment.Text = Session["Vr_UserDepartment"].ToString();
                    txtUserTelephone.Text = Session["Vr_UserTelephone"].ToString();
                    txtUserMail.Text = Session["Vr_UserMail"].ToString();

                }
            }
        }

        protected void btnUserExit_Click(object sender, EventArgs e)
        {
            txtUserCode.Text = "";
            txtUserPassword.Text = "";
            txtUserNameSurname.Text = "";
            txtUserDepartment.Text = "";
            txtUserTelephone.Text = "";
            txtUserMail.Text = "";
            Response.Redirect("SistemYonetimi.aspx");
          

        }

        protected void btnUserAdded_Click(object sender, EventArgs e)
        {
            UserOperations.P_User_Code = txtUserCode.Text;
            UserOperations.P_User_Password = txtUserPassword.Text;
            UserOperations.P_UserNameSurName = txtUserNameSurname.Text;
            UserOperations.P_UserDepartment = txtUserDepartment.Text;
            UserOperations.P_UserTelephone = txtUserTelephone.Text;
            UserOperations.P_UserMail = txtUserMail.Text;
            if (btnUserAdded.Text == "Ekle")
            {
                if (txtUserCode.Text == "" || txtUserPassword.Text == "")
                {
                    Response.Write("<script lang='JavaScript'> alert ('Kullanıcı Kodu ve Şifre Alanlarını Boş Bırakmayınız.');</script>");
                }

                else
                {
                    UserOperations.User_Add(UserOperations.P_User_Code, UserOperations.P_User_Password, UserOperations.P_UserNameSurName, UserOperations.P_UserDepartment, UserOperations.P_UserTelephone, UserOperations.P_UserMail, this.Context);

                }

                txtUserCode.Text = "";
                txtUserPassword.Text = "";
                txtUserNameSurname.Text = "";
                txtUserDepartment.Text = "";
                txtUserTelephone.Text = "";
                txtUserMail.Text = "";
            }
            else
            {
                UserOperations.User_Update(Session["Vr_UserID"].ToString(), UserOperations.P_User_Code, UserOperations.P_User_Password, UserOperations.P_UserNameSurName, UserOperations.P_UserDepartment, UserOperations.P_UserTelephone, UserOperations.P_UserMail, this.Context);
                //Response.Write("<script lang='JavaScript'> alert ('" + Session["Vr_UserID"].ToString() + "');</script>");
            }
        }
    }
}