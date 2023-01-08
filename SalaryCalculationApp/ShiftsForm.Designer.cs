namespace SalaryCalculationApp
{
    partial class ShiftsForm
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
            this.dgvShifts = new System.Windows.Forms.DataGridView();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShifts
            // 
            this.dgvShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShifts.Location = new System.Drawing.Point(49, 58);
            this.dgvShifts.Name = "dgvShifts";
            this.dgvShifts.ReadOnly = true;
            this.dgvShifts.RowHeadersWidth = 51;
            this.dgvShifts.RowTemplate.Height = 24;
            this.dgvShifts.Size = new System.Drawing.Size(705, 310);
            this.dgvShifts.TabIndex = 0;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(328, 401);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(156, 37);
            this.btnGoBack.TabIndex = 1;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(49, 22);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(44, 16);
            this.lblEmployee.TabIndex = 2;
            this.lblEmployee.Text = "label1";
            // 
            // ShiftsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.dgvShifts);
            this.Name = "ShiftsForm";
            this.Text = "ShiftsForm";
            this.Load += new System.EventHandler(this.ShiftsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShifts;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblEmployee;
    }
}