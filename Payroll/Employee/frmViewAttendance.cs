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
    public partial class frmViewAttendance : Form
    {
        public frmViewAttendance()
        {
            InitializeComponent();
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedIndex == 0)
            {
                txtSearch.Visible = false;
            }
            if (cmbSearch.SelectedIndex != 0)
            {
                txtSearch.Visible = true;
                txtSearch.Clear();
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

        private void frmViewAttendance_Load(object sender, EventArgs e)
        {
            ActiveControl = cmbSearch;
            txtSearch.Visible = false;
            cmbSearch.SelectedIndex = 0;
            Search();
            cmbYear.DataSource = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
            cmbMonth.DataSource = CultureInfo.InvariantCulture.DateTimeFormat.MonthNames.Take(12).ToList();
        }

        bool change = true;

        private void employee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (change)
            {
                change = false;
                txtSearch.Text = grdView.SelectedRows[0].Cells[0].Value.ToString();
                grdView.Visible = false;
                cmbYear.Focus();
                change = true;
            }
        }

        Connection con = new Connection();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length != 0)
            {
                if (cmbSearch.SelectedIndex == 1)
                {
                    grdView.Visible = true;
                    grdView.BringToFront();
                    Search(90, 70, 400, 200, "EMP ID, Emp Name", "100, 0");
                    grdView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(employee_MouseDoubleClick);

                    con.getData("SELECT TOP(10) EmpId, Name FROM Employee WHERE EmpId LIKE '" + txtSearch.Text + "%'");
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
            }
        }

        void loadData(string condition)
        {
            con.getData("SELECT EmpAttendance.*, Employee.Name FROM Employee INNER JOIN EmpAttendance ON Employee.EmpId = EmpAttendance.EmpId " + condition + "");
            DataTable objDT = new DataTable();
            con.sda.Fill(objDT);
            grdEmpAttendData.Rows.Clear();
            foreach (DataRow objDR in objDT.Rows)
            {
                int n = grdEmpAttendData.Rows.Add();
                grdEmpAttendData.Rows[n].Cells["grdEmpId"].Value = objDR["EmpId"].ToString();
                grdEmpAttendData.Rows[n].Cells["grdName"].Value = objDR["Name"].ToString();
                grdEmpAttendData.Rows[n].Cells["grdYear"].Value = objDR["Year"].ToString();
                grdEmpAttendData.Rows[n].Cells["grdMonth"].Value = objDR["Month"].ToString();
                grdEmpAttendData.Rows[n].Cells["grdTotalDays"].Value = objDR["TotalDays"].ToString();
                grdEmpAttendData.Rows[n].Cells["grdWorkingDays"].Value = objDR["WorkingDays"].ToString();
                grdEmpAttendData.Rows[n].Cells["grdPresent"].Value = objDR["PresentDays"].ToString();
                grdEmpAttendData.Rows[n].Cells["grdAbsent"].Value = objDR["AbsentDays"].ToString();
                grdEmpAttendData.Rows[n].Cells["grdLop"].Value = objDR["LopDays"].ToString();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (grdView.Rows.Count > 0)
                {
                    txtSearch.Text = grdView.SelectedRows[0].Cells[0].Value.ToString();
                    grdView.Visible = false;
                    cmbYear.Focus();
                }
                else
                {
                    grdView.Visible = false;
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedIndex == 0)
            {
                loadData("WHERE EmpAttendance.Year='" + cmbYear.Text + "' AND EmpAttendance.Month='" + cmbMonth.Text + "'");
            }
            if (cmbSearch.SelectedIndex == 1)
            {
                loadData("WHERE EmpAttendance.EmpId='" + txtSearch.Text + "' AND EmpAttendance.Year='" + cmbYear.Text + "' AND EmpAttendance.Month='" + cmbMonth.Text + "'");
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}