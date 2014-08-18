using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolWeeklyPeriods.Misc
{
    public static class Misc
    {
        public static void ShowPrintPreview(DevExpress.XtraReports.IReport report, bool dlg = false)
        {
            // Create a Print Tool and show the Print Preview form. 
            DevExpress.XtraReports.UI.ReportPrintTool printTool = new DevExpress.XtraReports.UI.ReportPrintTool(report);

            // Set watermark options.
            //printTool.PrintingSystem.Watermark.Image = Program.CompanyLogo;
            //printTool.PrintingSystem.Watermark.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            //printTool.PrintingSystem.Watermark.ImageTiling = false;
            //printTool.PrintingSystem.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Stretch;
            //printTool.PrintingSystem.Watermark.ImageTransparency = 150;
            //printTool.PrintingSystem.Watermark.ShowBehind = false;
            //printTool.PrintingSystem.Watermark.PageRange = "1";
            if (dlg)
                printTool.ShowRibbonPreviewDialog();
            else
                printTool.ShowRibbonPreview();
        }
    }
}
