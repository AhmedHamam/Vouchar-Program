namespace Vouchar_Program
{
    partial class frm_VoucherTypes
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
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbtn_Add = new DevExpress.XtraBars.BarButtonItem();
            this.bbtn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.bbtn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnprint = new DevExpress.XtraBars.BarButtonItem();
            this.bbtn_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vouchersTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeducted_from_salary = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vouchersTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbtn_Add,
            this.bbtn_Save,
            this.bbtn_Delete,
            this.bbtnprint,
            this.bbtn_Edit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(646, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bbtn_Add
            // 
            this.bbtn_Add.Caption = "Add";
            this.bbtn_Add.Id = 1;
            this.bbtn_Add.ImageOptions.SvgImage = global::Vouchar_Program.Properties.Resources.actions_addcircled;
            this.bbtn_Add.Name = "bbtn_Add";
            this.bbtn_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtn_Add_ItemClick);
            // 
            // bbtn_Save
            // 
            this.bbtn_Save.Caption = "Save";
            this.bbtn_Save.Id = 3;
            this.bbtn_Save.ImageOptions.Image = global::Vouchar_Program.Properties.Resources.Save_32x32;
            this.bbtn_Save.Name = "bbtn_Save";
            this.bbtn_Save.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtn_Save_ItemClick);
            // 
            // bbtn_Delete
            // 
            this.bbtn_Delete.Caption = "Delete";
            this.bbtn_Delete.Id = 4;
            this.bbtn_Delete.ImageOptions.Image = global::Vouchar_Program.Properties.Resources.Trash_32x32;
            this.bbtn_Delete.Name = "bbtn_Delete";
            this.bbtn_Delete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtn_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtn_Delete_ItemClick);
            // 
            // bbtnprint
            // 
            this.bbtnprint.Caption = "Print Priview";
            this.bbtnprint.Id = 5;
            this.bbtnprint.ImageOptions.SvgImage = global::Vouchar_Program.Properties.Resources.print;
            this.bbtnprint.Name = "bbtnprint";
            this.bbtnprint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnprint_ItemClick);
            // 
            // bbtn_Edit
            // 
            this.bbtn_Edit.Caption = "Edit";
            this.bbtn_Edit.Id = 6;
            this.bbtn_Edit.ImageOptions.SvgImage = global::Vouchar_Program.Properties.Resources.editquery;
            this.bbtn_Edit.Name = "bbtn_Edit";
            this.bbtn_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtn_Edit_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "File";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtn_Add);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtn_Edit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtn_Save);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtn_Delete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnprint);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Controls";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(646, 31);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vouchersTypeBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(646, 275);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vouchersTypeBindingSource
            // 
            this.vouchersTypeBindingSource.DataSource = typeof(Vouchar_Program.Voucher.Vouchers_Type);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 13F);
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colType,
            this.coldeducted_from_salary});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.Caption = "Id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colType
            // 
            this.colType.Caption = "Type";
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 1;
            // 
            // coldeducted_from_salary
            // 
            this.coldeducted_from_salary.Caption = "Deducted from Salary";
            this.coldeducted_from_salary.FieldName = "deducted_from_salary";
            this.coldeducted_from_salary.Name = "coldeducted_from_salary";
            this.coldeducted_from_salary.Visible = true;
            this.coldeducted_from_salary.VisibleIndex = 2;
            // 
            // frm_VoucherTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 449);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frm_VoucherTypes";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Voucher Type";
            this.Load += new System.EventHandler(this.frm_VoucherTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vouchersTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbtn_Add;
        private DevExpress.XtraBars.BarButtonItem bbtn_Save;
        private DevExpress.XtraBars.BarButtonItem bbtn_Delete;
        private DevExpress.XtraBars.BarButtonItem bbtnprint;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource vouchersTypeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn coldeducted_from_salary;
        private DevExpress.XtraBars.BarButtonItem bbtn_Edit;
    }
}