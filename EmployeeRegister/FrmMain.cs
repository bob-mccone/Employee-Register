using System;
using System.Windows.Forms;

namespace EmployeeRegister
{
    public partial class FrmMain : Form
    {
        // Declaring a member variable, still need this, forms are dealt with by the classes
        private ClsEmployeeDetails _EmployeeDetails;

        // Constructor, these have no return type
        public FrmMain()
        {
            InitializeComponent();
            // Initialise the combo box, the combo box is now in the class
            CboEmployeeType.DataSource = ClsEmployeeDetails.EmployeeType;
            CboEmployeeType.SelectedIndex = 0;

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

        // Edit employee details, now accepts an employee parameter
        private void EditEmployeeDetails(ClsEmployeeDetails prEmployeeDetails)
        {
            // If employee details are not empty and the ok button was clicked on the employee details form
            if (prEmployeeDetails != null && prEmployeeDetails.ViewEdit())
            {
                _EmployeeDetails = prEmployeeDetails;
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
                EditEmployeeDetails(_EmployeeDetails);
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
            // We pass the index of the users choice to the factory method in ClsEmployeeDetails, we then pass the newly created employee to the edit method
            ClsEmployeeDetails lcEmployeeDetails = ClsEmployeeDetails.NewEmployee(CboEmployeeType.SelectedIndex);
            // Call edit employee details method
            EditEmployeeDetails(lcEmployeeDetails);
        }

    }
}
