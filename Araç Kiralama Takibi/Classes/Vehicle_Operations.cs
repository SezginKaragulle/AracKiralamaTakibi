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
    public class Vehicle_Operations:DbConnection
    {
        public string P_Vehicle_Plate { get; set; }
        public string P_Vehicle_TradeMark { get; set; }
        public string P_VehicleModel { get; set; }
        public string P_VehicleType { get; set; }
        public string P_VehicleYear { get; set; }
        public string P_VehicleColor { get; set; }
        public string P_VehicleGear { get; set; }
        public string P_VehicleEnginePower { get; set; }
        public string P_VehicleVolume { get; set; }
        public string P_VehicleFuelType { get; set; }
        public int P_VehicleLicenseNo { get; set; }
        public string P_VehicleStatus { get; set; }

        public void Vehicle_List(GridView dt_VehiclesListGrd)
        {
            Db_Table = new DataTable();
            Db_Table.Clear();
            Db_Connection.Open();
            Db_Adapter = new SqlDataAdapter("Select * From VehicleList", Db_Connection);
            Db_Adapter.Fill(Db_Table);
            dt_VehiclesListGrd.DataSource = Db_Table;
            dt_VehiclesListGrd.DataBind();
            Db_Connection.Close();


        }

        public void Vehicle_Add(string vr_VehiclePlate,string vr_VehicleTradeMark,string vr_VehicleModel,string vr_VehicleType,string vr_VehicleYear,string vr_VehicleColor,string vr_VehicleGear,string vr_VehicleEnginePower,string vr_VehicleEngineVolume,string vr_VehicleFuelType,int vr_VehicleLicenseNo,string vr_VehicleStatus,HttpContext vr_Context)
        {
            Db_Connection.Open();
            Db_Query.Connection = Db_Connection;
            Db_Query.CommandText = "Exec VehicleAdd @Vehicle_Plate='"+vr_VehiclePlate+ "',@Vehicle_TradeMark='" + vr_VehicleTradeMark + "',@Vehicle_Model='"+vr_VehicleModel+ "',@Vehicle_Type='"+vr_VehicleType+ "',@Vehicle_Year='"+vr_VehicleYear+ "',@Vehicle_Color='"+vr_VehicleColor+ "',@Vehicle_Gear='"+vr_VehicleGear+ "',@Vehicle_EnginePower='"+vr_VehicleEnginePower+ "',@Vehicle_EngineVolume='"+vr_VehicleEngineVolume+ "',@Vehicle_FuelType='"+vr_VehicleFuelType+ "',@Vehicle_LicenseNo='"+vr_VehicleLicenseNo+ "',@Vehicle_Status='"+vr_VehicleStatus+"'";
            Db_Query.ExecuteNonQuery();
            vr_Context.Response.Write("<script lang='JavaScript'> alert ('Araç Eklendi.');</script>");
            Db_Connection.Close();

        }

        public void Vehicle_Update(string vr_VehicleCode,string vr_VehiclePlate, string vr_VehicleTradeMark, string vr_VehicleModel, string vr_VehicleType, string vr_VehicleYear, string vr_VehicleColor, string vr_VehicleGear, string vr_VehicleEnginePower, string vr_VehicleEngineVolume, string vr_VehicleFuelType, int vr_VehicleLicenseNo, string vr_VehicleStatus, HttpContext vr_Context)
        {
            Db_Connection.Open();
            Db_Query.Connection = Db_Connection;
            Db_Query.CommandText = "Exec VehicleUpdate @Vehicle_Code='" + vr_VehicleCode+"', @Vehicle_Plate='" + vr_VehiclePlate + "',@Vehicle_TradeMark='" + vr_VehicleTradeMark + "',@Vehicle_Model='" + vr_VehicleModel + "',@Vehicle_Type='" + vr_VehicleType + "',@Vehicle_Year='" + vr_VehicleYear + "',@Vehicle_Color='" + vr_VehicleColor + "',@Vehicle_Gear='" + vr_VehicleGear + "',@Vehicle_EnginePower='" + vr_VehicleEnginePower + "',@Vehicle_EngineVolume='" + vr_VehicleEngineVolume + "',@Vehicle_FuelType='" + vr_VehicleFuelType + "',@Vehicle_LicenseNo='" + vr_VehicleLicenseNo + "',@Vehicle_Status='" + vr_VehicleStatus + "'";
            Db_Query.ExecuteNonQuery();
            vr_Context.Response.Write("<script lang='JavaScript'> alert ('Araç Güncellendi.');</script>");
            Db_Connection.Close();

        }

        public void Vehicle_Delete(string vr_VehicleCode, HttpContext vr_Context)
        {
            Db_Connection.Open();
            Db_Query.Connection = Db_Connection;
            Db_Query.CommandText = "exec VehicleDelete @Vehicle_Code='" + vr_VehicleCode + "'";
            Db_Query.ExecuteNonQuery();
            vr_Context.Response.Write("<script lang='JavaScript'> alert ('Araç Silindi.');</script>");
            Db_Connection.Close();

        }
        public void Vehicle_List_VehicleFilter(GridView dt_VehiclesListGrd, string vr_VehicleCode, string vr_VehiclePlate)
        {
            Db_Table = new DataTable();
            Db_Table.Clear();
            Db_Connection.Open();
            Db_Adapter = new SqlDataAdapter("Exec VehicleFilter @Vehicle_Code='" + vr_VehicleCode + "',@Vehicle_Plate='" + vr_VehiclePlate + "'", Db_Connection);
            Db_Adapter.Fill(Db_Table);
            dt_VehiclesListGrd.DataSource = Db_Table;
            dt_VehiclesListGrd.DataBind();
            Db_Connection.Close();

        }
    }
}