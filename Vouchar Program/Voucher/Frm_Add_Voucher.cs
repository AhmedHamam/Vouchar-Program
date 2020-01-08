using Cheque_Printing_Program;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vouchar_Program.Voucher;

namespace Vouchar_Program
{
    public partial class Frm_Add_Vouchers : DevExpress.XtraEditors.XtraForm
    {
        LinqDataContext linq;
        public Frm_Add_Vouchers()
        {
           
            InitializeComponent();
            linq = new LinqDataContext(Properties.Settings.Default.ConnectionString);
        }
        private void Load_form()
        {
            Emp_No.Text = "";
            Emp_Name.Text = "";
            Iqama_no.Text = "";
            Voucher_Type.Text="";
            Voucher_Serial.Text = "";
            txt_VoucherId.Text = "";
            amountTextEdit.Text = "";
            Cheque_BankTextEdit.Text = "";
            Cheque_NoTextEdit.Text = "";
            Cheque_dateDateEdit.Text = DateTime.Now.ToShortDateString();
            Payment_Way.SelectedIndex = 0;
            var li = (from emp in linq.Tb_HrEmps
                      where emp.Is_deleted == false
                      select new { emp.EmpNo, emp.FullNameArab, emp.FullNameEng, emp.IqamaNo }).ToList();
            Emp_No.Properties.DataSource = li;
            Emp_No.Properties.DisplayMember = "EmpNo";
            Emp_No.Properties.ValueMember = "EmpNo";
            var types = (from type in linq.Vouchers_Types select new { type.id, type.Type,type.deducted_from_salary }).ToList();
            Voucher_Type.Properties.DataSource = types;
            Voucher_Type.Properties.DisplayMember = "Type";
            Voucher_Type.Properties.ValueMember = "id";
          
            Request_Date.Text = DateTime.Now.ToShortDateString();
            Recived_Date.Text = DateTime.Now.ToShortDateString();
            var countOfRows = linq.Tb_Vouchers.Count();
            Tb_Voucher lastRow =null;
            if (countOfRows > 0)
            {
                 lastRow = linq.Tb_Vouchers.OrderBy(c => 1 == 1).Skip(countOfRows - 1).FirstOrDefault();
            }
            amountTextEdit.Text = "0";
            if (lastRow != null)
            {
                Voucher_Serial.Text = (lastRow.Serial + 1).ToString();
            }
            else
            {
                Voucher_Serial.Text = "1";
            }
            for (int i = 0; i < gridView2.RowCount;)
                gridView2.DeleteRow(i);
            //var v_id =(from v in linq.Tb_Vouchers
            //            where v.Emp_Id == Emp_No.Text
            //            select v).ToList().Count;
            //txt_VoucherId.Text = Emp_No.Text + "V_" + (v_id+1);
            //MessageBox.Show(linq.Tb_Vouchers.LongCount().ToString());
        }
        private void Frm_Vouchers_Load(object sender, EventArgs e)
        {
            Load_form();
        }
        private void Emp_No_EditValueChanged(object sender, EventArgs e)
        {
            if (Emp_No.Text != "")
            {
                Emp_Name.Text = Emp_No.Properties.View.GetFocusedRowCellValue("FullNameEng").ToString();
                Iqama_no.Text = Emp_No.Properties.View.GetFocusedRowCellValue("IqamaNo").ToString();
                var count = (from v in linq.Tb_Vouchers
                             where v.Emp_Id == Emp_No.Text
                             select v).Count();
                txt_VoucherId.Text =  Emp_No.Text + "_V" + (count+1);
            }
        }
        private void Payment_Way_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Payment_Way.SelectedItem.ToString() == "Cheque")
            {
                ItemForCheque_No.Enabled = true;
                ItemForCheque_Bank.Enabled = true;
                ItemForCheque_date.Enabled = true;
                layout_Cheque.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                ItemForCheque_No.Enabled = false;
                ItemForCheque_Bank.Enabled = false;
                ItemForCheque_date.Enabled = false;
                layout_Cheque.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }
        private void amountTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (amountTextEdit.Text != "")
            {
                ToWord toWord = new ToWord(Convert.ToDecimal(amountTextEdit.Text), new CurrencyInfo());
                txt_amount_ar_word.Text = toWord.ConvertToArabic();
                txt_amount_En_word.Text = toWord.ConvertToEnglish();
            }
            else
            {
                txt_amount_ar_word.Text = "";
                txt_amount_En_word.Text = "";
            }
        }
        private bool check_input()
        {
            if (txt_VoucherId.Text == "")
            {
                MessageBox.Show("please Select the employee First");
                return false;
            }
            if (Voucher_Serial.Text == "")
            {
                //MessageBox.Show("please Select the employee First");
                return false;
            }
            if (amountTextEdit.Text == "")
            {
                MessageBox.Show("please The Amount of the Voucher");
                return false;
            }
            if (Voucher_Type.Text == "")
            {
                MessageBox.Show("please Select the Voucher Type");
                return false;
            }
            return true;
        }
        private Tb_Voucher getvoucher()
        {
            Tb_Voucher voucher = new Tb_Voucher();
            if (check_input())
            {
                voucher.Id = txt_VoucherId.Text;
                voucher.Is_Approved = false;
                voucher.Is_deleted = false;
                voucher.Is_Receved = true;
                voucher.Type = Voucher_Type.Text;
                voucher.Emp_Id = Emp_No.Text;
                voucher.Requsted_By = Emp_No.Text;
                voucher.Recived_By = Emp_No.Text;
                voucher.Payment_Way = Payment_Way.Text;
                voucher.Requste_Date = Convert.ToDateTime(Request_Date.Text);
                voucher.Recived_Date = Convert.ToDateTime(Recived_Date.Text);
                if (Payment_Way.SelectedItem.ToString() == "Cheque")
                {
                    voucher.Is_Cheque = true;
                    voucher.Cheque_Date = Convert.ToDateTime(Cheque_dateDateEdit.Text);
                    voucher.Cheque_No = Cheque_NoTextEdit.Text;
                    voucher.Cheque_Bank = ItemForCheque_Bank.Text;
                }
                else
                {
                    voucher.Is_Cheque = false;
                }
              //  voucher.deducted_from_salary = (bool)Voucher_Type.Properties.View.GetFocusedRowCellValue("deducted_from_salary");
                voucher.Amount = Convert.ToDecimal( amountTextEdit.Text);
            }
            return voucher;
        }
        private  void get_insttalment()
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                Tb_Installment installment = new Tb_Installment();
                installment.Canceled = false;
                installment.is_deleted = false;
                installment.is_Repayment = false;
                installment.Repayment_Date = Convert.ToDateTime(gridView2.GetRowCellDisplayText(i, "Repayment_Date"));
                installment.Amount = Convert.ToDecimal(gridView2.GetRowCellDisplayText(i, "Amount"));
                installment.v_id = Convert.ToInt64(Voucher_Serial.Text);
                linq.Tb_Installments.InsertOnSubmit(installment);
                linq.SubmitChanges();
            }
        }
        private bool check_installamount()
        {
            long Amount=0;
            for (int i = 0; i<gridView2.RowCount; i++)
            {
                if (gridView2.GetRowCellDisplayText(i, "Amount") != "")
                {
                    Amount += Convert.ToInt64(gridView2.GetRowCellDisplayText(i, "Amount"));
                }
                else
                {
                    MessageBox.Show("Don't leave empty cell in instalments tabel");
                    return false;
                }
            }
            if (Convert.ToInt64(amountTextEdit.Text) == Amount)
                return true;
            return false;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            if (check_input())
            {
                if (check_installamount())
                {
                    linq.Tb_Vouchers.InsertOnSubmit(getvoucher());
                    linq.SubmitChanges();
                    get_insttalment();
                    MessageBox.Show("Voucher Saved Successfully");
                    rpVoucher rp_vocher = new rpVoucher();
                    var x =(from I in linq.View_Installments
                     where I.v_id == Int64.Parse(Voucher_Serial.Text)
                     select I).ToList();
                    MessageBox.Show(x.Count.ToString());
                    rp_vocher.DataSource = x;
                    rp_vocher.ShowPreview();
                    //ReportPrintTool printTool = new ReportPrintTool(rp_vocher);
                    //printTool.ShowRibbonPreview();
                    Load_form();
                }
                else
                {
                    MessageBox.Show("Sum of installments amount must equal Voucher Amount");
                }

                
                //    Load_form();
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //rpVoucher rp_vocher = new rpVoucher();

            //rp_vocher.DataSource = (from I in linq.View_Installments
            //                        where I.v_id == Int64.Parse(Voucher_Serial.Text) - 1
            //                        select I);
            //rp_vocher.DataSource = (from I in linq.Tb_Installments
            //                        join V in linq.Tb_Vouchers on I.v_id equals V.Serial
            //                        join E in linq.Tb_HrEmps on V.==
            //                        where v.v_id == int.Parse( Voucher_Serial.Text)
            //                        select new
            //                        {
            //                            v.Amount, v.Repayment_Date,v.Tb_Vouchers.Select
            //                        }
            //                         ).ToList();
           // rp_vocher.ShowPreview();
            //Close();
        }

        private void btn_Add_installment_Click(object sender, EventArgs e)
        {
            gridView2.AddNewRow();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            gridView2.DeleteSelectedRows();
            if(gridView2.RowCount>0)
            installment--;
        }
        int installment = 1;
        private void gridView2_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView2.DataRowCount > 0)
            {
                view.SetRowCellValue(e.RowHandle, view.Columns["Repayment_Date"], AddMonthsCustom(Convert.ToDateTime(gridView2.GetRowCellDisplayText(0, "Repayment_Date")), installment++));
                view.SetRowCellValue(e.RowHandle, view.Columns["Amount"], 0);
            }
            else
            {
                view.SetRowCellValue(e.RowHandle, view.Columns["Repayment_Date"], DateTime.Now);
                view.SetRowCellValue(e.RowHandle, view.Columns["Amount"], amountTextEdit.Text);
            }
            gridView1.PostEditor();
            gridView1.RefreshData();
        }
        public  DateTime AddMonthsCustom(DateTime date, int months)
        {

            // Check if we are done quickly.
            if (months == 0)
                return date;

            // Lookup the target month and its last day.
            var targetMonth = new DateTime(date.Year, date.Month, 1).AddMonths(months);
            var lastDay = DateTime.DaysInMonth(targetMonth.Year, targetMonth.Month);

            // If we are starting out on the last day of the current month, then jump
            // to the last day of the target month.
            if (date.Day == DateTime.DaysInMonth(date.Year, date.Month))
                return new DateTime(targetMonth.Year, targetMonth.Month, lastDay);

            // If the target month cannot accomodate the current day, jump to the 
            // last day of the target month.
            if (date.Day > lastDay)
                return new DateTime(targetMonth.Year, targetMonth.Month, lastDay);

            // Simply jump to the current day in the target month.
            return new DateTime(targetMonth.Year, targetMonth.Month, date.Day);
        }
        private void amountTextEdit_Validated(object sender, EventArgs e)
        {
            if (gridView2.DataRowCount < 1)
            {
                gridView2.AddNewRow();
            }
            else
            {
                gridView2.SetRowCellValue(0, gridView2.Columns["Amount"], amountTextEdit.Text);
            }
            gridView1.PostEditor();
            gridView1.RefreshData();
        }
    }
}
