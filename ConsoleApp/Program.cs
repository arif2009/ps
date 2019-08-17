using PS.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        private static UserManager userManager = new UserManager();
        static void Main(string[] args)
        {
            var allUser = userManager.GetAllUsers();
            Console.ReadKey();
        }
    }
}
