using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    // Saving
    [Serializable]
    //Making the class inherit from the base class
    class ClsWagesEmployeeDetails : ClsEmployeeDetails
    {
        // We are creating a static member variable which means only one form is ever created for all instances of ClsWagesEmployeeDetails
        private static FrmWagesEmployeeDetails _Form = new FrmWagesEmployeeDetails();

        // Overriding the abstract method from the base class
        public override bool ViewEdit()
        {
            // Open wages employee details form
            return _Form.ShowDialog(this);
        }

        // Overriding the protected string type of employee method in class employee details
        protected override string TypeOfEmployee()
        {
            return "Wages";
        }

        // private member variable
        private decimal _HourlyRate;

        // Properties
        public decimal HourlyRate { get => _HourlyRate; set => _HourlyRate = value; }
    }
}
