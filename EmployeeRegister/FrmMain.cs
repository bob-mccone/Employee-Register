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
            // As file handing is error prone we put it inside of a try catch method to catch any errors
            try
            {
                // Retrieve the employee details
                ClsEmployeeList.Retrieve();
                // Update the number of employees
                UpdateTotalEmployees();
            }
            // Catch an error
            catch (Exception ex)
            {
                // Display a message
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateTotalEmployees()
        {
            // Updating the label to show the number of employees we currently have
            LblEmployeeDetails.Text = ClsEmployeeList.EmployeeList.Count + " Employee(s)";
        }

        // Manage employee button
        private void BtnManageEmployees_Click(object sender, EventArgs e)
        {
            // Open employee list form
            _EmployeeListForm.ShowDialog();
            UpdateTotalEmployees();
        }
        
        // Close button
        private void BtnClose_Click(object sender, EventArgs e)
        {
            // As file handing is error prone we put it inside of a try catch method to catch any errors
            try
            {
                // Save the employee details
                ClsEmployeeList.Save();
                // Close the main form
                Close();
            }
            // Catch an error
            catch (Exception ex)
            {
                // Display a message
                MessageBox.Show(ex.Message);
            }
        }      
    }
}
