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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Red;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Cornsilk;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.getData("SELECT * FROM [User] WHERE UserName = '" + txtUserName.Text + "' AND Password = '" + txtPassword.Text + "'");
            DataTable objDT = new DataTable();
            con.sda.Fill(objDT);

            if (objDT.Rows.Count > 0)
            {
                Hide();
                frmMain objMain = new frmMain();
                objMain.Show();
            }
            else
            {
                MessageBox.Show("Ivalid User Name or Password....", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ActiveControl = txtUserName;
        }

        private void lnkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User.frmChangePassword objChangePassword = new User.frmChangePassword();
            objChangePassword.StartPosition = FormStartPosition.CenterScreen;
            objChangePassword.Show();
        }
    }
}
