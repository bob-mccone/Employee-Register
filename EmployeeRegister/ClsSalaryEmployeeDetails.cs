using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    // Making the class inherit from the base class
    class ClsSalaryEmployeeDetails : ClsEmployeeDetails
    {
        // We are creating a static member variable which means only one form is ever created for all instances of ClsSalaryEmployeeDetails
        private static FrmSalaryEmployeeDetails _Form = new FrmSalaryEmployeeDetails();

        // Overriding the abstract method from the base class
        public override bool ViewEdit()
        {
            // Open salary employee details form
            return _Form.ShowDialog(this);
        }
        // private member variables
        private decimal _SalaryAmount;

        // Properties
        public decimal SalaryAmount { get => _SalaryAmount; set => _SalaryAmount = value; }
    }
}
