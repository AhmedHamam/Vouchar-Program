namespace Vouchar_Program
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Vouchers = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Employee = new DevExpress.XtraEditors.SimpleButton();
            this.btn_VoucherTypes = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btn_Vouchers
            // 
            this.btn_Vouchers.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn_Vouchers.Appearance.Options.UseFont = true;
            this.btn_Vouchers.ImageOptions.SvgImage = global::Vouchar_Program.Properties.Resources.bo_note;
            this.btn_Vouchers.Location = new System.Drawing.Point(243, 61);
            this.btn_Vouchers.Name = "btn_Vouchers";
            this.btn_Vouchers.Size = new System.Drawing.Size(131, 62);
            this.btn_Vouchers.TabIndex = 1;
            this.btn_Vouchers.Text = "Vouchers";
            this.btn_Vouchers.Click += new System.EventHandler(this.Btn_Vouchers_Click);
            // 
            // btn_Employee
            // 
            this.btn_Employee.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn_Employee.Appearance.Options.UseFont = true;
            this.btn_Employee.ImageOptions.Image = global::Vouchar_Program.Properties.Resources.Employee_32x32;
            this.btn_Employee.Location = new System.Drawing.Point(86, 61);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(124, 62);
            this.btn_Employee.TabIndex = 0;
            this.btn_Employee.Text = "Employee";
            this.btn_Employee.Click += new System.EventHandler(this.Btn_Employee_Click);
            // 
            // btn_VoucherTypes
            // 
            this.btn_VoucherTypes.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn_VoucherTypes.Appearance.Options.UseFont = true;
            this.btn_VoucherTypes.ImageOptions.SvgImage = global::Vouchar_Program.Properties.Resources.bo_note;
            this.btn_VoucherTypes.Location = new System.Drawing.Point(429, 61);
            this.btn_VoucherTypes.Name = "btn_VoucherTypes";
            this.btn_VoucherTypes.Size = new System.Drawing.Size(185, 62);
            this.btn_VoucherTypes.TabIndex = 2;
            this.btn_VoucherTypes.Text = "Vouchers Types";
            this.btn_VoucherTypes.Click += new System.EventHandler(this.Btn_VoucherTypes_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 427);
            this.Controls.Add(this.btn_VoucherTypes);
            this.Controls.Add(this.btn_Vouchers);
            this.Controls.Add(this.btn_Employee);
            this.Name = "Frm_Main";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Employee;
        private DevExpress.XtraEditors.SimpleButton btn_Vouchers;
        private DevExpress.XtraEditors.SimpleButton btn_VoucherTypes;
    }
}