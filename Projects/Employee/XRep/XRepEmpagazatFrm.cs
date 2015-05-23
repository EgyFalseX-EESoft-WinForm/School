using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Employee.XRep
{
    public partial class XRepEmpagazatFrm : DevExpress.XtraEditors.XtraForm
    {
        public XRepEmpagazatFrm()
        {
            InitializeComponent();
        }
        private void XRepEmpagazatFrm_Load(object sender, EventArgs e)
        {
            cD_AgazaTypeTableAdapter.Fill(dsRep.CD_AgazaType);
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(deStart.EditValue) || FXFW.SqlDB.IsNullOrEmpty(deEnd.EditValue) || FXFW.SqlDB.IsNullOrEmpty(ccbeType.EditValue))
            {
                MessageBox.Show("يجب ادخال كل البيانات");
                return;
            }
            xRep.XRepEmpagazat rep = new xRep.XRepEmpagazat(deStart.DateTime, deEnd.DateTime, Convert.ToInt32(ccbeType.EditValue));
            Misc.Misc.ShowPrintPreview(rep);
        }
        
    }
}