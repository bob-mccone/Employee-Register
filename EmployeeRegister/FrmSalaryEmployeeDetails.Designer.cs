
namespace EmployeeRegister
{
    partial class FrmSalaryEmployeeDetails
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
            this.LblEmployeeSalary = new System.Windows.Forms.Label();
            this.TxtEmployeeSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblEmployeeSalary
            // 
            this.LblEmployeeSalary.AutoSize = true;
            this.LblEmployeeSalary.Location = new System.Drawing.Point(146, 380);
            this.LblEmployeeSalary.Name = "LblEmployeeSalary";
            this.LblEmployeeSalary.Size = new System.Drawing.Size(45, 13);
            this.LblEmployeeSalary.TabIndex = 36;
            this.LblEmployeeSalary.Text = "Salary $";
            // 
            // TxtEmployeeSalary
            // 
            this.TxtEmployeeSalary.Location = new System.Drawing.Point(197, 377);
            this.TxtEmployeeSalary.Name = "TxtEmployeeSalary";
            this.TxtEmployeeSalary.Size = new System.Drawing.Size(200, 20);
            this.TxtEmployeeSalary.TabIndex = 35;
            // 
            // FrmSalaryEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(542, 414);
            this.Controls.Add(this.LblEmployeeSalary);
            this.Controls.Add(this.TxtEmployeeSalary);
            this.Name = "FrmSalaryEmployeeDetails";
            this.Text = "Salary Employee Details";
            this.Controls.SetChildIndex(this.TxtEmployeeSalary, 0);
            this.Controls.SetChildIndex(this.LblEmployeeSalary, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmployeeSalary;
        private System.Windows.Forms.TextBox TxtEmployeeSalary;
    }
}
