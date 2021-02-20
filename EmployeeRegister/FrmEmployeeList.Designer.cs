
namespace EmployeeRegister
{
    partial class FrmEmployeeList
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
            this.CboEmployeeType = new System.Windows.Forms.ComboBox();
            this.BtnModifyEmployee = new System.Windows.Forms.Button();
            this.BtnCreateEmployee = new System.Windows.Forms.Button();
            this.LstEmployees = new System.Windows.Forms.ListBox();
            this.LblID = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblPosition = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblLocation = new System.Windows.Forms.Label();
            this.BtnDeleteEmployee = new System.Windows.Forms.Button();
            this.BtnFindEmployee = new System.Windows.Forms.Button();
            this.TxtFindEmployeeDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CboEmployeeType
            // 
            this.CboEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEmployeeType.FormattingEnabled = true;
            this.CboEmployeeType.Location = new System.Drawing.Point(115, 386);
            this.CboEmployeeType.Name = "CboEmployeeType";
            this.CboEmployeeType.Size = new System.Drawing.Size(225, 21);
            this.CboEmployeeType.TabIndex = 7;
            // 
            // BtnModifyEmployee
            // 
            this.BtnModifyEmployee.Location = new System.Drawing.Point(12, 415);
            this.BtnModifyEmployee.Name = "BtnModifyEmployee";
            this.BtnModifyEmployee.Size = new System.Drawing.Size(97, 23);
            this.BtnModifyEmployee.TabIndex = 6;
            this.BtnModifyEmployee.Text = "Modify Employee";
            this.BtnModifyEmployee.UseVisualStyleBackColor = true;
            this.BtnModifyEmployee.Click += new System.EventHandler(this.BtnModifyEmployee_Click);
            // 
            // BtnCreateEmployee
            // 
            this.BtnCreateEmployee.Location = new System.Drawing.Point(12, 386);
            this.BtnCreateEmployee.Name = "BtnCreateEmployee";
            this.BtnCreateEmployee.Size = new System.Drawing.Size(97, 23);
            this.BtnCreateEmployee.TabIndex = 5;
            this.BtnCreateEmployee.Text = "Create Employee";
            this.BtnCreateEmployee.UseVisualStyleBackColor = true;
            this.BtnCreateEmployee.Click += new System.EventHandler(this.BtnCreateEmployee_Click);
            // 
            // LstEmployees
            // 
            this.LstEmployees.FormattingEnabled = true;
            this.LstEmployees.Location = new System.Drawing.Point(12, 25);
            this.LstEmployees.Name = "LstEmployees";
            this.LstEmployees.Size = new System.Drawing.Size(679, 355);
            this.LstEmployees.Sorted = true;
            this.LstEmployees.TabIndex = 8;
            this.LstEmployees.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstEmployees_MouseDoubleClick);
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(12, 9);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(18, 13);
            this.LblID.TabIndex = 9;
            this.LblID.Text = "ID";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(112, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 10;
            this.LblName.Text = "Name";
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Location = new System.Drawing.Point(202, 9);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(44, 13);
            this.LblPosition.TabIndex = 11;
            this.LblPosition.Text = "Position";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(480, 9);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(31, 13);
            this.LblType.TabIndex = 12;
            this.LblType.Text = "Type";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(265, 415);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 13;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Location = new System.Drawing.Point(355, 9);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(48, 13);
            this.LblLocation.TabIndex = 14;
            this.LblLocation.Text = "Location";
            // 
            // BtnDeleteEmployee
            // 
            this.BtnDeleteEmployee.Location = new System.Drawing.Point(115, 413);
            this.BtnDeleteEmployee.Name = "BtnDeleteEmployee";
            this.BtnDeleteEmployee.Size = new System.Drawing.Size(96, 23);
            this.BtnDeleteEmployee.TabIndex = 15;
            this.BtnDeleteEmployee.Text = "Delete Employee";
            this.BtnDeleteEmployee.UseVisualStyleBackColor = true;
            this.BtnDeleteEmployee.Click += new System.EventHandler(this.BtnDeleteEmployee_Click);
            // 
            // BtnFindEmployee
            // 
            this.BtnFindEmployee.Location = new System.Drawing.Point(12, 444);
            this.BtnFindEmployee.Name = "BtnFindEmployee";
            this.BtnFindEmployee.Size = new System.Drawing.Size(97, 23);
            this.BtnFindEmployee.TabIndex = 16;
            this.BtnFindEmployee.Text = "Find Employee";
            this.BtnFindEmployee.UseVisualStyleBackColor = true;
            this.BtnFindEmployee.Click += new System.EventHandler(this.BtnFindEmployee_Click);
            // 
            // TxtFindEmployeeDetails
            // 
            this.TxtFindEmployeeDetails.Location = new System.Drawing.Point(115, 447);
            this.TxtFindEmployeeDetails.Name = "TxtFindEmployeeDetails";
            this.TxtFindEmployeeDetails.Size = new System.Drawing.Size(225, 20);
            this.TxtFindEmployeeDetails.TabIndex = 17;
            // 
            // FrmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.TxtFindEmployeeDetails);
            this.Controls.Add(this.BtnFindEmployee);
            this.Controls.Add(this.BtnDeleteEmployee);
            this.Controls.Add(this.LblLocation);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.LblPosition);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LstEmployees);
            this.Controls.Add(this.CboEmployeeType);
            this.Controls.Add(this.BtnModifyEmployee);
            this.Controls.Add(this.BtnCreateEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmEmployeeList";
            this.Text = "Employee List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboEmployeeType;
        private System.Windows.Forms.Button BtnModifyEmployee;
        private System.Windows.Forms.Button BtnCreateEmployee;
        private System.Windows.Forms.ListBox LstEmployees;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblLocation;
        private System.Windows.Forms.Button BtnDeleteEmployee;
        private System.Windows.Forms.Button BtnFindEmployee;
        private System.Windows.Forms.TextBox TxtFindEmployeeDetails;
    }
}