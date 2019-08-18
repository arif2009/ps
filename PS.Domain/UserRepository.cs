using System;
using System.Collections.Generic;
using PS.Model;
using PS.Utility;

namespace PS.Domain
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAllCustomer()
        {
            return Data.customerList;
        }

        public List<User> GetAllUsers()
        {
            var userList = new List<User>();

            userList.Add(Data.owner);
            userList.AddRange(Data.customerList);

            return userList;
        }
    }
}
