namespace Employee.XRep
{
    partial class XRepEmpAllFrm
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
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmp_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpecializationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBIRTH_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWork_Start_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltameen_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltameen_date1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHONE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOBILE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpJobName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmarhala_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpStateName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname_alnoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colqualName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItemPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dsRep = new Employee.Datasource.dsRep();
            this.xRepEmpAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xRepEmpAllTableAdapter = new Employee.Datasource.dsRepTableAdapters.XRepEmpAllTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRepEmpAllBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.xRepEmpAllBindingSource;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.Location = new System.Drawing.Point(0, 24);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(784, 514);
            this.gridControlMain.TabIndex = 0;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmp_Name,
            this.colSpecializationName,
            this.colBIRTH_DATE,
            this.colWork_Start_Date,
            this.coltameen_no,
            this.coltameen_date1,
            this.colPHONE_NO,
            this.colMOBILE_NO,
            this.colEmpJobName,
            this.colmarhala_name,
            this.colDepartment,
            this.colSubject,
            this.colEmpStateName,
            this.colname_alnoa,
            this.colqualName});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            // 
            // colEmp_Name
            // 
            this.colEmp_Name.AppearanceCell.Options.UseTextOptions = true;
            this.colEmp_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmp_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmp_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmp_Name.Caption = "الاسم";
            this.colEmp_Name.FieldName = "Emp_Name";
            this.colEmp_Name.Name = "colEmp_Name";
            this.colEmp_Name.OptionsColumn.ReadOnly = true;
            this.colEmp_Name.Visible = true;
            this.colEmp_Name.VisibleIndex = 0;
            // 
            // colSpecializationName
            // 
            this.colSpecializationName.AppearanceCell.Options.UseTextOptions = true;
            this.colSpecializationName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSpecializationName.AppearanceHeader.Options.UseTextOptions = true;
            this.colSpecializationName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSpecializationName.Caption = "التخصص";
            this.colSpecializationName.FieldName = "SpecializationName";
            this.colSpecializationName.Name = "colSpecializationName";
            this.colSpecializationName.OptionsColumn.ReadOnly = true;
            this.colSpecializationName.Visible = true;
            this.colSpecializationName.VisibleIndex = 1;
            // 
            // colBIRTH_DATE
            // 
            this.colBIRTH_DATE.AppearanceCell.Options.UseTextOptions = true;
            this.colBIRTH_DATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBIRTH_DATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBIRTH_DATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBIRTH_DATE.Caption = "تاريخ الميلاد";
            this.colBIRTH_DATE.FieldName = "BIRTH_DATE";
            this.colBIRTH_DATE.Name = "colBIRTH_DATE";
            this.colBIRTH_DATE.Visible = true;
            this.colBIRTH_DATE.VisibleIndex = 2;
            // 
            // colWork_Start_Date
            // 
            this.colWork_Start_Date.AppearanceCell.Options.UseTextOptions = true;
            this.colWork_Start_Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWork_Start_Date.AppearanceHeader.Options.UseTextOptions = true;
            this.colWork_Start_Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWork_Start_Date.Caption = "تاريخ العمل";
            this.colWork_Start_Date.FieldName = "Work_Start_Date";
            this.colWork_Start_Date.Name = "colWork_Start_Date";
            this.colWork_Start_Date.Visible = true;
            this.colWork_Start_Date.VisibleIndex = 3;
            // 
            // coltameen_no
            // 
            this.coltameen_no.AppearanceCell.Options.UseTextOptions = true;
            this.coltameen_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltameen_no.AppearanceHeader.Options.UseTextOptions = true;
            this.coltameen_no.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltameen_no.Caption = "رقم التأمين";
            this.coltameen_no.FieldName = "tameen_no";
            this.coltameen_no.Name = "coltameen_no";
            this.coltameen_no.Visible = true;
            this.coltameen_no.VisibleIndex = 4;
            // 
            // coltameen_date1
            // 
            this.coltameen_date1.AppearanceCell.Options.UseTextOptions = true;
            this.coltameen_date1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltameen_date1.AppearanceHeader.Options.UseTextOptions = true;
            this.coltameen_date1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltameen_date1.Caption = "تاريخ التأمين";
            this.coltameen_date1.FieldName = "tameen_date1";
            this.coltameen_date1.Name = "coltameen_date1";
            this.coltameen_date1.Visible = true;
            this.coltameen_date1.VisibleIndex = 5;
            // 
            // colPHONE_NO
            // 
            this.colPHONE_NO.AppearanceCell.Options.UseTextOptions = true;
            this.colPHONE_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHONE_NO.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHONE_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHONE_NO.Caption = "تليفون";
            this.colPHONE_NO.FieldName = "PHONE_NO";
            this.colPHONE_NO.Name = "colPHONE_NO";
            this.colPHONE_NO.Visible = true;
            this.colPHONE_NO.VisibleIndex = 6;
            // 
            // colMOBILE_NO
            // 
            this.colMOBILE_NO.AppearanceCell.Options.UseTextOptions = true;
            this.colMOBILE_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMOBILE_NO.AppearanceHeader.Options.UseTextOptions = true;
            this.colMOBILE_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMOBILE_NO.Caption = "موبيل";
            this.colMOBILE_NO.FieldName = "MOBILE_NO";
            this.colMOBILE_NO.Name = "colMOBILE_NO";
            this.colMOBILE_NO.Visible = true;
            this.colMOBILE_NO.VisibleIndex = 7;
            // 
            // colEmpJobName
            // 
            this.colEmpJobName.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpJobName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpJobName.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpJobName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpJobName.Caption = "الوظيفة";
            this.colEmpJobName.FieldName = "EmpJobName";
            this.colEmpJobName.Name = "colEmpJobName";
            this.colEmpJobName.OptionsColumn.ReadOnly = true;
            this.colEmpJobName.Visible = true;
            this.colEmpJobName.VisibleIndex = 8;
            // 
            // colmarhala_name
            // 
            this.colmarhala_name.AppearanceCell.Options.UseTextOptions = true;
            this.colmarhala_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmarhala_name.AppearanceHeader.Options.UseTextOptions = true;
            this.colmarhala_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmarhala_name.Caption = "المرحلة";
            this.colmarhala_name.FieldName = "marhala_name";
            this.colmarhala_name.Name = "colmarhala_name";
            this.colmarhala_name.OptionsColumn.ReadOnly = true;
            this.colmarhala_name.Visible = true;
            this.colmarhala_name.VisibleIndex = 9;
            // 
            // colDepartment
            // 
            this.colDepartment.AppearanceCell.Options.UseTextOptions = true;
            this.colDepartment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepartment.AppearanceHeader.Options.UseTextOptions = true;
            this.colDepartment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepartment.Caption = "القسم";
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.OptionsColumn.ReadOnly = true;
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 10;
            // 
            // colSubject
            // 
            this.colSubject.AppearanceCell.Options.UseTextOptions = true;
            this.colSubject.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubject.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubject.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubject.Caption = "المادة";
            this.colSubject.FieldName = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.OptionsColumn.ReadOnly = true;
            this.colSubject.Visible = true;
            this.colSubject.VisibleIndex = 11;
            // 
            // colEmpStateName
            // 
            this.colEmpStateName.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpStateName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpStateName.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpStateName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpStateName.Caption = "الحالة";
            this.colEmpStateName.FieldName = "EmpStateName";
            this.colEmpStateName.Name = "colEmpStateName";
            this.colEmpStateName.OptionsColumn.ReadOnly = true;
            this.colEmpStateName.Visible = true;
            this.colEmpStateName.VisibleIndex = 12;
            // 
            // colname_alnoa
            // 
            this.colname_alnoa.AppearanceCell.Options.UseTextOptions = true;
            this.colname_alnoa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colname_alnoa.AppearanceHeader.Options.UseTextOptions = true;
            this.colname_alnoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colname_alnoa.Caption = "النوع";
            this.colname_alnoa.FieldName = "name_alnoa";
            this.colname_alnoa.Name = "colname_alnoa";
            this.colname_alnoa.OptionsColumn.ReadOnly = true;
            this.colname_alnoa.Visible = true;
            this.colname_alnoa.VisibleIndex = 13;
            // 
            // colqualName
            // 
            this.colqualName.AppearanceCell.Options.UseTextOptions = true;
            this.colqualName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colqualName.AppearanceHeader.Options.UseTextOptions = true;
            this.colqualName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colqualName.Caption = "المؤهل";
            this.colqualName.FieldName = "qualName";
            this.colqualName.Name = "colqualName";
            this.colqualName.OptionsColumn.ReadOnly = true;
            this.colqualName.Visible = true;
            this.colqualName.VisibleIndex = 14;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemPrint});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemPrint)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItemPrint
            // 
            this.barButtonItemPrint.Caption = "Print";
            this.barButtonItemPrint.Glyph = global::Employee.Properties.Resources.Print;
            this.barButtonItemPrint.Id = 0;
            this.barButtonItemPrint.Name = "barButtonItemPrint";
            this.barButtonItemPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItemPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPrint_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(784, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 538);
            this.barDockControlBottom.Size = new System.Drawing.Size(784, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 514);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(784, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 514);
            // 
            // dsRep
            // 
            this.dsRep.DataSetName = "dsRep";
            this.dsRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xRepEmpAllBindingSource
            // 
            this.xRepEmpAllBindingSource.DataMember = "XRepEmpAll";
            this.xRepEmpAllBindingSource.DataSource = this.dsRep;
            // 
            // xRepEmpAllTableAdapter
            // 
            this.xRepEmpAllTableAdapter.ClearBeforeFill = true;
            // 
            // XRepEmpAllFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XRepEmpAllFrm";
            this.Text = "سجل شئون العاملين";
            this.Load += new System.EventHandler(this.XRepEmpagazatFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRepEmpAllBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn colEmp_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colSpecializationName;
        private DevExpress.XtraGrid.Columns.GridColumn colBIRTH_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colWork_Start_Date;
        private DevExpress.XtraGrid.Columns.GridColumn coltameen_no;
        private DevExpress.XtraGrid.Columns.GridColumn coltameen_date1;
        private DevExpress.XtraGrid.Columns.GridColumn colPHONE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colMOBILE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpJobName;
        private DevExpress.XtraGrid.Columns.GridColumn colmarhala_name;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpStateName;
        private DevExpress.XtraGrid.Columns.GridColumn colname_alnoa;
        private DevExpress.XtraGrid.Columns.GridColumn colqualName;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPrint;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private Datasource.dsRep dsRep;
        private System.Windows.Forms.BindingSource xRepEmpAllBindingSource;
        private Datasource.dsRepTableAdapters.XRepEmpAllTableAdapter xRepEmpAllTableAdapter;
    }
}