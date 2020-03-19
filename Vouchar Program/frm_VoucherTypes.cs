using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Vouchar_Program.Voucher;

namespace Vouchar_Program
{
    public partial class Frm_VoucherTypes : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        LinqDataContext linq;
        public Frm_VoucherTypes()
        {
            InitializeComponent();
            linq = new LinqDataContext();
        }
        List<Vouchers_Type> types;
        private void Frm_VoucherTypes_Load(object sender, EventArgs e)
        {
            types= (from t in linq.Vouchers_Types select t).ToList();
            gridControl1.DataSource =types;
            ReadOnly();
        }
        private void ReadOnly()
        {
            gridView1.Columns[0].OptionsColumn.ReadOnly = true;
            gridView1.Columns[1].OptionsColumn.ReadOnly = true;
            gridView1.Columns[2].OptionsColumn.ReadOnly = true;
        }
        private void Allow_Edit()
        {
            gridView1.Columns[1].OptionsColumn.ReadOnly = false;
            gridView1.Columns[2].OptionsColumn.ReadOnly = false;
        }
        private void Bbtn_Add_ItemClick(object sender, ItemClickEventArgs e)
        {
            Vouchers_Type v = new Vouchers_Type();
            if (types.Count > 0)
            {
                v.id = types[types.Count - 1].id + 1;
            }
            else
            {
                v.id =  1;
            }
            v.deducted_from_salary = true;
            v.Type = "Voucher";
            types.Add(v);
            Allow_Edit();
            gridView1.Columns[0].OptionsColumn.ReadOnly = true;
            gridView1.RefreshData();
        }
        private void Bbtn_Edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Allow_Edit();
        }
        private void Bbtnprint_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
        private void Bbtn_Save_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView1.PostEditor();
            gridView1.RefreshData();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                var x = (from t in linq.Vouchers_Types
                         where t.id == types[i].id
                         select t).SingleOrDefault() ;
                if (x != null)
                {
                    x.deducted_from_salary =Convert.ToBoolean( gridView1.GetRowCellValue(i, "deducted_from_salary"));
                    x.id =Convert.ToInt32( gridView1.GetRowCellDisplayText(i, "id"));
                    x.Type =Convert.ToString( gridView1.GetRowCellDisplayText(i, "Type"));
                    linq.SubmitChanges();
                }
                else
                {
                    linq.Vouchers_Types.InsertOnSubmit(types[i]);
                    linq.SubmitChanges();
                }
            }
            MessageBox.Show("Saved Successfully");
        }
        private void Bbtn_Delete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var x = (from t in linq.Vouchers_Types
                     where t.id ==int.Parse (gridView1.GetFocusedRowCellDisplayText("id"))
                     select t).SingleOrDefault();
            if (x != null)
            {
                linq.Vouchers_Types.DeleteOnSubmit(x);
                linq.SubmitChanges();
            }
            gridView1.DeleteSelectedRows();
            MessageBox.Show("Deleted Successfully");
        }
    }
}