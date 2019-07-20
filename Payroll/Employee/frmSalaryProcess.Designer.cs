namespace Payroll.Employee
{
    partial class frmSalaryProcess
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.grdSalaryData = new System.Windows.Forms.DataGridView();
            this.grdEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaryData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year :";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(112, 28);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(218, 27);
            this.cmbYear.TabIndex = 1;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(509, 28);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(218, 27);
            this.cmbMonth.TabIndex = 3;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Month :";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(332, 78);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(167, 53);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grdSalaryData
            // 
            this.grdSalaryData.AllowUserToAddRows = false;
            this.grdSalaryData.AllowUserToDeleteRows = false;
            this.grdSalaryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalaryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdEmpId,
            this.grdName,
            this.grdYear,
            this.grdMonth,
            this.grdSalary});
            this.grdSalaryData.Location = new System.Drawing.Point(3, 169);
            this.grdSalaryData.Name = "grdSalaryData";
            this.grdSalaryData.ReadOnly = true;
            this.grdSalaryData.Size = new System.Drawing.Size(796, 327);
            this.grdSalaryData.TabIndex = 5;
            // 
            // grdEmpId
            // 
            this.grdEmpId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdEmpId.HeaderText = "EMP ID";
            this.grdEmpId.Name = "grdEmpId";
            this.grdEmpId.ReadOnly = true;
            // 
            // grdName
            // 
            this.grdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdName.HeaderText = "Emp Name";
            this.grdName.Name = "grdName";
            this.grdName.ReadOnly = true;
            // 
            // grdYear
            // 
            this.grdYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdYear.HeaderText = "Year";
            this.grdYear.Name = "grdYear";
            this.grdYear.ReadOnly = true;
            // 
            // grdMonth
            // 
            this.grdMonth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdMonth.HeaderText = "Month";
            this.grdMonth.Name = "grdMonth";
            this.grdMonth.ReadOnly = true;
            // 
            // grdSalary
            // 
            this.grdSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdSalary.HeaderText = "Salary";
            this.grdSalary.Name = "grdSalary";
            this.grdSalary.ReadOnly = true;
            // 
            // frmSalaryProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.grdSalaryData);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalaryProcess";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Salary";
            this.Load += new System.EventHandler(this.frmSalaryProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaryData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView grdSalaryData;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdSalary;
    }
}