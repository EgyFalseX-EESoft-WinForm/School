using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Employee.xRep
{
    public partial class XRepEmpDetail : DevExpress.XtraReports.UI.XtraReport
    {
        int _EmpId;
        public XRepEmpDetail()
        {
            InitializeComponent();
        }
        public XRepEmpDetail(int EmpId)
        {
            InitializeComponent();
            _EmpId = EmpId;
        }

        private void XRepEmpAll_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            repGeneralInfoTableAdapter.Fill(dsRep.RepGeneralInfo, Convert.ToByte(FXFW.SqlDB.asase_code));
            repAppOptionsTableAdapter.Fill(dsRep.RepAppOptions);

            xRepEmpDetailTableAdapter.FillByEmpID(dsRep.XRepEmpDetail, _EmpId);
            
        }

    }
}
