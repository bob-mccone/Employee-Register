using System;
using System.Windows.Forms;

namespace EmployeeRegister
{
    public partial class FrmMain : Form
    {
        // Declaring a member variable
        private ClsEmployeeDetails _EmployeeDetails;
        // Creating a new form object
        private FrmEmployeeDetails _EmployeeDetailsForm = new FrmEmployeeDetails();

        // Constructor
        public FrmMain()
        {
            InitializeComponent();
        }

        // Close button
        private void BtnClose_Click(object sender, EventArgs e)
        {
            // Close the main form
            Close();
        }

        // Create employee button
        private void BtnCreateEmployee_Click(object sender, EventArgs e)
        {
            // Create employee method
            CreateEmployee();
        }

        // Edit employee details
        private void EditEmployeeDetails()
        {
            // If employee details are not empty and the ok button was clicked on the employee details form
            if (_EmployeeDetails != null && _EmployeeDetailsForm.ShowDialog(_EmployeeDetails) == DialogResult.OK)
            {
                // Update the label on the main form with the employee details
                LblEmployeeDetails.Text = "Employee Details:\n" + _EmployeeDetails.ToString();
            }
        }

        // Modify employee button
        private void BtnModifyEmployee_Click(object sender, EventArgs e)
        {
            // If no employees exist
            if (_EmployeeDetails == null)
            {
                // Call the message box method and display it
                NoEmployeeToEdit();
            }
            else
            {
                // Edit the current employee details
                EditEmployeeDetails();
            }
            
        }

        // Message box that will pop up if user clicks modify employee if one does not exist
        private void NoEmployeeToEdit()
        {
            // Display message box with message
            DialogResult NoEmployeeMessage = MessageBox.Show("There is no employees to edit, would you like to create one?", "No employees", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            // If user clicks yes
            if (NoEmployeeMessage == DialogResult.Yes)
            {
                // Call create employee method
                CreateEmployee();
            }
            else
            {
                // Close Message box
                DialogResult = DialogResult.Cancel;
            }
        }
        
        // Create employee method
        private void CreateEmployee()
        {
            // Creating a ClsEmployeeDetails object and assigning it to the member variable _EmployeeDetails
            _EmployeeDetails = new ClsEmployeeDetails();
            // Call edit employee details method
            EditEmployeeDetails();
        }

    }
}
