using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll.ReportForm
{
    public partial class frmSalaryReport : Form
    {
        public frmSalaryReport()
        {
            InitializeComponent();
        }

        private void frmSalaryReport_Load(object sender, EventArgs e)
        {
            ActiveControl = cmbYear;
            cmbYear.DataSource = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
            cmbMonth.DataSource = CultureInfo.InvariantCulture.DateTimeFormat.MonthNames.Take(12).ToList();
        }

        ReportDocument crypt = new ReportDocument();

        private void btnView_Click(object sender, EventArgs e)
        {
            crypt.Load(@"D:\Amarjeet\SEED\C#\Payroll\Payroll\Reports\repSalary.rpt");
            Connection con = new Connection();
            DataSet objDS = new DataSet();
            con.getData("Select * from Employee");
            con.sda.Fill(objDS, "Employee");
            con.getData("Select * from SalaryProcess Where Year = '"+cmbYear.Text+"' and Month = '"+cmbMonth.Text+"'");
            con.sda.Fill(objDS, "SalaryProcess");
            crypt.SetDataSource(objDS);
            crptSalary.ReportSource = crypt;
        }
    }
}
