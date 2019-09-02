using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.Timers;


namespace AracKiralamaWindowsService
{
    public class InnerOperation
    {
        public SqlConnection Db_Connection = new SqlConnection(@"Data Source=.;Initial Catalog=DBAracKiralama;Integrated Security=True");

        public SqlCommand Db_Query = new SqlCommand();
        public SqlDataAdapter Db_Adapter = null;
        public SqlDataReader Db_DataReader = null;
        public DataTable Db_Table = new DataTable();

        System.Timers.Timer timer = new System.Timers.Timer();
        private int Last_Counts;
        public void Db_User_Update()
        {
            try
            {
                Console.WriteLine("Servis Başladı.");
                System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", "İşlem Başladı");
                Db_Connection.Open();
                Db_Query.Connection = Db_Connection;
                Db_Query.CommandText = "Update UsersList Set UserNameSurName = 'Sezgin Karagülle' Where UserId = 1";
                Db_Query.ExecuteNonQuery();
                Db_Connection.Close();

                System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", "İşlem Bitti");
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", ex.Message + " " + ex.StackTrace);
            }
        }

        public void Contract_Vehicle_Update()
        {
             try
            {
                Console.WriteLine("Servis Başladı.");
                System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", "İşlem Başladı");
                Db_Connection.Open();
                Db_Query.Connection = Db_Connection;
                Db_Query.CommandText = "exec Contract_Count @Update_Time=''";
                Db_DataReader = Db_Query.ExecuteReader();
                while (Db_DataReader.Read())
                {
                    Last_Counts = int.Parse(Db_DataReader[0].ToString());

                }
                string[] plakalar = new string[Last_Counts];
                SqlCommand VehiclePlate = new SqlCommand();
                VehiclePlate.Connection = Db_Connection;
                VehiclePlate.CommandText = "select VehiclePlate from ContractsList";
                Db_DataReader = VehiclePlate.ExecuteReader();
                while (Db_DataReader.Read())
                {
                    for (int i = 0; i < Last_Counts; i++)
                    {
                        plakalar[i] = Db_DataReader[0].ToString();
                        SqlCommand Vehicle_Update = new SqlCommand();
                        Vehicle_Update.Connection = Db_Connection;
                        Vehicle_Update.CommandText = "UPDATE VehicleList SET VehicleStatus='Uygun' Where VehiclePlate='" + plakalar[i].ToString() + "'";
                        Vehicle_Update.ExecuteNonQuery();
                    }

                }
                SqlCommand Contract_Update = new SqlCommand();
                Contract_Update.Connection = Db_Connection;
                Contract_Update.CommandText = "exec Contract_Count @Update_Time='Evet'";
                Contract_Update.ExecuteNonQuery();
                Db_Connection.Close();
                Db_DataReader.Close();


                System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", "İşlem Bitti");
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", ex.Message + " " + ex.StackTrace);
            }
        }
       
        public void Start()
        {
            
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 60000;
            timer.Enabled = true;
        }
        public void Stop()
        {
            Console.WriteLine("Servis Durduruldu");
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            //Db_User_Update();
            Contract_Vehicle_Update();
        }



    }
}
