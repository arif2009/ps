﻿using PS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Domain
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        List<User> GetAllCustomer();
    }
}
