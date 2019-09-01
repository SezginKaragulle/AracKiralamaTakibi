using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Araç_Kiralama_Takibi
{
    public partial class GelirGiderYonetimi : System.Web.UI.Page
    {
        Classes.RevenuesExpenses_Operations RevenuesExpenses_Operations = new Classes.RevenuesExpenses_Operations();
        private int Vr_Selected_Row;
    
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RevenuesExpenses_Operations.RevenuesExpenses_List(grdRevenuesExpensesList);
                Session.Add("Vr_VoucherNumber", "");
                Session.Add("Vr_VoucherDate", "");
                Session.Add("Vr_VoucherExplanation", "");
                Session.Add("Vr_VoucherAmount", "");
                Session.Add("Vr_VoucherCurrency", "");
                Session.Add("Vr_VoucherCreditDebt", "");
                Session.Add("Vr_VoucherPositionCode", "");
            }
        }

        protected void grdRevenuesExpensesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vr_Selected_Row = grdRevenuesExpensesList.SelectedIndex;
            GridViewRow row = grdRevenuesExpensesList.Rows[Vr_Selected_Row];
            Session["Vr_VoucherNumber"] = row.Cells[1].Text;
            Session["Vr_VoucherDate"] = row.Cells[2].Text;
            Session["Vr_VoucherExplanation"] = row.Cells[3].Text;
            Session["Vr_VoucherAmount"] = row.Cells[4].Text;
            Session["Vr_VoucherCurrency"] = row.Cells[5].Text;
            Session["Vr_VoucherCreditDebt"] = row.Cells[6].Text;
            Session["Vr_VoucherPositionCode"] = row.Cells[7].Text;
        }

        protected void grdRevenuesExpensesList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdRevenuesExpensesList.PageIndex = e.NewPageIndex;
            RevenuesExpenses_Operations.RevenuesExpenses_List(grdRevenuesExpensesList);
        }

        protected void btnRevenuesExpensesUpdate_Click(object sender, EventArgs e)
        {
            if (Session["Vr_VoucherNumber"].ToString() == "")
            {
                Response.Write("<script lang='JavaScript'> alert ('Fiş Seçmelisiniz.');</script>");
            }
            else if (Session["Vr_VoucherPositionCode"].ToString() == "2")
            {
                Response.Write("<script lang='JavaScript'> alert ('Fiş Sözleşme Kaydına Ait Buradan Güncellenemez.');</script>");
            }
            else
            {
                Session.Add("Vr_Data", "RevenuesExpensesUpdate");
                Response.Redirect("GelirGiderEkleGuncelle.aspx");
            }
        }

        protected void btnRevenuesExpensesDel_Click(object sender, EventArgs e)
        {
            if (Session["Vr_VoucherNumber"].ToString() == "")
            {
                Response.Write("<script lang='JavaScript'> alert ('Fiş Seçmelisiniz.');</script>");
            }
            else if (Session["Vr_VoucherPositionCode"].ToString() == "2")
            {
                Response.Write("<script lang='JavaScript'> alert ('Fiş Sözleşme Kaydına Ait Buradan Silinemez.');</script>");
            }
            else
            {
                RevenuesExpenses_Operations.RevenuesExpenses_Delete(Session["Vr_VoucherNumber"].ToString(), this.Context);
                RevenuesExpenses_Operations.RevenuesExpenses_List(grdRevenuesExpensesList);
                Response.Redirect("GelirGiderYonetimi.aspx");
            }
        }

        protected void btnRevenuesExpensesAdd_Click(object sender, EventArgs e)
        {
            Session.Add("Vr_Data", "RevenuesExpensesAdd");
            Response.Redirect("GelirGiderEkleGuncelle.aspx");
        }

        protected void btnRevenuesExpensesSearch_Click(object sender, EventArgs e)
        {
            RevenuesExpenses_Operations.RevenuesExpenses_Filter(grdRevenuesExpensesList, txtVoucherNumber.Text, txtVoucherExplanation.Text);
            txtVoucherNumber.Text = "";
            txtVoucherExplanation.Text = "";
        }
    }
}