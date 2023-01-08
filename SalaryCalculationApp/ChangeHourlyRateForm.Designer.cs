namespace SalaryCalculationApp
{
    partial class ChangeHourlyRateForm
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
            this.btnChangeHR = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChangeHR
            // 
            this.btnChangeHR.Location = new System.Drawing.Point(267, 148);
            this.btnChangeHR.Name = "btnChangeHR";
            this.btnChangeHR.Size = new System.Drawing.Size(159, 49);
            this.btnChangeHR.TabIndex = 0;
            this.btnChangeHR.Text = "Change Hourly Rate";
            this.btnChangeHR.UseVisualStyleBackColor = true;
            this.btnChangeHR.Click += new System.EventHandler(this.btnChangeHR_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(62, 148);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 49);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Hourly Rate";
            // 
            // txtNewValue
            // 
            this.txtNewValue.Location = new System.Drawing.Point(230, 69);
            this.txtNewValue.Name = "txtNewValue";
            this.txtNewValue.Size = new System.Drawing.Size(115, 22);
            this.txtNewValue.TabIndex = 3;
            // 
            // ChangeHourlyRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 222);
            this.Controls.Add(this.txtNewValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangeHR);
            this.Name = "ChangeHourlyRateForm";
            this.Text = "ChangeHourlyRateForm";
            this.Load += new System.EventHandler(this.ChangeHourlyRateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeHR;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewValue;
    }
}