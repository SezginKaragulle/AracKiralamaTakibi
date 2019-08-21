using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;


namespace Araç_Kiralama_Takibi.Classes
{
    public class User_Operations:DbConnection
    {
        public string P_User_Code  { get; set; }
        public string P_User_Password { get; set; }
        public string P_UserNameSurName { get; set; }
        public string P_UserDepartment { get; set; }
        public string P_UserTelephone { get; set; }
        public string P_UserMail { get; set; }

        public void Db_Connect(HttpContext cnt)
        {
           
            Db_Connection.Open();
            cnt.Response.Write("Bağlantı Kuruldu");
            Db_Connection.Close();
            
        }

        public void User_Login(string vr_UserCode, string vr_UserPassword, HttpContext vr_Context)
        {
            Db_Connection.Open();
            Db_Query.Connection = Db_Connection;
            Db_Query.CommandText = "select * from UsersList";
            Db_DataReader = Db_Query.ExecuteReader();
            while (Db_DataReader.Read())
            {
                if (vr_UserCode != Db_DataReader[1].ToString() || vr_UserPassword != Db_DataReader[2].ToString())
                {
                    vr_Context.Response.Write("<script lang='JavaScript'> alert ('Yanlış Kullanıcı Adı Veya Şifre Girişi');</script>");
                }
                else
                {
                    vr_Context.Response.Redirect("Anasayfa.aspx");
                }
            }
            Db_DataReader.Close();
            Db_Connection.Close();

        }

        public void User_Add(string vr_UserCode, string vr_UserPassword,string vr_UserNameSurName,string vr_UserDepartment,string vr_UserTelephone,string vr_UserMail,HttpContext vr_Context)
        {
            Db_Connection.Open();
            Db_Query.Connection = Db_Connection;
            Db_Query.CommandText = "exec UserAdd @User_code='" + vr_UserCode + "',@User_Password='" + vr_UserPassword + "',@UserName_Surname='" + vr_UserNameSurName + "',@User_Department='" + vr_UserDepartment + "',@User_Telephone='" + vr_UserTelephone + "',@User_Mail='" + vr_UserMail + "'";
            Db_Query.ExecuteNonQuery();
            vr_Context.Response.Write("<script lang='JavaScript'> alert ('Kullanıcı Eklendi.');</script>");
            Db_Connection.Close();

        }

        public void User_Update(string vr_UserId,string vr_UserCode, string vr_UserPassword, string vr_UserNameSurName, string vr_UserDepartment, string vr_UserTelephone, string vr_UserMail, HttpContext vr_Context)
        {
            Db_Connection.Open();
            Db_Query.Connection = Db_Connection;
            Db_Query.CommandText = "exec UserUpdate @User_Id='"+vr_UserId+"', @User_code='" + vr_UserCode + "',@User_Password='" + vr_UserPassword + "',@UserName_Surname='" + vr_UserNameSurName + "',@User_Department='" + vr_UserDepartment + "',@User_Telephone='" + vr_UserTelephone + "',@User_Mail='" + vr_UserMail + "'";
            Db_Query.ExecuteNonQuery();
            vr_Context.Response.Write("<script lang='JavaScript'> alert ('Kullanıcı Güncellendi.');</script>");
            Db_Connection.Close();

        }

        public void User_Delete(string vr_UserId, HttpContext vr_Context)
        {
            Db_Connection.Open();
            Db_Query.Connection = Db_Connection;
            Db_Query.CommandText = "exec UserDelete @User_Id='" + vr_UserId + "'";
            Db_Query.ExecuteNonQuery();
            vr_Context.Response.Write("<script lang='JavaScript'> alert ('Kullanıcı Silindi.');</script>");
            Db_Connection.Close();

        }

        public void User_List(GridView dt_UsersListGrd)
        {
            Db_Table = new DataTable();
            Db_Table.Clear();
            Db_Connection.Open();
            Db_Adapter = new SqlDataAdapter("select UserId,UserCode,UserNameSurName,UserDepartment,UserTelephone,UserMail from UsersList", Db_Connection);
            Db_Adapter.Fill(Db_Table);
            dt_UsersListGrd.DataSource = Db_Table;
            dt_UsersListGrd.DataBind();
            Db_Connection.Close();
            
        }

        public void User_List_UserFilter(GridView dt_UsersListGrd,string vr_FQuery)
        {
            Db_Table = new DataTable();
            Db_Table.Clear();
            Db_Connection.Open();
            Db_Adapter = new SqlDataAdapter(vr_FQuery, Db_Connection);
            Db_Adapter.Fill(Db_Table);
            dt_UsersListGrd.DataSource = Db_Table;
            dt_UsersListGrd.DataBind();
            Db_Connection.Close();

        }


    }
}