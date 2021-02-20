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

        // Overriding the protected string type of employee method in class employee details
        protected override string TypeOfEmployee()
        {
            return "Salary";
        }

        // private member variables
        private string _SalaryAmount;

        // Properties
        public string SalaryAmount { get => _SalaryAmount; set => _SalaryAmount = value; }
    }
}
