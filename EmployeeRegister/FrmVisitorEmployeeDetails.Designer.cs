
namespace EmployeeRegister
{
    partial class FrmVisitorEmployeeDetails
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
            this.LblEmployeeVisitorTimeIn = new System.Windows.Forms.Label();
            this.LblEmployeeVisitorTimeOut = new System.Windows.Forms.Label();
            this.TxtEmployeeVisitorTimeIn = new System.Windows.Forms.TextBox();
            this.TxtEmployeeVisitorTimeOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblEmployeeVisitorTimeIn
            // 
            this.LblEmployeeVisitorTimeIn.AutoSize = true;
            this.LblEmployeeVisitorTimeIn.Location = new System.Drawing.Point(150, 380);
            this.LblEmployeeVisitorTimeIn.Name = "LblEmployeeVisitorTimeIn";
            this.LblEmployeeVisitorTimeIn.Size = new System.Drawing.Size(41, 13);
            this.LblEmployeeVisitorTimeIn.TabIndex = 35;
            this.LblEmployeeVisitorTimeIn.Text = "Time in";
            // 
            // LblEmployeeVisitorTimeOut
            // 
            this.LblEmployeeVisitorTimeOut.AutoSize = true;
            this.LblEmployeeVisitorTimeOut.Location = new System.Drawing.Point(141, 406);
            this.LblEmployeeVisitorTimeOut.Name = "LblEmployeeVisitorTimeOut";
            this.LblEmployeeVisitorTimeOut.Size = new System.Drawing.Size(50, 13);
            this.LblEmployeeVisitorTimeOut.TabIndex = 36;
            this.LblEmployeeVisitorTimeOut.Text = "Time Out";
            // 
            // TxtEmployeeVisitorTimeIn
            // 
            this.TxtEmployeeVisitorTimeIn.Location = new System.Drawing.Point(197, 377);
            this.TxtEmployeeVisitorTimeIn.Name = "TxtEmployeeVisitorTimeIn";
            this.TxtEmployeeVisitorTimeIn.Size = new System.Drawing.Size(200, 20);
            this.TxtEmployeeVisitorTimeIn.TabIndex = 37;
            // 
            // TxtEmployeeVisitorTimeOut
            // 
            this.TxtEmployeeVisitorTimeOut.Location = new System.Drawing.Point(197, 403);
            this.TxtEmployeeVisitorTimeOut.Name = "TxtEmployeeVisitorTimeOut";
            this.TxtEmployeeVisitorTimeOut.Size = new System.Drawing.Size(200, 20);
            this.TxtEmployeeVisitorTimeOut.TabIndex = 38;
            // 
            // FrmVisitorEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(542, 436);
            this.Controls.Add(this.TxtEmployeeVisitorTimeOut);
            this.Controls.Add(this.TxtEmployeeVisitorTimeIn);
            this.Controls.Add(this.LblEmployeeVisitorTimeOut);
            this.Controls.Add(this.LblEmployeeVisitorTimeIn);
            this.Name = "FrmVisitorEmployeeDetails";
            this.Controls.SetChildIndex(this.LblEmployeeVisitorTimeIn, 0);
            this.Controls.SetChildIndex(this.LblEmployeeVisitorTimeOut, 0);
            this.Controls.SetChildIndex(this.TxtEmployeeVisitorTimeIn, 0);
            this.Controls.SetChildIndex(this.TxtEmployeeVisitorTimeOut, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmployeeVisitorTimeIn;
        private System.Windows.Forms.Label LblEmployeeVisitorTimeOut;
        private System.Windows.Forms.TextBox TxtEmployeeVisitorTimeIn;
        private System.Windows.Forms.TextBox TxtEmployeeVisitorTimeOut;
    }
}
