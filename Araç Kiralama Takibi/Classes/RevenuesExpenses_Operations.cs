﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Araç_Kiralama_Takibi.Classes
{
    public class RevenuesExpenses_Operations:DbConnection
    {
        public string P_Voucher_Date { get; set; }

        public string P_Voucher_Explanation { get; set; }

        public int P_Voucher_Amount { get; set; }

        public string P_Voucher_Currency { get; set; }

        public string P_Voucher_CreditDebt { get; set; }

        public int P_Voucher_PositionCode { get; set; }

        public void RevenuesExpenses_List(GridView dt_RevenuesExpensesListGrd)
        {
            Db_Table = new DataTable();
            Db_Table.Clear();
            Db_Connection.Open();
            Db_Adapter = new SqlDataAdapter("Select * From RevenuesExpensesList", Db_Connection);
            Db_Adapter.Fill(Db_Table);
            dt_RevenuesExpensesListGrd.DataSource = Db_Table;
            dt_RevenuesExpensesListGrd.DataBind();
            Db_Connection.Close();


        }

        public void RevenuesExpenses_Add(string vr_VoucherDate, string vr_VoucherExplanation, int vr_VoucherAmount,string vr_VoucherCurrency,string vr_VoucherCreditDebt,int vr_VoucherPositionCode, HttpContext vr_Context)
        {
            Db_Connection.Open();
            Db_Query.Connection = Db_Connection;
            Db_Query.CommandText = "Exec RevenuesExpensesAdd @Voucher_Date='"+vr_VoucherDate+ "',@Voucher_Explanation='"+vr_VoucherExplanation+ "',@Voucher_Amount='"+vr_VoucherAmount+ "',@Voucher_Currency='"+vr_VoucherCurrency+ "',@Voucher_CreditDebt='"+vr_VoucherCreditDebt+ "',@Voucher_PositionCode='"+vr_VoucherPositionCode+"'";
            Db_Query.ExecuteNonQuery();
            vr_Context.Response.Write("<script lang='JavaScript'> alert ('Fiş Eklendi.');</script>");
            Db_Connection.Close();

        }

        public void RevenuesExpenses_Update(string vr_VoucherNumber,string vr_VoucherDate, string vr_VoucherExplanation, int vr_VoucherAmount, string vr_VoucherCurrency, string vr_VoucherCreditDebt, int vr_VoucherPositionCode, HttpContext vr_Context)
        {
            Db_Connection.Open();
            Db_Query.Connection = Db_Connection;
            Db_Query.CommandText = "Exec RevenuesExpensesUpdate @Voucher_Number='"+vr_VoucherNumber+"',@Voucher_Date='" + vr_VoucherDate + "',@Voucher_Explanation='" + vr_VoucherExplanation + "',@Voucher_Amount='" + vr_VoucherAmount + "',@Voucher_Currency='" + vr_VoucherCurrency + "',@Voucher_CreditDebt='" + vr_VoucherCreditDebt + "',@Voucher_PositionCode='" + vr_VoucherPositionCode + "'";
            Db_Query.ExecuteNonQuery();
            vr_Context.Response.Write("<script lang='JavaScript'> alert ('Fiş Güncellendi.');</script>");
            Db_Connection.Close();

        }

        public void RevenuesExpenses_Delete(string vr_VoucherNumber, HttpContext vr_Context)
        {
            Db_Connection.Open();
            Db_Query.Connection = Db_Connection;
            Db_Query.CommandText = "Exec RevenuesExpensesDel @Voucher_Number='" + vr_VoucherNumber + "'";
            Db_Query.ExecuteNonQuery();
            vr_Context.Response.Write("<script lang='JavaScript'> alert ('Fiş Silindi.');</script>");
            Db_Connection.Close();

        }

        public void RevenuesExpenses_Filter(GridView dt_RevenuesExpensesListGrd, string vr_VoucherNumber, string vr_VoucherExplanation)
        {
            Db_Table = new DataTable();
            Db_Table.Clear();
            Db_Connection.Open();
            Db_Adapter = new SqlDataAdapter("Exec RevenuesExpensesFilter @Voucher_Number='" + vr_VoucherNumber + "',@Voucher_Explanation='"+vr_VoucherExplanation+"'", Db_Connection);
            Db_Adapter.Fill(Db_Table);
            dt_RevenuesExpensesListGrd.DataSource = Db_Table;
            dt_RevenuesExpensesListGrd.DataBind();
            Db_Connection.Close();


        }


    }
}