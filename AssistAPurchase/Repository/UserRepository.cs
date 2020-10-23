using System.Collections.Generic;
using AssistAPurchase.Models;
using AssistAPurchase.Database;

namespace AssistAPurchase.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly List<UserModel> _userList = new List<UserModel>();

        public UserRepository()
        {
            var users = new UsersGetter().Users;
            foreach (UserModel user in users)
            {
                Add(user);
            }
        }

        private void Add(UserModel user)
        {
            _userList.Add(user);
        }

        private bool Find(string email)
        {
            foreach (UserModel userModel in _userList)
                if (userModel.Email == email)
                    return true;
            return false;
        }

        public bool Login(UserModel user)
        {
            foreach (UserModel userModel in _userList)
                if (userModel.Email == user.Email)
                    if (userModel.Password == user.Password)
                        return true;
                    else
                    {
                        return false;
                    }
            return false;
        }

        public bool SignUp(UserModel user)
        {
            var ifExist = Find(user.Email);
            if (!ifExist)
                Add(user);
            return !ifExist;
        }
    }
}