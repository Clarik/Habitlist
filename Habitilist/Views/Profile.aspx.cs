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
    public partial class Profile : System.Web.UI.Page
    {
        private string name = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] != null)
            {
                name = Request.Cookies["username"].Value;
                User u = UserRepository.getUser(name);
                nameTxt.Text = u.Name;
                emailTxt.Text = u.Email;
                pointsTxt.Text = u.Points.ToString() + " points";
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {

            Session.Remove("user");
            Session.Abandon();
            Session.Clear();

            if (Request.Cookies["username"] != null)
            {
                Response.Cookies["username"].Expires = DateTime.Now.AddDays(-1);
            }

            Response.Redirect("Login.aspx");
        }

        protected void editBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditProfile.aspx");
        }
    }
}