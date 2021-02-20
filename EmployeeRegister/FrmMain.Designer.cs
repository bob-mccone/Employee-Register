
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblEmployeeDetails = new System.Windows.Forms.Label();
            this.BtnManageEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(140, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(97, 23);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblEmployeeDetails
            // 
            this.LblEmployeeDetails.Location = new System.Drawing.Point(12, 41);
            this.LblEmployeeDetails.Name = "LblEmployeeDetails";
            this.LblEmployeeDetails.Size = new System.Drawing.Size(225, 81);
            this.LblEmployeeDetails.TabIndex = 3;
            this.LblEmployeeDetails.Text = "-";
            // 
            // BtnManageEmployees
            // 
            this.BtnManageEmployees.Location = new System.Drawing.Point(12, 12);
            this.BtnManageEmployees.Name = "BtnManageEmployees";
            this.BtnManageEmployees.Size = new System.Drawing.Size(110, 23);
            this.BtnManageEmployees.TabIndex = 4;
            this.BtnManageEmployees.Text = "Manage Employees";
            this.BtnManageEmployees.UseVisualStyleBackColor = true;
            this.BtnManageEmployees.Click += new System.EventHandler(this.BtnManageEmployees_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 133);
            this.Controls.Add(this.BtnManageEmployees);
            this.Controls.Add(this.LblEmployeeDetails);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMain";
            this.Text = "Employee Register";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblEmployeeDetails;
        private System.Windows.Forms.Button BtnManageEmployees;
    }
}

