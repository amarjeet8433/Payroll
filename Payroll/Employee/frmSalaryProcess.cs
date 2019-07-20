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

namespace Payroll.Employee
{
    public partial class frmSalaryProcess : Form
    {
        public frmSalaryProcess()
        {
            InitializeComponent();
        }

        private void frmSalaryProcess_Load(object sender, EventArgs e)
        {
            ActiveControl = cmbYear;
            cmbYear.DataSource = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
            cmbMonth.DataSource = CultureInfo.InvariantCulture.DateTimeFormat.MonthNames.Take(12).ToList();
        }

        float SalaryPA = 0;
        float workingDays = 0;
        float present = 0;
        float lop = 0;
        float perDay = 0;
        float netSalary = 0;

        Connection con = new Connection();

        private void btnStart_Click(object sender, EventArgs e)
        {
            con.getData("Select * from EmpAttendance Where Year = '" + cmbYear.Text + "' and Month = '" + cmbMonth.Text + "'");
            DataTable objDT = new DataTable();
            con.sda.Fill(objDT);
            if (objDT.Rows.Count > 0)
            {
                foreach (DataRow objDR in objDT.Rows)
                {
                    con.getData("SELECT ES.SalaryPA, EA.WorkingDays, EA.PresentDays, EA.LopDays FROM EmpAttendance EA INNER JOIN EmpSalary ES ON EA.EmpId = ES.EmpId Where EA.Year = '" + cmbYear.Text + "' and EA.Month='" + cmbMonth.Text + "' and EA.EmpId = '" + objDT.Rows[0]["EmpId"].ToString() + "'");
                    DataTable objDT1 = new DataTable();
                    con.sda.Fill(objDT1);
                    SalaryPA = float.Parse(objDT1.Rows[0]["SalaryPA"].ToString());
                    workingDays = float.Parse(objDT1.Rows[0]["WorkingDays"].ToString());
                    present = float.Parse(objDT1.Rows[0]["PresentDays"].ToString());
                    lop = float.Parse(objDT1.Rows[0]["LopDays"].ToString());
                    perDay = (SalaryPA / 12) / workingDays;
                    netSalary = (perDay * present) - (perDay * lop);
                    con.sendData("INSERT INTO SalaryProcess (EmpId, Year, Month, NetSalary) VALUES ('" + objDT.Rows[0]["EmpId"].ToString() + "', '" + cmbYear.Text + "', '" + cmbMonth.Text + "', '"+netSalary+"')");
                    MessageBox.Show("Salary Generated Successfully!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
            }
        }

        void loadData()
        {
            con.getData("SELECT SalaryProcess.*, Employee.Name FROM Employee INNER JOIN SalaryProcess ON Employee.EmpId = SalaryProcess.EmpId");
            DataTable objDT = new DataTable();
            con.sda.Fill(objDT);
            grdSalaryData.Rows.Clear();
            if (objDT.Rows.Count > 0)
            {
                foreach (DataRow objDR in objDT.Rows)
                {
                    int n = grdSalaryData.Rows.Add();
                    grdSalaryData.Rows[n].Cells["grdEmpId"].Value = objDR["EmpId"].ToString();
                    grdSalaryData.Rows[n].Cells["grdName"].Value = objDR["Name"].ToString();
                    grdSalaryData.Rows[n].Cells["grdYear"].Value = objDR["Year"].ToString();
                    grdSalaryData.Rows[n].Cells["grdMonth"].Value = objDR["Month"].ToString();
                    grdSalaryData.Rows[n].Cells["grdSalary"].Value = objDR["NetSalary"].ToString();
                }
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.getData("SELECT SalaryProcess.*, Employee.Name FROM Employee INNER JOIN SalaryProcess ON Employee.EmpId = SalaryProcess.EmpId WHERE SalaryProcess.Year = '" + cmbYear.Text + "' AND SalaryProcess.Month = '" + cmbMonth.Text + "'");
            DataTable objDT = new DataTable();
            con.sda.Fill(objDT);
            grdSalaryData.Rows.Clear();
            if (objDT.Rows.Count > 0)
            {
                foreach (DataRow objDR in objDT.Rows)
                {
                    int n = grdSalaryData.Rows.Add();
                    grdSalaryData.Rows[n].Cells["grdEmpId"].Value = objDR["EmpId"].ToString();
                    grdSalaryData.Rows[n].Cells["grdName"].Value = objDR["Name"].ToString();
                    grdSalaryData.Rows[n].Cells["grdYear"].Value = objDR["Year"].ToString();
                    grdSalaryData.Rows[n].Cells["grdMonth"].Value = objDR["Month"].ToString();
                    grdSalaryData.Rows[n].Cells["grdSalary"].Value = objDR["NetSalary"].ToString();
                }
            }
            else
            {
                grdSalaryData.Rows.Clear();
            }
        }
    }
}
