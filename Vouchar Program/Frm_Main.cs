using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Vouchar_Program.Voucher;
namespace Vouchar_Program
{
    public partial class Frm_Main : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Employee_Click(object sender, EventArgs e)
        {
            Frm_Employees frm = new Frm_Employees();
            frm.Show();
        }

        private void Btn_Vouchers_Click(object sender, EventArgs e)
        {
            Frm_Vouchers frm = new Frm_Vouchers();
            frm.Show();
        }

        private void Btn_VoucherTypes_Click(object sender, EventArgs e)
        {
            Frm_VoucherTypes frm = new Frm_VoucherTypes();
            frm.Show();
        }
    }
}