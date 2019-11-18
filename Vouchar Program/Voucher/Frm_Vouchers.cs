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

namespace Vouchar_Program.Voucher
{
    public partial class Frm_Vouchers : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        LinqDataContext linq;
        private void Load_Data()
        {
            var voucher = (from v in linq.Tb_Vouchers
                           select
                         new
                         {
                             v.Id,
                             v.EmployeeName.FullNameEng,
                             v.Amount,
                             v.Requste_Date,
                             v.Payment_Way,
                             v.Type,
                         }).ToList();
            gridControl.DataSource = voucher;
        }
        public Frm_Vouchers()
        {
            InitializeComponent();
            linq = new LinqDataContext(Properties.Settings.Default.ConnectionString);
            Load_Data();
        }
        private void frm_closed(object sender, EventArgs e)
        {
            Load_Data();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Add_Vouchers frm = new Frm_Add_Vouchers();
            frm.Show();
            frm.FormClosed += frm_closed;
        }
        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Edit_Vouchers frm = new Frm_Edit_Vouchers();
            frm.Show();
            frm.FormClosed += frm_closed;
        }
        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Load_Data();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {

        }
        private void Emp_IdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (Emp_IdTextEdit.Text != "")
            {
                var voucher = (from v in linq.Tb_Vouchers
                               where v.Is_deleted == false && v.Emp_Id == Emp_IdTextEdit.Text
                               select new
                               {
                                   v.Serial,
                                   v.Id,
                                   v.EmployeeName.FullNameEng,
                                   v.Amount,
                                   v.Requste_Date,
                                   v.Payment_Way,
                                   v.Type
                               }).ToList();
                gridControl.DataSource = voucher;
            }
            else
            {
                Load_Data();
            }
        }
        private void Voucher_idTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (Voucher_idTextEdit.Text != "")
            {
                var voucher = (from v in linq.Tb_Vouchers
                               where v.Is_deleted == false && v.Id == Voucher_idTextEdit.Text
                               select new
                               {
                                   v.Id,
                                   v.EmployeeName.FullNameEng,
                                   v.Amount,
                                   v.Requste_Date,
                                   v.Payment_Way,
                                   v.Type
                               }).ToList();
                gridControl.DataSource = voucher;
            }
            else
            {
                Load_Data();
            }

        }

        private void Frm_Vouchers_Load(object sender, EventArgs e)
        {

        }

        private void bbtn_ShowVoucher_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}