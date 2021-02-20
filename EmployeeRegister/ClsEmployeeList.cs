using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    class ClsEmployeeList
    {
        // Creating a list of employees
        private static List<ClsEmployeeDetails> _EmployeeList = new List<ClsEmployeeDetails>();

        // Property, made it read only by having the get accessor and removing the set accessor
        public static List<ClsEmployeeDetails> EmployeeList { get => _EmployeeList; }
        
        // Was playing around with this, dont need it
        // Display the total balance of employees
        //public static decimal TotalBalance()
        //{
        //    decimal lcTotal = 0;
        //    decimal lcSalaryTotal = 0;
        //    decimal lcWagesTotal = 0;
            
            // Foreach loop that loops through all the salary employees in the list
        //    foreach (ClsSalaryEmployeeDetails lcSalaryEmployeeDetails in _EmployeeList)
        //        lcSalaryTotal += lcSalaryEmployeeDetails.SalaryAmount;
            //return lcSalaryTotal;
            // 
        //    foreach (ClsWagesEmployeeDetails lcWagesEmployeeDetails in _EmployeeList)
        //        lcWagesTotal += lcWagesEmployeeDetails.HourlyRate;
            //return lcWagesTotal;

        //    lcTotal = lcSalaryTotal + lcWagesTotal;
        //    return lcTotal;
        //}
    }
}
