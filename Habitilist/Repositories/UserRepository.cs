using Habitilist.Factories;
using Habitilist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Habitilist.Repositories
{
    public class UserRepository
    {
        public static int insertUser(string name, string email, string password)
        {
            HabitilistDBEntities db = new HabitilistDBEntities();
            User user = HabitilistFactory.createUser(name, email, password);
            db.User.Add(user);
            return db.SaveChanges();
        }

        public static void updateUser(string name, string email, string password, int id)
        {
            HabitilistDBEntities db = new HabitilistDBEntities();
            User user = db.User.Find(id);
            user.Name = name;
            user.Email = email;
            user.Password = password;

            db.SaveChanges();
        }

        public static User getUser(string username, string password)
        {
            HabitilistDBEntities db = new HabitilistDBEntities();
            return (from x in db.User where x.Name == username && x.Password == password select x).FirstOrDefault();
        }

        public static User getUser(string name)
        {
            HabitilistDBEntities db = new HabitilistDBEntities();
            return (from x in db.User where x.Name == name select x).FirstOrDefault();
        }

        public static User getUser(int id)
        {
            HabitilistDBEntities db = new HabitilistDBEntities();
            return (from x in db.User where x.Id == id select x).FirstOrDefault();
        }
    }
}