﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.Domain;
using PS.Model;
using PS.Utility;

namespace PS.Manager
{
    public class UserManager : IUserManager
    {
        private IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAllCustomer()
        {
            return this.GetAllUsers().FindAll(x => x.Role == Roles.Customer);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetCustomerById(long id)
        {
            return this.GetAllCustomer().FirstOrDefault(x=>x.Id == id);
        }

        public User GetOwner()
        {
            return _userRepository.GetAllUsers().FirstOrDefault(x=>x.Role == Roles.Owner);
        }
    }
}
