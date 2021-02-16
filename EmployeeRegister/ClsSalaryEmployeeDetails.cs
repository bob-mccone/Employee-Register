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
        // private member variables
        private decimal _SalaryAmount;

        // Properties
        public decimal SalaryAmount { get => _SalaryAmount; set => _SalaryAmount = value; }
    }
}
