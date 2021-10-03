using Habitilist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Habitilist.Factories
{
    public class HabitilistFactory
    {
        public static User createUser(string name, string email, string password)
        {
            User user = new User();
            user.Name = name;
            user.Email = email;
            user.Password = password;
            user.Points = 0;

            return user;
        }

        public static ToDoList createToDoList(string name, string deadline, string description, int userId)
        {
            DateTime dl = DateTime.Parse(deadline);
            dl.ToString("DD/MM/YYYY");

            ToDoList toDoList = new ToDoList();
            toDoList.Name = name;
            toDoList.UserId = userId;
            toDoList.Description = description;
            toDoList.Deadline = dl;
            toDoList.Points = 10;

            return toDoList;
        }

        public static Habit createHabit(string name, string target, int userId)
        {
            DateTime trgt = DateTime.Parse(target);
            trgt.ToString("DD/MM/YYYY");
            Habit habit = new Habit();
            habit.Name = name;
            habit.Target = trgt;
            habit.UserId = userId;

            int diff = Convert.ToInt32((trgt - DateTime.Now).TotalDays);
            habit.Points = 2 * diff;

            return habit;
        }

        public static List<HabitDetails> createHabitDetails(Habit habit)
        {
            List<HabitDetails> hdList = new List<HabitDetails>();
            int HabitId = habit.Id;
            int diff = Convert.ToInt32((habit.Target - DateTime.Now).TotalDays);
            for (int i = 1; i <= diff; i++)
            {
                HabitDetails hd = new HabitDetails();
                hd.HabitId = habit.Id;
                hd.Day = i;
                hdList.Add(hd);
            }

            return hdList;
        }
    }
}