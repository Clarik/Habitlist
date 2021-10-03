using Habitilist.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Habitilist.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string password = passwordTxt.Text;
            string email = emailTxt.Text;
            string confPass = confPassTxt.Text;

            string response = AuthController.register(name, email, password, confPass);
            error.Text = response;
        }
    }
}