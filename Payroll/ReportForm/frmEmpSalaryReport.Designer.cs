namespace Payroll.ReportForm
{
    partial class frmEmpSalaryReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crptEmpSalary = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crptEmpSalary
            // 
            this.crptEmpSalary.ActiveViewIndex = -1;
            this.crptEmpSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptEmpSalary.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptEmpSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptEmpSalary.Location = new System.Drawing.Point(0, 0);
            this.crptEmpSalary.Name = "crptEmpSalary";
            this.crptEmpSalary.Size = new System.Drawing.Size(944, 514);
            this.crptEmpSalary.TabIndex = 0;
            this.crptEmpSalary.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmEmpSalaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(944, 514);
            this.Controls.Add(this.crptEmpSalary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmEmpSalaryReport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Salary Report";
            this.Load += new System.EventHandler(this.frmEmpSalaryReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptEmpSalary;
    }
}