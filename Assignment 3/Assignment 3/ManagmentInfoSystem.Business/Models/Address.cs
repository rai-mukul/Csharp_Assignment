using System;

namespace ManagmentInfoSystem.Business.Models
{
    public class Address
    {
        private string line1;
        private string city;
        private string state;
        private string zipCode;
        public string Line1
        {
            get => line1;
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentNullException();
                else
                    line1 = value;
            }
        }
        public string Line2 { get; set; }
        public string City 
        {
            get => city;
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentNullException();
                else
                    city = value;
            }
        }
        public string State 
        {
            get => state;
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentNullException();
                else
                    state = value;
            }
        }
        public string ZipCode 
        {
            get => zipCode;
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentNullException();
                else
                    zipCode = value;
            }
        }

        public int Id { get; set; }
        public int StudentId { get; set; }
    }
}
