using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading;
using System.Timers;

namespace AracKiralamaWindowsService
{
    public partial class AracKiramalaServis : ServiceBase
    {
        //public SqlConnection Db_Connection = null;

        //public SqlCommand Db_Query = null;
        //public SqlDataAdapter Db_Adapter = null;
        //public SqlDataReader Db_DataReader = null;
        //public DataTable Db_Table = null;
        
      
        public AracKiramalaServis()
        {
            //Db_Connection = new SqlConnection(@"Data Source=.;Initial Catalog=DBAracKiralama;Integrated Security=True");
            //Db_Query = new SqlCommand();
            //Db_Table = new DataTable();
            InitializeComponent();
        }

        //public void Db_User_Update()
        //{


        //    try
        //    {
        //        Console.WriteLine("Servis Başladı.");
        //        System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", "İşlem Başladı");
        //        Db_Connection.Open();
        //        Db_Query.Connection = Db_Connection;
        //        Db_Query.CommandText = "Update UsersList Set UserNameSurName = 'Sezgin Karagülle' Where UserId = 1";
        //        Db_Query.ExecuteNonQuery();
        //        Db_Connection.Close();

        //        System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", "İşlem Bitti");
        //    }
        //    catch (Exception ex)
        //    {
        //        System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", ex.Message + " " + ex.StackTrace);
        //    }
        //}
        InnerOperation obj = new InnerOperation();
        protected override void OnStart(string[] args)
        {
            obj.Start();
        }

        protected override void OnStop()
        {
            obj.Stop();
        }
    }
}
