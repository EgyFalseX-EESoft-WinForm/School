using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Employee.xRep
{
    public partial class XRepEmpagazat : DevExpress.XtraReports.UI.XtraReport
    {
        public XRepEmpagazat()
        {
            InitializeComponent();
        }
        public XRepEmpagazat(DateTime DateStart, DateTime DateEnd, int types)
        {
            InitializeComponent();
            xRepEmpagazatTableAdapter.Fill(dsRep.XRepEmpagazat, DateStart, DateEnd, types);
        }
        private void XRepEmpagazat_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            repGeneralInfoTableAdapter.Fill(dsRep.RepGeneralInfo, Convert.ToByte(FXFW.SqlDB.asase_code));
            repAppOptionsTableAdapter.Fill(dsRep.RepAppOptions);
            
        }

    }
}
