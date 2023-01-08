namespace SalaryCalculationApp
{
    partial class StatsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtWage = new System.Windows.Forms.TextBox();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wage Sum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Active Months";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(176, 251);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(148, 54);
            this.btnGoBack.TabIndex = 3;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(231, 81);
            this.txtHours.Name = "txtHours";
            this.txtHours.ReadOnly = true;
            this.txtHours.Size = new System.Drawing.Size(190, 22);
            this.txtHours.TabIndex = 4;
            // 
            // txtWage
            // 
            this.txtWage.Location = new System.Drawing.Point(231, 129);
            this.txtWage.Name = "txtWage";
            this.txtWage.ReadOnly = true;
            this.txtWage.Size = new System.Drawing.Size(190, 22);
            this.txtWage.TabIndex = 5;
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(231, 176);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.ReadOnly = true;
            this.txtMonths.Size = new System.Drawing.Size(190, 22);
            this.txtMonths.TabIndex = 6;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 355);
            this.Controls.Add(this.txtMonths);
            this.Controls.Add(this.txtWage);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.Load += new System.EventHandler(this.StatsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtWage;
        private System.Windows.Forms.TextBox txtMonths;
    }
}