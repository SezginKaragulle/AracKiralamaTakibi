﻿using System;
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
            Db_User_Update();
        }



    }
}