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
    public partial class frmEmpAttendance : Form
    {
        public frmEmpAttendance()
        {
            InitializeComponent();
        }

        private void txtEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPresentDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtAbsentDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtLOPDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private DataGridView grdView;
        private DataGridViewTextBoxColumn grdViewCol1;
        private DataGridViewTextBoxColumn grdViewCol2;

        void Search()
        {
            grdView = new DataGridView();
            grdViewCol1 = new DataGridViewTextBoxColumn();
            grdViewCol2 = new DataGridViewTextBoxColumn();
            grdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { grdViewCol1, grdViewCol2 });
            grdView.Name = "grdView";
            grdView.Visible = false;
            grdViewCol1.Visible = false;
            grdViewCol2.Visible = false;
            grdView.AllowUserToAddRows = false;
            grdView.RowHeadersVisible = false;
            grdView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            Controls.Add(grdView);
            grdView.ReadOnly = true;
            grdView.BringToFront();
        }

        void Search(int LX, int LY, int DW, int DH, string ColName, string ColSize)
        {
            grdView.Location = new System.Drawing.Point(LX, LY);
            grdView.Size = new System.Drawing.Size(DW, DH);

            string[] ClSize = ColSize.Split(',');
            for (int i = 0; i < ClSize.Length; i++)
            {
                if (int.Parse(ClSize[i]) != 0)
                {
                    grdView.Columns[i].Width = int.Parse(ClSize[i]);
                }
                else
                {
                    grdView.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                }
            }

            string[] CLName = ColName.Split(',');
            for (int i = 0; i < CLName.Length; i++)
            {
                grdView.Columns[i].HeaderText = CLName[i];
                grdView.Columns[i].Visible = true;
            }
        }

        private void frmEmpAttendance_Load(object sender, EventArgs e)
        {
            Search();
            ActiveControl = txtEmpID;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnView.Enabled = true;
            cmbYear.DataSource = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
            cmbMonth.DataSource = CultureInfo.InvariantCulture.DateTimeFormat.MonthNames.Take(12).ToList();
        }

        Connection con = new Connection();

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpID.Text.Length > 0)
            {
                grdView.Visible = true;
                grdView.BringToFront();
                Search(90, 70, 400, 200, "EMP ID, Emp Name", "100, 0");
                grdView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(employee_MouseDoubleClick);

                con.getData("SELECT TOP(10) EmpId, Name FROM Employee WHERE EmpId LIKE '" + txtEmpID.Text + "%'");
                DataTable objDT = new DataTable();
                con.sda.Fill(objDT);
                grdView.Rows.Clear();
                foreach (DataRow objDR in objDT.Rows)
                {
                    int n = grdView.Rows.Add();
                    grdView.Rows[n].Cells[0].Value = objDR["EmpId"].ToString();
                    grdView.Rows[n].Cells[1].Value = objDR["Name"].ToString();
                }
            }
            else
            {
                grdView.Visible = false;
            }
        }

        bool change = true;

        private void employee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (change)
            {
                change = false;
                txtEmpID.Text = grdView.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = grdView.SelectedRows[0].Cells[1].Value.ToString();
                grdView.Visible = false;
                cmbYear.Focus();
                change = true;
            }
        }

        private void txtEmpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (grdView.Rows.Count > 0)
                {
                    txtEmpID.Text = grdView.SelectedRows[0].Cells[0].Value.ToString();
                    txtName.Text = grdView.SelectedRows[0].Cells[1].Value.ToString();
                    grdView.Visible = false;
                    cmbYear.Focus();
                }
                else
                {
                    grdView.Visible = false;
                }
            }
        }

        private void loadDateCombo()
        {
            string s = cmbMonth.SelectedItem.ToString() + "," + cmbYear.SelectedItem.ToString();
            DateTime dt = DateTime.Parse(s);
            int days = DateTime.DaysInMonth(dt.Year, dt.Month);
            int count;
            count = 0;
            for (int i = 0; i < days; ++i)
            {
                DateTime d = new DateTime(dt.Year, dt.Month, i + 1);
                if (d.DayOfWeek == DayOfWeek.Sunday)
                {
                    count = count + 1;
                }
            }
            txtTotalDays.Text = days.ToString();
            txtWorkingDays.Text = (days - count).ToString();
        }

        private void cmbYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbYear.SelectedIndex != -1)
                {
                    cmbMonth.Focus();
                }
                else
                {
                    cmbYear.Focus();
                }
            }
        }

        private void cmbMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbMonth.SelectedIndex != -1)
                {
                    txtPresentDays.Focus();
                }
                else
                {
                    cmbMonth.Focus();
                }
            }
        }

        private void txtPresentDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPresentDays.Text.Length > 0)
                {
                    txtAbsentDays.Focus();
                }
                else
                {
                    txtPresentDays.Focus();
                }
            }
        }

        private void txtAbsentDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAbsentDays.Text.Length > 0)
                {
                    txtLOPDays.Focus();
                }
                else
                {
                    txtAbsentDays.Focus();
                }
            }
        }

        private void txtLOPDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtLOPDays.Text.Length > 0)
                {
                    btnSave.Focus();
                }
                else
                {
                    txtLOPDays.Focus();
                }
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedIndex != -1)
            {
                loadDateCombo();
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedIndex != -1)
            {
                con.getData("SELECT * FROM [EmpAttendance] WHERE EmpId = '" + txtEmpID.Text + "' AND Year = '" + cmbYear.Text + "' AND Month = '" + cmbMonth.Text + "'");
                DataTable objDT = new DataTable();
                con.sda.Fill(objDT);
                if (objDT.Rows.Count > 0)
                {
                    txtTotalDays.Text = objDT.Rows[0]["TotalDays"].ToString();
                    txtWorkingDays.Text = objDT.Rows[0]["WorkingDays"].ToString();
                    txtPresentDays.Text = objDT.Rows[0]["PresentDays"].ToString();
                    txtAbsentDays.Text = objDT.Rows[0]["AbsentDays"].ToString();
                    txtLOPDays.Text = objDT.Rows[0]["LopDays"].ToString();
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    txtTotalDays.Clear();
                    txtWorkingDays.Clear();
                    txtPresentDays.Clear();
                    txtAbsentDays.Clear();
                    txtLOPDays.Clear();
                    btnSave.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnView.Enabled = true;
                }
            }
            loadDateCombo();
        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtEmpID.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmpID, "Employee ID Required");
            }
            else if (string.IsNullOrEmpty(cmbYear.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbYear, "Select Year");
            }
            else if (string.IsNullOrEmpty(cmbMonth.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbMonth, "Select Month");
            }
            else if (string.IsNullOrEmpty(txtTotalDays.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtTotalDays, "Total Days Required");
            }
            else if (string.IsNullOrEmpty(txtWorkingDays.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtWorkingDays, "Working Days Required");
            }
            else if (string.IsNullOrEmpty(txtPresentDays.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPresentDays, "Present Days Required");
            }
            else if (txtPresentDays.Text.Length > 2)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPresentDays, "Enter proper value!!");
            }
            else if (string.IsNullOrEmpty(txtAbsentDays.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAbsentDays, "Absent Days Required");
            }
            else if (txtAbsentDays.Text.Length > 2)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAbsentDays, "Enter proper value!!");
            }
            else if (string.IsNullOrEmpty(txtLOPDays.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtLOPDays, "LOP Days Required");
            }
            else if (txtLOPDays.Text.Length > 2)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtLOPDays, "Enter proper value!!");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                con.sendData("INSERT INTO [EmpAttendance](EmpId, Year, Month, TotalDays, WorkingDays, PresentDays, AbsentDays, LopDays) VALUES('" + txtEmpID.Text + "', '" + cmbYear.Text + "', '" + cmbMonth.Text + "', '" + txtTotalDays.Text + "', '" + txtWorkingDays.Text + "', '" + txtPresentDays.Text + "', '" + txtAbsentDays.Text + "', '" + txtLOPDays.Text + "')");
                MessageBox.Show("Employee Attendance Saved Successfully!!!", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
            }
        }

        private void clearData()
        {
            txtEmpID.Clear();
            txtName.Clear();
            cmbYear.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
            txtTotalDays.Clear();
            txtWorkingDays.Clear();
            txtPresentDays.Clear();
            txtAbsentDays.Clear();
            txtLOPDays.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnView.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (MessageBox.Show("Are you sure, you want to Update?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.sendData("UPDATE [EmpAttendance] SET TotalDays='" + txtTotalDays.Text + "', WorkingDays='" + txtWorkingDays.Text + "', PresentDays='" + txtPresentDays.Text + "', AbsentDays='" + txtAbsentDays.Text + "', LopDays='" + txtLOPDays.Text + "' WHERE EmpId='" + txtEmpID.Text + "' AND Year='" + cmbYear.Text + "' AND Month='" + cmbMonth.Text + "'");
                    MessageBox.Show("Employee Attendance Updated Successfully!!!", "Update Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to Delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.sendData("DELETE FROM [EmpAttendance] WHERE EmpId='" + txtEmpID.Text + "' AND Year='" + cmbYear.Text + "' AND Month='" + cmbMonth.Text + "'");
                MessageBox.Show("Employee Attendance Deleted Successfully!!!", "Delete Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmViewAttendance objViewAttend = new frmViewAttendance();
            objViewAttend.StartPosition = FormStartPosition.CenterScreen;
            objViewAttend.Show();
        }
    }
}
