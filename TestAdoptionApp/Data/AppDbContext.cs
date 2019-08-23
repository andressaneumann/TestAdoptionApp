using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using TestAdoptionApp.Models;

namespace TestAdoptionApp.Data
{
    public class AppDbContext
    {
        readonly SQLiteConnection _database;

        public AppDbContext(string dbPath)
        {
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<User>();
        }

        public List<User> GetUsers()
        {
            return _database.Table<User>().ToList();
        }

        public User GetUserAsync(int id)
        {
            return _database.Table<User>()
                            .Where(i => i.Id == id)
                            .FirstOrDefault();
        }

        public bool CheckLoginData(User user)
        {
            User currentUser = _database.Table<User>().Where(i => i.Email == user.Email).FirstOrDefault();

            if(currentUser != null)
            {
                if (currentUser.Password == user.Password)
                    return true;
                else
                    return false;
            }

            return false;
        }

        public int SaveUser(User user)
        {
            if(user.Id != 0)
            {
                return _database.Update(user);
            }
            else
            {
                return _database.Insert(user);
            }
        }

        public int DeleteUser(User user)
        {
            return _database.Delete(user);
        }
    }
}
