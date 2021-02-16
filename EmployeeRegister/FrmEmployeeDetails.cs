using System;
using System.Windows.Forms;

namespace EmployeeRegister
{
    // Generated when form is created, it is public, partial which means there is another file with 
    // additional code, and it inherits from a class called form which is part of .NET
    public partial class FrmEmployeeDetails : Form
    {
        // Member variable of type ClsEmloyeeDetails, this is a reference variables and allocate only 
        // enough memory to hold an address to an object
        // This must be protected so that the inherited forms can access it
        protected ClsEmployeeDetails _EmployeeDetails;

        // Constructor
        public FrmEmployeeDetails()
        {
            InitializeComponent();
        }

        // Execute when we want this form to display itself
        public DialogResult ShowDialog(ClsEmployeeDetails prEmployeeDetails)
        {
            // Storing the parameter value in our member variable _EmployeeDetails
            _EmployeeDetails = prEmployeeDetails;
            // Calling the update display method
            UpdateDisplay();
            // Default method, this will return OK or cancel depends on what the user clicks on
            return ShowDialog();
        }

        // Updates the text boxes with the employee details
        // Must be protected and virtual so that the inherited forms can override them
        protected virtual void UpdateDisplay()
        {
            TxtEmployeeID.Text = _EmployeeDetails.ID;
            TxtEmployeeName.Text = _EmployeeDetails.Name;
            DtpEmployeeDOB.Value = _EmployeeDetails.DOB;
            TxtEmployeeAddress.Text = _EmployeeDetails.Address;
            TxtEmployeePhoneNumber.Text = _EmployeeDetails.PhoneNo;
            TxtEmployeeEmail.Text = _EmployeeDetails.Email;
            TxtEmployeeEmergencyContactPerson.Text = _EmployeeDetails.EmergencyContactPerson;
            TxtEmployeeEmergencyContactNumber.Text = _EmployeeDetails.EmergencyContactNo;
            TxtEmployeeEmergencyRelationship.Text = _EmployeeDetails.EmergencyContactRelationship;
            DtpEmployeeStartDate.Value = _EmployeeDetails.StartDate;
            TxtEmployeePosition.Text = _EmployeeDetails.Position;
            TxtEmployeeLocation.Text = _EmployeeDetails.Location;
            TxtEmployeeWorkNo.Text = _EmployeeDetails.WorkNo;
            TxtEmployeeWorkEmail.Text = _EmployeeDetails.WorkEmail;
            TxtEmployeeID.Enabled = String.IsNullOrEmpty(_EmployeeDetails.ID);
        }

        // Assigning the contents of the textboxes on the form to the employee properties when the OK button is clicked
        private void BtnOK_Click(object sender, EventArgs e)
        {
            // Calling push data method
            PushData();
            DialogResult = DialogResult.OK;
        }

        // Push data method, this is so the form can work with inherited forms
        // Must be protected and virtual so that the inherited forms can override them
        protected virtual void PushData()
        {
            _EmployeeDetails.ID = TxtEmployeeID.Text;
            _EmployeeDetails.Name = TxtEmployeeName.Text;
            _EmployeeDetails.DOB = DtpEmployeeDOB.Value;
            _EmployeeDetails.Address = TxtEmployeeAddress.Text;
            _EmployeeDetails.PhoneNo = TxtEmployeePhoneNumber.Text;
            _EmployeeDetails.Email = TxtEmployeeEmail.Text;
            _EmployeeDetails.EmergencyContactPerson = TxtEmployeeEmergencyContactPerson.Text;
            _EmployeeDetails.EmergencyContactNo = TxtEmployeeEmergencyContactNumber.Text;
            _EmployeeDetails.EmergencyContactRelationship = TxtEmployeeEmergencyRelationship.Text;
            _EmployeeDetails.StartDate = DtpEmployeeStartDate.Value;
            _EmployeeDetails.Position = TxtEmployeePosition.Text;
            _EmployeeDetails.Location = TxtEmployeeLocation.Text;
            _EmployeeDetails.WorkNo = TxtEmployeeWorkNo.Text;
            _EmployeeDetails.WorkEmail = TxtEmployeeWorkEmail.Text;
        }

        // Cancel button
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
