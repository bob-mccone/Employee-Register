
namespace EmployeeRegister
{
    partial class FrmMain
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
            this.BtnCreateEmployee = new System.Windows.Forms.Button();
            this.BtnModifyEmployee = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblEmployeeDetails = new System.Windows.Forms.Label();
            this.CboEmployeeType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnCreateEmployee
            // 
            this.BtnCreateEmployee.Location = new System.Drawing.Point(12, 12);
            this.BtnCreateEmployee.Name = "BtnCreateEmployee";
            this.BtnCreateEmployee.Size = new System.Drawing.Size(97, 23);
            this.BtnCreateEmployee.TabIndex = 0;
            this.BtnCreateEmployee.Text = "Create Employee";
            this.BtnCreateEmployee.UseVisualStyleBackColor = true;
            this.BtnCreateEmployee.Click += new System.EventHandler(this.BtnCreateEmployee_Click);
            // 
            // BtnModifyEmployee
            // 
            this.BtnModifyEmployee.Location = new System.Drawing.Point(12, 41);
            this.BtnModifyEmployee.Name = "BtnModifyEmployee";
            this.BtnModifyEmployee.Size = new System.Drawing.Size(97, 23);
            this.BtnModifyEmployee.TabIndex = 1;
            this.BtnModifyEmployee.Text = "Modify Employee";
            this.BtnModifyEmployee.UseVisualStyleBackColor = true;
            this.BtnModifyEmployee.Click += new System.EventHandler(this.BtnModifyEmployee_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(12, 70);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(97, 23);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblEmployeeDetails
            // 
            this.LblEmployeeDetails.Location = new System.Drawing.Point(115, 41);
            this.LblEmployeeDetails.Name = "LblEmployeeDetails";
            this.LblEmployeeDetails.Size = new System.Drawing.Size(225, 81);
            this.LblEmployeeDetails.TabIndex = 3;
            this.LblEmployeeDetails.Text = "-";
            // 
            // CboEmployeeType
            // 
            this.CboEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEmployeeType.FormattingEnabled = true;
            this.CboEmployeeType.Location = new System.Drawing.Point(115, 12);
            this.CboEmployeeType.Name = "CboEmployeeType";
            this.CboEmployeeType.Size = new System.Drawing.Size(225, 21);
            this.CboEmployeeType.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 133);
            this.Controls.Add(this.CboEmployeeType);
            this.Controls.Add(this.LblEmployeeDetails);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnModifyEmployee);
            this.Controls.Add(this.BtnCreateEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMain";
            this.Text = "Employee Register";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateEmployee;
        private System.Windows.Forms.Button BtnModifyEmployee;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblEmployeeDetails;
        private System.Windows.Forms.ComboBox CboEmployeeType;
    }
}

