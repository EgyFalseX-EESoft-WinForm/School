namespace Employee.XRep
{
    partial class XRepEmpDetailFrm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.dsRep = new Employee.Datasource.dsRep();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmp_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpecializationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBIRTH_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWork_Start_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltameen_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpJobName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colqualName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xRepEmpDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xRepEmpDetailTableAdapter = new Employee.Datasource.dsRepTableAdapters.XRepEmpDetailTableAdapter();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRepEmpDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.xRepEmpDetailBindingSource;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.Location = new System.Drawing.Point(0, 0);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditPrint});
            this.gridControlMain.Size = new System.Drawing.Size(784, 561);
            this.gridControlMain.TabIndex = 0;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // dsRep
            // 
            this.dsRep.DataSetName = "dsRep";
            this.dsRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmp_Name,
            this.colSpecializationName,
            this.colBIRTH_DATE,
            this.colWork_Start_Date,
            this.coltameen_no,
            this.colEmpJobName,
            this.colqualName,
            this.gridColumn1});
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
            this.colEmpJobName.VisibleIndex = 5;
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
            this.colqualName.VisibleIndex = 6;
            // 
            // xRepEmpDetailBindingSource
            // 
            this.xRepEmpDetailBindingSource.DataMember = "XRepEmpDetail";
            this.xRepEmpDetailBindingSource.DataSource = this.dsRep;
            // 
            // xRepEmpDetailTableAdapter
            // 
            this.xRepEmpDetailTableAdapter.ClearBeforeFill = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "طباعة";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditPrint;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // repositoryItemButtonEditPrint
            // 
            this.repositoryItemButtonEditPrint.AutoHeight = false;
            this.repositoryItemButtonEditPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::Employee.Properties.Resources.Print, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.repositoryItemButtonEditPrint.Name = "repositoryItemButtonEditPrint";
            this.repositoryItemButtonEditPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditPrint.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditPrint_ButtonClick);
            // 
            // XRepEmpDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gridControlMain);
            this.Name = "XRepEmpDetailFrm";
            this.Text = "سجل شئون العاملين";
            this.Load += new System.EventHandler(this.XRepEmpDetailFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRepEmpDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditPrint)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colEmpJobName;
        private DevExpress.XtraGrid.Columns.GridColumn colqualName;
        private Datasource.dsRep dsRep;
        private System.Windows.Forms.BindingSource xRepEmpDetailBindingSource;
        private Datasource.dsRepTableAdapters.XRepEmpDetailTableAdapter xRepEmpDetailTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditPrint;
    }
}