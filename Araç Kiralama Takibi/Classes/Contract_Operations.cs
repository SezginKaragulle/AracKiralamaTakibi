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
    }
}