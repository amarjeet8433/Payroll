namespace Payroll.ReportForm
{
    partial class frmEmpAttendanceReport
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
            this.crptEmpAttend = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crptEmpAttend
            // 
            this.crptEmpAttend.ActiveViewIndex = -1;
            this.crptEmpAttend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptEmpAttend.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptEmpAttend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptEmpAttend.Location = new System.Drawing.Point(0, 0);
            this.crptEmpAttend.Name = "crptEmpAttend";
            this.crptEmpAttend.Size = new System.Drawing.Size(944, 514);
            this.crptEmpAttend.TabIndex = 0;
            this.crptEmpAttend.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnExport.Location = new System.Drawing.Point(480, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmEmpAttendanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(944, 514);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.crptEmpAttend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmEmpAttendanceReport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Attendance Report";
            this.Load += new System.EventHandler(this.frmEmpAttendanceReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptEmpAttend;
        private System.Windows.Forms.Button btnExport;
    }
}