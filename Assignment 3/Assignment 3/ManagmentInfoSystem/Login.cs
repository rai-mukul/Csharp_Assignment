
using ManagmentInfoSystem.Business;
using ManagmentInfoSystem.Business.Contracts;
using ManagmentInfoSystem.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ManagmentInfoSystem
{
    public partial class Login : Form
    {
        private readonly IManager<User> _userManager;
        private IList<User> Users;
        public Login()
        {
            InitializeComponent();
            _userManager = new UserManager();
            GetUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = username.Text;
            string userPass = password.Text;

            if(string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Username cannot be empty");
                return;
            }

            if (string.IsNullOrEmpty(userPass))
            {
                MessageBox.Show("Password cannot be empty");
                return;
            }

            var isValidUser = false;
            foreach(var user in Users)
            {
                if(user.UserName.Equals(userName) && user.Password.Equals(userPass))
                {
                    isValidUser = true;
                    break;
                }
            }

            if(isValidUser)
            {
                MessageBox.Show("Login Successfull!!!");
                this.Hide();
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please check username and password.");
            }
        }

        private void GetUsers()
        {
            Users = _userManager.Get().ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
