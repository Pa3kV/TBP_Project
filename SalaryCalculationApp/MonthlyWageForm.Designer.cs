namespace SalaryCalculationApp
{
    partial class MonthlyWageForm
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
            this.lblEmployee = new System.Windows.Forms.Label();
            this.dgvMonthsInfo = new System.Windows.Forms.DataGridView();
            this.btnGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(32, 44);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(44, 16);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "label1";
            // 
            // dgvMonthsInfo
            // 
            this.dgvMonthsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthsInfo.Location = new System.Drawing.Point(35, 90);
            this.dgvMonthsInfo.Name = "dgvMonthsInfo";
            this.dgvMonthsInfo.RowHeadersWidth = 51;
            this.dgvMonthsInfo.RowTemplate.Height = 24;
            this.dgvMonthsInfo.Size = new System.Drawing.Size(729, 279);
            this.dgvMonthsInfo.TabIndex = 1;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(360, 391);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(121, 47);
            this.btnGoBack.TabIndex = 2;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // MonthlyWageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.dgvMonthsInfo);
            this.Controls.Add(this.lblEmployee);
            this.Name = "MonthlyWageForm";
            this.Text = "MonthlyWageForm";
            this.Load += new System.EventHandler(this.MonthlyWageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthsInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.DataGridView dgvMonthsInfo;
        private System.Windows.Forms.Button btnGoBack;
    }
}