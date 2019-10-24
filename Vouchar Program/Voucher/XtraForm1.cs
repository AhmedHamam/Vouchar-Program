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
    public partial class XtraForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public XtraForm1()
        {
            InitializeComponent();
            Voucher.LinqVoucherDataContext linq = new LinqVoucherDataContext(Properties.Settings.Default.ConnectionString);
            var voucher = (from v in linq.STblVouchers
                           
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
            //BindingList<Voucher.STblVoucher> dataSource = voucher;
            
            gridControl.DataSource = voucher;
            bsiRecordsCount.Caption = "RECORDS : " + voucher.Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        public BindingList<Customer> GetDataSource()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            result.Add(new Customer()
            {
                ID = 1,
                Name = "ACME",
                Address = "2525 E El Segundo Blvd",
                City = "El Segundo",
                State = "CA",
                ZipCode = "90245",
                Phone = "(310) 536-0611"
            });
            result.Add(new Customer()
            {
                ID = 2,
                Name = "Electronics Depot",
                Address = "2455 Paces Ferry Road NW",
                City = "Atlanta",
                State = "GA",
                ZipCode = "30339",
                Phone = "(800) 595-3232"
            });
            return result;
        }
        public class Customer
        {
            [Key, Display(AutoGenerateField = false)]
            public int ID { get; set; }
            [Required]
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            [Display(Name = "Zip Code")]
            public string ZipCode { get; set; }
            public string Phone { get; set; }
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }
    }
}