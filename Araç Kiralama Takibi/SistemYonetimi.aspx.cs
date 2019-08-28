using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Araç_Kiralama_Takibi
{
    public partial class SistemYonetimi : System.Web.UI.Page
    {
        Classes.User_Operations User_Operations = new Classes.User_Operations();
        private int Vr_Selected_Row;
        private int Vr_Object = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User_Operations.User_List(grdUsersList);
                Session.Add("Vr_UserID", "");
                Session.Add("Vr_UserCode", "");
                Session.Add("Vr_UserNameSurName", "");
                Session.Add("Vr_UserDepartment", "");
                Session.Add("Vr_UserTelephone", "");
                Session.Add("Vr_UserMail", "");
            }
            

        }

        protected void grdUsersList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdUsersList.PageIndex = e.NewPageIndex;
            User_Operations.User_List(grdUsersList);
        }

        protected void btnUserAdd_Click(object sender, EventArgs e)
        {
            //int secili;
            //secili = grdUsersList.SelectedIndex;
            //GridViewRow row = grdUsersList.Rows[secili];
            //btnUserDel.Text = row.Cells[1].Text;
            Session.Add("Vr_Data", "UserAdd");
            Response.Redirect("KullaniciEkleGuncelle.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnUserUpdate_Click(object sender, EventArgs e)
        {
            if (Session["Vr_UserID"].ToString() == "")
            {
                Response.Write("<script lang='JavaScript'> alert ('Kullanıcı Seçmelisiniz.');</script>");
            }
            else
            {
                Session.Add("Vr_Data", "UserUpdate");
                Response.Redirect("KullaniciEkleGuncelle.aspx");
            }
              
          
        }

        protected void grdUsersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Vr_Selected_Row = grdUsersList.SelectedIndex;
            GridViewRow row = grdUsersList.Rows[Vr_Selected_Row];
            //Session.Add("Vr_UserID", row.Cells[1].Text);
            //Session.Add("Vr_UserCode", row.Cells[2].Text);
            //Session.Add("Vr_UserNameSurName", row.Cells[3].Text);
            //Session.Add("Vr_UserDepartment", row.Cells[4].Text);
            //Session.Add("Vr_UserTelephone", row.Cells[5].Text);
            //Session.Add("Vr_UserMail", row.Cells[6].Text);

            Session["Vr_UserID"] = row.Cells[1].Text;
            Session["Vr_UserCode"] = row.Cells[2].Text;
            Session["Vr_UserNameSurName"] = row.Cells[3].Text;
            Session["Vr_UserDepartment"] = row.Cells[4].Text;
            Session["Vr_UserTelephone"] = row.Cells[5].Text;
            Session["Vr_UserMail"] = row.Cells[6].Text;


        }

        protected void btnUserDel_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnUserDel_Click1(object sender, EventArgs e)
        {
            if (Session["Vr_UserID"].ToString() == "")
            {
                Response.Write("<script lang='JavaScript'> alert ('Kullanıcı Seçmelisiniz.');</script>");
            }
            else
            {
                User_Operations.User_Delete(Session["Vr_UserID"].ToString(), this.Context);
                User_Operations.User_List(grdUsersList);
            }

           
            
            
        }

        protected void btnUserSearch_Click(object sender, EventArgs e)
        {
            if (txtUserCode.Text.Trim() != "")
            {
                User_Operations.User_List_UserFilter(grdUsersList, "Select UserId,UserCode,UserNameSurName,UserDepartment,UserTelephone,UserMail from UsersList Where UserCode Like '%" + txtUserCode.Text.Trim() + "%'");
                txtUserCode.Text = "";
                txtUserNameSurName.Text = "";
            }
            else if (txtUserNameSurName.Text.Trim() != "")
            {
                User_Operations.User_List_UserFilter(grdUsersList, "Select UserId,UserCode,UserNameSurName,UserDepartment,UserTelephone,UserMail from UsersList Where UserNameSurName Like '%" + txtUserNameSurName.Text.Trim() + "%'");
                txtUserCode.Text = "";
                txtUserNameSurName.Text = "";
            }
            else if (txtUserCode.Text.Trim() == "" && txtUserNameSurName.Text.Trim() == "")
            {
                User_Operations.User_List(grdUsersList);
                txtUserCode.Text = "";
                txtUserNameSurName.Text = "";
            }
        }

        protected void grdUsersList_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            
        }
    }
}