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
    public partial class ToDoListPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string name = Request.Cookies["username"].Value;
                int userId = UserRepository.getUser(name).Id;
                List<ToDoList> list = ToDoListRepository.getAllToDoList(userId);
                Repeater1.DataSource = list;
                Repeater1.DataBind();
            }
        }

        protected void doneBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.CommandArgument);

            ToDoListRepository.done(id);
            Response.Redirect("ToDoListPage.aspx");
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.CommandArgument);

            ToDoListRepository.delete(id);
            Response.Redirect("ToDoListPage.aspx");
        }

        protected void insertTDLBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertTDLPage.aspx");
        }
    }
}