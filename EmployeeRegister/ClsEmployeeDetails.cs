using System;

namespace EmployeeRegister
{
    public class ClsEmployeeDetails
    {
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
        private decimal _HourlyRate;

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
        public decimal HourlyRate { get => _HourlyRate; set => _HourlyRate = value; }



        // Display employee ID, Name, Hourly rate, position and location on the main form
        public override string ToString()
        {
            return ID + "\n" + Name + " " + HourlyRate + "\n" + Position + " " + Location;
        }
    }
}
