using System;
using System.Collections.Generic;
using System.Text;
using SILAKBO.DAL;
using SILAKBO.Models;
using SILAKBO.Utils;

namespace SILAKBO.BLL
{
    public class UserService
    {
        UserRepository repo = new UserRepository();

        // REGISTER USER
        public void Register(string username, string password)
        {
            User user = new User();

            user.Username = username;
            user.PasswordHash = PasswordHasher.Hash(password);
            user.Role = "Victim";
            user.Gender = "Female";

            repo.Register(user);
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
    }
}