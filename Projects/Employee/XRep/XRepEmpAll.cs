using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Employee.xRep
{
    public partial class XRepEmpAll : DevExpress.XtraReports.UI.XtraReport
    {
        string _filterstring = string.Empty;
        public XRepEmpAll()
        {
            InitializeComponent();
        }
        public XRepEmpAll(string filterstring)
        {
            InitializeComponent();
            _filterstring = filterstring;
        }

        private void XRepEmpAll_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            repGeneralInfoTableAdapter.Fill(dsRep.RepGeneralInfo, Convert.ToByte(FXFW.SqlDB.asase_code));
            repAppOptionsTableAdapter.Fill(dsRep.RepAppOptions);

            if (_filterstring != string.Empty)
                xRepEmpAllTableAdapter.Adapter.SelectCommand.CommandText = string.Format("{0} WHERE {1}", xRepEmpAllTableAdapter.Adapter.SelectCommand.CommandText, _filterstring);
            
            //System.Data.SqlClient.SqlDataAdapter adp = new System.Data.SqlClient.SqlDataAdapter("", Properties.Settings.Default.eschoolConnectionString);
            xRepEmpAllTableAdapter.Fill(dsRep.XRepEmpAll);
            
        }

    }
}
