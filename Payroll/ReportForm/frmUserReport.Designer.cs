namespace Payroll.ReportForm
{
    partial class frmUserReport
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
            this.crptUser = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crptUser
            // 
            this.crptUser.ActiveViewIndex = -1;
            this.crptUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptUser.Location = new System.Drawing.Point(0, 0);
            this.crptUser.Name = "crptUser";
            this.crptUser.Size = new System.Drawing.Size(971, 533);
            this.crptUser.TabIndex = 0;
            this.crptUser.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmUserReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 533);
            this.Controls.Add(this.crptUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmUserReport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Report";
            this.Load += new System.EventHandler(this.frmUserReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptUser;
    }
}