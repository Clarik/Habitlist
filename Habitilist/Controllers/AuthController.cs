using Habitilist.Factories;
using Habitilist.Models;
using Habitilist.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Habitilist.Controllers
{
    public class AuthController
    {
        public static string register(string name, string email, string password, string confPass)
        {
            string temp = "";

            if(name == "") temp += "Name cannot be empty! <br />";

            if (email == "") temp += "Email cannot be empty! <br />";
            else if (!(email.Contains("@") && email.Contains("."))) temp += "Invalid Email! <br />";

            if (password == "") temp += "Password cannot be empty! <br />";
            else if (confPass != password) temp += "Password is not the same as confirmation password! <br />";

            if(temp == "")
            {
                int status = UserRepository.insertUser(name, email, password);

                if (status == 1) temp = "Successfully registered!";
                else temp = "Register Failed!";
            }

            return temp;
        }

        public static dynamic login(string name, string password)
        {
            User u = UserRepository.getUser(name, password);

            if(u == null)
            {
                return "User not found!";
            }

            return u;
        }

        public static string update(User user, string name, string email, string oldPassword, string newPassword, string confNewPass)
        {
            string temp = "";

            if (name == "" && email == "" && newPassword == "")
            {
                temp = "You must make a change to update your profile! <br />";
            }
            else
            {
                if (name == "") name = user.Name;

                if (email == "") email = user.Email;
                else if (!(email.Contains("@") && email.Contains("."))) temp += "Invalid Email! <br />";

                if (oldPassword == "") temp += "Password cannot be empty! <br />";
                else if (oldPassword != user.Password) temp += "Invalid Password! <br />";

                if (newPassword == "") newPassword = user.Password;

                if (confNewPass == "") confNewPass = newPassword;
                else if (confNewPass != newPassword) temp += "New password doesn't match with the confirmation password! <br />";

                if (temp == "")
                {
                    UserRepository.updateUser(name, email, newPassword, user.Id);
                }
            }

            return temp;
        }
    }
}