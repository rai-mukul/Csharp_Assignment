using System;

namespace ManagmentInfoSystem.Business.Models
{
    public class User
    {
        private string username;
        private string password;

        public string UserName
        {
            get => username;
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentNullException();
                else
                    username = value;
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentNullException();
                else
                    password = value;
            }
        }

        public int Id { get; set; }
    }
}
