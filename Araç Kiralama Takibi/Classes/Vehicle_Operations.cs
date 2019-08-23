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
        public string P_VehicleLicenseNo { get; set; }
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
    }
}