using SILAKBO.DAL;
using SILAKBO.Models;
using SILAKBO.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SILAKBO.BLL
{
    public class UserService
    {
        UserRepository repo = new UserRepository();

        // REGISTER USER
        //public bool Register(string username, string password)
        //{
        //    if (repo.UsernameExists(username))
        //    {
        //        return false;
        //    }

        //    User user = new User();

        //    user.Username = username;
        //    user.PasswordHash = PasswordHasher.Hash(password);
        //    user.Role = "Victim";
        //    user.Gender = "Female";

        //    repo.Register(user);

        //    return true;
        //}

        // Change (string username, string password) to include gender
        public bool Register(string name, string username, string password, string gender, DateTime birthdate)
        {
            if (repo.UsernameExists(username))
            {
                return false;
            }

            User user = new User();
            user.Name = name;
            user.Username = username;
            user.PasswordHash = PasswordHasher.Hash(password);
            user.Role = "Victim";
            user.Gender = gender;
            user.Birthday = birthdate;

            repo.Register(user);

            return true;
        }

        // LOGIN USER
        public User Login(string username, string password)
        {
            User user = repo.GetUserByUsername(username);

            if (user != null)
            {
                string hashedPassword = PasswordHasher.Hash(password);

                if (user.PasswordHash == hashedPassword)
                {
                    return user;
                }
            }

            return null;
        }

        public User GetUserByUsername(string username)
        {
            return repo.GetUserByUsername(username); // call UserRepository
        }
    }
}