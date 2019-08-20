using Autofac;
using PS.Domain;
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
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            var container = ConfigureContainer();
            var userManager = container.Resolve<IUserManager>();

            var allUser = userManager.GetAllUsers();

            Console.ReadKey();
        }

        private static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<UserManager>().As<IUserManager>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<TransManager>().As<ITransManager>();
            // Register all dependencies (and dependencies of those dependencies, etc)

            return builder.Build();
        }
    }
}
