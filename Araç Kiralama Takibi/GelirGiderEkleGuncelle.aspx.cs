using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Araç_Kiralama_Takibi
{
    public partial class GelirGiderEkleGuncelle : System.Web.UI.Page
    {
        Classes.RevenuesExpenses_Operations RevenuesExpenses_Operations = new Classes.RevenuesExpenses_Operations();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Vr_Data"].ToString() == "RevenuesExpensesAdd")
            {
                txtVoucherNumber.Visible = false;
                Label1.Visible = false;
                txtVoucherNumber.Text = "";
                txtVoucherDate.Text = "";
                txtVoucherExplanation.Text = "";
                txtVoucherAmount.Text = "";
                drpVoucherCurrency.Text = "";
                drpVoucherCreditDebt.Text = "";
                btnRevenuesExpensesAdded.Text = "Ekle";
               
            }
            else if (Session["Vr_Data"].ToString() == "RevenuesExpensesUpdate")
            {
                txtVoucherNumber.Visible = true;
                Label1.Visible = true;
                btnRevenuesExpensesAdded.Text = "Güncelle";
                txtVoucherDate.Text = Session["Vr_VoucherDate"].ToString();

            }
           
        }

    

        protected void btnRevenuesExpensesExit_Click(object sender, EventArgs e)
        {
            txtVoucherNumber.Text = "";
            txtVoucherDate.Text = "";
            txtVoucherExplanation.Text = "";
            txtVoucherAmount.Text = "";
            drpVoucherCurrency.Text = "";
            drpVoucherCreditDebt.Text = "";
            Response.Redirect("GelirGiderYonetimi.aspx");
        }

        protected void btnRevenuesExpensesAdded_Click(object sender, EventArgs e)
        {
            RevenuesExpenses_Operations.P_Voucher_Date = DateTime.Parse(txtVoucherDate.Text);
            RevenuesExpenses_Operations.P_Voucher_Explanation = txtVoucherExplanation.Text;
            RevenuesExpenses_Operations.P_Voucher_Amount = int.Parse(txtVoucherAmount.Text);
            RevenuesExpenses_Operations.P_Voucher_Currency = drpVoucherCurrency.Text;
            RevenuesExpenses_Operations.P_Voucher_CreditDebt = drpVoucherCreditDebt.Text;
            RevenuesExpenses_Operations.P_Voucher_PositionCode = 1;
            if (btnRevenuesExpensesAdded.Text == "Ekle")
            {
                RevenuesExpenses_Operations.RevenuesExpenses_Add(RevenuesExpenses_Operations.P_Voucher_Date, RevenuesExpenses_Operations.P_Voucher_Explanation, RevenuesExpenses_Operations.P_Voucher_Amount, RevenuesExpenses_Operations.P_Voucher_Currency, RevenuesExpenses_Operations.P_Voucher_CreditDebt, RevenuesExpenses_Operations.P_Voucher_PositionCode, this.Context);
                txtVoucherNumber.Text = "";
                txtVoucherDate.Text = "";
                txtVoucherExplanation.Text = "";
                txtVoucherAmount.Text = "";
                drpVoucherCurrency.Text = "";
                drpVoucherCreditDebt.Text = "";
            }
        }
    }
}