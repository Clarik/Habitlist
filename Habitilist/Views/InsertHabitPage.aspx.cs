using Habitilist.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Habitilist.Views
{
    public partial class InsertHabitPage : System.Web.UI.Page
    {
        private string Username = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Username = Request.Cookies["username"].Value;
            }
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string target = targetTxt.Text;
            int userId = UserRepository.getUser(Username).Id;

            HabitRepository.insert(name, target, userId);
            Response.Redirect("HabitPage.aspx");
        }
    }
}