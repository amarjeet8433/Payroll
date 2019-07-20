using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll.User
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserName.Text.Length > 0)
                {
                    txtOldPassword.Focus();
                }
                else
                {
                    txtUserName.Focus();
                }
            }
        }

        private void txtOldPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOldPassword.Text.Length > 0)
                {
                    txtNewPassword.Focus();
                }
                else
                {
                    txtOldPassword.Focus();
                }
            }
        }

        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNewPassword.Text.Length > 0)
                {
                    txtConfirmPassword.Focus();
                }
                else
                {
                    txtNewPassword.Focus();
                }
            }
        }

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtConfirmPassword.Text.Length > 0)
                {
                    btnChangePassword.Focus();
                }
                else
                {
                    txtConfirmPassword.Focus();
                }
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ActiveControl = txtUserName;
        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtUserName, "Username Required");
            }
            else if (string.IsNullOrEmpty(txtOldPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtOldPassword, "Old Password Required");
            }
            else if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtNewPassword, "New Password Required");
            }
            else if (txtNewPassword.Text.Length < 4)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtNewPassword, "Minimum 4 characters/digits are required");
            }
            else if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password Required");
            }
            else if (txtConfirmPassword.Text.Length < 4)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConfirmPassword, "Minimum 4 characters/digits are required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        private bool IfUNPassExists(string userName, string password)
        {
            Connection con = new Connection();
            con.getData("SELECT 1 FROM [User] WHERE [UserName] = '" + userName + "' AND [Password] = '" + password + "'");
            DataTable objDT = new DataTable();
            con.sda.Fill(objDT);
            if (objDT.Rows.Count > 0)
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    con.sendData("UPDATE [User] SET [Password]='" + txtNewPassword.Text + "' WHERE [UserName]='" + userName + "' AND [Password]='" + password + "'");
                    MessageBox.Show("Password changed succesfully!!!", "Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtNewPassword, "Password Mismatch");
                    errorProvider1.SetError(txtConfirmPassword, "Password Mismatch");
                    txtNewPassword.Clear();
                    txtConfirmPassword.Clear();
                }
                return true;
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtUserName, "Please check entered Username and Password");
                errorProvider1.SetError(txtOldPassword, "Please check entered Username and Password");
                txtOldPassword.Clear();
                return false;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (MessageBox.Show("Are you sure, you want to Change Password?", "Change Password.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (IfUNPassExists(txtUserName.Text, txtOldPassword.Text))
                    {
                        txtUserName.Clear();
                        txtOldPassword.Clear();
                        txtNewPassword.Clear();
                        txtConfirmPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Entered Username or Password does not exixts!!!", "Does Not Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtOldPassword.Clear();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
