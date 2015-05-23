using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Employee.xRep
{
    public partial class XRepEmpAddress : DevExpress.XtraReports.UI.XtraReport
    {
        public XRepEmpAddress()
        {
            InitializeComponent();
        }

        private void XRepEmpAddress_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            repGeneralInfoTableAdapter.Fill(dsRep.RepGeneralInfo, Convert.ToByte(FXFW.SqlDB.asase_code));
            repAppOptionsTableAdapter.Fill(dsRep.RepAppOptions);
            xRepEmpAddressTableAdapter.Fill(dsRep.XRepEmpAddress);
        }

    }
}
