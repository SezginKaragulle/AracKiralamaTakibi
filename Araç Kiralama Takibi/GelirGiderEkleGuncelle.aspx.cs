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
        string Date_Control; 
    
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
                    DateTime dt = Convert.ToDateTime(Session["Vr_VoucherDate"]);
                    txtVoucherNumber.Visible = true;
                    Label1.Visible = true;
                    btnRevenuesExpensesAdded.Text = "Güncelle";
                    txtVoucherNumber.Text = Session["Vr_VoucherNumber"].ToString();
                    txtVoucherDate.Text = dt.ToString("yyyy-MM-dd");
                    txtVoucherExplanation.Text = Session["Vr_VoucherExplanation"].ToString();
                    txtVoucherAmount.Text = Session["Vr_VoucherAmount"].ToString();
                    drpVoucherCurrency.Items[0].Text = Session["Vr_VoucherCurrency"].ToString();
                    drpVoucherCreditDebt.Items[0].Text = Session["Vr_VoucherCreditDebt"].ToString();

                }
            }
           
        }

    

        protected void btnRevenuesExpensesExit_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("GelirGiderYonetimi.aspx");
        }

        protected void btnRevenuesExpensesAdded_Click(object sender, EventArgs e)
        {
            DateTime today = Convert.ToDateTime(txtVoucherDate.Text);
            RevenuesExpenses_Operations.P_Voucher_Date = txtVoucherDate.Text;
            RevenuesExpenses_Operations.P_Voucher_Explanation = txtVoucherExplanation.Text;
            RevenuesExpenses_Operations.P_Voucher_Amount = int.Parse(txtVoucherAmount.Text);
            RevenuesExpenses_Operations.P_Voucher_Currency = drpVoucherCurrency.Text;
            RevenuesExpenses_Operations.P_Voucher_CreditDebt = drpVoucherCreditDebt.Text;
            RevenuesExpenses_Operations.P_Voucher_PositionCode = 1;
            if (btnRevenuesExpensesAdded.Text == "Ekle")
            {

                if (today > DateTime.Now.Date)
                {
                    Response.Write("<script lang='JavaScript'> alert ('Fiş Tarihi Günün Tarihinden Büyük Olamaz.');</script>");
                }
                else
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
            else if (btnRevenuesExpensesAdded.Text == "Güncelle")
            {
                if (today > DateTime.Now.Date)
                {
                    Response.Write("<script lang='JavaScript'> alert ('Fiş Tarihi Günün Tarihinden Büyük Olamaz.');</script>");
                }
                else
                {
                    RevenuesExpenses_Operations.RevenuesExpenses_Update(txtVoucherNumber.Text.Trim(), RevenuesExpenses_Operations.P_Voucher_Date, RevenuesExpenses_Operations.P_Voucher_Explanation, RevenuesExpenses_Operations.P_Voucher_Amount, RevenuesExpenses_Operations.P_Voucher_Currency, RevenuesExpenses_Operations.P_Voucher_CreditDebt, RevenuesExpenses_Operations.P_Voucher_PositionCode, this.Context);
                }
              
            }
        }
    }
}