namespace Payroll.Employee
{
    partial class frmViewAttendance
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.grdEmpAttendData = new System.Windows.Forms.DataGridView();
            this.grdEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdTotalDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdWorkingDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdAbsent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpAttendData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search :";
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "All",
            "EmpId"});
            this.cmbSearch.Location = new System.Drawing.Point(149, 25);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(208, 27);
            this.cmbSearch.TabIndex = 5;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(564, 25);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(208, 27);
            this.cmbYear.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Year :";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(149, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(208, 24);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(564, 60);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(208, 27);
            this.cmbMonth.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Month :";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(356, 120);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(141, 46);
            this.btnView.TabIndex = 11;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // grdEmpAttendData
            // 
            this.grdEmpAttendData.AllowUserToAddRows = false;
            this.grdEmpAttendData.AllowUserToDeleteRows = false;
            this.grdEmpAttendData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpAttendData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdEmpId,
            this.grdName,
            this.grdYear,
            this.grdMonth,
            this.grdTotalDays,
            this.grdWorkingDays,
            this.grdPresent,
            this.grdAbsent,
            this.grdLop});
            this.grdEmpAttendData.Location = new System.Drawing.Point(4, 199);
            this.grdEmpAttendData.Name = "grdEmpAttendData";
            this.grdEmpAttendData.ReadOnly = true;
            this.grdEmpAttendData.Size = new System.Drawing.Size(870, 291);
            this.grdEmpAttendData.TabIndex = 12;
            // 
            // grdEmpId
            // 
            this.grdEmpId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.grdEmpId.HeaderText = "EMP ID";
            this.grdEmpId.Name = "grdEmpId";
            this.grdEmpId.ReadOnly = true;
            this.grdEmpId.Width = 69;
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
            // grdTotalDays
            // 
            this.grdTotalDays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdTotalDays.HeaderText = "Total Days";
            this.grdTotalDays.Name = "grdTotalDays";
            this.grdTotalDays.ReadOnly = true;
            // 
            // grdWorkingDays
            // 
            this.grdWorkingDays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdWorkingDays.HeaderText = "Working Days";
            this.grdWorkingDays.Name = "grdWorkingDays";
            this.grdWorkingDays.ReadOnly = true;
            // 
            // grdPresent
            // 
            this.grdPresent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdPresent.HeaderText = "Present";
            this.grdPresent.Name = "grdPresent";
            this.grdPresent.ReadOnly = true;
            // 
            // grdAbsent
            // 
            this.grdAbsent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdAbsent.HeaderText = "Absent";
            this.grdAbsent.Name = "grdAbsent";
            this.grdAbsent.ReadOnly = true;
            // 
            // grdLop
            // 
            this.grdLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdLop.HeaderText = "LOP";
            this.grdLop.Name = "grdLop";
            this.grdLop.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(877, 493);
            this.Controls.Add(this.grdEmpAttendData);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewAttendance";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Attendance";
            this.Load += new System.EventHandler(this.frmViewAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpAttendData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView grdEmpAttendData;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdTotalDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdWorkingDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdAbsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdLop;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}