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
    public partial class frmUserReport : Form
    {
        ReportDocument crypt = new ReportDocument();

        public frmUserReport()
        {
            InitializeComponent();
        }

        private void frmUserReport_Load(object sender, EventArgs e)
        {
            crypt.Load(@"D:\Amarjeet\SEED\C#\Payroll\Payroll\Reports\repUser.rpt");
            Connection con = new Connection();
            DataSet objDS = new DataSet();
            con.getData("Select * from [User]");
            con.sda.Fill(objDS, "User");
            crypt.SetDataSource(objDS);
            crptUser.ReportSource = crypt;
        }
    }
}
