using System;
using SQLite;

namespace TestAdoptionApp.Models
{
    public class User
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {

        }

        public User(string name, string email, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }

        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

    }
}
