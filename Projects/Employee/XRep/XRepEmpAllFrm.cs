using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Employee.xRep;

namespace Employee.XRep
{
    public partial class XRepEmpAllFrm : DevExpress.XtraEditors.XtraForm
    {
        public XRepEmpAllFrm()
        {
            InitializeComponent();
        }
       
        private void XRepEmpagazatFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRep.XRepEmpAll' table. You can move, or remove it, as needed.
            this.xRepEmpAllTableAdapter.Fill(this.dsRep.XRepEmpAll);
            
        }
        private void barButtonItemPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //gridViewMain.print
            string filterstring = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(gridViewMain.ActiveFilterCriteria);
            XRepEmpAll rep = new XRepEmpAll(filterstring);
            Misc.Misc.ShowPrintPreview(rep);
        }
        
    }
}