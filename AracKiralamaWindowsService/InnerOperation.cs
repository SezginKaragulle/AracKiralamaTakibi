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
        string[] plakalar;
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

        public void Contract_Count()
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
                Db_DataReader.Close();
                Db_Connection.Close();

                System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", "İşlem Bitti");
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", ex.Message + " " + ex.StackTrace);
            }
        }

        public void Vehicle_Search()
        {
            try
            {
                plakalar = new string[Last_Counts];
                Console.WriteLine("Servis Başladı.");
                System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", "İşlem Başladı");
                Db_Connection.Open();
                Db_Query.Connection = Db_Connection;
                Db_Query.CommandText = "select VehiclePlate from ContractsList Where ContractStatus='Aktif' ";
                Db_DataReader = Db_Query.ExecuteReader();
                while (Db_DataReader.Read())
                {
                    //Last_Counts = int.Parse(Db_DataReader[0].ToString());
                    for (int i = 1; i < Last_Counts; i++)
                    {
                        plakalar[i] = Db_DataReader[0].ToString();
                    }

                }
                Db_DataReader.Close();
                Db_Connection.Close();

                System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", "İşlem Bitti");
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", ex.Message + " " + ex.StackTrace);
            }
        }

        public void Vehicle_Update()
        {
            try
            {
                Console.WriteLine("Servis Başladı.");
                System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", "İşlem Başladı");
                Db_Connection.Open();
                Db_Query.Connection = Db_Connection;
                for (int i = 0; i < plakalar.Length; i++)
                {
                    
                    Db_Query.CommandText = "UPDATE VehicleList SET VehicleStatus = 'Uygun' Where VehiclePlate ='"+plakalar[i].ToString()+"'";
                    Db_Query.ExecuteNonQuery();
                }
             
                Db_Connection.Close();

                System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", "İşlem Bitti");
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", ex.Message + " " + ex.StackTrace);
            }
        }

        public void Contract_Update()
        {
            try
            {
                Console.WriteLine("Servis Başladı.");
                System.IO.File.AppendAllText(@"C:\temp\hataservis.txt", "İşlem Başladı");
                Db_Connection.Open();
                Db_Query.Connection = Db_Connection;
                Db_Query.CommandText = "exec Contract_Count @Update_Time='Evet'";
                Db_Query.ExecuteNonQuery();
                Db_Connection.Close();

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
            Contract_Count();
            Vehicle_Search();
            Vehicle_Update();
            Contract_Update();
           
        }



    }
}
