using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll.Employee
{
    public partial class frmRegisterEmployee : Form
    {
        string fileName;

        public frmRegisterEmployee()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog objOFD = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (objOFD.ShowDialog() == DialogResult.OK)
                {
                    fileName = objOFD.FileName;
                    lblFileName.Text = fileName;
                    picEmpImg.Image = Image.FromFile(fileName);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            picEmpImg.Image = null;
        }

        private void frmRegisterEmployee_Load(object sender, EventArgs e)
        {
            lblFileName.Visible = false;
            ActiveControl = txtName;
            loadData();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtName.Text.Length > 0)
                {
                    txtMobile.Focus();
                }
                else
                {
                    txtName.Focus();
                }
            }
        }

        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMobile.Text.Length > 0)
                {
                    txtEmail.Focus();
                }
                else
                {
                    txtMobile.Focus();
                }
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmail.Text.Length > 0)
                {
                    txtPAN.Focus();
                }
                else
                {
                    txtEmail.Focus();
                }
            }
        }

        private void txtPAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPAN.Text.Length > 0)
                {
                    dtpDOB.Focus();
                }
                else
                {
                    txtPAN.Focus();
                }
            }
        }

        private void dtpDOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBankDetails.Focus();
            }
        }

        private bool Validation()
        {
            Regex mailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match mailMatch = mailRegex.Match(txtEmail.Text);

            Regex panRegex = new Regex(@"[A-Z]{5}\d{4}[A-Z]{1}");
            Match panMatch = panRegex.Match(txtPAN.Text);

            bool result = false;
            if (picEmpImg.Image == null)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(picEmpImg, "Employee Image Required");
            }
            else if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtName, "Employee Name Required");
            }
            else if (string.IsNullOrEmpty(txtMobile.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtMobile, "Employee Mobile No. Required");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmail, "Employee Email ID Required");
            }
            else if (mailMatch.Success == false)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmail, "Enter proper Email ID");
            }
            else if (string.IsNullOrEmpty(txtPAN.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPAN, "Employee PAN No. Required");
            }
            else if (panMatch.Success == false)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPAN, "Enter proper PAN No.");
            }
            else if (string.IsNullOrEmpty(txtBankDetails.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtBankDetails, "Employee Bank Details Required");
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAddress, "Employee Address Required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        private void clearData()
        {
            lblFileName.Visible = false;
            txtName.Clear();
            txtEmpID.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtPAN.Clear();
            dtpDOB.Value = DateTime.Now;
            txtBankDetails.Clear();
            txtAddress.Clear();
            picEmpImg.Image = null;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        Connection con = new Connection();

        private bool IfEmployeeExists(string mobile, string panNo)
        {
            con.getData("SELECT 1 FROM [Employee] WHERE [Mobile]='" + mobile + "' AND [PANNo]='" + panNo + "'");
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

        byte[] ConvertImageToBinary(Image objImg)
        {
            using (MemoryStream objMS = new MemoryStream())
            {
                objImg.Save(objMS, System.Drawing.Imaging.ImageFormat.Jpeg);
                return objMS.ToArray();
            }
        }

        private void loadData()
        {
            con.getData("SELECT * FROM [Employee]");
            DataTable objDT = new DataTable();
            con.sda.Fill(objDT);
            grdEmployeeData.Rows.Clear();
            foreach (DataRow objDR in objDT.Rows)
            {
                int n = grdEmployeeData.Rows.Add();
                grdEmployeeData.Rows[n].Cells["grdEmpId"].Value = objDR["EmpId"].ToString();
                grdEmployeeData.Rows[n].Cells["grdName"].Value = objDR["Name"].ToString();
                grdEmployeeData.Rows[n].Cells["grdEmail"].Value = objDR["Email"].ToString();
                grdEmployeeData.Rows[n].Cells["grdDob"].Value = Convert.ToDateTime(objDR["Dob"].ToString()).ToString("dd/MMM/yy");
                grdEmployeeData.Rows[n].Cells["grdPanNo"].Value = objDR["PANNo"].ToString();
                grdEmployeeData.Rows[n].Cells["grdMobile"].Value = objDR["Mobile"].ToString();
                grdEmployeeData.Rows[n].Cells["grdBankDetails"].Value = objDR["BankDetails"].ToString();
                grdEmployeeData.Rows[n].Cells["grdAddress"].Value = objDR["Address"].ToString();
                grdEmployeeData.Rows[n].Cells["grdFileName"].Value = objDR["FileName"].ToString();
                grdEmployeeData.Rows[n].Cells["grdImageData"].Value = objDR["ImageData"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (IfEmployeeExists(txtMobile.Text, txtPAN.Text))
                {
                    MessageBox.Show("Employee Already Exists!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.sendData("INSERT INTO [Employee](Name, Mobile, Email, PANNo, Dob, BankDetails, Address, FileName, ImageData) VALUES('" + txtName.Text + "', '" + txtMobile.Text + "', '" + txtEmail.Text + "', '" + txtPAN.Text + "', '" + dtpDOB.Value.ToString("dd/MMM/yy") + "','" + txtBankDetails.Text + "','" + txtAddress.Text + "','" + fileName + "','" + ConvertImageToBinary(picEmpImg.Image) + "')");
                    MessageBox.Show("Employee Data Saved Successfully!!!", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                    loadData();
                }
            }
        }

        private void grdEmployeeData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEmpID.Text = grdEmployeeData.SelectedRows[0].Cells["grdEmpId"].Value.ToString();
            txtName.Text = grdEmployeeData.SelectedRows[0].Cells["grdName"].Value.ToString();
            txtMobile.Text = grdEmployeeData.SelectedRows[0].Cells["grdMobile"].Value.ToString();
            txtEmail.Text = grdEmployeeData.SelectedRows[0].Cells["grdEmail"].Value.ToString();
            txtPAN.Text = grdEmployeeData.SelectedRows[0].Cells["grdPanNo"].Value.ToString();
            dtpDOB.Text = grdEmployeeData.SelectedRows[0].Cells["grdDob"].Value.ToString();
            txtBankDetails.Text = grdEmployeeData.SelectedRows[0].Cells["grdBankDetails"].Value.ToString();
            txtAddress.Text = grdEmployeeData.SelectedRows[0].Cells["grdAddress"].Value.ToString();
            lblFileName.Visible = true;
            lblFileName.Text = grdEmployeeData.SelectedRows[0].Cells["grdFileName"].Value.ToString();
            picEmpImg.Image = Image.FromFile(grdEmployeeData.SelectedRows[0].Cells["grdFileName"].Value.ToString());
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (MessageBox.Show("Are you sure, you want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.sendData("UPDATE [Employee] SET [Name] = '" + txtName.Text + "', [Mobile] = '" + txtMobile.Text + "', [Email] = '" + txtEmail.Text + "', [PANNo] = '" + txtPAN.Text + "', [Dob] = '" + dtpDOB.Value.ToString("dd/MMM/yy") + "', [BankDetails] = '" + txtBankDetails.Text + "', [Address] = '" + txtAddress.Text + "', [FileName] = '" + fileName + "', [ImageData] = '" + ConvertImageToBinary(picEmpImg.Image) + "' WHERE [EmpId] = '" + txtEmpID.Text + "'");
                    MessageBox.Show("Employee Data Updated Successfully!!!", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                    loadData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.sendData("DELETE FROM [Employee] WHERE [EmpId] = '" + txtEmpID.Text + "'");
                MessageBox.Show("Employee Data Deleted Successfully!!!", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
                loadData();
            }
        }
    }
}
