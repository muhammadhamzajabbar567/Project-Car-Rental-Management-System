using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CAR_RENTAL_MANAGEMENT_SYSTEM
{
     public class User
    {

        public string Username = "";
        public string password = "";

        public void LogIn()
        {
            if (Username == "admin" && password == "12345")
            {
                MessageBox.Show("you are login succesfully!!!");
            }
            else
            {
                MessageBox.Show("Invalid username or passwrod........!!");
            }

        }

    }
}
