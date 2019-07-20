using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll.ReportForm
{
    public partial class frmEmpAttendanceReport : Form
    {
        public frmEmpAttendanceReport()
        {
            InitializeComponent();
        }

        ReportDocument crypt = new ReportDocument();

        private void frmEmpAttendanceReport_Load(object sender, EventArgs e)
        {
            Color color = ColorTranslator.FromHtml("#f8f8f8");
            btnExport.BackColor = color;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.FlatAppearance.BorderColor = color;
            btnExport.FlatAppearance.BorderSize = 1;

            crypt.Load(@"D:\Amarjeet\SEED\C#\Payroll\Payroll\Reports\repEmpAttend.rpt");
            Connection con = new Connection();
            DataSet objDS = new DataSet();
            con.getData("Select * from Employee");
            con.sda.Fill(objDS, "Employee");
            con.getData("Select * from EmpAttendance");
            con.sda.Fill(objDS, "EmpAttendance");
            crypt.SetDataSource(objDS);
            crptEmpAttend.ReportSource = crypt;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportOptions exportOptions;
            DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
            SaveFileDialog objSFD = new SaveFileDialog();
            //objSFD.Filter = "Pdf Files|*.pdf";
            objSFD.Filter = "Excel|*.xls";
            if (objSFD.ShowDialog() == DialogResult.OK)
            {
                diskFileDestinationOptions.DiskFileName = objSFD.FileName;
            }
            exportOptions = crypt.ExportOptions;
            {
                exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                //exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                exportOptions.ExportFormatType = ExportFormatType.Excel;
                exportOptions.ExportDestinationOptions = diskFileDestinationOptions;
                //exportOptions.ExportFormatOptions = new PdfRtfWordFormatOptions();
                exportOptions.ExportFormatOptions = new ExcelFormatOptions();
            }
            crypt.Export();
        }
    }
}
