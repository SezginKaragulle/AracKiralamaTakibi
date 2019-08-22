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
    public class Customer_Operations: DbConnection
    {
        public string P_Customer_Title { get; set; }
        public string P_Customer_Province { get; set; }
        public string P_Customer_District { get; set; }
        public string P_Customer_Address { get; set; }
        public string P_Customer_TaxAdministration { get; set; }
        public int P_Customer_TaxNumber { get; set; }
        public string P_Customer_Telephone { get; set; }
        public string P_Customer_EMail { get; set; }



        public void Customer_List(GridView dt_CustomersListGrd)
        {
            Db_Table = new DataTable();
            Db_Table.Clear();
            Db_Connection.Open();
            Db_Adapter = new SqlDataAdapter("Select * From CustomersList", Db_Connection);
            Db_Adapter.Fill(Db_Table);
            dt_CustomersListGrd.DataSource = Db_Table;
            dt_CustomersListGrd.DataBind();
            Db_Connection.Close();
            

        }

        public void Customer_Add(string vr_CustomerTitle,string vr_CustomerProvince,string vr_CustomerDistrict,string vr_CustomerAddress,string vr_CustomerTaxAdministration,int vr_CustomerTaxNumber,string vr_CustomerTelephone,string vr_CustomerEmail,HttpContext vr_Context)
        {
            Db_Connection.Open();
            Db_Query.Connection = Db_Connection;
            Db_Query.CommandText = "Exec CustomerAdd @Customer_Title='"+vr_CustomerTitle+ "',@Customer_Province='"+vr_CustomerProvince+ "',@Customer_District='"+vr_CustomerDistrict+ "',@Customer_Address='"+vr_CustomerAddress+ "',@Customer_TaxAdministration='"+vr_CustomerTaxAdministration+ "',@Customer_Taxnumber='"+vr_CustomerTaxNumber+ "',@Customer_Telephone='"+vr_CustomerTelephone+ "',@Customer_Email='"+vr_CustomerEmail+"'";
            Db_Query.ExecuteNonQuery();
            vr_Context.Response.Write("<script lang='JavaScript'> alert ('Müşteri Eklendi.');</script>");
            Db_Connection.Close();

        }

        public void Customer_Update(string vr_CustomerID,string vr_CustomerTitle, string vr_CustomerProvince, string vr_CustomerDistrict, string vr_CustomerAddress, string vr_CustomerTaxAdministration, int vr_CustomerTaxNumber, string vr_CustomerTelephone, string vr_CustomerEmail, HttpContext vr_Context)
        {
            Db_Connection.Open();
            Db_Query.Connection = Db_Connection;
            Db_Query.CommandText = "Exec CustomerUpdate @Customer_ID='"+vr_CustomerID+"',@Customer_Title='" + vr_CustomerTitle + "',@Customer_Province='" + vr_CustomerProvince + "',@Customer_District='" + vr_CustomerDistrict + "',@Customer_Address='" + vr_CustomerAddress + "',@Customer_TaxAdministration='" + vr_CustomerTaxAdministration + "',@Customer_Taxnumber='" + vr_CustomerTaxNumber + "',@Customer_Telephone='" + vr_CustomerTelephone + "',@Customer_Email='" + vr_CustomerEmail + "'";
            Db_Query.ExecuteNonQuery();
            vr_Context.Response.Write("<script lang='JavaScript'> alert ('Müşteri Güncellendi.');</script>");
            Db_Connection.Close();

        }


        public void Customer_Delete(string vr_CustomerID, HttpContext vr_Context)
        {
            Db_Connection.Open();
            Db_Query.Connection = Db_Connection;
            Db_Query.CommandText = "Exec CustomerDelete @Customer_ID='" + vr_CustomerID + "'";
            Db_Query.ExecuteNonQuery();
            vr_Context.Response.Write("<script lang='JavaScript'> alert ('Müşteri Silindi.');</script>");
            Db_Connection.Close();

        }

        public void Customer_List_CustomerFilter(GridView dt_CustomersListGrd, string vr_CustomerID, string vr_CustomerTitle, string vr_CustomerTaxNumber)
        {
            Db_Table = new DataTable();
            Db_Table.Clear();
            Db_Connection.Open();
            Db_Adapter = new SqlDataAdapter("Exec CustomerFilter @Customer_ID='" + vr_CustomerID + "',@Customer_Title='" + vr_CustomerTitle + "',@Customer_TaxNumber='" + vr_CustomerTaxNumber + "'", Db_Connection);
            Db_Adapter.Fill(Db_Table);
            dt_CustomersListGrd.DataSource = Db_Table;
            dt_CustomersListGrd.DataBind();
            Db_Connection.Close();

        }

        //public void Customer_List_CustomerFilter(GridView dt_CustomersListGrd,string vr_FQuery)
        //{
        //    Db_Table = new DataTable();
        //    Db_Table.Clear();
        //    Db_Connection.Open();
        //    Db_Adapter = new SqlDataAdapter(vr_FQuery, Db_Connection);
        //    Db_Adapter.Fill(Db_Table);
        //    dt_CustomersListGrd.DataSource = Db_Table;
        //    dt_CustomersListGrd.DataBind();
        //    Db_Connection.Close();

        //}


    }
}