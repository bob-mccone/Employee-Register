using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    // Making the class inherit from the base class
    class ClsContractorEmployeeDetails : ClsEmployeeDetails
    {
        // Private member variables
        private string _EmployeeContractingCompany;
        private string _EmployeeContractingCompanyContactNo;
        private string _EmployeeContractingCompanyContactPerson;
        private string _EmployeeContractingTimeIn;
        private string _EmployeeContractingTimeOut;

        // Properities
        public string EmployeeContractingCompany { get => _EmployeeContractingCompany; set => _EmployeeContractingCompany = value; }
        public string EmployeeContractingCompanyContactNo { get => _EmployeeContractingCompanyContactNo; set => _EmployeeContractingCompanyContactNo = value; }
        public string EmployeeContractingCompanyContactPerson { get => _EmployeeContractingCompanyContactPerson; set => _EmployeeContractingCompanyContactPerson = value; }
        public string EmployeeContractingTimeIn { get => _EmployeeContractingTimeIn; set => _EmployeeContractingTimeIn = value; }
        public string EmployeeContractingTimeOut { get => _EmployeeContractingTimeOut; set => _EmployeeContractingTimeOut = value; }
    }
}
