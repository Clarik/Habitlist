using Habitilist.Factories;
using Habitilist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Habitilist.Repositories
{
    public class ToDoListRepository
    {
        private static int UserId;
        public static List<ToDoList> getAllToDoList(int userId)
        {
            UserId = userId;
            HabitilistDBEntities db = new HabitilistDBEntities();
            return (from x in db.ToDoList where x.UserId == userId select x).ToList();
        }

        public static List<ToDoList> getUrgentList(int userId)
        {
            UserId = userId;
            HabitilistDBEntities db = new HabitilistDBEntities();
            List<ToDoList> temp = getAllToDoList(userId);
            List<ToDoList> urgentList = new List<ToDoList>();
            DateTime now = DateTime.Now;
            foreach(ToDoList tdl in temp)
            {
                if (Convert.ToInt32((tdl.Deadline - now).TotalDays) <= 7)
                {
                    urgentList.Add(tdl);
                }
            }

            return urgentList;
        }

        public static void insert(string name, string deadline, string description, int userId)
        {
            HabitilistDBEntities db = new HabitilistDBEntities();
            ToDoList tdl = HabitilistFactory.createToDoList(name, deadline, description, userId);
            db.ToDoList.Add(tdl);
            db.SaveChanges();
        }

        public static void delete(int id)
        {
            HabitilistDBEntities db = new HabitilistDBEntities();
            ToDoList tdl = db.ToDoList.Find(id);

            db.ToDoList.Remove(tdl);
            db.SaveChanges();
        }

        public static void done(int id)
        {
            HabitilistDBEntities db = new HabitilistDBEntities();
            ToDoList tdl = db.ToDoList.Find(id);

            int points = tdl.Points;
            User u = db.User.Find(UserId);
            u.Points += points;

            db.ToDoList.Remove(tdl);
            db.SaveChanges();
        }
    }
}