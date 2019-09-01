using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;


namespace Araç_Kiralama_Takibi.Classes
{
    public class Contract_Operations:DbConnection
    {
        public string P_ContractNo { get; set; }
        public string P_ContractStart { get; set; }
        public string P_ContractFinish { get; set; }
        public string P_HandingDate { get; set; }
        public string P_VehiclePlate { get; set; }
        public int P_CustomerCode { get; set; }
        public string P_CustomerTitle { get; set; }
        public string P_CustomerAuthorized { get; set; }
        public string P_TelephoneNo { get; set; }
        public string P_EMail { get; set; }
        public string P_CustomerRepresentative { get; set; }
        public int P_ContractAmount { get; set; }
        public string P_ContractCurrency { get; set; }

        public void Contract_List(GridView dt_ContractsListGrd)
        {
            Db_Table = new DataTable();
            Db_Table.Clear();
            Db_Connection.Open();
            Db_Adapter = new SqlDataAdapter("Select * From ContractsList", Db_Connection);
            Db_Adapter.Fill(Db_Table);
            dt_ContractsListGrd.DataSource = Db_Table;
            dt_ContractsListGrd.DataBind();
            Db_Connection.Close();

        }


        public void Contract_Add(string vr_ContractNo,string vr_ContractStart,string vr_ContractFinish,string vr_HandingDate,string vr_VehiclePlate,int vr_CustomerCode,string vr_CustomerTitle,string vr_CustomerAuthorized,string vr_TelephoneNo,string vr_EMail,string vr_CustomerRepresentative,string vr_AccoutingStatus, string vr_ContractStatus, int vr_ContractAmount, string vr_ContractCurrency, HttpContext vr_Context)
        {
            Db_Connection.Open();
            Db_Query.Connection = Db_Connection;
            Db_Query.CommandText = "Exec ContractAdd @Contract_No='"+vr_ContractNo+ "',@Contract_Start='"+vr_ContractStart+ "',@Contract_Finish='"+vr_ContractFinish+ "',@Handing_Date='"+vr_HandingDate+ "',@Vehicle_Plate='"+vr_VehiclePlate+ "',@Customer_Code='"+vr_CustomerCode+ "',@Customer_Title='"+vr_CustomerTitle+ "',@Customer_Authorized='"+vr_CustomerAuthorized+ "',@Telephone_No='"+vr_TelephoneNo+ "',@E_Mail='"+vr_EMail+ "',@Customer_Representative='"+vr_CustomerRepresentative+ "',@AccoutingStatus='"+vr_AccoutingStatus+"',@Contract_Status='" + vr_ContractStatus+ "',@Contract_Amount='" + vr_ContractAmount + "',@Contract_Currency='" + vr_ContractCurrency + "'";
            Db_Query.ExecuteNonQuery();
            //vr_Context.Response.Write("<script lang='JavaScript'> alert ('Sözleşme Eklendi.');</script>");
            Db_Connection.Close();

        }

        public void Contract_Update(string vr_ContactID,string vr_ContractNo, string vr_ContractStart, string vr_ContractFinish, string vr_HandingDate, string vr_VehiclePlate, int vr_CustomerCode, string vr_CustomerTitle, string vr_CustomerAuthorized, string vr_TelephoneNo, string vr_EMail, string vr_CustomerRepresentative,int vr_ContractAmount,string vr_ContractCurrency, HttpContext vr_Context)
        {
            Db_Connection.Open();
            Db_Query.Connection = Db_Connection;
            Db_Query.CommandText = "Exec ContractUpdate @Contact_ID='"+vr_ContactID+"', @Contract_No='" + vr_ContractNo + "',@Contract_Start='" + vr_ContractStart + "',@Contract_Finish='" + vr_ContractFinish + "',@Handing_Date='" + vr_HandingDate + "',@Vehicle_Plate='" + vr_VehiclePlate + "',@Customer_Code='" + vr_CustomerCode + "',@Customer_Title='" + vr_CustomerTitle + "',@Customer_Authorized='" + vr_CustomerAuthorized + "',@Telephone_No='" + vr_TelephoneNo + "',@E_Mail='" + vr_EMail + "',@Customer_Representative='" + vr_CustomerRepresentative + "',@Contract_Amount='"+vr_ContractAmount+ "',@Contract_Currency='"+vr_ContractCurrency+"'";
            Db_Query.ExecuteNonQuery();
            vr_Context.Response.Write("<script lang='JavaScript'> alert ('Sözleşme Güncellendi.');</script>");
            Db_Connection.Close();

        }

        public void Contract_Del(string vr_ContactID, HttpContext vr_Context)
        {
            Db_Connection.Open();
            Db_Query.Connection = Db_Connection;
            Db_Query.CommandText = "Exec ContractDel @Contact_ID='" + vr_ContactID + "'";
            Db_Query.ExecuteNonQuery();
            vr_Context.Response.Write("<script lang='JavaScript'> alert ('Sözleşme Silindi.');</script>");
            Db_Connection.Close();

        }

        public void Contract_List_VehicleFilter(GridView dt_ContractListGrd, string vr_ContractCode, string vr_ContractNo)
        {
            Db_Table = new DataTable();
            Db_Table.Clear();
            Db_Connection.Open();
            Db_Adapter = new SqlDataAdapter("Exec ContractFilter @Contract_Code='" + vr_ContractCode + "',@Contract_No='" + vr_ContractNo + "'", Db_Connection);
            Db_Adapter.Fill(Db_Table);
            dt_ContractListGrd.DataSource = Db_Table;
            dt_ContractListGrd.DataBind();
            Db_Connection.Close();

        }
    }
}