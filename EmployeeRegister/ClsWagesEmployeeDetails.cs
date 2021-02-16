using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    //Making the class inherit from the base class
    class ClsWagesEmployeeDetails : ClsEmployeeDetails
    {
        // private member variable
        private decimal _HourlyRate;

        // Properties
        public decimal HourlyRate { get => _HourlyRate; set => _HourlyRate = value; }
    }
}
