using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AnjaeRSVP.Model;

namespace AnjaeRSVP.Model
{
    public partial class Users
    {
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
    }
    public class userDAL
    {
        private string _dbPath = Path.Combine(System.Environment.GetFolderPath(
            System.Environment.SpecialFolder.Personal), "UsersDb.db");

        public userDAL()
        {
            //check to see if DB exists - if not, create it
            if (!File.Exists(_dbPath))
            {
                SQLiteDb db = new SQLiteDb(_dbPath);
                db.Create();
            }
        }

        //method to save a person to the DB
        public void AddUser(Users userToAdd)
        {
            using (SQLiteConnection db = new SQLiteConnection(_dbPath))
            {
                bool exists = false;

                //error checking to prevent adding same person twice
                foreach (Users u in db.Table<Users>())
                {
                    if (u.firstName == userToAdd.firstName
                        && u.lastName == userToAdd.lastName
                        && u.email == userToAdd.email
                        && u.phone == userToAdd.phone
                        && u.username == userToAdd.username
                        && u.password == userToAdd.password)
                    {
                        exists = true;
                        break;
                    }
                }

                //person doesn't exist in the DB, add them
                if (!exists)
                {
                    db.Insert(userToAdd);
                    
                }
            }
        }

        public void GetUserData(Users currentUser)
        {
            using (SQLiteConnection db = new SQLiteConnection(_dbPath))
            {

            }
        }
    }
}
