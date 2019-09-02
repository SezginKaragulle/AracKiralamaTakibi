using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Araç_Kiralama_Takibi
{
    public partial class SozlesmeYonetimi : System.Web.UI.Page
    {
        Classes.Contract_Operations Contract_Operations = new Classes.Contract_Operations();
        Classes.RevenuesExpenses_Operations RevenuesExpenses_Operations = new Classes.RevenuesExpenses_Operations();
        private int Vr_Selected_Row;
        private string LastVoucher;
        public void LastVoucherNumber_Search()
        {
            Contract_Operations.Db_Connection.Open();
            Contract_Operations.Db_Query.Connection = Contract_Operations.Db_Connection;
            Contract_Operations.Db_Query.CommandText = "SELECT top 1 VoucherNumber FROM RevenuesExpensesList ORDER BY VoucherNumber DESC";
            Contract_Operations.Db_DataReader = Contract_Operations.Db_Query.ExecuteReader();
            while (Contract_Operations.Db_DataReader.Read())
            {
                LastVoucher = Contract_Operations.Db_DataReader[0].ToString();
            }
            Contract_Operations.Db_Connection.Close();
            Contract_Operations.Db_DataReader.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                Contract_Operations.Contract_List(grdContractsList);
                Session.Add("Vr_ContractID", "");
                Session.Add("Vr_ContractNo", "");
                Session.Add("Vr_ContractStart", "");
                Session.Add("Vr_ContractFinish", "");
                Session.Add("Vr_HandingDate", "");
                Session.Add("Vr_VehiclePlate", "");
                Session.Add("Vr_CustomerCode", "");
                Session.Add("Vr_CustomerTitle", "");
                Session.Add("Vr_CustomerAuthorized", "");
                Session.Add("Vr_TelephoneNo", "");
                Session.Add("Vr_EMail", "");
                Session.Add("Vr_CustomerRepresentative", "");
                Session.Add("Vr_AccountingStatus", "");
                Session.Add("Vr_VoucherNo", "");
                Session.Add("Vr_ContractStatus", "");
                Session.Add("Vr_ContractAmount", "");
                Session.Add("Vr_ContractCurrency", "");
            }
        }

        protected void btnContractAdd_Click(object sender, EventArgs e)
        {
            Session.Add("Vr_Data", "ContractAdd");
            Response.Redirect("SozlesmeEkleGuncelle.aspx");
        }

        protected void grdContractsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vr_Selected_Row = grdContractsList.SelectedIndex;
            GridViewRow row = grdContractsList.Rows[Vr_Selected_Row];
            Session["Vr_ContractID"] = row.Cells[1].Text;
            Session["Vr_ContractNo"] = row.Cells[2].Text;
            Session["Vr_ContractStart"] = row.Cells[3].Text;
            Session["Vr_ContractFinish"] = row.Cells[4].Text;
            Session["Vr_HandingDate"] = row.Cells[5].Text;
            Session["Vr_VehiclePlate"] = row.Cells[6].Text;
            Session["Vr_CustomerCode"] = row.Cells[7].Text;
            Session["Vr_CustomerTitle"] = row.Cells[8].Text;
            Session["Vr_CustomerAuthorized"] = row.Cells[9].Text;
            Session["Vr_TelephoneNo"] = row.Cells[10].Text;
            Session["Vr_EMail"] = row.Cells[11].Text;
            Session["Vr_CustomerRepresentative"] = row.Cells[12].Text;
            Session["Vr_AccountingStatus"] = row.Cells[13].Text;
            Session["Vr_VoucherNo"] = row.Cells[14].Text;
            Session["Vr_ContractStatus"] = row.Cells[15].Text;
            Session["Vr_ContractAmount"] = row.Cells[16].Text;
            Session["Vr_ContractCurrency"] = row.Cells[17].Text;
            if (Session["Vr_AccountingStatus"].ToString() == "E")
            {
                btnVoucherSend.Text = "Geri Al";
            }
            else
            {
                btnVoucherSend.Text = "Mahsup";
            }
            //if (Session["Vr_ContractStatus"].ToString() == "Aktif")
            //{
            //    btnContractActivePas.Text = "Pasif";
            //}
            //else if (Session["Vr_ContractStatus"].ToString() == "Pasif")
            //{
            //    btnContractActivePas.Text = "Aktif";
            //}
        }

        protected void btnContractUpdate_Click(object sender, EventArgs e)
        {
            if (Session["Vr_ContractNo"].ToString() == "")
            {
                Response.Write("<script lang='JavaScript'> alert ('Sözleşme Seçmelisiniz.');</script>");
            }
            else if (Session["Vr_AccountingStatus"].ToString() == "E")
            {
                Response.Write("<script lang='JavaScript'> alert ('Muhasebe Kaydı Olduğundan Güncellenemez.');</script>");
            }
            else
            {
                Session.Add("Vr_Data", "ContractUpdate");
                Response.Redirect("SozlesmeEkleGuncelle.aspx");

            }
        }

        protected void btnContractDel_Click(object sender, EventArgs e)
        {
            if (Session["Vr_ContractNo"].ToString() == "")
            {
                Response.Write("<script lang='JavaScript'> alert ('Sözleşme Seçmelisiniz.');</script>");
            }
            else if (Session["Vr_AccountingStatus"].ToString() == "E")
            {
                Response.Write("<script lang='JavaScript'> alert ('Muhasebe Kaydı Olduğundan Silinemez.');</script>");
            }
            else
            {
                Contract_Operations.Query_Send("UPDATE VehicleList SET VehicleStatus='Uygun' Where VehiclePlate='" + Session["Vr_VehiclePlate"].ToString() + "'");
                Contract_Operations.Contract_Del(Session["Vr_ContractID"].ToString(), this.Context);
                Response.Redirect("SozlesmeYonetimi.aspx");
            }
        }

        protected void grdContractsList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdContractsList.PageIndex = e.NewPageIndex;
            Contract_Operations.Contract_List(grdContractsList);
        }

        protected void btnVoucherSend_Click(object sender, EventArgs e)
        {
            if (Session["Vr_ContractNo"].ToString() == "")
            {
                Response.Write("<script lang='JavaScript'> alert ('Sözleşme Seçmelisiniz.');</script>");
            }
            else
            {
                if (btnVoucherSend.Text == "Mahsup")
                {
                    RevenuesExpenses_Operations.P_Voucher_Date = DateTime.Now.ToShortDateString();
                    RevenuesExpenses_Operations.P_Voucher_Explanation = "Sözleşme Geliri: "+Session["Vr_ContractNo"].ToString();
                    RevenuesExpenses_Operations.P_Voucher_Amount = int.Parse(Session["Vr_ContractAmount"].ToString());
                    RevenuesExpenses_Operations.P_Voucher_Currency = Session["Vr_ContractCurrency"].ToString();
                    RevenuesExpenses_Operations.P_Voucher_CreditDebt = "Alacak";
                    RevenuesExpenses_Operations.P_Voucher_PositionCode = 2;

                    RevenuesExpenses_Operations.RevenuesExpenses_Add(RevenuesExpenses_Operations.P_Voucher_Date, RevenuesExpenses_Operations.P_Voucher_Explanation, RevenuesExpenses_Operations.P_Voucher_Amount, RevenuesExpenses_Operations.P_Voucher_Currency, RevenuesExpenses_Operations.P_Voucher_CreditDebt, RevenuesExpenses_Operations.P_Voucher_PositionCode, this.Context);
                    LastVoucherNumber_Search();
                    Contract_Operations.Query_Send("UPDATE ContractsList SET AccountingStatus='E',VoucherNo='" + int.Parse(LastVoucher) + "' Where ContractID='" + Session["Vr_ContractID"].ToString() + "'");
                    Response.Redirect("SozlesmeYonetimi.aspx");
                }
                else if (btnVoucherSend.Text == "Geri Al")
                {
                    
                    Contract_Operations.Query_Send("UPDATE ContractsList SET AccountingStatus='H',VoucherNo= 0 WHERE ContractID='" + Session["Vr_ContractID"].ToString() + "'");
                    RevenuesExpenses_Operations.RevenuesExpenses_Delete(Session["Vr_VoucherNo"].ToString(), this.Context);
                    Response.Redirect("SozlesmeYonetimi.aspx");
                }
            }
        }

        protected void btnContractSearch_Click(object sender, EventArgs e)
        {
            Contract_Operations.Contract_List_VehicleFilter(grdContractsList, txtContractCode.Text, txtContractNo.Text);
            txtContractCode.Text = "";
            txtContractNo.Text = "";
        }

        protected void btnContractActivePas_Click(object sender, EventArgs e)
        {
            if (Session["Vr_ContractNo"].ToString() == "")
            {
                Response.Write("<script lang='JavaScript'> alert ('Sözleşme Seçmelisiniz.');</script>");
            }
            else if (Session["Vr_ContractStatus"].ToString() == "Pasif")
            {
                Response.Write("<script lang='JavaScript'> alert ('Sözleşme Durumu Aktif Olmalı.');</script>");
            }
            else
            {
                Contract_Operations.Query_Send("Update VehicleList SET VehicleStatus='Uygun' Where VehiclePlate='" + Session["Vr_VehiclePlate"].ToString() + "'");
                Contract_Operations.Query_Send("Update ContractsList SET ContractStatus='Pasif' Where ContractID='" + Session["Vr_ContractID"].ToString() + "'");
                Response.Redirect("SozlesmeYonetimi.aspx");
            }
        }
    }
}