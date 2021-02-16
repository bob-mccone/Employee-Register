using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    // Making the class inherit from the base class
    class ClsVisitorEmployeeDetails : ClsEmployeeDetails
    {
        // Private member variables
        private string _EmployeeVisitorTimeIn;
        private string _EmployeeVisitorTimeOut;

        // Properities
        public string EmployeeVisitorTimeIn { get => _EmployeeVisitorTimeIn; set => _EmployeeVisitorTimeIn = value; }
        public string EmployeeVisitorTimeOut { get => _EmployeeVisitorTimeOut; set => _EmployeeVisitorTimeOut = value; }
    }
}
