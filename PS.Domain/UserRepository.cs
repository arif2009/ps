using System;
using System.Collections.Generic;
using PS.Model;

namespace PS.Domain
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAllUsers()
        {
            return new List<User>();
        }
    }
}
