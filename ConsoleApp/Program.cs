using Autofac;
using PS.Domain;
using PS.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.Service;

namespace ConsoleApp
{
    class Program
    {
        private static IContainer container { get; set; }
        static void Main(string[] args)
        {
            container = ConfigureContainer();
            var revinueService = container.Resolve<IRevenueService>();

            var allUser = revinueService.GetRevinueBetween(DateTime.Now, DateTime.Now.AddDays(5));

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

            builder.RegisterType<RevenueService>().As<IRevenueService>();
            // Register all dependencies (and dependencies of those dependencies, etc)

            return builder.Build();
        }
    }
}
