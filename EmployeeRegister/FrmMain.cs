using System;
using System.Windows.Forms;

namespace EmployeeRegister
{
    public partial class FrmMain : Form
    {
        // Member variable of type FrmEmployeeList and instantiate it
        private FrmEmployeeList _EmployeeListForm = new FrmEmployeeList();

        // Constructor, these have no return type
        public FrmMain()
        {
            InitializeComponent();
        }

        // Manage employee button
        private void BtnManageEmployees_Click(object sender, EventArgs e)
        {
            // Open employee list form
            _EmployeeListForm.ShowDialog();
            // Updating the label to show the number of employees we currently have
            LblEmployeeDetails.Text = ClsEmployeeList.EmployeeList.Count + " Employee(s)";
        }
        
        // Close button
        private void BtnClose_Click(object sender, EventArgs e)
        {
            // Close the main form
            Close();
        }      
    }
}
