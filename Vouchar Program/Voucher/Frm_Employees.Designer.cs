namespace Vouchar_Program.Voucher
{
    partial class Frm_Employees
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem2 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_Emp_Name = new DevExpress.XtraEditors.TextEdit();
            this.txt_Emp_no = new DevExpress.XtraEditors.TextEdit();
            this.txt_iqama_no = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForEmp_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemEmp_No = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForVoucher_id1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Emp_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Emp_no.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_iqama_no.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemEmp_No)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVoucher_id1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnPrintPreview,
            this.btnNew,
            this.btnEdit,
            this.btnDelete,
            this.btnRefresh,
            this.skinDropDownButtonItem2});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 22;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(980, 143);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Caption = "Print Employee";
            this.btnPrintPreview.Id = 14;
            this.btnPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.btnPrintPreview.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnPrintPreview.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnPrintPreview.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPrintPreview.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPrintPreview.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnPrintPreview.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // btnNew
            // 
            this.btnNew.Caption = "New";
            this.btnNew.Id = 16;
            this.btnNew.ImageOptions.Image = global::Vouchar_Program.Properties.Resources.Add_32x32;
            this.btnNew.ImageOptions.ImageUri.Uri = "New";
            this.btnNew.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnNew.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnNew.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnNew.ItemAppearance.Normal.Options.UseFont = true;
            this.btnNew.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnNew.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnNew.Name = "btnNew";
            this.btnNew.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit";
            this.btnEdit.Id = 17;
            this.btnEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.btnEdit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnEdit.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnEdit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnEdit.ItemAppearance.Normal.Options.UseFont = true;
            this.btnEdit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnEdit.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 18;
            this.btnDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.btnDelete.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnDelete.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnDelete.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDelete.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDelete.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnDelete.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 19;
            this.btnRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.btnRefresh.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnRefresh.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnRefresh.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnRefresh.ItemAppearance.Normal.Options.UseFont = true;
            this.btnRefresh.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnRefresh.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // skinDropDownButtonItem2
            // 
            this.skinDropDownButtonItem2.Id = 21;
            this.skinDropDownButtonItem2.Name = "skinDropDownButtonItem2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.skinDropDownButtonItem1.Id = 20;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            this.bsiRecordsCount.Size = new System.Drawing.Size(811, 27);
            this.bsiRecordsCount.Width = 811;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl);
            this.layoutControl1.Controls.Add(this.txt_Emp_Name);
            this.layoutControl1.Controls.Add(this.txt_Emp_no);
            this.layoutControl1.Controls.Add(this.txt_iqama_no);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup5;
            this.layoutControl1.Size = new System.Drawing.Size(980, 534);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 49);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(956, 473);
            this.gridControl.TabIndex = 6;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // txt_Emp_Name
            // 
            this.txt_Emp_Name.Location = new System.Drawing.Point(157, 42);
            this.txt_Emp_Name.Name = "txt_Emp_Name";
            this.txt_Emp_Name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_Emp_Name.Properties.Appearance.Options.UseFont = true;
            this.txt_Emp_Name.Size = new System.Drawing.Size(787, 26);
            this.txt_Emp_Name.StyleController = this.layoutControl1;
            this.txt_Emp_Name.TabIndex = 5;
            this.txt_Emp_Name.EditValueChanged += new System.EventHandler(this.txt_Emp_Name_EditValueChanged);
            // 
            // txt_Emp_no
            // 
            this.txt_Emp_no.Location = new System.Drawing.Point(157, 12);
            this.txt_Emp_no.Name = "txt_Emp_no";
            this.txt_Emp_no.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_Emp_no.Properties.Appearance.Options.UseFont = true;
            this.txt_Emp_no.Size = new System.Drawing.Size(787, 26);
            this.txt_Emp_no.StyleController = this.layoutControl1;
            this.txt_Emp_no.TabIndex = 4;
            this.txt_Emp_no.EditValueChanged += new System.EventHandler(this.txt_Emp_no_EditValueChanged);
            // 
            // txt_iqama_no
            // 
            this.txt_iqama_no.Location = new System.Drawing.Point(157, 72);
            this.txt_iqama_no.Name = "txt_iqama_no";
            this.txt_iqama_no.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_iqama_no.Properties.Appearance.Options.UseFont = true;
            this.txt_iqama_no.Size = new System.Drawing.Size(787, 26);
            this.txt_iqama_no.StyleController = this.layoutControl1;
            this.txt_iqama_no.TabIndex = 4;
            this.txt_iqama_no.EditValueChanged += new System.EventHandler(this.txt_iqama_no_EditValueChanged);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup5.GroupBordersVisible = false;
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem1});
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(980, 534);
            this.layoutControlGroup5.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlGroup2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup2.CustomizationFormText = "Search For Employee";
            this.layoutControlGroup2.ExpandButtonVisible = true;
            this.layoutControlGroup2.Expanded = false;
            this.layoutControlGroup2.ExpandOnDoubleClick = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForEmp_Id,
            this.ItemEmp_No,
            this.ItemForVoucher_id1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(960, 37);
            this.layoutControlGroup2.Text = "Search For Employee";
            // 
            // ItemForEmp_Id
            // 
            this.ItemForEmp_Id.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.ItemForEmp_Id.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForEmp_Id.Control = this.txt_Emp_Name;
            this.ItemForEmp_Id.CustomizationFormText = " Employee Name";
            this.ItemForEmp_Id.Location = new System.Drawing.Point(0, 30);
            this.ItemForEmp_Id.Name = "ItemForEmp_Id";
            this.ItemForEmp_Id.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.ItemForEmp_Id.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForEmp_Id.Size = new System.Drawing.Size(936, 30);
            this.ItemForEmp_Id.Text = " Employee Name";
            this.ItemForEmp_Id.TextSize = new System.Drawing.Size(142, 23);
            // 
            // ItemEmp_No
            // 
            this.ItemEmp_No.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.ItemEmp_No.AppearanceItemCaption.Options.UseFont = true;
            this.ItemEmp_No.Control = this.txt_Emp_no;
            this.ItemEmp_No.CustomizationFormText = "Employee No";
            this.ItemEmp_No.Location = new System.Drawing.Point(0, 0);
            this.ItemEmp_No.Name = "ItemEmp_No";
            this.ItemEmp_No.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.ItemEmp_No.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
            this.ItemEmp_No.Size = new System.Drawing.Size(936, 30);
            this.ItemEmp_No.Text = "Employee No";
            this.ItemEmp_No.TextSize = new System.Drawing.Size(142, 23);
            // 
            // ItemForVoucher_id1
            // 
            this.ItemForVoucher_id1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.ItemForVoucher_id1.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForVoucher_id1.Control = this.txt_iqama_no;
            this.ItemForVoucher_id1.CustomizationFormText = "Voucher No";
            this.ItemForVoucher_id1.Location = new System.Drawing.Point(0, 60);
            this.ItemForVoucher_id1.Name = "ItemForVoucher_id1";
            this.ItemForVoucher_id1.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.ItemForVoucher_id1.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForVoucher_id1.Size = new System.Drawing.Size(936, 30);
            this.ItemForVoucher_id1.Text = "Iqama No";
            this.ItemForVoucher_id1.TextSize = new System.Drawing.Size(142, 23);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 37);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(960, 477);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsFind.ShowCloseButton = false;
            // 
            // Frm_Employees
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(980, 677);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Frm_Employees";
            this.Ribbon = this.ribbonControl;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Emp_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Emp_no.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_iqama_no.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemEmp_No)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVoucher_id1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem btnPrintPreview;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraEditors.TextEdit txt_Emp_Name;
        private DevExpress.XtraEditors.TextEdit txt_Emp_no;
        private DevExpress.XtraEditors.TextEdit txt_iqama_no;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_Id;
        private DevExpress.XtraLayout.LayoutControlItem ItemEmp_No;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVoucher_id1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}