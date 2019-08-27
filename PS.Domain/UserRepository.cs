using System;
using System.Collections.Generic;
using PS.Model;
using PS.Utility;

namespace PS.Domain
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAllUsers()
        {
            return Data.customerList;
        }
    }
}
