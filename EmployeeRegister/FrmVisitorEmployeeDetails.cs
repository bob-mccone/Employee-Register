using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeRegister
{
    public partial class FrmVisitorEmployeeDetails : EmployeeRegister.FrmEmployeeDetails
    {
        // Constructor
        public FrmVisitorEmployeeDetails()
        {
            InitializeComponent();
        }

        // We are overridding the base class update display
        protected override void UpdateDisplay()
        {
            // Calling the overridden method in the base class
            base.UpdateDisplay();
            // Need the employee details variable _EmployeeDetails, we typecast _EmployeeDetails 
            // into ClsContractorEmployeeDetails in order to use the specific properties related to that class
            ClsVisitorEmployeeDetails lcEmployeeDetails = (ClsVisitorEmployeeDetails)_EmployeeDetails;
            // Moving the data in the same way as the base class
            TxtEmployeeVisitorTimeIn.Text = lcEmployeeDetails.EmployeeVisitorTimeIn;
            TxtEmployeeVisitorTimeOut.Text = lcEmployeeDetails.EmployeeVisitorTimeOut;
        }

        // We are overriding the base class push data
        protected override void PushData()
        {
            // Calling the overriden method in the base class
            base.PushData();
            // Need the employee details variable _EmployeeDetails, we typecast _EmployeeDetails 
            // into ClsContractorEmployeeDetails in order to use the specific properties related to that class
            ClsVisitorEmployeeDetails lcEmployeeDetails = (ClsVisitorEmployeeDetails)_EmployeeDetails;
            // Moving the data in the same way as the base class
            lcEmployeeDetails.EmployeeVisitorTimeIn = TxtEmployeeVisitorTimeIn.Text;
            lcEmployeeDetails.EmployeeVisitorTimeOut = TxtEmployeeVisitorTimeOut.Text;
        }
    }
}
