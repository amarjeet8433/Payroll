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
    public partial class frmEmpReport : Form
    {
        ReportDocument crypt = new ReportDocument();

        public frmEmpReport()
        {
            InitializeComponent();
        }

        private void frmEmpReport_Load(object sender, EventArgs e)
        {
            crypt.Load(@"D:\Amarjeet\SEED\C#\Payroll\Payroll\Reports\repEmployee.rpt");
            Connection con = new Connection();
            DataSet objDS = new DataSet();
            con.getData("Select * from Employee");
            con.sda.Fill(objDS,"Employee");
            crypt.SetDataSource(objDS);
            crptEmployee.ReportSource = crypt;
        }
    }
}
