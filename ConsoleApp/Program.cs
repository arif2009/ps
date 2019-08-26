using Autofac;
using PS.Domain;
using PS.Manager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.Service;
using System.Globalization;
using PS.Utility;

namespace ConsoleApp
{
    class Program
    {
        private static IContainer container { get; set; }
        static void Main(string[] args)
        {
            container = ConfigureContainer();
            var revinueService = container.Resolve<IRevenueService>();

            DateTime reference = DateTime.Now;
            Calendar calendar = CultureInfo.CurrentCulture.Calendar;

            var endDate = DateTime.Now;
            var startDate = DateTime.Now.AddDays(-30);
            startDate = startDate.Date.DayOfWeek == DayOfWeek.Sunday? startDate.AddDays(1): startDate;

            IEnumerable<DateTime> daysInMonth = MethodExtensions.EachDay(startDate, endDate);

            List<Tuple<DateTime, DateTime>> weeks = daysInMonth.GroupBy(d => calendar.GetWeekOfYear(d, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday))
                .Select(g => new Tuple<DateTime, DateTime>(g.First(), (g.Last().DayOfWeek == DayOfWeek.Sunday) ? g.Last().AddDays(-1) : g.Last()))
                .ToList();

            Console.WriteLine("Weekly revenue report with immobilized money from {0:MM/dd/yyyy} to {1:MM/dd/yyyy}\n", startDate, endDate);

            weeks.ForEach(x =>
            {
                Console.WriteLine("From {0:MM/dd/yyyy} to {1:MM/dd/yyyy}", x.Item1, x.Item2);
                var rev = revinueService.GetRevinueBetween(x.Item1, x.Item2);
                Console.WriteLine($"Revinue => {rev.Revenue} Immobilized money => {rev.Immobilized}\n");
            });

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
