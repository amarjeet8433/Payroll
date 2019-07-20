using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll.User
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtName.Text.Length > 0)
                {
                    txtUserName.Focus();
                }
                else
                {
                    txtName.Focus();
                }
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserName.Text.Length > 0)
                {
                    dtpDob.Focus();
                }
                else
                {
                    txtUserName.Focus();
                }
            }
        }

        private void dtpDob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmail.Text.Length > 0)
                {
                    txtPassword.Focus();
                }
                else
                {
                    txtEmail.Focus();
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPassword.Text.Length > 0)
                {
                    cmbRole.Focus();
                }
                else
                {
                    txtPassword.Focus();
                }
            }
        }

        private void cmbRole_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbRole.Text.Length > 0)
                {
                    txtAddress.Focus();
                }
                else
                {
                    cmbRole.Focus();
                }
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAddress.Text.Length > 0)
                {
                    btnSave.Focus();
                }
                else
                {
                    txtAddress.Focus();
                }
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            ActiveControl = txtName;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            loadData();
        }

        private void clearData()
        {
            txtName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            cmbRole.SelectedIndex = -1;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            dtpDob.Value = DateTime.Now;
        }

        private bool Validation()
        {
            Regex objRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match emailMatch = objRegex.Match(txtEmail.Text);

            bool result = false;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtName, "Name Required");
            }
            else if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtUserName, "Username Required");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Password Required");
            }
            else if (txtPassword.Text.Length < 4)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Minimum 4 characters/digits are required");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmail, "Email Required");
            }
            else if (emailMatch.Success == false)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmail, "Enter Proper Email");
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAddress, "Address Required");
            }
            else if (cmbRole.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbRole, "Select Role");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        Connection con = new Connection();

        private bool IfUserNameExists(string userName)
        {
            con.getData("SELECT 1 FROM [User] WHERE [UserName] = '" + userName + "'");
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
                if (IfUserNameExists(txtUserName.Text))
                {
                    MessageBox.Show("Entered Username already exixts!!!", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.sendData("INSERT INTO [User](Name, Email, UserName, Password, Role, Dob, Address) VALUES('" + txtName.Text + "','" + txtEmail.Text + "','" + txtUserName.Text + "','" + txtPassword.Text + "','" + cmbRole.Text + "','" + dtpDob.Value.ToString("dd/MMM/yy") + "','" + txtAddress.Text + "')");
                    MessageBox.Show("Record Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                    loadData();
                }
            }
        }

        private void loadData()
        {
            con.getData("SELECT * FROM [User]");
            DataTable objDT = new DataTable();
            con.sda.Fill(objDT);
            grdUserData.Rows.Clear();
            foreach (DataRow objDR in objDT.Rows)
            {
                int n = grdUserData.Rows.Add();
                grdUserData.Rows[n].Cells["grdSno"].Value = n + 1;
                grdUserData.Rows[n].Cells["grdName"].Value = objDR["Name"].ToString();
                grdUserData.Rows[n].Cells["grdDob"].Value = objDR["Dob"].ToString();
                grdUserData.Rows[n].Cells["grdEmail"].Value = objDR["Email"].ToString();
                grdUserData.Rows[n].Cells["grdUserName"].Value = objDR["UserName"].ToString();
                grdUserData.Rows[n].Cells["grdRole"].Value = objDR["Role"].ToString();
                grdUserData.Rows[n].Cells["grdAddress"].Value = objDR["Address"].ToString();
            }
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
        }

        private void grdUserData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtName.Text = grdUserData.SelectedRows[0].Cells["grdName"].Value.ToString();
            txtUserName.Text = grdUserData.SelectedRows[0].Cells["grdUserName"].Value.ToString();
            txtEmail.Text = grdUserData.SelectedRows[0].Cells["grdEmail"].Value.ToString();
            txtAddress.Text = grdUserData.SelectedRows[0].Cells["grdAddress"].Value.ToString();
            dtpDob.Text = grdUserData.SelectedRows[0].Cells["grdDob"].Value.ToString();
            cmbRole.Text = grdUserData.SelectedRows[0].Cells["grdRole"].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (MessageBox.Show("Are you sure, you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.sendData("UPDATE [User] SET Name='" + txtName.Text + "', Email = '" + txtEmail.Text + "', Role = '" + cmbRole.Text + "', Dob='" + dtpDob.Value.ToString("dd/MMM/yy") + "', Address='" + txtAddress.Text + "' WHERE UserName='" + txtUserName.Text + "'");
                    MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                    loadData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.sendData("DELETE FROM [User] WHERE UserName = '" + txtUserName.Text + "'");
                MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
                loadData();
            }
        }
    }
}
