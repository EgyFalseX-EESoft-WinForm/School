using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors.Controls;

namespace SchoolWeeklyPeriods
{
    public partial class XRepTimeAllTable : DevExpress.XtraReports.UI.XtraReport
    {

        public XRepTimeAllTable()
        {
            InitializeComponent();
            LoadDataSource();
        }
        private void LoadDataSource()
        {
            cD_AsasetimeTableAdapter.Fill(dsSchoolQuery.CD_Asasetime, Convert.ToByte(FXFW.SqlDB.asase_code));
            cdAlsofofTableAdapter.Fill(dsSchoolQuery.CDAlsofof);
            appOptionsTableAdapter.Fill(dsSchoolQuery.AppOptions);

            xlAsase.Text = new DataSources.dsSchoolQueryTableAdapters.QueriesTableAdapter().Getasase_year(Convert.ToByte(FXFW.SqlDB.asase_code));

            xRepTimeAllTableTableAdapter.Fill(dsSchoolQuery.XRepTimeAllTable, Convert.ToByte(FXFW.SqlDB.asase_code));
        }
      
        private void XRep01_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            //foreach (ParameterInfo info in e.ParametersInformation)
            //{
            //    if (info.Parameter.Name == "pramDofatSarfId")
            //    {
            //        LookUpEdit LUE = new LookUpEdit();
            //        LUE.Properties.DataSource = XPTBLDofatSarf;
            //        LUE.Properties.DisplayMember = "DofatSarf";
            //        LUE.Properties.ValueMember = "DofatSarfId";
            //        LUE.Properties.Columns.Add(new LookUpColumnInfo("DofatSarf", 0, "النوع"));
            //        LUE.Properties.BestFit();
            //        LUE.Properties.NullText = string.Empty;
            //        LUE.Properties.TextEditStyle = TextEditStyles.Standard;
            //        //LUE.Properties.NullText = "<اختر فرعيه>";
            //        info.Editor = LUE;
            //        info.Parameter.Value = DBNull.Value;
            //        continue;
            //    }
            //}
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            xRepTimeAllTableTableAdapter.Fill(dsSchoolQuery.XRepTimeAllTable, Convert.ToByte(FXFW.SqlDB.asase_code));
        }

    }
}
