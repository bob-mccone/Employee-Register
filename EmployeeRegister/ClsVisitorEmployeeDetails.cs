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
        // We are creating a static member variable which means only one form is ever created for all instances of ClsvisitorEmployeeDetails
        private static FrmVisitorEmployeeDetails _Form = new FrmVisitorEmployeeDetails();

        // Overriding the abstract method from the base class
        public override bool ViewEdit()
        {
            // Open visitor employee details form
            return _Form.ShowDialog(this);
        }

        // Overriding the protected string type of employee method in class employee details
        protected override string TypeOfEmployee()
        {
            return "Visitor";
        }

        // Private member variables
        private string _EmployeeVisitorTimeIn;
        private string _EmployeeVisitorTimeOut;

        // Properities
        public string EmployeeVisitorTimeIn { get => _EmployeeVisitorTimeIn; set => _EmployeeVisitorTimeIn = value; }
        public string EmployeeVisitorTimeOut { get => _EmployeeVisitorTimeOut; set => _EmployeeVisitorTimeOut = value; }
    }
}
