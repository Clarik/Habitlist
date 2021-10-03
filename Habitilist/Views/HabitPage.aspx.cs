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
    public partial class HabitPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string name = Request.Cookies["username"].Value;
                int userId = UserRepository.getUser(name).Id;
                List<Habit> list = HabitRepository.getAllHabit(userId);
                Repeater1.DataSource = list;
                Repeater1.DataBind();
            }
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.CommandArgument);

            HabitRepository.delete(id);
            Response.Redirect("HabitPage.aspx");
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertHabitPage.aspx");
        }
    }
}