namespace SalaryCalculationApp
{
    partial class EmployeesForm
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnShowShifts = new System.Windows.Forms.Button();
            this.btnShowStats = new System.Windows.Forms.Button();
            this.btnChangeHourlyRate = new System.Windows.Forms.Button();
            this.btnRegisterShift = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnMonthlyWage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(15, 50);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(979, 290);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.SelectionChanged += new System.EventHandler(this.dgvEmployees_SelectionChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(12, 21);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(76, 16);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "Employees";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(15, 376);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(118, 56);
            this.btnGoBack.TabIndex = 2;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnShowShifts
            // 
            this.btnShowShifts.Location = new System.Drawing.Point(163, 376);
            this.btnShowShifts.Name = "btnShowShifts";
            this.btnShowShifts.Size = new System.Drawing.Size(118, 56);
            this.btnShowShifts.TabIndex = 3;
            this.btnShowShifts.Text = "Show Shifts";
            this.btnShowShifts.UseVisualStyleBackColor = true;
            this.btnShowShifts.Click += new System.EventHandler(this.btnShowShifts_Click);
            // 
            // btnShowStats
            // 
            this.btnShowStats.Location = new System.Drawing.Point(320, 376);
            this.btnShowStats.Name = "btnShowStats";
            this.btnShowStats.Size = new System.Drawing.Size(118, 56);
            this.btnShowStats.TabIndex = 4;
            this.btnShowStats.Text = "Show Stats";
            this.btnShowStats.UseVisualStyleBackColor = true;
            this.btnShowStats.Click += new System.EventHandler(this.btnShowStats_Click);
            // 
            // btnChangeHourlyRate
            // 
            this.btnChangeHourlyRate.Location = new System.Drawing.Point(636, 376);
            this.btnChangeHourlyRate.Name = "btnChangeHourlyRate";
            this.btnChangeHourlyRate.Size = new System.Drawing.Size(118, 56);
            this.btnChangeHourlyRate.TabIndex = 5;
            this.btnChangeHourlyRate.Text = "Change Hourly Rate";
            this.btnChangeHourlyRate.UseVisualStyleBackColor = true;
            this.btnChangeHourlyRate.Click += new System.EventHandler(this.btnChangeHourlyRate_Click);
            // 
            // btnRegisterShift
            // 
            this.btnRegisterShift.Location = new System.Drawing.Point(796, 376);
            this.btnRegisterShift.Name = "btnRegisterShift";
            this.btnRegisterShift.Size = new System.Drawing.Size(118, 56);
            this.btnRegisterShift.TabIndex = 6;
            this.btnRegisterShift.Text = "Register Shift";
            this.btnRegisterShift.UseVisualStyleBackColor = true;
            this.btnRegisterShift.Click += new System.EventHandler(this.btnRegisterShift_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(1111, 376);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(118, 56);
            this.btnAddNew.TabIndex = 7;
            this.btnAddNew.Text = "Add New Employee";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.Location = new System.Drawing.Point(957, 376);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(118, 56);
            this.btnRelease.TabIndex = 8;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnMonthlyWage
            // 
            this.btnMonthlyWage.Location = new System.Drawing.Point(482, 376);
            this.btnMonthlyWage.Name = "btnMonthlyWage";
            this.btnMonthlyWage.Size = new System.Drawing.Size(118, 56);
            this.btnMonthlyWage.TabIndex = 9;
            this.btnMonthlyWage.Text = "Show Monthly Wage ";
            this.btnMonthlyWage.UseVisualStyleBackColor = true;
            this.btnMonthlyWage.Click += new System.EventHandler(this.btnMonthlyWage_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 453);
            this.Controls.Add(this.btnMonthlyWage);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnRegisterShift);
            this.Controls.Add(this.btnChangeHourlyRate);
            this.Controls.Add(this.btnShowStats);
            this.Controls.Add(this.btnShowShifts);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "EmployeesForm";
            this.Text = "EmployeesForm";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnShowShifts;
        private System.Windows.Forms.Button btnShowStats;
        private System.Windows.Forms.Button btnChangeHourlyRate;
        private System.Windows.Forms.Button btnRegisterShift;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Button btnMonthlyWage;
    }
}