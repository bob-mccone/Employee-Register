
namespace EmployeeRegister
{
    partial class FrmWagesEmployeeDetails
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
            this.LblEmployeeHouryRate = new System.Windows.Forms.Label();
            this.TxtEmployeeHourlyRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblEmployeeHouryRate
            // 
            this.LblEmployeeHouryRate.AutoSize = true;
            this.LblEmployeeHouryRate.Location = new System.Drawing.Point(119, 380);
            this.LblEmployeeHouryRate.Name = "LblEmployeeHouryRate";
            this.LblEmployeeHouryRate.Size = new System.Drawing.Size(72, 13);
            this.LblEmployeeHouryRate.TabIndex = 36;
            this.LblEmployeeHouryRate.Text = "Hourly Rate $";
            // 
            // TxtEmployeeHourlyRate
            // 
            this.TxtEmployeeHourlyRate.Location = new System.Drawing.Point(197, 377);
            this.TxtEmployeeHourlyRate.Name = "TxtEmployeeHourlyRate";
            this.TxtEmployeeHourlyRate.Size = new System.Drawing.Size(200, 20);
            this.TxtEmployeeHourlyRate.TabIndex = 35;
            // 
            // FrmWagesEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(542, 414);
            this.Controls.Add(this.LblEmployeeHouryRate);
            this.Controls.Add(this.TxtEmployeeHourlyRate);
            this.Name = "FrmWagesEmployeeDetails";
            this.Text = "Wages Employee Details";
            this.Controls.SetChildIndex(this.TxtEmployeeHourlyRate, 0);
            this.Controls.SetChildIndex(this.LblEmployeeHouryRate, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmployeeHouryRate;
        private System.Windows.Forms.TextBox TxtEmployeeHourlyRate;
    }
}
