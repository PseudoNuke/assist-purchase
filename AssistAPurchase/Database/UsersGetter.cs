using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using AssistAPurchase.Models;

namespace AssistAPurchase.Database
{
    public class UsersGetter
    {
        public List<UserModel> Users { get; private set; }

        public UsersGetter()
        {
            this.GetAllUsers();
            Console.WriteLine(Users.Count);
        }
        private void GetAllUsers()
        {
            List<UserModel> usersList = new List<UserModel>
            {
                new UserModel
                {
                    Password = "anitha",
                    Email = "anitha@gmail.com"
                },
                new UserModel
                {
                    Password = "thilakashwin",
                    Email = "thilakashwin@gmail.com"
                },
            };
            this.Users = usersList;
        }
    }
}