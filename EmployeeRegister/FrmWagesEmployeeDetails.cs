using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeRegister
{
    public partial class FrmWagesEmployeeDetails : EmployeeRegister.FrmEmployeeDetails
    {
        // Constructor
        public FrmWagesEmployeeDetails()
        {
            InitializeComponent();
        }

        // We are overriding the superclass method update display
        protected override void UpdateDisplay()
        {
            // Calling the overridden method in the base class
            base.UpdateDisplay();
            // Need the employee details variable _EmployeeDetails, we typecast _EmployeeDetails 
            // into ClsWagesEmployeeDetails in order to use the specific properties related to that class
            ClsWagesEmployeeDetails lcEmployeeDetails = (ClsWagesEmployeeDetails)_EmployeeDetails;
            // Moving the data in the same way with the base class
            TxtEmployeeHourlyRate.Text = Convert.ToString(lcEmployeeDetails.HourlyRate);
        }

        // We are overriding the superclass method push data
        protected override void PushData()
        {
            // Calling the overriden method in the base class
            base.PushData();
            // Need the employee details variable _EmployeeDetails, we typecast _EmployeeDetails 
            // into ClsWagesEmployeeDetails in order to use the specific properties related to that class
            ClsWagesEmployeeDetails lcEmployeeDetails = (ClsWagesEmployeeDetails)_EmployeeDetails;
            // Moving the data in the same way with the base class
            lcEmployeeDetails.HourlyRate = Convert.ToDecimal(TxtEmployeeHourlyRate.Text);
        }
    }
}
