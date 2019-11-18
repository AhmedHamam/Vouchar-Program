using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace Vouchar_Program.Voucher
{
    public partial class Frm_Employees : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        LinqDataContext linq;
        public Frm_Employees()
        {
            InitializeComponent();
            linq = new LinqDataContext(Properties.Settings.Default.ConnectionString);
        }
        private void Refrech_Data(object sender, EventArgs e)
        {
            load_data();
        }
        public void load_data()
        {
            txt_Emp_Name.Text = "";
            txt_Emp_no.Text = "";
            txt_iqama_no.Text = "";
            var emps = (from emp in linq.Tb_HrEmps
                        where emp.Is_deleted == false
                        select new { emp.EmpNo, emp.FullNameArab,
                                     emp.FullNameEng, emp.IqamaNo
                                    }).ToList();
            gridControl.DataSource = emps;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowPrintPreview();
        }
        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Add_Employee frm = new Frm_Add_Employee();
            frm.Show();
            frm.FormClosed += Refrech_Data;
        }
        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Edit_Employee frm = new Frm_Edit_Employee();
            frm.Show();
            frm.FormClosed += Refrech_Data;
        }
        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var gv = gridControl.MainView as GridView;
            var index = gv.FocusedRowHandle;
            string emp_no = gv.GetRowCellValue(index, "EmpNo").ToString();
            string emp_Name= gv.GetRowCellValue(index, "FullNameEng").ToString();
           DialogResult Dr= MessageBox.Show( "Do you Want to delete this employee ("+emp_Name+")", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (Dr == DialogResult.Yes)
            {
                Tb_HrEmp Tb_HrEmps = (from emp in linq.Tb_HrEmps
                                     where emp.EmpNo == emp_no
                                     select emp).SingleOrDefault();
                Tb_HrEmps.Is_deleted = true;
                linq.SubmitChanges();
                MessageBox.Show(emp_Name+" deleted Successfly");
                load_data();
            }
        }
        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_data();
        }
        private void Frm_Employees_Load(object sender, EventArgs e)
        {
            load_data();
        }
        private void txt_Emp_no_EditValueChanged(object sender, EventArgs e)
        {
            var emps = (from emp in linq.Tb_HrEmps
                        where emp.Is_deleted == false  && emp.EmpNo.Contains(txt_Emp_no.Text)&&
                       ( emp.FullNameEng.Contains(txt_Emp_Name.Text)|| emp.FullNameArab.Contains(txt_Emp_Name.Text)) 
                       && emp.IqamaNo.Contains(txt_iqama_no.Text)
                        select new { emp.EmpNo, emp.FullNameArab,
                                     emp.FullNameEng, emp.IqamaNo
                                   }).ToList();
            gridControl.DataSource = emps;
        }
        private void txt_Emp_Name_EditValueChanged(object sender, EventArgs e)
        {
            var emps = (from emp in linq.Tb_HrEmps
                        where emp.Is_deleted == false &&
                       (emp.FullNameEng.Contains(txt_Emp_Name.Text) || emp.FullNameArab.Contains(txt_Emp_Name.Text))
                        select new { emp.EmpNo, emp.FullNameArab, emp.FullNameEng, emp.IqamaNo }).ToList();
            gridControl.DataSource = emps;
        }
        private void txt_iqama_no_EditValueChanged(object sender, EventArgs e)
        {
            var emps = (from emp in linq.Tb_HrEmps
                        where emp.Is_deleted == false && 
                        emp.IqamaNo.Contains(txt_iqama_no.Text)
                        select new { emp.EmpNo, emp.FullNameArab, emp.FullNameEng, emp.IqamaNo }).ToList();
            gridControl.DataSource = emps;
        }
    }
}