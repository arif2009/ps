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
        private static IContainer container { get; set; }
        static void Main(string[] args)
        {
            container = ConfigureContainer();
            var userManager = container.Resolve<IPetManager>();

            var allUser = userManager.GetUnSoldablePets();

            Console.ReadKey();
        }

        private static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<PetRepository>().As<IPetRepository>();
            builder.RegisterType<TransRepository>().As<ITransRepository>();

            builder.RegisterType<UserManager>().As<IUserManager>();
            builder.RegisterType<PetManager>().As<IPetManager>();
            builder.RegisterType<TransManager>().As<ITransManager>();
            // Register all dependencies (and dependencies of those dependencies, etc)

            return builder.Build();
        }
    }
}
