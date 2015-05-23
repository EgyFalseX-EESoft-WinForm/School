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
    public partial class XRepEmpDetailFrm : DevExpress.XtraEditors.XtraForm
    {
        public XRepEmpDetailFrm()
        {
            InitializeComponent();
        }
       
        private void XRepEmpDetailFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRep.XRepEmpDetail' table. You can move, or remove it, as needed.
            this.xRepEmpDetailTableAdapter.Fill(this.dsRep.XRepEmpDetail);
            
        }
       
        private void repositoryItemButtonEditPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Datasource.dsRep.XRepEmpDetailRow row = (Datasource.dsRep.XRepEmpDetailRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
            XRepEmpDetail rep = new XRepEmpDetail(row.EmpID);
            Misc.Misc.ShowPrintPreview(rep);
        }
        
    }
}