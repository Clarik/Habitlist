using Habitilist.Controllers;
using Habitilist.Models;
using Habitilist.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Habitilist.Views
{
    public partial class EditProfile : System.Web.UI.Page
    {
        private static User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] != null)
            {
                user = UserRepository.getUser(Request.Cookies["username"].Value);
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string email = emailTxt.Text;
            string oldPassword = oldPasswordTxt.Text;
            string newPassword = newPasswordTxt.Text;
            string confNewPass = confNewPassTxt.Text;

            error.Text = AuthController.update(user, name, email, oldPassword, newPassword, confNewPass);
            if(error.Text == "")
            {
                error.Text = "Successfully updated!<br />";
            }

            if(name != "")
            {
                DateTime exp = Request.Cookies["username"].Expires;
                Response.Cookies["username"].Expires = DateTime.Now.AddDays(-1);

                HttpCookie cookie = new HttpCookie("username");
                cookie.Value = name;
                cookie.Expires = exp;
                Response.Cookies.Add(cookie);

                User u = new User();
                u.Name = name;
                Session["user"] = u;
            }
        }
    }
}