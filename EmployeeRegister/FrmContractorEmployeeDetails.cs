using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeRegister
{
    public partial class FrmContractorEmployeeDetails : EmployeeRegister.FrmEmployeeDetails
    {
        // Constructor
        public FrmContractorEmployeeDetails()
        {
            InitializeComponent();
        }

        //We are overriding the base class update display
        protected override void UpdateDisplay()
        {
            // Calling the overridden method in the base class
            base.UpdateDisplay();
            // Need the employee details variable _EmployeeDetails, we typecast _EmployeeDetails 
            // into ClsContractorEmployeeDetails in order to use the specific properties related to that class
            ClsContractorEmployeeDetails lcEmployeeDetails = (ClsContractorEmployeeDetails)_EmployeeDetails;
            // Moving the data in the same way as the base class
            TxtEmployeeContractingCompany.Text = lcEmployeeDetails.EmployeeContractingCompany;
            TxtEmployeeContractingCompanyContactNo.Text = lcEmployeeDetails.EmployeeContractingCompanyContactNo;
            TxtEmployeeContractingCompanyContactPerson.Text = lcEmployeeDetails.EmployeeContractingCompanyContactPerson;
            TxtContractorEmployeeTimeIn.Text = lcEmployeeDetails.EmployeeContractingTimeIn;
            TxtContractorEmployeeTimeOut.Text = lcEmployeeDetails.EmployeeContractingTimeOut;
        }

        // We are overriding the base class push data
        protected override void PushData()
        {
            // Calling the overridden method in the base class
            base.PushData();
            // Need the employee details variable _EmployeeDetails, we typecast _EmployeeDetails 
            // into ClsContractorEmployeeDetails in order to use the specific properties related to that class
            ClsContractorEmployeeDetails lcEmployeeDetails = (ClsContractorEmployeeDetails)_EmployeeDetails;
            // Moving the data in the same way as the base class
            lcEmployeeDetails.EmployeeContractingCompany = TxtEmployeeContractingCompany.Text;
            lcEmployeeDetails.EmployeeContractingCompanyContactNo = TxtEmployeeContractingCompanyContactNo.Text;
            lcEmployeeDetails.EmployeeContractingCompanyContactPerson = TxtEmployeeContractingCompanyContactPerson.Text;
            lcEmployeeDetails.EmployeeContractingTimeIn = TxtContractorEmployeeTimeIn.Text;
            lcEmployeeDetails.EmployeeContractingTimeOut = TxtContractorEmployeeTimeOut.Text;
        }
    }
}
