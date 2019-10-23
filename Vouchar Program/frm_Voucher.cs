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
    public partial class frm_Voucher : Form
    {
        LinqVoucherDataContext linq;
        public frm_Voucher()
        {
            InitializeComponent();
            linq = new LinqVoucherDataContext(Properties.Settings.Default.ConnectionString);
        }

        private void frm_Voucher_Load(object sender, EventArgs e)
        {
            var dt = linq.View_Emps.Select(row=>row);
            searchLookUpEdit1.Properties.NullText = " ";
            searchLookUpEdit1.Properties.DataSource = dt.ToList();
            searchLookUpEdit2.Properties.DataSource = dt.ToList();
            searchLookUpEdit1.Properties.DisplayMember = "FullNameArab";
            searchLookUpEdit2.Properties.DisplayMember = "FullNameArab";

        }
    }
}
