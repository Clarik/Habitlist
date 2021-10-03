using Habitilist.Factories;
using Habitilist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Habitilist.Repositories
{
    public class HabitRepository
    {
        private static int tempId;
        public static List<Habit> getAllHabit(int userId)
        {
            HabitilistDBEntities db = new HabitilistDBEntities();
            return (from x in db.Habit where x.UserId == userId select x).ToList();
        }

        public static Habit getHabit(int id)
        {
            HabitilistDBEntities db = new HabitilistDBEntities();
            return db.Habit.Find(id);
        }

        public static List<HabitDetails> getHabitDetails(int id)
        {
            HabitilistDBEntities db = new HabitilistDBEntities();
            return (from x in db.HabitDetails where x.HabitId == id select x).ToList();
        }

        public static void insert(string name, string target, int userId)
        {
            HabitilistDBEntities db = new HabitilistDBEntities();
            Habit habit = HabitilistFactory.createHabit(name, target, userId);
            db.Habit.Add(habit);
            db.SaveChanges();

            List<HabitDetails> hdList = HabitilistFactory.createHabitDetails(habit);
            db.HabitDetails.AddRange(hdList);
            db.SaveChanges();
        }

        public static void delete(int id)
        {
            HabitilistDBEntities db = new HabitilistDBEntities();
            Habit habit = db.Habit.Find(id);
            List<HabitDetails> hdList = (from x in db.HabitDetails where x.HabitId == id select x).ToList();
            db.HabitDetails.RemoveRange(hdList);
            db.SaveChanges();
            db.Habit.Remove(habit);
            db.SaveChanges();
        }

        public static void doneHabitDetails(int habitDetailsId, int id)
        {
            HabitilistDBEntities db = new HabitilistDBEntities();
            User user = db.User.Find(id);
            HabitDetails hd = db.HabitDetails.Find(habitDetailsId);
            Habit habit = getHabit(Convert.ToInt32(hd.HabitId));
            if(hd.Day == (habit.Points / 2))
            {
                tempId = hd.Habit.Id;
                db.HabitDetails.Remove(hd);
                db.SaveChanges();
                Habit temp = db.Habit.Find(tempId);
                db.Habit.Remove(temp);
            }
            else
            {
                db.HabitDetails.Remove(hd);
            }

            user.Points += 2;
            db.SaveChanges();
        }
    }
}