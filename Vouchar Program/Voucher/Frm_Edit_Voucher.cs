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
using Cheque_Printing_Program;

namespace Vouchar_Program
{
    public partial class Frm_Edit_Vouchers : DevExpress.XtraEditors.XtraForm
    {
        LinqDataContext linq;
        public Frm_Edit_Vouchers()
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
            Voucher_ID.Text = "";
            amountTextEdit.Text = "";
            Cheque_BankTextEdit.Text = "";
            Cheque_NoTextEdit.Text = "";
            Cheque_dateDateEdit.Text = DateTime.Now.ToShortDateString();
            Payment_Way.SelectedIndex = 0;
            var employee = (from emp in linq.Tb_HrEmps
                      where emp.Is_deleted == false
                      select new { emp.EmpNo, emp.FullNameArab, emp.FullNameEng, emp.IqamaNo }).ToList();
            Emp_No.Properties.DataSource = employee;
            Emp_No.Properties.DisplayMember = "EmpNo";
            Emp_No.Properties.ValueMember = "EmpNo";
            var voucher = (from vr in linq.Tb_Vouchers
                           select new {vr.Id,
                           EmpName=vr.EmployeeName.FullNameArab ,
                           RequstedBy=vr.RequstedBy.FullNameArab,
                           ApprovedBy=vr.AprrovedBy.FullNameArab,
                           RecivedBy=vr.RecivedBy.FullNameArab,
                           });
            Voucher_ID.Properties.DataSource = voucher;
            var types = (from type in linq.Vouchers_Types select new { type.id, type.Type });
            Voucher_Type.Properties.DataSource = types;
            Voucher_Type.Properties.DisplayMember = "Type";
            Voucher_Type.Properties.ValueMember = "id";
            Request_Date.Text = DateTime.Now.ToShortDateString();
            Recived_Date.Text = DateTime.Now.ToShortDateString();
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
                Voucher_ID.Text = "V" + Emp_No.Text + count;
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
            if (Voucher_ID.Text == "")
            {
                MessageBox.Show("please Select the employee First");
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
                voucher.Id = Voucher_ID.Text;
                voucher.Is_Approved = false;
                voucher.Is_deleted = false;
                voucher.Is_Receved = true;
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
                voucher.Payment_Way = Payment_Way.Text;
                voucher.Amount = Convert.ToDecimal(amountTextEdit.Text);
            }
            return voucher;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (check_input())
            {
                linq.Tb_Vouchers.InsertOnSubmit(getvoucher());
                linq.SubmitChanges();
                MessageBox.Show("Voucher Saved Successfully");
                Load_form();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
