using System;

namespace EmployeeRegister
{
    // Saving
    [Serializable]
    // Now it is abstract, basically there are no employee detail objects as it is a base class and does 
    // not have any instances, it is a template
    public abstract class ClsEmployeeDetails
    {
        // Initialising and inserting into the combo box, need to make it readonly as public variables are a no-no in OO programing, moving from form main to reduce coupling
        public static readonly string[] EmployeeType = { "Wages", "Salary", "Contractor", "Visitor" };
       
        // Static factory method, these are always accessible irrespective of objects created, its job is to return the correct employee dependant on the choice on the combo box
        public static ClsEmployeeDetails NewEmployee(int prChoice)
        {
            // prChoice is referencing the combo box on form main, dont need a break because the return code will execute
            switch(prChoice)
            {
                // If second option was selected
                case 1:
                    // Open salary employee details form
                    return new ClsSalaryEmployeeDetails();

                // If third option was selected
                case 2:
                    // Open contractor employee details form
                    return new ClsContractorEmployeeDetails();

                // If fourth option was selected
                case 3:
                    // Open visitor employee details form
                    return new ClsVisitorEmployeeDetails();

                // If first option or unchanged
                default:
                    // Open wages employee details form
                    return new ClsWagesEmployeeDetails();
            }
        }

        // Public abstract method that returns a boolean, tells us if editing was successful or not, abstract methods have no code
        public abstract bool ViewEdit();

        // Protected abstract method that returns a string depending on the type of employee created, don't need code as it is an abstract method and will be overridden by the sub classes
        protected abstract string TypeOfEmployee();
        
        // Private member variables
        private string _ID;
        private string _Name;
        private DateTime _DOB = DateTime.Today;
        private string _Address;
        private string _PhoneNo;
        private string _Email;
        private string _EmergencyContactPerson;
        private string _EmergencyContactNo;
        private string _EmergencyContactRelationship;
        private DateTime _StartDate = DateTime.Today;
        private string _Position;
        private string _Location;
        private string _WorkNo;
        private string _WorkEmail;

        // Properties, normally public and contains the accessor methods set and get which expose 
        // the private member variable to the rest of the program.
        public string ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public DateTime DOB { get => _DOB; set => _DOB = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string PhoneNo { get => _PhoneNo; set => _PhoneNo = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string EmergencyContactPerson { get => _EmergencyContactPerson; set => _EmergencyContactPerson = value; }
        public string EmergencyContactNo { get => _EmergencyContactNo; set => _EmergencyContactNo = value; }
        public string EmergencyContactRelationship { get => _EmergencyContactRelationship; set => _EmergencyContactRelationship = value; }
        public DateTime StartDate { get => _StartDate; set => _StartDate = value; }
        public string Position { get => _Position; set => _Position = value; }
        public string Location { get => _Location; set => _Location = value; }
        public string WorkNo { get => _WorkNo; set => _WorkNo = value; }
        public string WorkEmail { get => _WorkEmail; set => _WorkEmail = value; }



        // Display employee ID, Name, position and location on the main form, \n means new line, \t means tab charater
        public override string ToString()
        {
            return Name + "\t" + ID + "\t" + Position + "\t" + Location + "\t" + TypeOfEmployee();
        }
    }
}
