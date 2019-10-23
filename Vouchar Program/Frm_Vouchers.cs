using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vouchar_Program
{
    public partial class Frm_Vouchers : DevExpress.XtraEditors.XtraForm
    {
        LinqVoucherDataContext linq;
        public Frm_Vouchers()
        {
            InitializeComponent();
            linq = new LinqVoucherDataContext(Properties.Settings.Default.ConnectionString);
        }

        private void Frm_Vouchers_Load(object sender, EventArgs e)
        {
            List<object> li = (from emp in linq.View_Emps select emp).ToList<object>();
            Emp_No.Properties.DataSource= li;
            Emp_No.Properties.DisplayMember = "EmpNo";
            Emp_No.Properties.ValueMember = "EmpNo";
            //Emp_Name.Properties.EditFormat
        }

        private void Emp_No_EditValueChanged(object sender, EventArgs e)
        {
            Voucher_ID.Properties.ShowAddNewButton = true;
            var voucher = (from v in linq.STblVouchers
                           where v.Emp_Id == Emp_No.Text
                           select
                         new
                         {
                             v.Voucher_id,
                             v.TblHrEmp.FullNameEng,
                             v.amount,
                             v.Emp_Id,
                             v.Payment_Date,
                             v.Payment_Way,
                             v.type,
                             v.Recived_Date,
                             v.is_Cheque,
                             v.Cheque_Bank,
                             v.Cheque_date,
                             v.Cheque_No
                         }).ToList();
            Emp_Name.Text = Emp_No.Properties.View.GetFocusedRowCellValue("FullNameEng").ToString();
            Iqama_no.Text = Emp_No.Properties.View.GetFocusedRowCellValue("IqamaNo").ToString();
            Voucher_ID.Properties.DataSource = voucher;
            Voucher_ID.Properties.DisplayMember = "Voucher_id";
            Voucher_ID.Properties.ValueMember = "Voucher_id";
        }

        private void Voucher_ID_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (Voucher_ID.Properties.DataSource != null)
            {
                Voucher_ID.Properties.View.Columns["Payment_Date"].Visible = false;
                Voucher_ID.Properties.View.Columns["Payment_Way"].Visible = false;
                Voucher_ID.Properties.View.Columns["Recived_Date"].Visible = false;
                Voucher_ID.Properties.View.Columns["is_Cheque"].Visible = false;
                Voucher_ID.Properties.View.Columns["Cheque_date"].Visible = false;
                Voucher_ID.Properties.View.Columns["Cheque_Bank"].Visible = false;
                Voucher_ID.Properties.View.Columns["Cheque_No"].Visible = false;
                Voucher_ID.Properties.View.Columns["Voucher_id"].Caption = "Voucher No ";
                Voucher_ID.Properties.View.Columns["FullNameEng"].Caption = "Employee Name";
            }
            else
            {
                if (Emp_No.Text=="")
                {
                    MessageBox.Show("Please Select Employee");
                }
                else
                {
                    MessageBox.Show("this Employee dosenot have any vouchers  ");
                }
            }
        }

        private void Voucher_ID_EditValueChanged(object sender, EventArgs e)
        {
            ////DataRow row = Voucher_ID.Properties.View.GetRow(Voucher_ID.Properties.GetIndexByKeyValue(Voucher_ID.EditValue))as DataRow;
            //DataRow row = Voucher_ID.Properties.View.GetFocusedDataRow();
            //MessageBox.Show(Voucher_ID.Properties.View.GetFocusedRowCellValue("FullNameEng").ToString());

            Payment_Way.Text = Voucher_ID.Properties.View.GetFocusedRowCellValue("Payment_Way")!= null ? Voucher_ID.Properties.View.GetFocusedRowCellValue("Payment_Way").ToString()  : "";
            Voucher_Type.Text = Voucher_ID.Properties.View.GetFocusedRowCellValue("type")!= null ? Voucher_ID.Properties.View.GetFocusedRowCellValue("type").ToString()  : "";
            Payment_Date.Text = Voucher_ID.Properties.View.GetFocusedRowCellValue("Payment_Date")!= null ? Voucher_ID.Properties.View.GetFocusedRowCellValue("Payment_Date").ToString().Substring(0,10)  : "";
            Recived_Date.Text = Voucher_ID.Properties.View.GetFocusedRowCellValue("Recived_Date")!= null ? Voucher_ID.Properties.View.GetFocusedRowCellValue("Recived_Date").ToString().Substring(0, 10) : "";
            Cheque_dateDateEdit.Text = Voucher_ID.Properties.View.GetFocusedRowCellValue("Cheque_date")!= null ? Voucher_ID.Properties.View.GetFocusedRowCellValue("Cheque_date").ToString().Substring(0, 10) : "";
            Cheque_BankTextEdit.Text = Voucher_ID.Properties.View.GetFocusedRowCellValue("Cheque_Bank")!= null ? Voucher_ID.Properties.View.GetFocusedRowCellValue("Cheque_Bank").ToString()  : "";
            Cheque_NoTextEdit.Text = Voucher_ID.Properties.View.GetFocusedRowCellValue("Cheque_No")!= null ? Voucher_ID.Properties.View.GetFocusedRowCellValue("Cheque_No").ToString()  : "";
            amountTextEdit.Text = Voucher_ID.Properties.View.GetFocusedRowCellValue("amount")!= null ? Voucher_ID.Properties.View.GetFocusedRowCellValue("amount").ToString()  : "";
            if (Convert.ToBoolean(Voucher_ID.Properties.View.GetFocusedRowCellValue("is_Cheque") != null ? Voucher_ID.Properties.View.GetFocusedRowCellValue("is_Cheque").ToString()  : "False"))
            {
                layout_Cheque.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layout_Cheque.Expanded = true;
            }
            else
            {
                layout_Cheque.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layout_Cheque.Expanded = false;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (btn_Edit.Text == "Edit")
            {
                Payment_Date.Enabled = true;
                Recived_Date.Enabled = true;
                Payment_Way.Enabled = true;
                Voucher_Type.Enabled = true;
                Cheque_BankTextEdit.Enabled = true;
                Cheque_dateDateEdit.Enabled = true;
                Cheque_NoTextEdit.Enabled = true;
                amountTextEdit.Enabled = true;
                btn_Edit.Text = "Cancl";
            }
            else
            {
                Recived_Date.Enabled = false;
                Payment_Date.Enabled = false;
                Payment_Way.Enabled = false;
                Voucher_Type.Enabled = false;
                Cheque_BankTextEdit.Enabled = false;
                Cheque_dateDateEdit.Enabled = false;
                Cheque_NoTextEdit.Enabled = false;
                amountTextEdit.Enabled = false;
                btn_Edit.Text = "Edit";
            }

        }
    }
}
