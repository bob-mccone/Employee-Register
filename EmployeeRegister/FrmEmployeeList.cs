using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeRegister
{
    public partial class FrmEmployeeList : Form
    {
        // Constructor, these have no return type
        public FrmEmployeeList()
        {
            InitializeComponent();
            // Initialise the combo box, the combo box is now in the class
            CboEmployeeType.DataSource = ClsEmployeeDetails.EmployeeType;
            CboEmployeeType.SelectedIndex = 0;
        }

        // Refreshes the contents of the listbox
        private void UpdateDisplay()
        {
            LstEmployees.DataSource = null;
            // As we are using a dictionary instead of a list we need to select the values column and convert it to a list before assigning it to the data source of the listbox
            LstEmployees.DataSource = ClsEmployeeList.EmployeeList.Values.ToList<ClsEmployeeDetails>();
        }

        // Create employee button
        private void BtnCreateEmployee_Click(object sender, EventArgs e)
        {
            // Call create employee method
            CreateEmployee();
        }

        // Modify employee button
        private void BtnModifyEmployee_Click(object sender, EventArgs e)
        {
            // Locating the selected employee in the list box and editing it
            ClsEmployeeDetails lcEmplyeeDetails = (ClsEmployeeDetails)LstEmployees.SelectedItem;
            // If no employees exist
            if (lcEmplyeeDetails == null)
            {
                // Call the message box method and display it
                NoEmployeeToEdit();
            }
            else
            {
                // Else edit the employe details
                EditEmployeeDetails();
            }
        }

        // Close employee list form button
        private void BtnClose_Click(object sender, EventArgs e)
        {
            // Closing the employee list form only
            this.Close();
        }

        // When user double clicks on an employee in the list box
        private void LstEmployees_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Call edit employee details method
            EditEmployeeDetails();
        }

        // Delete employee button
        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            // Locating the selected employee in the list box and deleting it
            ClsEmployeeDetails lcEmplyeeDetails = (ClsEmployeeDetails)LstEmployees.SelectedItem;
            // If the list is empty display message box saying there are no employees to delete
            if (lcEmplyeeDetails == null)
            {
                DialogResult NoEmployeeToDelete = MessageBox.Show("There are no employees to delete", "No Employees",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (NoEmployeeToDelete == DialogResult.OK)
                {
                    return;
                }
            }
            else
            {
                // Display message box asking if user wants to delete an employee first
                DialogResult DeletingEmployeeMessage = MessageBox.Show("You are about to delete an employee, are you sure you want to do this?", "Deleting Employee",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                // If user selects yes
                if (DeletingEmployeeMessage == DialogResult.Yes)
                {
                    // Call delete employee method
                    DeleteEmployee();
                }
                else
                {
                    // Else close the message box and dont delete because the user clicked no
                    return;
                }
            }
            
            
        }

        // Create employee method
        private void CreateEmployee()
        {
            // We create a new employee by calling the factory method NewEmployee in ClsEmployeeDetails and stroing it in the local variable lcEmployeeDetails
            ClsEmployeeDetails lcEmployeeDetails = ClsEmployeeDetails.NewEmployee(CboEmployeeType.SelectedIndex);
            // If the user didn't cancel
            if (lcEmployeeDetails != null && lcEmployeeDetails.ViewEdit())
            {
                // Add the new employee details to the list box, as we are adding to a dictionary we need to put the key in
                ClsEmployeeList.EmployeeList.Add(lcEmployeeDetails.ID, lcEmployeeDetails);
                // Then we update the display to show the new employee in teh list box
                UpdateDisplay();
            }
        }
        
        // Message box that will pop up if user clicks modify employee if one does not exist
        private void NoEmployeeToEdit()
        {
            // Display message box with message
            DialogResult NoEmployeeMessage = MessageBox.Show("There is no employees to edit, would you like to create one?", "No employees",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // If user clicks yes
            if (NoEmployeeMessage == DialogResult.Yes)
            {
                // Call create employee method
                CreateEmployee();
            }
            else
            {
                // Close Message box
                return;
            }
        }

        // Edit employee details, now accepts an employee parameter
        private void EditEmployeeDetails()
        {
            // Locating the selected employee in the list box and editing it
            ClsEmployeeDetails lcEmplyeeDetails = (ClsEmployeeDetails)LstEmployees.SelectedItem;
            // If employee is not empty we edit it
            if (lcEmplyeeDetails != null && lcEmplyeeDetails.ViewEdit())
            {
                // Call update display method
                UpdateDisplay();
            }
        }

        // Delete employee details
        private void DeleteEmployee()
        {
            // Find the selected employee in the list
            ClsEmployeeDetails lcEmployeeDetails = (ClsEmployeeDetails)LstEmployees.SelectedItem;
            // Remove the selected employee
            ClsEmployeeList.EmployeeList.Remove(lcEmployeeDetails.ID);
            // Update the list box to show that the employee has been removed
            UpdateDisplay();
        }

        // Find employee button
        private void BtnFindEmployee_Click(object sender, EventArgs e)
        {
            // Assigning a local variable
            ClsEmployeeDetails lcEmployeeDetails;
            // Find the ID that the user entered
            if (ClsEmployeeList.EmployeeList.TryGetValue(TxtFindEmployeeDetails.Text,out lcEmployeeDetails))
            {
                // Once found the employee select it
                LstEmployees.SelectedItem = lcEmployeeDetails;
            }
            else
            {
                // Else display message box saying that we cant find an employee
                MessageBox.Show("Unable to find an employee, please try again", "Can't find an employee");
            }
        }
    }
}
