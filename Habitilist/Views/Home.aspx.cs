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
    public partial class Home : System.Web.UI.Page
    {
        public List<Habit> habitList;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = "";
            string idTxt = Request.QueryString["id"];

            if (Session["user"] == null)
            {
                if (Request.Cookies["username"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    name = Request.Cookies["username"].Value;
                    User u = new User();
                    u.Name = name;
                    Session["user"] = u;
                }
            }
            else
            {
                name = ((User)Session["user"]).Name;
            }

            if (idTxt != null)
            {
                int id = int.Parse(idTxt);
                int userId = UserRepository.getUser(name).Id;
                HabitRepository.doneHabitDetails(id, userId);
                Response.Redirect("Home.aspx");
            }

            if (name != "")
            {
                List<ToDoList> urgentList = ToDoListRepository.getUrgentList(UserRepository.getUser(name).Id);
                Repeater1.DataSource = urgentList;
                Repeater1.DataBind();
                if(!urgentList.Any())
                {
                    inspectBtn.Visible = false;
                    isEmpty.Visible = true;
                }

                habitList = HabitRepository.getAllHabit(UserRepository.getUser(name).Id);
                if (!habitList.Any())
                {
                    isEmpty2.Visible = true;
                }
            }
        }

        protected void inspectBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ToDoListPage.aspx");
        }
    }
}