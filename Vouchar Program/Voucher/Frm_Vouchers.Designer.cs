namespace Vouchar_Program.Voucher
{
    partial class Frm_Vouchers
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbtn_ShowVoucher = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Voucher_idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Emp_IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.typeTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Payment_DateDateEdit = new DevExpress.XtraEditors.TextEdit();
            this.Recived_DateDateEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForEmp_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForVoucher_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForPayment_Date = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRecived_Date = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemFortype = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Voucher_idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Payment_DateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Recived_DateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVoucher_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayment_Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRecived_Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFortype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridControl.Location = new System.Drawing.Point(12, 12);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(956, 290);
            this.gridControl.TabIndex = 3;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
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
            this.bbtn_ShowVoucher});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 22;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(980, 143);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Caption = "Print Preview";
            this.btnPrintPreview.Id = 14;
            this.btnPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // btnNew
            // 
            this.btnNew.Caption = "New";
            this.btnNew.Id = 16;
            this.btnNew.ImageOptions.Image = global::Vouchar_Program.Properties.Resources.Add_32x32;
            this.btnNew.ImageOptions.ImageUri.Uri = "New";
            this.btnNew.Name = "btnNew";
            this.btnNew.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit";
            this.btnEdit.Id = 17;
            this.btnEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 18;
            this.btnDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 19;
            this.btnRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // bbtn_ShowVoucher
            // 
            this.bbtn_ShowVoucher.Caption = "Show Voucher Details";
            this.bbtn_ShowVoucher.Id = 21;
            this.bbtn_ShowVoucher.ImageOptions.SvgImage = global::Vouchar_Program.Properties.Resources.printarea;
            this.bbtn_ShowVoucher.Name = "bbtn_ShowVoucher";
            this.bbtn_ShowVoucher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtn_ShowVoucher_ItemClick);
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
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtn_ShowVoucher);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Dock = System.Windows.Forms.DockStyle.None;
            this.ribbonStatusBar.Location = new System.Drawing.Point(18, 299);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(950, 27);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.skinDropDownButtonItem1.Id = 20;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.Voucher_idTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_IdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.btn_Search);
            this.dataLayoutControl1.Controls.Add(this.typeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Payment_DateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.Recived_DateDateEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 143);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(980, 200);
            this.dataLayoutControl1.TabIndex = 2;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Voucher_idTextEdit
            // 
            this.Voucher_idTextEdit.Location = new System.Drawing.Point(585, 52);
            this.Voucher_idTextEdit.MenuManager = this.ribbonControl;
            this.Voucher_idTextEdit.Name = "Voucher_idTextEdit";
            this.Voucher_idTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Voucher_idTextEdit.Properties.Appearance.Options.UseFont = true;
            this.Voucher_idTextEdit.Size = new System.Drawing.Size(354, 26);
            this.Voucher_idTextEdit.StyleController = this.dataLayoutControl1;
            this.Voucher_idTextEdit.TabIndex = 4;
            this.Voucher_idTextEdit.EditValueChanged += new System.EventHandler(this.Voucher_idTextEdit_EditValueChanged);
            // 
            // Emp_IdTextEdit
            // 
            this.Emp_IdTextEdit.Location = new System.Drawing.Point(126, 52);
            this.Emp_IdTextEdit.MenuManager = this.ribbonControl;
            this.Emp_IdTextEdit.Name = "Emp_IdTextEdit";
            this.Emp_IdTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Emp_IdTextEdit.Properties.Appearance.Options.UseFont = true;
            this.Emp_IdTextEdit.Size = new System.Drawing.Size(353, 26);
            this.Emp_IdTextEdit.StyleController = this.dataLayoutControl1;
            this.Emp_IdTextEdit.TabIndex = 5;
            this.Emp_IdTextEdit.EditValueChanged += new System.EventHandler(this.Emp_IdTextEdit_EditValueChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.Location = new System.Drawing.Point(12, 252);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(939, 26);
            this.btn_Search.StyleController = this.dataLayoutControl1;
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Search";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // typeTextEdit
            // 
            this.typeTextEdit.Location = new System.Drawing.Point(126, 216);
            this.typeTextEdit.MenuManager = this.ribbonControl;
            this.typeTextEdit.Name = "typeTextEdit";
            this.typeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.typeTextEdit.Size = new System.Drawing.Size(813, 20);
            this.typeTextEdit.StyleController = this.dataLayoutControl1;
            this.typeTextEdit.TabIndex = 10;
            // 
            // Payment_DateDateEdit
            // 
            this.Payment_DateDateEdit.Location = new System.Drawing.Point(126, 134);
            this.Payment_DateDateEdit.MenuManager = this.ribbonControl;
            this.Payment_DateDateEdit.Name = "Payment_DateDateEdit";
            this.Payment_DateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Payment_DateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.Payment_DateDateEdit.Properties.DisplayFormat.FormatString = "d";
            this.Payment_DateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Payment_DateDateEdit.Properties.EditFormat.FormatString = "d";
            this.Payment_DateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Payment_DateDateEdit.Properties.Mask.EditMask = "d";
            this.Payment_DateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.Payment_DateDateEdit.Size = new System.Drawing.Size(353, 26);
            this.Payment_DateDateEdit.StyleController = this.dataLayoutControl1;
            this.Payment_DateDateEdit.TabIndex = 6;
            // 
            // Recived_DateDateEdit
            // 
            this.Recived_DateDateEdit.Location = new System.Drawing.Point(585, 134);
            this.Recived_DateDateEdit.MenuManager = this.ribbonControl;
            this.Recived_DateDateEdit.Name = "Recived_DateDateEdit";
            this.Recived_DateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Recived_DateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.Recived_DateDateEdit.Properties.DisplayFormat.FormatString = "d";
            this.Recived_DateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Recived_DateDateEdit.Properties.EditFormat.FormatString = "d";
            this.Recived_DateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Recived_DateDateEdit.Properties.Mask.EditMask = "d";
            this.Recived_DateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.Recived_DateDateEdit.Size = new System.Drawing.Size(354, 26);
            this.Recived_DateDateEdit.StyleController = this.dataLayoutControl1;
            this.Recived_DateDateEdit.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.ExpandButtonVisible = true;
            this.Root.ExpandOnDoubleClick = true;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(963, 290);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(943, 270);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btn_Search;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 240);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(943, 30);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlGroup2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup2.ExpandButtonVisible = true;
            this.layoutControlGroup2.ExpandOnDoubleClick = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForEmp_Id,
            this.ItemForVoucher_id});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlGroup2.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControlGroup2.Size = new System.Drawing.Size(943, 82);
            this.layoutControlGroup2.Text = "Search by ID";
            // 
            // ItemForEmp_Id
            // 
            this.ItemForEmp_Id.Control = this.Emp_IdTextEdit;
            this.ItemForEmp_Id.Location = new System.Drawing.Point(0, 0);
            this.ItemForEmp_Id.Name = "ItemForEmp_Id";
            this.ItemForEmp_Id.Size = new System.Drawing.Size(459, 30);
            this.ItemForEmp_Id.Text = " Employee No";
            this.ItemForEmp_Id.TextSize = new System.Drawing.Size(99, 19);
            // 
            // ItemForVoucher_id
            // 
            this.ItemForVoucher_id.Control = this.Voucher_idTextEdit;
            this.ItemForVoucher_id.Location = new System.Drawing.Point(459, 0);
            this.ItemForVoucher_id.Name = "ItemForVoucher_id";
            this.ItemForVoucher_id.Size = new System.Drawing.Size(460, 30);
            this.ItemForVoucher_id.Text = "Voucher No";
            this.ItemForVoucher_id.TextSize = new System.Drawing.Size(99, 19);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlGroup3.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlGroup3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup3.ExpandButtonVisible = true;
            this.layoutControlGroup3.ExpandOnDoubleClick = true;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForPayment_Date,
            this.ItemForRecived_Date});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 82);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlGroup3.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControlGroup3.Size = new System.Drawing.Size(943, 82);
            this.layoutControlGroup3.Text = "Search by Date";
            // 
            // ItemForPayment_Date
            // 
            this.ItemForPayment_Date.Control = this.Payment_DateDateEdit;
            this.ItemForPayment_Date.Location = new System.Drawing.Point(0, 0);
            this.ItemForPayment_Date.Name = "ItemForPayment_Date";
            this.ItemForPayment_Date.Size = new System.Drawing.Size(459, 30);
            this.ItemForPayment_Date.Text = "From";
            this.ItemForPayment_Date.TextSize = new System.Drawing.Size(99, 19);
            // 
            // ItemForRecived_Date
            // 
            this.ItemForRecived_Date.Control = this.Recived_DateDateEdit;
            this.ItemForRecived_Date.Location = new System.Drawing.Point(459, 0);
            this.ItemForRecived_Date.Name = "ItemForRecived_Date";
            this.ItemForRecived_Date.Size = new System.Drawing.Size(460, 30);
            this.ItemForRecived_Date.Text = "To";
            this.ItemForRecived_Date.TextSize = new System.Drawing.Size(99, 19);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 14F);
            this.layoutControlGroup4.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlGroup4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup4.ExpandButtonVisible = true;
            this.layoutControlGroup4.ExpandOnDoubleClick = true;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemFortype});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 164);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlGroup4.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControlGroup4.Size = new System.Drawing.Size(943, 76);
            this.layoutControlGroup4.Text = "Search by Type";
            // 
            // ItemFortype
            // 
            this.ItemFortype.Control = this.typeTextEdit;
            this.ItemFortype.Location = new System.Drawing.Point(0, 0);
            this.ItemFortype.Name = "ItemFortype";
            this.ItemFortype.Size = new System.Drawing.Size(919, 24);
            this.ItemFortype.Text = "Type";
            this.ItemFortype.TextSize = new System.Drawing.Size(99, 19);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ribbonStatusBar);
            this.layoutControl1.Controls.Add(this.gridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 343);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup5;
            this.layoutControl1.Size = new System.Drawing.Size(980, 338);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup5.GroupBordersVisible = false;
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(980, 338);
            this.layoutControlGroup5.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(960, 294);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ribbonStatusBar;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 294);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(960, 24);
            this.layoutControlItem3.Text = " ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(3, 13);
            // 
            // Frm_Vouchers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(980, 681);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "Frm_Vouchers";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Vouchers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Voucher_idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Payment_DateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Recived_DateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVoucher_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPayment_Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRecived_Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFortype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
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
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit Voucher_idTextEdit;
        private DevExpress.XtraEditors.TextEdit Emp_IdTextEdit;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.ComboBoxEdit typeTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVoucher_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRecived_Date;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_Id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPayment_Date;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem ItemFortype;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit Payment_DateDateEdit;
        private DevExpress.XtraEditors.TextEdit Recived_DateDateEdit;
        private DevExpress.XtraBars.BarButtonItem bbtn_ShowVoucher;
    }
}