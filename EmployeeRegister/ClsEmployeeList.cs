using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    // Saving
    [Serializable]
    class ClsEmployeeList
    {
        // Creating a dictionary of employees, dictionaries require two items, key (string) and value (clsEmployeeDetails) which is where we want it stored
        private static Dictionary<string, ClsEmployeeDetails> _EmployeeList = new Dictionary<string, ClsEmployeeDetails>();

        // Property, made it read only by having the get accessor and removing the set accessor
        public static Dictionary<string, ClsEmployeeDetails> EmployeeList { get => _EmployeeList; }

        // Save method
        public static void Save()
        {
            // Declaring and instantiate a file stream object, using is recommended because it closes and disposes when it is finished
            using (FileStream lcFileStream = new FileStream("Employees.dat", FileMode.Create))
            {
                // Declaring and instantiate the binary formatter
                BinaryFormatter lcFormatter = new BinaryFormatter();
                // Saving the employee list
                lcFormatter.Serialize(lcFileStream, _EmployeeList);
            }
        }

        public static void Retrieve()
        {
            // Declaring and instantiate a file stream object, using is recommended because it closes and disposes when it is finished
            using (FileStream lcFileStream = new FileStream("Employees.dat", FileMode.Open))
            {
                // Declaring and instantiate the binary formatter
                BinaryFormatter lcFormatter = new BinaryFormatter();
                // Retrieving the employee list
                _EmployeeList = (Dictionary<string, ClsEmployeeDetails>)lcFormatter.Deserialize(lcFileStream);
            }
        }
        
        // Was playing around with this, dont need it
        // Display the total balance of employees
        //public static decimal TotalBalance()
        //{
        //    decimal lcTotal = 0;
        //    decimal lcSalaryTotal = 0;
        //    decimal lcWagesTotal = 0;
            
            // Foreach loop that loops through all the salary employees in the list, if a dictionary need .value at the end of _EmployeeList
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
