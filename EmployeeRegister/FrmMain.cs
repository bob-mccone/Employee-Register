using System;
using System.Windows.Forms;

namespace EmployeeRegister
{
    public partial class FrmMain : Form
    {
        // Declaring a member variable
        private ClsEmployeeDetails _EmployeeDetails;
        // Don't need to create a general form as we no longer need it as we have two other forms that we can use
        private FrmEmployeeDetails _EmployeeDetailsForm;
        // Creating a new wages employee object
        private FrmEmployeeDetails _WagesEmployeeDetailsForm = new FrmWagesEmployeeDetails();
        // Creating a new salary employee object
        private FrmEmployeeDetails _SalaryEmployeeDetailsForm = new FrmSalaryEmployeeDetails();
        // Creating a new contractor employee object
        private FrmEmployeeDetails _ContractorEmployeeDetailsForm = new FrmContractorEmployeeDetails();
        // Creating a new visitor employee object
        private FrmEmployeeDetails _VisitorEmployeeDetailsForm = new FrmVisitorEmployeeDetails();
        // Initialising and inserting into the combo box
        private string[] _EmployeeType = { "Wages", "Salary", "Contractor", "Visitor" };

        // Constructor, these have no return type
        public FrmMain()
        {
            InitializeComponent();
            // Initialise the combo box
            CboEmployeeType.DataSource = _EmployeeType;
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
            switch (CboEmployeeType.SelectedIndex)
            {
                // If the second option was selected, open salary form
                case 1:
                    _EmployeeDetailsForm = _SalaryEmployeeDetailsForm;
                    _EmployeeDetails = new ClsSalaryEmployeeDetails();
                    break;
                
                // If the third option was selected, open contractor form
                case 2:
                    _EmployeeDetailsForm = _ContractorEmployeeDetailsForm;
                    _EmployeeDetails = new ClsContractorEmployeeDetails();
                    break;

                // If the fourth option was selected, open visitors form
                case 3:
                    _EmployeeDetailsForm = _VisitorEmployeeDetailsForm;
                    _EmployeeDetails = new ClsVisitorEmployeeDetails();
                    break;

                // Open wages form by default as this is always the first option
                default:
                    _EmployeeDetailsForm = _WagesEmployeeDetailsForm;
                    _EmployeeDetails = new ClsWagesEmployeeDetails();
                    break;
            }
            // If the combo box selected option was wages
            //if (CboEmployeeType.SelectedIndex == 0)
            //{
                // Open employee wages form
                //_EmployeeDetailsForm = _WagesEmployeeDetailsForm;
                // Creating the correct employee details according to the users choice and assigning 
                // it to the member variable _EmployeeDetails
                //_EmployeeDetails = new ClsWagesEmployeeDetails();
            //}
            //else 
            //{
                // Open employee salary form
                //_EmployeeDetailsForm = _SalaryEmployeeDetailsForm;
                // Creating the correct employee details according to the users choice and assigning 
                // it to the member variable _EmployeeDetails
                //_EmployeeDetails = new ClsSalaryEmployeeDetails();
            //}
            // Call edit employee details method
            EditEmployeeDetails();
        }

    }
}
