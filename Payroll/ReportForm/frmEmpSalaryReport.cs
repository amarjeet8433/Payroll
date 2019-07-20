using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmEmpSalaryReport : Form
    {
        public frmEmpSalaryReport()
        {
            InitializeComponent();
        }

        ReportDocument crypt = new ReportDocument();

        private void frmEmpSalaryReport_Load(object sender, EventArgs e)
        {
            crypt.Load(@"D:\Amarjeet\SEED\C#\Payroll\Payroll\Reports\repEmpSalary.rpt");
            Connection con = new Connection();
            DataSet objDS = new DataSet();
            con.getData("Select * from Employee");
            con.sda.Fill(objDS, "Employee");
            con.getData("Select * from EmpSalary");
            con.sda.Fill(objDS, "EmpSalary");
            crypt.SetDataSource(objDS);
            crptEmpSalary.ReportSource = crypt;
        }
    }
}
