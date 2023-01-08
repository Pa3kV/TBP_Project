namespace SalaryCalculationApp
{
    partial class EditDepartment
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
            this.btnEditDep = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Name";
            // 
            // btnEditDep
            // 
            this.btnEditDep.Location = new System.Drawing.Point(72, 182);
            this.btnEditDep.Name = "btnEditDep";
            this.btnEditDep.Size = new System.Drawing.Size(119, 43);
            this.btnEditDep.TabIndex = 1;
            this.btnEditDep.Text = "Edit Department";
            this.btnEditDep.UseVisualStyleBackColor = true;
            this.btnEditDep.Click += new System.EventHandler(this.btnEditDep_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 22);
            this.txtName.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(258, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 43);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 257);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnEditDep);
            this.Controls.Add(this.label1);
            this.Name = "EditDepartment";
            this.Text = "EditDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditDep;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancel;
    }
}