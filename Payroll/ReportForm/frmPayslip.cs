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
    public partial class frmPayslip : Form
    {
        public frmPayslip()
        {
            InitializeComponent();
        }

        private void frmPayslip_Load(object sender, EventArgs e)
        {
            ActiveControl = cmbYear;
            cmbYear.DataSource = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
            cmbMonth.DataSource = CultureInfo.InvariantCulture.DateTimeFormat.MonthNames.Take(12).ToList();
        }

        private void txtEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        float SalaryPA = 0;
        float workingDays = 0;
        float Present = 0;
        float LOP = 0;
        float perDay = 0;
        float Income = 0;
        float Deduction = 0;
        float netSalary = 0;

        ReportDocument crypt = new ReportDocument();

        Connection con = new Connection();

        private void txtEmpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                con.getData("Select * from Payslip Where Year = '" + cmbYear.Text + "' and Month = '" + cmbMonth.Text + "' and EmpId = '" + txtEmpID.Text + "'");
                DataTable objDT = new DataTable();
                con.sda.Fill(objDT);
                if (objDT.Rows.Count > 0)
                {
                    SalaryPA = float.Parse(objDT.Rows[0]["SalaryPA"].ToString());
                    workingDays = float.Parse(objDT.Rows[0]["WorkingDays"].ToString());
                    Present = float.Parse(objDT.Rows[0]["PresentDays"].ToString());
                    LOP = float.Parse(objDT.Rows[0]["LopDays"].ToString());
                    perDay = (SalaryPA / 12) / workingDays;
                    Income = perDay * Present;
                    Deduction = perDay * LOP;
                    netSalary = Income - Deduction;
                    con.getData("Select * from Payslip Where Year = '" + cmbYear.Text + "' and Month = '" + cmbMonth.Text + "' and EmpId = '" + txtEmpID.Text + "'");
                    DataSet objDS = new DataSet();
                    con.sda.Fill(objDS, "Payslip");
                    crypt.Load(@"D:\Amarjeet\SEED\C#\Payroll\Payroll\Reports\repPayslip.rpt");
                    crypt.SetDataSource(objDS);
                    crypt.SetParameterValue("@Income", Income);
                    crypt.SetParameterValue("@Deductions", Deduction);
                    crypt.SetParameterValue("@Salary", netSalary);
                    crptPayslip.ReportSource = crypt;
                }
                else
                {
                    crptPayslip.ReportSource = null;
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int empID = int.Parse(txtEmpID.Text);
            txtEmpID.Text = (empID - 1).ToString();

            con.getData("Select * from Payslip Where Year = '" + cmbYear.Text + "' and Month = '" + cmbMonth.Text + "' and EmpId = '" + txtEmpID.Text + "'");
            DataTable objDT = new DataTable();
            con.sda.Fill(objDT);
            if (objDT.Rows.Count > 0)
            {
                SalaryPA = float.Parse(objDT.Rows[0]["SalaryPA"].ToString());
                workingDays = float.Parse(objDT.Rows[0]["WorkingDays"].ToString());
                Present = float.Parse(objDT.Rows[0]["PresentDays"].ToString());
                LOP = float.Parse(objDT.Rows[0]["LopDays"].ToString());
                perDay = (SalaryPA / 12) / workingDays;
                Income = perDay * Present;
                Deduction = perDay * LOP;
                netSalary = Income - Deduction;
                con.getData("Select * from Payslip Where Year = '" + cmbYear.Text + "' and Month = '" + cmbMonth.Text + "' and EmpId = '" + txtEmpID.Text + "'");
                DataSet objDS = new DataSet();
                con.sda.Fill(objDS, "Payslip");
                crypt.Load(@"D:\Amarjeet\SEED\C#\Payroll\Payroll\Reports\repPayslip.rpt");
                crypt.SetDataSource(objDS);
                crypt.SetParameterValue("@Income", Income);
                crypt.SetParameterValue("@Deductions", Deduction);
                crypt.SetParameterValue("@Salary", netSalary);
                crptPayslip.ReportSource = crypt;
            }
            else
            {
                crptPayslip.ReportSource = null;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int empID = int.Parse(txtEmpID.Text);
            txtEmpID.Text = (empID + 1).ToString();

            con.getData("Select * from Payslip Where Year = '" + cmbYear.Text + "' and Month = '" + cmbMonth.Text + "' and EmpId = '" + txtEmpID.Text + "'");
            DataTable objDT = new DataTable();
            con.sda.Fill(objDT);
            if (objDT.Rows.Count > 0)
            {
                SalaryPA = float.Parse(objDT.Rows[0]["SalaryPA"].ToString());
                workingDays = float.Parse(objDT.Rows[0]["WorkingDays"].ToString());
                Present = float.Parse(objDT.Rows[0]["PresentDays"].ToString());
                LOP = float.Parse(objDT.Rows[0]["LopDays"].ToString());
                perDay = (SalaryPA / 12) / workingDays;
                Income = perDay * Present;
                Deduction = perDay * LOP;
                netSalary = Income - Deduction;
                con.getData("Select * from Payslip Where Year = '" + cmbYear.Text + "' and Month = '" + cmbMonth.Text + "' and EmpId = '" + txtEmpID.Text + "'");
                DataSet objDS = new DataSet();
                con.sda.Fill(objDS, "Payslip");
                crypt.Load(@"D:\Amarjeet\SEED\C#\Payroll\Payroll\Reports\repPayslip.rpt");
                crypt.SetDataSource(objDS);
                crypt.SetParameterValue("@Income", Income);
                crypt.SetParameterValue("@Deductions", Deduction);
                crypt.SetParameterValue("@Salary", netSalary);
                crptPayslip.ReportSource = crypt;
            }
            else
            {
                crptPayslip.ReportSource = null;
            }
        }
    }
}
