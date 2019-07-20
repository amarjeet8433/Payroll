using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogin objLogin = new frmLogin();
                objLogin.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.frmRegister objRegUser = new User.frmRegister();
            objRegUser.MdiParent = this;
            objRegUser.StartPosition = FormStartPosition.CenterScreen;
            objRegUser.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.frmChangePassword objChangePass = new User.frmChangePassword();
            objChangePass.MdiParent = this;
            objChangePass.StartPosition = FormStartPosition.CenterScreen;
            objChangePass.Show();
        }

        private void registerEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee.frmRegisterEmployee objRegEmp = new Employee.frmRegisterEmployee();
            objRegEmp.MdiParent = this;
            objRegEmp.StartPosition = FormStartPosition.CenterScreen;
            objRegEmp.Show();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee.frmEmpSalary objEmpSal = new Employee.frmEmpSalary();
            objEmpSal.MdiParent = this;
            objEmpSal.StartPosition = FormStartPosition.CenterScreen;
            objEmpSal.Show();
        }

        private void employeeAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee.frmEmpAttendance objEmpAttend = new Employee.frmEmpAttendance();
            objEmpAttend.MdiParent = this;
            objEmpAttend.StartPosition = FormStartPosition.CenterScreen;
            objEmpAttend.Show();
        }

        private void viewAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee.frmViewAttendance objViewAttend = new Employee.frmViewAttendance();
            objViewAttend.MdiParent = this;
            objViewAttend.StartPosition = FormStartPosition.CenterScreen;
            objViewAttend.Show();
        }

        private void salaryProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee.frmSalaryProcess objSalProcess = new Employee.frmSalaryProcess();
            objSalProcess.MdiParent = this;
            objSalProcess.StartPosition = FormStartPosition.CenterScreen;
            objSalProcess.Show();
        }

        private void userReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm.frmUserReport objUserReport = new ReportForm.frmUserReport();
            objUserReport.MdiParent = this;
            objUserReport.StartPosition = FormStartPosition.CenterScreen;
            objUserReport.Show();
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm.frmEmpSalaryReport objEmpSalReport = new ReportForm.frmEmpSalaryReport();
            objEmpSalReport.MdiParent = this;
            objEmpSalReport.StartPosition = FormStartPosition.CenterScreen;
            objEmpSalReport.Show();
        }

        private void employeeAttendanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm.frmEmpAttendanceReport objEmpAttendReport = new ReportForm.frmEmpAttendanceReport();
            objEmpAttendReport.MdiParent = this;
            objEmpAttendReport.StartPosition = FormStartPosition.CenterScreen;
            objEmpAttendReport.Show();
        }

        private void employeeReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportForm.frmEmpReport objEmpReport = new ReportForm.frmEmpReport();
            objEmpReport.MdiParent = this;
            objEmpReport.StartPosition = FormStartPosition.CenterScreen;
            objEmpReport.Show();
        }

        private void salaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm.frmSalaryReport objSalReport = new ReportForm.frmSalaryReport();
            objSalReport.MdiParent = this;
            objSalReport.StartPosition = FormStartPosition.CenterScreen;
            objSalReport.Show();
        }

        private void payslipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm.frmPayslip objPayslip = new ReportForm.frmPayslip();
            objPayslip.MdiParent = this;
            objPayslip.StartPosition = FormStartPosition.CenterScreen;
            objPayslip.Show();
        }
    }
}
