using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll.Employee
{
    public partial class frmEmpSalary : Form
    {
        Connection con = new Connection();

        public frmEmpSalary()
        {
            InitializeComponent();
        }

        private void txtEmpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (grdEmployeeData.Rows.Count > 0)
                {
                    txtEmpID.Text = grdEmployeeData.SelectedRows[0].Cells[0].Value.ToString();
                    txtName.Text = grdEmployeeData.SelectedRows[0].Cells[1].Value.ToString();
                    dtpJoinDate.Focus();
                }
            }
        }

        private void txtEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {
            con.getData("SELECT TOP(10) [EmpId], [Name] FROM [Employee] WHERE [EmpId] LIKE '" + txtEmpID.Text + "%'");
            DataTable objDT = new DataTable();
            con.sda.Fill(objDT);
            grdEmployeeData.DataSource = objDT;
        }

        private void dtpJoinDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSalaryPA.Focus();
            }
        }

        private void txtSalaryPA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSalaryPA.Text.Length > 0)
                {
                    btnSave.Focus();
                }
                else
                {
                    txtSalaryPA.Focus();
                }
            }
        }

        private void txtSalaryPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void frmEmpSalary_Load(object sender, EventArgs e)
        {
            ActiveControl = txtEmpID;
            loadData();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtEmpID.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmpID, "Employee ID Required");
            }
            else if (string.IsNullOrEmpty(txtSalaryPA.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmpID, "Employee Salary Required");
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
            return result;
        }

        private void clearData()
        {
            txtEmpID.Clear();
            txtName.Clear();
            dtpJoinDate.Value = DateTime.Now;
            txtSalaryPA.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtEmpID.Enabled = true;
        }

        private void loadData()
        {
            con.getData("SELECT EmpSalary.*, Employee.Name FROM Employee Inner Join EmpSalary ON Employee.EmpId = EmpSalary.EmpId");
            DataTable objDT = new DataTable();
            con.sda.Fill(objDT);
            grdEmpSalaryData.Rows.Clear();
            foreach (DataRow objDR in objDT.Rows)
            {
                int n = grdEmpSalaryData.Rows.Add();
                grdEmpSalaryData.Rows[n].Cells["grdEmpId"].Value = objDR["EmpId"].ToString();
                grdEmpSalaryData.Rows[n].Cells["grdEmpName"].Value = objDR["Name"].ToString();
                grdEmpSalaryData.Rows[n].Cells["grdJoinDate"].Value = Convert.ToDateTime(objDR["JoinDate"].ToString()).ToString("dd/MMM/yy");
                grdEmpSalaryData.Rows[n].Cells["grdSalaryPA"].Value = objDR["SalaryPA"].ToString();
            }
        }

        private bool IfEmployeeExists(string empId)
        {
            con.getData("SELECT 1 FROM [EmpSalary] WHERE [EmpId] = '" + empId + "'");
            DataTable objDT = new DataTable();
            con.sda.Fill(objDT);
            if (objDT.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (IfEmployeeExists(txtEmpID.Text))
                {
                    MessageBox.Show("Employee Record Already Exists!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.sendData(@"INSERT INTO [EmpSalary](EmpId, JoinDate, SalaryPA) VALUES('" + txtEmpID.Text + "', '" + dtpJoinDate.Value.ToString("dd/MMM/yy") + "', '" + txtSalaryPA.Text + "')");
                    MessageBox.Show("Employee Salary Assigned Successfully!!!", "Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                    loadData();
                }
            }
        }

        private void grdEmpSalaryData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEmpID.Text = grdEmpSalaryData.SelectedRows[0].Cells["grdEmpId"].Value.ToString();
            txtName.Text = grdEmpSalaryData.SelectedRows[0].Cells["grdEmpName"].Value.ToString();
            dtpJoinDate.Text = grdEmpSalaryData.SelectedRows[0].Cells["grdJoinDate"].Value.ToString();
            txtSalaryPA.Text = grdEmpSalaryData.SelectedRows[0].Cells["grdSalaryPA"].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            txtEmpID.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (MessageBox.Show("Are you sure, you want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.sendData("Update EmpSalary Set JoinDate='" + dtpJoinDate.Value.ToString("dd/MMM/yy") + "', SalaryPA='" + txtSalaryPA.Text + "' Where EmpId='" + txtEmpID.Text + "'");
                    MessageBox.Show("Employee Data Updated Successfully!!!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                    loadData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.sendData("Delete from EmpSalary Where EmpId='" + txtEmpID.Text + "'");
                MessageBox.Show("Employee Data Deleted Successfully!!!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
                loadData();
            }
        }
    }
}
