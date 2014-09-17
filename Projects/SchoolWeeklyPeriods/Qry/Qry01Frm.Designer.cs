namespace SchoolWeeklyPeriods
{
    partial class Qry01Frm
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
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.XPSCSData = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.sessionData = new DevExpress.Xpo.Session(this.components);
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEMP_FIRST_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMP_FATHER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMP_FAM_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMP_FOURTH_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpNationalID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOBILE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHONE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmp_Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.XPSCSData;
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.EmbeddedNavigator.TextStringFormat = "صف {0} من {1}";
            this.gridControlData.Location = new System.Drawing.Point(0, 0);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDate});
            this.gridControlData.Size = new System.Drawing.Size(822, 462);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // XPSCSData
            // 
            this.XPSCSData.ObjectType = typeof(SchoolWeeklyPeriods.DataSources.dsSchoolQuery.Qry01DataTable);
            this.XPSCSData.Session = this.sessionData;
            // 
            // sessionData
            // 
            this.sessionData.TrackPropertiesModifications = false;
            // 
            // gridViewData
            // 
            this.gridViewData.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewData.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewData.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewData.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.gridViewData.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewData.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewData.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewData.Appearance.Empty.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewData.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewData.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridViewData.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewData.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewData.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewData.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewData.Appearance.FocusedRow.BackColor = System.Drawing.Color.Black;
            this.gridViewData.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewData.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewData.Appearance.FooterPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.FooterPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewData.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewData.Appearance.GroupFooter.BackColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewData.Appearance.GroupPanel.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewData.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewData.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewData.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewData.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray;
            this.gridViewData.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray;
            this.gridViewData.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewData.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridViewData.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro;
            this.gridViewData.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewData.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewData.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewData.Appearance.Row.Options.UseBackColor = true;
            this.gridViewData.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewData.Appearance.SelectedRow.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray;
            this.gridViewData.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEMP_FIRST_NAME,
            this.colEMP_FATHER_NAME,
            this.colEMP_FAM_NAME,
            this.colEMP_FOURTH_NAME,
            this.colEmpNationalID,
            this.colMOBILE_NO,
            this.colPHONE_NO,
            this.colEmp_Address});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.Editable = false;
            this.gridViewData.OptionsBehavior.ReadOnly = true;
            this.gridViewData.OptionsCustomization.AllowRowSizing = true;
            this.gridViewData.OptionsFind.AlwaysVisible = true;
            this.gridViewData.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ShowFooter = true;
            // 
            // colEMP_FIRST_NAME
            // 
            this.colEMP_FIRST_NAME.AppearanceCell.Options.UseTextOptions = true;
            this.colEMP_FIRST_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMP_FIRST_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colEMP_FIRST_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMP_FIRST_NAME.Caption = "الاسم الاول";
            this.colEMP_FIRST_NAME.FieldName = "EMP_FIRST_NAME";
            this.colEMP_FIRST_NAME.Name = "colEMP_FIRST_NAME";
            this.colEMP_FIRST_NAME.Visible = true;
            this.colEMP_FIRST_NAME.VisibleIndex = 0;
            this.colEMP_FIRST_NAME.Width = 100;
            // 
            // colEMP_FATHER_NAME
            // 
            this.colEMP_FATHER_NAME.AppearanceCell.Options.UseTextOptions = true;
            this.colEMP_FATHER_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMP_FATHER_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colEMP_FATHER_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMP_FATHER_NAME.Caption = "اسم الاب";
            this.colEMP_FATHER_NAME.FieldName = "EMP_FATHER_NAME";
            this.colEMP_FATHER_NAME.Name = "colEMP_FATHER_NAME";
            this.colEMP_FATHER_NAME.Visible = true;
            this.colEMP_FATHER_NAME.VisibleIndex = 1;
            this.colEMP_FATHER_NAME.Width = 115;
            // 
            // colEMP_FAM_NAME
            // 
            this.colEMP_FAM_NAME.AppearanceCell.Options.UseTextOptions = true;
            this.colEMP_FAM_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMP_FAM_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colEMP_FAM_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMP_FAM_NAME.Caption = "اسم الجد";
            this.colEMP_FAM_NAME.FieldName = "EMP_FAM_NAME";
            this.colEMP_FAM_NAME.Name = "colEMP_FAM_NAME";
            this.colEMP_FAM_NAME.Visible = true;
            this.colEMP_FAM_NAME.VisibleIndex = 2;
            this.colEMP_FAM_NAME.Width = 116;
            // 
            // colEMP_FOURTH_NAME
            // 
            this.colEMP_FOURTH_NAME.AppearanceCell.Options.UseTextOptions = true;
            this.colEMP_FOURTH_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMP_FOURTH_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colEMP_FOURTH_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMP_FOURTH_NAME.Caption = "الاسم الرابع";
            this.colEMP_FOURTH_NAME.FieldName = "EMP_FOURTH_NAME";
            this.colEMP_FOURTH_NAME.Name = "colEMP_FOURTH_NAME";
            this.colEMP_FOURTH_NAME.Visible = true;
            this.colEMP_FOURTH_NAME.VisibleIndex = 3;
            this.colEMP_FOURTH_NAME.Width = 156;
            // 
            // colEmpNationalID
            // 
            this.colEmpNationalID.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpNationalID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpNationalID.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpNationalID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpNationalID.Caption = "الرقم القومي";
            this.colEmpNationalID.FieldName = "EmpNationalID";
            this.colEmpNationalID.Name = "colEmpNationalID";
            this.colEmpNationalID.Visible = true;
            this.colEmpNationalID.VisibleIndex = 4;
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
            this.colMOBILE_NO.VisibleIndex = 5;
            // 
            // colPHONE_NO
            // 
            this.colPHONE_NO.AppearanceCell.Options.UseTextOptions = true;
            this.colPHONE_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHONE_NO.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHONE_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHONE_NO.Caption = "رقم التليفون";
            this.colPHONE_NO.FieldName = "PHONE_NO";
            this.colPHONE_NO.Name = "colPHONE_NO";
            this.colPHONE_NO.Visible = true;
            this.colPHONE_NO.VisibleIndex = 6;
            // 
            // colEmp_Address
            // 
            this.colEmp_Address.AppearanceCell.Options.UseTextOptions = true;
            this.colEmp_Address.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmp_Address.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmp_Address.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmp_Address.Caption = "العنوان";
            this.colEmp_Address.FieldName = "Emp_Address";
            this.colEmp_Address.Name = "colEmp_Address";
            this.colEmp_Address.Visible = true;
            this.colEmp_Address.VisibleIndex = 7;
            // 
            // repositoryItemDateEditDate
            // 
            this.repositoryItemDateEditDate.AutoHeight = false;
            this.repositoryItemDateEditDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDate.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEditDate.Name = "repositoryItemDateEditDate";
            this.repositoryItemDateEditDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // Qry01Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 462);
            this.Controls.Add(this.gridControlData);
            this.Name = "Qry01Frm";
            this.Text = "العاملين";
            this.Load += new System.EventHandler(this.QryTblAhteatyFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDate;
        private DevExpress.Xpo.XPServerCollectionSource XPSCSData;
        private DevExpress.Xpo.Session sessionData;
        private DevExpress.XtraGrid.Columns.GridColumn colEMP_FIRST_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colEMP_FATHER_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colEMP_FAM_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colEMP_FOURTH_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpNationalID;
        private DevExpress.XtraGrid.Columns.GridColumn colMOBILE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPHONE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colEmp_Address;

    }
}