using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.Domain;
using PS.Model;

namespace PS.Manager
{
    public class UserManager : IUserManager
    {
        private UserRepository userRepository = new UserRepository();
        public List<User> GetAllUsers()
        {
            return userRepository.GetAllUsers();
        }
    }
}
