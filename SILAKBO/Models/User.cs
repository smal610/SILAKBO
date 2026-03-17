using System;
using System.Collections.Generic;
using System.Text;

namespace SILAKBO.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public string Role { get; set; }

        public string Gender { get; set; }

        public DateTime Birthday { get; set; }
    }
}
