using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Cheque_Printing_Program;

namespace Vouchar_Program
{
    public partial class rpVoucher : DevExpress.XtraReports.UI.XtraReport
    {
        public rpVoucher()
        {
            InitializeComponent();
        }

        private void AmountDesc_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ToWord toWord = new ToWord(Convert.ToDecimal(Amount.Value), new CurrencyInfo());
            AmountAr.Text = toWord.ConvertToArabic();
        }

        private void cb_Cash_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (P_way.Text == "Cash")
            {
                //P_way.Text = "";
                //cb_Cash.Checked = true;
            }
        }
    }
}
