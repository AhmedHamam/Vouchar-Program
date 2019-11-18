namespace Vouchar_Program
{
    partial class Frm_Edit_Employee
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
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.FullNameArabTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FullNameEngTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IqamaNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Emp_No = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Employee_Info = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForEmpNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFullNameArab = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFullNameEng = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIqamaNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout_buttons = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FullNameArabTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullNameEngTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IqamaNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_No.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFullNameArab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFullNameEng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIqamaNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_buttons)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btn_Cancel);
            this.dataLayoutControl1.Controls.Add(this.btn_Save);
            this.dataLayoutControl1.Controls.Add(this.FullNameArabTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FullNameEngTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IqamaNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_No);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(879, 254);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.ImageOptions.Image = global::Vouchar_Program.Properties.Resources.Cancel_32x32;
            this.btn_Cancel.Location = new System.Drawing.Point(441, 200);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(426, 38);
            this.btn_Cancel.StyleController = this.dataLayoutControl1;
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.ImageOptions.Image = global::Vouchar_Program.Properties.Resources.Save_32x32;
            this.btn_Save.Location = new System.Drawing.Point(12, 200);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(425, 38);
            this.btn_Save.StyleController = this.dataLayoutControl1;
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // FullNameArabTextEdit
            // 
            this.FullNameArabTextEdit.Location = new System.Drawing.Point(156, 86);
            this.FullNameArabTextEdit.Name = "FullNameArabTextEdit";
            this.FullNameArabTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FullNameArabTextEdit.Properties.Appearance.Options.UseFont = true;
            this.FullNameArabTextEdit.Size = new System.Drawing.Size(699, 30);
            this.FullNameArabTextEdit.StyleController = this.dataLayoutControl1;
            this.FullNameArabTextEdit.TabIndex = 5;
            // 
            // FullNameEngTextEdit
            // 
            this.FullNameEngTextEdit.Location = new System.Drawing.Point(156, 120);
            this.FullNameEngTextEdit.Name = "FullNameEngTextEdit";
            this.FullNameEngTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FullNameEngTextEdit.Properties.Appearance.Options.UseFont = true;
            this.FullNameEngTextEdit.Size = new System.Drawing.Size(699, 30);
            this.FullNameEngTextEdit.StyleController = this.dataLayoutControl1;
            this.FullNameEngTextEdit.TabIndex = 6;
            // 
            // IqamaNoTextEdit
            // 
            this.IqamaNoTextEdit.Location = new System.Drawing.Point(156, 154);
            this.IqamaNoTextEdit.Name = "IqamaNoTextEdit";
            this.IqamaNoTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.IqamaNoTextEdit.Properties.Appearance.Options.UseFont = true;
            this.IqamaNoTextEdit.Properties.Mask.EditMask = "d";
            this.IqamaNoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IqamaNoTextEdit.Size = new System.Drawing.Size(699, 30);
            this.IqamaNoTextEdit.StyleController = this.dataLayoutControl1;
            this.IqamaNoTextEdit.TabIndex = 7;
            // 
            // Emp_No
            // 
            this.Emp_No.Location = new System.Drawing.Point(156, 52);
            this.Emp_No.Name = "Emp_No";
            this.Emp_No.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Emp_No.Properties.Appearance.Options.UseFont = true;
            this.Emp_No.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Emp_No.Properties.NullText = "";
            this.Emp_No.Properties.PopupView = this.searchLookUpEdit1View;
            this.Emp_No.Size = new System.Drawing.Size(699, 30);
            this.Emp_No.StyleController = this.dataLayoutControl1;
            this.Emp_No.TabIndex = 4;
            this.Emp_No.EditValueChanged += new System.EventHandler(this.Emp_No_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(879, 254);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Employee_Info,
            this.layoutControlItem2,
            this.layout_buttons});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(859, 234);
            // 
            // Employee_Info
            // 
            this.Employee_Info.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Employee_Info.AppearanceGroup.Options.UseFont = true;
            this.Employee_Info.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Employee_Info.AppearanceItemCaption.Options.UseFont = true;
            this.Employee_Info.CustomizationFormText = "Employee information";
            this.Employee_Info.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForEmpNo,
            this.ItemForFullNameArab,
            this.ItemForFullNameEng,
            this.ItemForIqamaNo});
            this.Employee_Info.Location = new System.Drawing.Point(0, 0);
            this.Employee_Info.Name = "Employee_Info";
            this.Employee_Info.Size = new System.Drawing.Size(859, 188);
            this.Employee_Info.Text = "Employee information";
            // 
            // ItemForEmpNo
            // 
            this.ItemForEmpNo.Control = this.Emp_No;
            this.ItemForEmpNo.Location = new System.Drawing.Point(0, 0);
            this.ItemForEmpNo.Name = "ItemForEmpNo";
            this.ItemForEmpNo.Size = new System.Drawing.Size(835, 34);
            this.ItemForEmpNo.Text = "Emp No";
            this.ItemForEmpNo.TextSize = new System.Drawing.Size(129, 23);
            // 
            // ItemForFullNameArab
            // 
            this.ItemForFullNameArab.Control = this.FullNameArabTextEdit;
            this.ItemForFullNameArab.Location = new System.Drawing.Point(0, 34);
            this.ItemForFullNameArab.Name = "ItemForFullNameArab";
            this.ItemForFullNameArab.Size = new System.Drawing.Size(835, 34);
            this.ItemForFullNameArab.Text = "Full Name Arab";
            this.ItemForFullNameArab.TextSize = new System.Drawing.Size(129, 23);
            // 
            // ItemForFullNameEng
            // 
            this.ItemForFullNameEng.Control = this.FullNameEngTextEdit;
            this.ItemForFullNameEng.Location = new System.Drawing.Point(0, 68);
            this.ItemForFullNameEng.Name = "ItemForFullNameEng";
            this.ItemForFullNameEng.Size = new System.Drawing.Size(835, 34);
            this.ItemForFullNameEng.Text = "Full Name Eng";
            this.ItemForFullNameEng.TextSize = new System.Drawing.Size(129, 23);
            // 
            // ItemForIqamaNo
            // 
            this.ItemForIqamaNo.Control = this.IqamaNoTextEdit;
            this.ItemForIqamaNo.Location = new System.Drawing.Point(0, 102);
            this.ItemForIqamaNo.Name = "ItemForIqamaNo";
            this.ItemForIqamaNo.Size = new System.Drawing.Size(835, 34);
            this.ItemForIqamaNo.Text = "Iqama No";
            this.ItemForIqamaNo.TextSize = new System.Drawing.Size(129, 23);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btn_Save;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 188);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(429, 46);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layout_buttons
            // 
            this.layout_buttons.Control = this.btn_Cancel;
            this.layout_buttons.Location = new System.Drawing.Point(429, 188);
            this.layout_buttons.Name = "layout_buttons";
            this.layout_buttons.Size = new System.Drawing.Size(430, 46);
            this.layout_buttons.TextSize = new System.Drawing.Size(0, 0);
            this.layout_buttons.TextVisible = false;
            // 
            // Frm_Edit_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 254);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "Frm_Edit_Employee";
            this.Text = "Edit Employee";
            this.Load += new System.EventHandler(this.Frm_Edit_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FullNameArabTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullNameEngTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IqamaNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_No.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFullNameArab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFullNameEng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIqamaNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_buttons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.TextEdit FullNameArabTextEdit;
        private DevExpress.XtraEditors.TextEdit FullNameEngTextEdit;
        private DevExpress.XtraEditors.TextEdit IqamaNoTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup Employee_Info;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFullNameArab;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFullNameEng;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIqamaNo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layout_buttons;
        private DevExpress.XtraEditors.SearchLookUpEdit Emp_No;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    }
}