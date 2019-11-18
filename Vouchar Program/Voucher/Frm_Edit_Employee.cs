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
    public partial class Frm_Edit_Employee : DevExpress.XtraEditors.XtraForm
    {
        LinqDataContext linq;
        public Frm_Edit_Employee()
        {
            linq = new LinqDataContext(Properties.Settings.Default.ConnectionString);
            InitializeComponent();
        }
        private void Loadagain()
        {
            var li = (from emp in linq.Tb_HrEmps
                      where emp.Is_deleted == false
                      select new { emp.EmpNo, emp.FullNameArab, emp.FullNameEng, emp.IqamaNo }).ToList();
            Emp_No.Properties.DataSource = li;
            Emp_No.Properties.DisplayMember = "EmpNo";
            Emp_No.Properties.ValueMember = "EmpNo";
            Emp_No.Text = "";
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
            if (Emp_No.Text == "")
            {
                MessageBox.Show("please Select an employee  ");
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
            if (check_input())
            {

                Tb_HrEmp emp = (Tb_HrEmp)(from x in linq.Tb_HrEmps
                               where x.EmpNo== Emp_No.Text
                               select x).SingleOrDefault();
                emp.FullNameArab = FullNameArabTextEdit.Text;
                emp.FullNameEng = FullNameEngTextEdit.Text;
                emp.IqamaNo = IqamaNoTextEdit.Text;
                linq.SubmitChanges();
                MessageBox.Show(" Employee Updated Successfully");
                Loadagain();
            }
        }

        private void Frm_Edit_Employee_Load(object sender, EventArgs e)
        {
            Loadagain();
        }
        private void Emp_No_EditValueChanged(object sender, EventArgs e)
        {
            if (Emp_No.Text != "")
            {
                FullNameArabTextEdit.Text = Emp_No.Properties.View.GetFocusedRowCellValue("FullNameArab").ToString();
                FullNameEngTextEdit.Text = Emp_No.Properties.View.GetFocusedRowCellValue("FullNameEng").ToString();
                IqamaNoTextEdit.Text= Emp_No.Properties.View.GetFocusedRowCellValue("IqamaNo").ToString();
            }
        }
    }
}
