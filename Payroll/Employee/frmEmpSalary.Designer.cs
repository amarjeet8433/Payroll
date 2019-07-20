namespace Payroll.Employee
{
    partial class frmEmpSalary
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
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpJoinDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalaryPA = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grdEmpSalaryData = new System.Windows.Forms.DataGridView();
            this.grdEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdJoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdSalaryPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdEmployeeData = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpSalaryData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp ID :";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(118, 40);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(208, 24);
            this.txtEmpID.TabIndex = 1;
            this.txtEmpID.TextChanged += new System.EventHandler(this.txtEmpID_TextChanged);
            this.txtEmpID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpID_KeyDown);
            this.txtEmpID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpID_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(458, 38);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(208, 24);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Emp Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Join Date :";
            // 
            // dtpJoinDate
            // 
            this.dtpJoinDate.CustomFormat = "dd/MMM/yy";
            this.dtpJoinDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJoinDate.Location = new System.Drawing.Point(118, 90);
            this.dtpJoinDate.Name = "dtpJoinDate";
            this.dtpJoinDate.Size = new System.Drawing.Size(208, 24);
            this.dtpJoinDate.TabIndex = 5;
            this.dtpJoinDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpJoinDate_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salary P/A :";
            // 
            // txtSalaryPA
            // 
            this.txtSalaryPA.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryPA.Location = new System.Drawing.Point(458, 90);
            this.txtSalaryPA.Name = "txtSalaryPA";
            this.txtSalaryPA.Size = new System.Drawing.Size(208, 24);
            this.txtSalaryPA.TabIndex = 7;
            this.txtSalaryPA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalaryPA_KeyDown);
            this.txtSalaryPA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalaryPA_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(118, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 48);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(312, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(159, 48);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(504, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 48);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grdEmpSalaryData
            // 
            this.grdEmpSalaryData.AllowUserToAddRows = false;
            this.grdEmpSalaryData.AllowUserToDeleteRows = false;
            this.grdEmpSalaryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpSalaryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdEmpId,
            this.grdEmpName,
            this.grdJoinDate,
            this.grdSalaryPA});
            this.grdEmpSalaryData.Location = new System.Drawing.Point(118, 222);
            this.grdEmpSalaryData.Name = "grdEmpSalaryData";
            this.grdEmpSalaryData.ReadOnly = true;
            this.grdEmpSalaryData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmpSalaryData.Size = new System.Drawing.Size(548, 298);
            this.grdEmpSalaryData.TabIndex = 11;
            this.grdEmpSalaryData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdEmpSalaryData_MouseDoubleClick);
            // 
            // grdEmpId
            // 
            this.grdEmpId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.grdEmpId.HeaderText = "EMP ID";
            this.grdEmpId.Name = "grdEmpId";
            this.grdEmpId.ReadOnly = true;
            this.grdEmpId.Width = 69;
            // 
            // grdEmpName
            // 
            this.grdEmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdEmpName.HeaderText = "Emp Name";
            this.grdEmpName.Name = "grdEmpName";
            this.grdEmpName.ReadOnly = true;
            // 
            // grdJoinDate
            // 
            this.grdJoinDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.grdJoinDate.HeaderText = "Join Date";
            this.grdJoinDate.Name = "grdJoinDate";
            this.grdJoinDate.ReadOnly = true;
            this.grdJoinDate.Width = 77;
            // 
            // grdSalaryPA
            // 
            this.grdSalaryPA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.grdSalaryPA.HeaderText = "Salary P/A";
            this.grdSalaryPA.Name = "grdSalaryPA";
            this.grdSalaryPA.ReadOnly = true;
            this.grdSalaryPA.Width = 83;
            // 
            // grdEmployeeData
            // 
            this.grdEmployeeData.AllowUserToAddRows = false;
            this.grdEmployeeData.AllowUserToDeleteRows = false;
            this.grdEmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployeeData.Location = new System.Drawing.Point(706, 17);
            this.grdEmployeeData.Name = "grdEmployeeData";
            this.grdEmployeeData.ReadOnly = true;
            this.grdEmployeeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmployeeData.Size = new System.Drawing.Size(248, 199);
            this.grdEmployeeData.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEmpSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 532);
            this.Controls.Add(this.grdEmployeeData);
            this.Controls.Add(this.grdEmpSalaryData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSalaryPA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpJoinDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpSalary";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Salary to Employee";
            this.Load += new System.EventHandler(this.frmEmpSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpSalaryData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalaryPA;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView grdEmpSalaryData;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdJoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdSalaryPA;
        private System.Windows.Forms.DataGridView grdEmployeeData;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}