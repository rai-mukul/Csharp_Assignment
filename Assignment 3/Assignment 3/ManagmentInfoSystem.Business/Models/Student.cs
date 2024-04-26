using System;

namespace ManagmentInfoSystem.Business.Models
{
    public class Student
    {
        private string firstName;
        private string lastName;
        public int Id { get; set; }

        public string FirstName 
        {
            get => firstName;
            set {
                if (value == "" || value == null)
                    throw new ArgumentNullException();
                else
                    firstName = value;
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentNullException();
                else
                    lastName = value;
            }
        }
        public int DepartmentId { get; set; }
        public Address Address { get; set; }
        public Department Department { get; set; }
    }
}
