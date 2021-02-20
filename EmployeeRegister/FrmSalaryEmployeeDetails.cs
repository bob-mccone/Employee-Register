using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeRegister
{
    public partial class FrmSalaryEmployeeDetails : EmployeeRegister.FrmEmployeeDetails
    {
        // Constructor
        public FrmSalaryEmployeeDetails()
        {
            InitializeComponent();
        }

        //We are overriding the base class update display
        protected override void UpdateDisplay()
        {
            // Calling the overridden method in the base class
            base.UpdateDisplay();
            // Need the employee details variable _EmployeeDetails, we typecast _EmployeeDetails 
            // into ClsSalaryEmployeeDetails in order to use the specific properties related to that class
            ClsSalaryEmployeeDetails lcEmployeeDetails = (ClsSalaryEmployeeDetails)_EmployeeDetails;
            // Moving the data in the same way with the base class
            TxtEmployeeSalary.Text = lcEmployeeDetails.SalaryAmount;
        }

        // We are overriding the base class push data
        protected override void PushData()
        {
            // Calling the overridden method in the base class
            base.PushData();
            // Need the employee details variable _EmployeeDetails, we typecast _EmployeeDetails 
            // into ClsSalaryEmployeeDetails in order to use the specific properties related to that class
            ClsSalaryEmployeeDetails lcEmployeeDetails = (ClsSalaryEmployeeDetails)_EmployeeDetails;
            // Moving the data in the same way with the base class
            lcEmployeeDetails.SalaryAmount = TxtEmployeeSalary.Text;
        }
    }
}
