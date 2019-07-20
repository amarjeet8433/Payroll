namespace Payroll.ReportForm
{
    partial class frmEmpReport
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
            this.crptEmployee = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crptEmployee
            // 
            this.crptEmployee.ActiveViewIndex = -1;
            this.crptEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptEmployee.Location = new System.Drawing.Point(0, 0);
            this.crptEmployee.Name = "crptEmployee";
            this.crptEmployee.Size = new System.Drawing.Size(971, 532);
            this.crptEmployee.TabIndex = 0;
            this.crptEmployee.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmEmpReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 532);
            this.Controls.Add(this.crptEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmEmpReport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Report";
            this.Load += new System.EventHandler(this.frmEmpReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptEmployee;
    }
}