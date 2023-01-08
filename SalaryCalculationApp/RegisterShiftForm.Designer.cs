namespace SalaryCalculationApp
{
    partial class RegisterShiftForm
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromTime = new System.Windows.Forms.DateTimePicker();
            this.dtpToTime = new System.Windows.Forms.DateTimePicker();
            this.btnRegisterShift = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(203, 81);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "To:";
            // 
            // dtpFromTime
            // 
            this.dtpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFromTime.Location = new System.Drawing.Point(203, 156);
            this.dtpFromTime.Name = "dtpFromTime";
            this.dtpFromTime.Size = new System.Drawing.Size(200, 22);
            this.dtpFromTime.TabIndex = 4;
            // 
            // dtpToTime
            // 
            this.dtpToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpToTime.Location = new System.Drawing.Point(203, 235);
            this.dtpToTime.Name = "dtpToTime";
            this.dtpToTime.Size = new System.Drawing.Size(200, 22);
            this.dtpToTime.TabIndex = 5;
            // 
            // btnRegisterShift
            // 
            this.btnRegisterShift.Location = new System.Drawing.Point(255, 309);
            this.btnRegisterShift.Name = "btnRegisterShift";
            this.btnRegisterShift.Size = new System.Drawing.Size(131, 45);
            this.btnRegisterShift.TabIndex = 6;
            this.btnRegisterShift.Text = "Register Shift";
            this.btnRegisterShift.UseVisualStyleBackColor = true;
            this.btnRegisterShift.Click += new System.EventHandler(this.btnRegisterShift_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(62, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RegisterShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 383);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegisterShift);
            this.Controls.Add(this.dtpToTime);
            this.Controls.Add(this.dtpFromTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Name = "RegisterShiftForm";
            this.Text = "RegisterShiftForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromTime;
        private System.Windows.Forms.DateTimePicker dtpToTime;
        private System.Windows.Forms.Button btnRegisterShift;
        private System.Windows.Forms.Button btnCancel;
    }
}