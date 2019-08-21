using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Araç_Kiralama_Takibi.Classes
{
    public class DbConnection
    {
        public  SqlConnection Db_Connection = new SqlConnection(@"Data Source=.;Initial Catalog=DBAracKiralama;Integrated Security=True");
        public  SqlCommand Db_Query = new SqlCommand();
        public  SqlDataAdapter Db_Adapter;
        public  SqlDataReader Db_DataReader;
        public  DataTable Db_Table = new DataTable();
    }
}