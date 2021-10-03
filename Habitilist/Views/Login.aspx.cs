using Habitilist.Models;
using Habitilist.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Habitilist.Repositories;

namespace Habitilist.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            passwordTxt.Attributes["type"] = "password";

            if(Session["user"] != null)
            {
                registerTxt.Visible = false;
                registerBtn.Visible = false;
            }

            if (Request.Cookies["username"] != null)
            {
                User u = UserRepository.getUser(Request.Cookies["username"].Value);
                nameTxt.Text = u.Name;
                passwordTxt.Text = u.Password;
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string password = passwordTxt.Text;

            var response = AuthController.login(name, password);
            if (response is User)
            {
                User temp = response;
                Session["user"] = temp;

                HttpCookie cookie = new HttpCookie("username");
                cookie.Value = temp.Name;
                cookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cookie);

                Response.Redirect("Home.aspx");
            }
            else
            {
                error.Text = response;
            }
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}