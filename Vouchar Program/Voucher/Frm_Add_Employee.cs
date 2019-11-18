using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Vouchar_Program.Voucher;

namespace Vouchar_Program
{
    public partial class Frm_Add_Employee : DevExpress.XtraEditors.XtraForm
    {
        LinqDataContext linq;
        public Frm_Add_Employee()
        {
            InitializeComponent();
            linq = new LinqDataContext(Properties.Settings.Default.ConnectionString);
            Loadagain();
        }
        private void Loadagain()
        {
            EmpNoTextEdit.Text = "";
            FullNameArabTextEdit.Text = "";
            FullNameEngTextEdit.Text = "";
            IqamaNoTextEdit.Text = "";
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool check_input()
        {
            if (EmpNoTextEdit.Text == "")
            {
                MessageBox.Show("Enter Employee Number Please ");
                return false;
            }
            if (FullNameArabTextEdit.Text == "")
            {
                MessageBox.Show("Enter Arabic Name of the employee Please ");
                return false;
            }
            if (FullNameEngTextEdit.Text == "")
            {
                MessageBox.Show("Enter English Name of the employee Please ");
                return false;
            }
            if (IqamaNoTextEdit.Text == "")
            {
                MessageBox.Show("Enter Iqamaa number of the employee Please ");
                return false;
            }
            return true;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            LinqDataContext linq = new LinqDataContext(Properties.Settings.Default.ConnectionString);
            Voucher.Tb_HrEmp   emp = new Voucher.Tb_HrEmp();
            emp.EmpNo = EmpNoTextEdit.Text;
            emp.FullNameArab = FullNameArabTextEdit.Text;
            emp.FullNameEng = FullNameArabTextEdit.Text;
            emp.IqamaNo = FullNameArabTextEdit.Text;
            emp.Is_deleted = false;
            linq.Tb_HrEmps.InsertOnSubmit(emp);
            linq.SubmitChanges();
            MessageBox.Show("New Employee Added Successfully");
            Loadagain();
        }
        private void EmpNoTextEdit_Leave(object sender, EventArgs e)
        {
            var count = (from emp in linq.Tb_HrEmps
                         where emp.EmpNo == EmpNoTextEdit.Text
                         select emp).Count();
            if (count > 0)
            {
                MessageBox.Show("The Emp No must be unique ");
                EmpNoTextEdit.Text = "";
                EmpNoTextEdit.Focus();
            }
        }
    }
}
